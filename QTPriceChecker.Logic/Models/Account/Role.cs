//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTPriceChecker.Logic.Models.Account
{
    using System;
    public partial class Role : VersionModel
    {
        static Role()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Role()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        new internal QTPriceChecker.Logic.Entities.Account.Role Source
        {
            get => (QTPriceChecker.Logic.Entities.Account.Role)(_source ??= new QTPriceChecker.Logic.Entities.Account.Role());
            set => _source = value;
        }
        public System.String Designation
        {
            get => Source.Designation;
            set => Source.Designation = value;
        }
        public System.String? Description
        {
            get => Source.Description;
            set => Source.Description = value;
        }
        public System.Collections.Generic.List<QTPriceChecker.Logic.Models.Account.Identity> Identities
        {
            get => Source.Identities.Select(e => QTPriceChecker.Logic.Models.Account.Identity.Create(e)).ToList();
            set => Source.Identities = value.Select(e => e.Source).ToList();
        }
        internal void CopyProperties(QTPriceChecker.Logic.Entities.Account.Role other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Designation = other.Designation;
                Description = other.Description;
                Identities = other.Identities.Select(e => QTPriceChecker.Logic.Models.Account.Identity.Create((object)e)).ToList();
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Entities.Account.Role other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Entities.Account.Role other);
        internal void CopyProperties(QTPriceChecker.Logic.Models.Account.Role other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Designation = other.Designation;
                Description = other.Description;
                Identities = other.Identities;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Models.Account.Role other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Models.Account.Role other);
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Account.Role other)
            {
                result = IsEqualsWith(RowVersion, other.RowVersion)
                && Id == other.Id;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Designation, Description, Identities, RowVersion, Id);
        }
        public static QTPriceChecker.Logic.Models.Account.Role Create()
        {
            BeforeCreate();
            var result = new QTPriceChecker.Logic.Models.Account.Role();
            AfterCreate(result);
            return result;
        }
        public static QTPriceChecker.Logic.Models.Account.Role Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTPriceChecker.Logic.Models.Account.Role();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static QTPriceChecker.Logic.Models.Account.Role Create(QTPriceChecker.Logic.Models.Account.Role other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.Logic.Models.Account.Role();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        internal static QTPriceChecker.Logic.Models.Account.Role Create(QTPriceChecker.Logic.Entities.Account.Role other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.Logic.Models.Account.Role();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Account.Role instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Account.Role instance, object other);
        static partial void BeforeCreate(QTPriceChecker.Logic.Models.Account.Role other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Account.Role instance, QTPriceChecker.Logic.Models.Account.Role other);
        static partial void BeforeCreate(QTPriceChecker.Logic.Entities.Account.Role other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Account.Role instance, QTPriceChecker.Logic.Entities.Account.Role other);
    }
}
#endif
//MdEnd
