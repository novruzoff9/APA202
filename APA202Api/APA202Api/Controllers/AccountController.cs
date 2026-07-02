using APA202Api.Dto.Account;
using APA202Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace APA202Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController(
    IMapper mapper,
    IConfiguration configuration,
    UserManager<AppUser> userManager
    ) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        AppUser newUser = mapper.Map<AppUser>(registerDto);
        var result = await userManager.CreateAsync(newUser, registerDto.Password);
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        var roleResult = await userManager.AddToRoleAsync(newUser, "Member");
        if (!roleResult.Succeeded)
            return BadRequest(roleResult.Errors);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var user = await userManager.FindByEmailAsync(loginDto.Email);
        if (user is null)
            return NotFound("Istifadeci tapilmadi");
        var checkPass = await userManager.CheckPasswordAsync(user, loginDto.Password);
        if (!checkPass)
            return BadRequest("Parol Ynalisdir");

        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim("Full Name", user.LastName + " " + user.FirstName)
        };

        var roles = await userManager.GetRolesAsync(user);

        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        string secretKey = configuration["Jwt:Key"];
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenOptions = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddDays(1), 
            signingCredentials: creds
        );

        var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        return Ok(token);
    }
}
