using Microsoft.Extensions.DependencyInjection;
using WebApi.Starter.Business;
using WebApi.Starter.Business.Contract;
using WebApi.Starter.DataAccess;
using WebApi.Starter.DataAccess.Contract;

namespace WebApi.Starter.Core
{
    public static class DependencyConfig
    {
        public static void ConfigureDependencies(IServiceCollection services)
        {
            //Data access registration
            services.AddTransient<IUserManagementDA, UserManagementDA>();

            //Business layer registration
            services.AddTransient<IAuthenticationBO, AuthenticationBO>();
        }
    }
}
