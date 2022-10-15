namespace QTPriceChecker.AspMvc.Models.Base
{
    partial class Product
    {
        partial void AfterCopyProperties(Logic.Entities.Base.Product other)
        {
            for (int i = 0; i < ProductXSuppliers.Count; i++)
            {
                ProductXSuppliers[i].PriceHistories = other.ProductXSuppliers[i].PriceHistories.Select(e => Models.App.PriceHistory.Create(e)).ToList();
            }
        }
    }
}
