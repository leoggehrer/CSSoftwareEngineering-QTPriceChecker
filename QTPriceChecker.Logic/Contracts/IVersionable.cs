//@CodeCopy
//MdStart

namespace QTPriceChecker.Logic.Contracts
{
    public partial interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd
