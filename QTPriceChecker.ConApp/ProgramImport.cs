namespace QTPriceChecker.ConApp
{
    using Bogus;

    partial class Program
    {
        private static Random Random = new Random();
        static partial void AfterRun()
        {
            var startDate = DateTime.Now.AddDays(400); 
            var productFaker = new Faker<Logic.Entities.Base.Product>()
                .RuleFor(e => e.Number, f => f.Commerce.Ean13())
                .RuleFor(e => e.Designation, f => f.Commerce.ProductName())
                .RuleFor(e => e.Description, f => string.Join(" ", f.Lorem.Words(5)))
                .RuleFor(e => e.Quantity, f => Random.Next(100, 1000))
                .RuleFor(e => e.Unit, f => f.PickRandom<Logic.Modules.Common.UnitOfMeasure>());
            var products = productFaker.Generate(100);
            var supplierFaker = new Faker<Logic.Entities.Base.Supplier>()
                .RuleFor(e => e.Name, f => f.Company.CompanyName());
            var supplieres = supplierFaker.Generate(10);
            var supplierXProducts = new List<Logic.Entities.Base.ProductXSupplier>();

            foreach (var supp in supplieres)
            {
                foreach (var prod in products)
                {
                    var startPrice = 1.0m * Random.Next(1, 35);
                    var sXp = new Logic.Entities.Base.ProductXSupplier()
                    {
                        Supplier = supp,
                        Product = prod,
                    };
                    for (int i = 0; i < Random.Next(1, 10); i++)
                    {
                        var sign = Random.Next(1, 1000) % 2 == 0 ? 1 : -1;

                        sXp.PriceHistories.Add(new Logic.Entities.App.PriceHistory
                        {
                            From = startDate.AddDays(Random.Next(1, 390)),
                            Price = startPrice + (sign * startPrice / 100.0m * Random.Next(0, 50) / 100.0m),
                        });
                    }
                    supplierXProducts.Add(sXp);
                }
            }

            using var suppXprodCtrl = new Logic.Controllers.Base.SupplierXProductsController();

            suppXprodCtrl.InsertAsync(supplierXProducts).Wait();
            suppXprodCtrl.SaveChangesAsync().Wait();
        }
    }
}
