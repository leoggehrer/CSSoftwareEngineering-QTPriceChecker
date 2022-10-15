namespace QTPriceChecker.AspMvc.Models.Base
{
    partial class ProductXSupplier
    {
        public string ProductText { get; set; } = string.Empty;
        public List<Supplier>? Suppliers { get; set; }
        static partial void AfterCreate(ProductXSupplier instance, object other)
        {
            if (other is Logic.Entities.Base.ProductXSupplier pXs)
            {
                instance.Product = Product.Create((object)pXs.Product!);
                instance.Supplier = Supplier.Create((object)pXs.Supplier!);
            }
        }
    }
}
