using QTPriceChecker.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTPriceChecker.Logic.Entities.Base
{
    [Table("SupplierXProducts", Schema = "base")]
    [Index(nameof(SupplierId), nameof(ProductId), IsUnique = true)]
    public class SupplierXProduct : VersionEntity
    {
        public int SupplierId { get; set; }
        public int ProductId { get; set; }

        [NotMapped]
        public decimal CurrentPrice { get; set; }

        // Navigation properties
        public Supplier? Supplier { get; set; }
        public Product? Product { get; set; }
        public List<PriceHistory> PriceHistories { get; set; } = new();

    }
}
