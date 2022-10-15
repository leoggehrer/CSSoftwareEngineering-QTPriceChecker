//@GeneratedCode
namespace QTPriceChecker.AspMvc
{
    ///
    /// Generated by the generator
    ///
    partial class Program
    {
        static partial void AddServices(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<QTPriceChecker.Logic.Contracts.Base.IProductsAccess<QTPriceChecker.Logic.Entities.Base.Product>, QTPriceChecker.Logic.Controllers.Base.ProductsController>();
            builder.Services.AddTransient<QTPriceChecker.Logic.Contracts.Base.IProductXSuppliersAccess<QTPriceChecker.Logic.Entities.Base.ProductXSupplier>, QTPriceChecker.Logic.Controllers.Base.ProductXSuppliersController>();
            builder.Services.AddTransient<QTPriceChecker.Logic.Contracts.Base.ISuppliersAccess<QTPriceChecker.Logic.Entities.Base.Supplier>, QTPriceChecker.Logic.Controllers.Base.SuppliersController>();
            builder.Services.AddTransient<QTPriceChecker.Logic.Contracts.App.IPriceHistoriesAccess<QTPriceChecker.Logic.Entities.App.PriceHistory>, QTPriceChecker.Logic.Controllers.App.PriceHistoriesController>();
        }
    }
}
