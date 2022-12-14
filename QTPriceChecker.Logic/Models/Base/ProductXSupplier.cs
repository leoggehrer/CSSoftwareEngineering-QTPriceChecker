//@GeneratedCode
namespace QTPriceChecker.Logic.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class ProductXSupplier
    {
        ///
        /// Generated by the generator
        ///
        static ProductXSupplier()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public ProductXSupplier()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        new internal QTPriceChecker.Logic.Entities.Base.ProductXSupplier Source
        {
            get => (QTPriceChecker.Logic.Entities.Base.ProductXSupplier)(_source ??= new QTPriceChecker.Logic.Entities.Base.ProductXSupplier());
            set => _source = value;
        }
        public System.Int32 SupplierId
        {
            get => Source.SupplierId;
            set => Source.SupplierId = value;
        }
        public System.Int32 ProductId
        {
            get => Source.ProductId;
            set => Source.ProductId = value;
        }
        public System.Decimal MinPrice
        {
            get => Source.MinPrice;
        }
        public System.Decimal MaxPrice
        {
            get => Source.MaxPrice;
        }
        public System.Decimal CurrentPrice
        {
            get => Source.CurrentPrice;
        }
        public QTPriceChecker.Logic.Models.Base.Supplier? Supplier
        {
            get => Source.Supplier != null ? QTPriceChecker.Logic.Models.Base.Supplier.Create(Source.Supplier) : null;
            set => Source.Supplier = value?.Source;
        }
        public QTPriceChecker.Logic.Models.Base.Product? Product
        {
            get => Source.Product != null ? QTPriceChecker.Logic.Models.Base.Product.Create(Source.Product) : null;
            set => Source.Product = value?.Source;
        }
        public System.Collections.Generic.List<QTPriceChecker.Logic.Models.App.PriceHistory> PriceHistories
        {
            get => Source.PriceHistories.Select(e => QTPriceChecker.Logic.Models.App.PriceHistory.Create(e)).ToList();
            set => Source.PriceHistories = value.Select(e => e.Source).ToList();
        }
        ///
        /// Generated by the generator
        ///
        internal void CopyProperties(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                SupplierId = other.SupplierId;
                ProductId = other.ProductId;
                Supplier = other.Supplier != null ? QTPriceChecker.Logic.Models.Base.Supplier.Create((object)other.Supplier) : null;
                Product = other.Product != null ? QTPriceChecker.Logic.Models.Base.Product.Create((object)other.Product) : null;
                PriceHistories = other.PriceHistories.Select(e => QTPriceChecker.Logic.Models.App.PriceHistory.Create((object)e)).ToList();
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTPriceChecker.Logic.Models.Base.ProductXSupplier other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                SupplierId = other.SupplierId;
                ProductId = other.ProductId;
                Supplier = other.Supplier;
                Product = other.Product;
                PriceHistories = other.PriceHistories;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Models.Base.ProductXSupplier other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Models.Base.ProductXSupplier other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.ProductXSupplier other)
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
            return HashCode.Combine(SupplierId, ProductId, MinPrice, MaxPrice, CurrentPrice, Supplier, HashCode.Combine(Product, PriceHistories, RowVersion, Id));
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.Logic.Models.Base.ProductXSupplier Create()
        {
            BeforeCreate();
            var result = new QTPriceChecker.Logic.Models.Base.ProductXSupplier();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.Logic.Models.Base.ProductXSupplier Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTPriceChecker.Logic.Models.Base.ProductXSupplier();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.Logic.Models.Base.ProductXSupplier Create(QTPriceChecker.Logic.Models.Base.ProductXSupplier other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.Logic.Models.Base.ProductXSupplier();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.Logic.Models.Base.ProductXSupplier Create(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.Logic.Models.Base.ProductXSupplier();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Base.ProductXSupplier instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Base.ProductXSupplier instance, object other);
        static partial void BeforeCreate(QTPriceChecker.Logic.Models.Base.ProductXSupplier other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Base.ProductXSupplier instance, QTPriceChecker.Logic.Models.Base.ProductXSupplier other);
        static partial void BeforeCreate(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Base.ProductXSupplier instance, QTPriceChecker.Logic.Entities.Base.ProductXSupplier other);
    }
}
