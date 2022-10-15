using QTPriceChecker.Logic.Entities.Base;

namespace QTPriceChecker.Logic.Controllers.Base
{
    partial class ProductsController
    {
        protected override Product BeforeReturn(Product entity)
        {
            LoadPriceHistory(entity);

            return base.BeforeReturn(entity);
        }
        protected override Product[] BeforeReturn(Product[] entities)
        {
            return entities.ForEach(e => LoadPriceHistory(e)).ToArray();
        }
        private void LoadPriceHistory(Product entity)
        {
            using var prodXsuppCtrl = new ProductXSuppliersController(this);
            
            entity.ProductXSuppliers = prodXsuppCtrl.ExecuteQueryAsync(e => e.ProductId == entity.Id, "PriceHistories").Result
                                                    .ToList();
        }
    }
}
