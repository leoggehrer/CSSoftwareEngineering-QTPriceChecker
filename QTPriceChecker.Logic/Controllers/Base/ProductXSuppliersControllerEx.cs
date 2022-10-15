namespace QTPriceChecker.Logic.Controllers.Base
{
    partial class ProductXSuppliersController
    {
        internal override IEnumerable<string> Includes => new[] { nameof(Entities.Base.ProductXSupplier.Product), nameof(Entities.Base.ProductXSupplier.Supplier) };
    }
}
