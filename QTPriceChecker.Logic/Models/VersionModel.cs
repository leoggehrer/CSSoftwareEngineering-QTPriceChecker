//@CodeCopy
//MdStart
using QTPriceChecker.Logic.Contracts;

namespace QTPriceChecker.Logic.Models
{
    public abstract partial class VersionModel : IdentityModel, IVersionable
    {
        private byte[]? _rowVersion;
        new internal virtual Entities.VersionEntity Source
        {
            get => (Entities.VersionEntity)_source!;
            set => _source = value;
        }
        /// <summary>
        /// Row version of the entity.
        /// </summary>
        public virtual byte[]? RowVersion
        {
            get => Source?.RowVersion ?? _rowVersion;
            set
            {
                if (Source != null)
                    Source.RowVersion = value;
                else
                    _rowVersion = value;
            }
        }
    }
}
//MdEnd
