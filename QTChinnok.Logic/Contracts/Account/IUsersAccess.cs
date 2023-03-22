//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTChinnok.Logic.Contracts.Account
{
    using TOutModel = Models.Account.User;

    public partial interface IUsersAccess : IDataAccess<TOutModel>
    {
    }
}
#endif
//MdEnd
