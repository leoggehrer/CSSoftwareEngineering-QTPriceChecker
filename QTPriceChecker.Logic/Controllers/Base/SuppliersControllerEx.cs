using QTPriceChecker.Logic.Entities.Base;

namespace QTPriceChecker.Logic.Controllers.Base
{
    partial class SuppliersController
    {
        internal override IEnumerable<string> Includes => base.Includes;// new string[] { nameof(Supplier.ProductXSuppliers) };
    }
}
