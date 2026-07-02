using Microsoft.AspNetCore.Identity;

namespace APA202Api.Models;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
