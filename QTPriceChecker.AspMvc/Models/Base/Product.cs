//@GeneratedCode
namespace QTPriceChecker.AspMvc.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class Product
    {
        ///
        /// Generated by the generator
        ///
        static Product()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public Product()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public System.String Number
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String Designation
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String? Description
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Double Quantity
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public QTPriceChecker.Logic.Modules.Common.UnitOfMeasure Unit
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Decimal MinPrice
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Decimal MaxPrice
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public QTPriceChecker.Logic.Modules.Common.State State
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Collections.Generic.List<QTPriceChecker.AspMvc.Models.Base.ProductXSupplier> ProductXSuppliers
        {
            get;
            set;
        }
        = new();
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.AspMvc.Models.Base.Product Create()
        {
            BeforeCreate();
            var result = new QTPriceChecker.AspMvc.Models.Base.Product();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.AspMvc.Models.Base.Product Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTPriceChecker.AspMvc.Models.Base.Product();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTPriceChecker.AspMvc.Models.Base.Product instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTPriceChecker.AspMvc.Models.Base.Product instance, object other);
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.AspMvc.Models.Base.Product Create(QTPriceChecker.Logic.Entities.Base.Product other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.AspMvc.Models.Base.Product();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate(QTPriceChecker.Logic.Entities.Base.Product other);
        static partial void AfterCreate(QTPriceChecker.AspMvc.Models.Base.Product instance, QTPriceChecker.Logic.Entities.Base.Product other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTPriceChecker.Logic.Entities.Base.Product other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Number = other.Number;
                Designation = other.Designation;
                Description = other.Description;
                Quantity = other.Quantity;
                Unit = other.Unit;
                MinPrice = other.MinPrice;
                MaxPrice = other.MaxPrice;
                State = other.State;
                ProductXSuppliers = other.ProductXSuppliers.Select(e => QTPriceChecker.AspMvc.Models.Base.ProductXSupplier.Create((object)e)).ToList();
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Entities.Base.Product other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Entities.Base.Product other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTPriceChecker.AspMvc.Models.Base.Product other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Number = other.Number;
                Designation = other.Designation;
                Description = other.Description;
                Quantity = other.Quantity;
                Unit = other.Unit;
                MinPrice = other.MinPrice;
                MaxPrice = other.MaxPrice;
                State = other.State;
                ProductXSuppliers = other.ProductXSuppliers;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.AspMvc.Models.Base.Product other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.AspMvc.Models.Base.Product other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.Product other)
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
            return HashCode.Combine(Number, Designation, Description, Quantity, Unit, MinPrice, HashCode.Combine(MaxPrice, State, ProductXSuppliers, RowVersion, Id));
        }
    }
}
