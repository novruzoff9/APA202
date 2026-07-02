using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class AppDbContext:DbContext
{
    public DbSet<Service> Services { get; set; }
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
}
