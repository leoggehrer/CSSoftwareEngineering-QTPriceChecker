//@GeneratedCode
namespace QTPriceChecker.WebApi.Models.App
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class PriceHistory
    {
        ///
        /// Generated by the generator
        ///
        static PriceHistory()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public PriceHistory()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public System.Int32 ProductXSupplierId
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.DateTime From
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Decimal Price
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public QTPriceChecker.WebApi.Models.Base.ProductXSupplier? ProductXSupplier
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.WebApi.Models.App.PriceHistory Create()
        {
            BeforeCreate();
            var result = new QTPriceChecker.WebApi.Models.App.PriceHistory();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.WebApi.Models.App.PriceHistory Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTPriceChecker.WebApi.Models.App.PriceHistory();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTPriceChecker.WebApi.Models.App.PriceHistory instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTPriceChecker.WebApi.Models.App.PriceHistory instance, object other);
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.WebApi.Models.App.PriceHistory Create(QTPriceChecker.Logic.Entities.App.PriceHistory other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.WebApi.Models.App.PriceHistory();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate(QTPriceChecker.Logic.Entities.App.PriceHistory other);
        static partial void AfterCreate(QTPriceChecker.WebApi.Models.App.PriceHistory instance, QTPriceChecker.Logic.Entities.App.PriceHistory other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTPriceChecker.Logic.Entities.App.PriceHistory other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                ProductXSupplierId = other.ProductXSupplierId;
                From = other.From;
                Price = other.Price;
                ProductXSupplier = other.ProductXSupplier != null ? QTPriceChecker.WebApi.Models.Base.ProductXSupplier.Create((object)other.ProductXSupplier) : null;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Entities.App.PriceHistory other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Entities.App.PriceHistory other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTPriceChecker.WebApi.Models.App.PriceHistory other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                ProductXSupplierId = other.ProductXSupplierId;
                From = other.From;
                Price = other.Price;
                ProductXSupplier = other.ProductXSupplier;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.WebApi.Models.App.PriceHistory other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.WebApi.Models.App.PriceHistory other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.App.PriceHistory other)
            {
                result = IsEqualsWith(RowVersion, other.RowVersion)
                && Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return HashCode.Combine(ProductXSupplierId, From, Price, ProductXSupplier, RowVersion, Id);
        }
    }
}
