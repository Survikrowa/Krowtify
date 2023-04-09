using backend.modules.auth;
using Microsoft.EntityFrameworkCore;

namespace backend.modules.shared.database;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DataContext()
    {
        _configuration = new ConfigurationManager();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(_configuration.GetConnectionString("WebApiDatabase"));
    }
    
    public DbSet<NormalUserModel> Users { get; set; }
}