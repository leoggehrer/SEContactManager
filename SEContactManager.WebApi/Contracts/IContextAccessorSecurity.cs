//@CodeCopy
#if ACCOUNT_ON
namespace SEContactManager.WebApi.Contracts
{
    partial interface IContextAccessor
    {
        string SessionToken { set; }
    }
}
#endif
