using IdentityService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityService.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        
        var connectionString = configuration.GetConnectionString("IdentityServiceDbConnection")
            ?? throw new InvalidOperationException("Connection string 'IdentityServiceDbConnection' not found.");
        
        services.AddDbContext<IdentityServiceDbContext>(options =>
            options.UseSqlServer(connectionString));
        
        
    }

}