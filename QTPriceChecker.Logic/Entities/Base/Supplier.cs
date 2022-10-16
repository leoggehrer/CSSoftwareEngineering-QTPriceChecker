using QTPriceChecker.Logic.Modules.Common;

namespace QTPriceChecker.Logic.Entities.Base
{
    [Table("Suppliers", Schema = "base")]
    [Index(nameof(Name), IsUnique = true)]
    public class Supplier : VersionEntity
    {
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;
        public State State { get; set; } = State.Active;

        // Navigation properties
        public List<ProductXSupplier> ProductXSuppliers { get; set; } = new();
    }
}
