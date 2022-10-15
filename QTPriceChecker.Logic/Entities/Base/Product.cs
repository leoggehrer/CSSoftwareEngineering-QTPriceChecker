using QTPriceChecker.Logic.Modules.Common;

namespace QTPriceChecker.Logic.Entities.Base
{
    [Table("Products", Schema = "base")]
    [Index(nameof(Number), IsUnique = true)]
    public class Product : VersionEntity
    {
        [MaxLength(13)]
        public string Number { get; set; } = string.Empty;
        [MaxLength(256)]
        public string Designation { get; set; } = string.Empty;
        [MaxLength(1024)]
        public string? Description { get; set; }
        public double Quantity { get; set; }
        public UnitOfMeasure Unit { get; set; }
        [NotMapped]
        public decimal MinPrice => ProductXSuppliers.SelectMany(e => e.PriceHistories).Min(e => e.Price);
        [NotMapped]
        public decimal MaxPrice => ProductXSuppliers.SelectMany(e => e.PriceHistories).Max(e => e.Price);
        public State State { get; set; } = State.Active;

        // Navigation properties
        public List<ProductXSupplier> ProductXSuppliers { get; set; } = new();
    }
}
