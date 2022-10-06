using QTPriceChecker.Logic.Entities.Base;

namespace QTPriceChecker.Logic.Controllers.Base
{
    partial class ProductsController
    {
        internal override IEnumerable<string> Includes => new string[] { nameof(Product.SupplierXProducts) };
    }
}
