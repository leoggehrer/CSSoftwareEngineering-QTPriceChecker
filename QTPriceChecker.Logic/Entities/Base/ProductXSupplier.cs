using QTPriceChecker.Logic.Entities.App;

namespace QTPriceChecker.Logic.Entities.Base
{
    [Table("ProductXSuppliers", Schema = "base")]
    [Index(nameof(SupplierId), nameof(ProductId), IsUnique = true)]
    public class ProductXSupplier : VersionEntity
    {
        public int SupplierId { get; set; }
        public int ProductId { get; set; }

        [NotMapped]
        public decimal MinPrice => PriceHistories.Min(e => e.Price);
        [NotMapped]
        public decimal MaxPrice => PriceHistories.Max(e => e.Price);

        // Navigation properties
        public Supplier? Supplier { get; set; }
        public Product? Product { get; set; }
        public List<PriceHistory> PriceHistories { get; set; } = new();

    }
}
