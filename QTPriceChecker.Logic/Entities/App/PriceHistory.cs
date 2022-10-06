using QTPriceChecker.Logic.Entities.Base;

namespace QTPriceChecker.Logic.Entities.App
{
    [Table("PriceHistories", Schema = "app")]
    public class PriceHistory : VersionEntity
    {
        public int SupplierXProductId { get; set; }
        public DateTime From { get; set; }
        [Precision(18,2)]
        public decimal Price { get; set; }

        // Navigation properties
        public SupplierXProduct? SupplierXProduct { get; set; }
    }
}
