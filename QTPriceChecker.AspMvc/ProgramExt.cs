//@CodeCopy
//MdStart
namespace QTPriceChecker.AspMvc
{
    /// <summary>
    /// Extension Program
    /// </summary>
    public partial class Program
    {
        /// <summary>
        /// Services can be added using this method.
        /// </summary>
        /// <param name="builder">The builder</param>
        public static void BeforeBuild(WebApplicationBuilder builder)
        {
#if ACCOUNT_ON
            builder.Services.AddTransient<QTPriceChecker.Logic.Contracts.Account.IIdentitiesAccess<QTPriceChecker.Logic.Models.Account.Identity>, QTPriceChecker.Logic.Facades.Account.IdentitiesFacade>();
            builder.Services.AddTransient<QTPriceChecker.Logic.Contracts.Account.IRolesAccess<QTPriceChecker.Logic.Models.Account.Role>, QTPriceChecker.Logic.Facades.Account.RolesFacade>();
            builder.Services.AddTransient<QTPriceChecker.Logic.Contracts.Account.IUsersAccess<QTPriceChecker.Logic.Models.Account.User>, QTPriceChecker.Logic.Facades.Account.UsersFacade>();
#endif
            AddServices(builder);
        }
        /// <summary>
        /// Configures can be added using this method.
        /// </summary>
        /// <param name="app"></param>
        public static void AfterBuild(WebApplication app)
        {
            AddConfigures(app);
        }
        static partial void AddServices(WebApplicationBuilder builder);
        static partial void AddConfigures(WebApplication app);
    }
}
//MdEnd
