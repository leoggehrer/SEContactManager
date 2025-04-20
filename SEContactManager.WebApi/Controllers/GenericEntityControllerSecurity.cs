//@CodeCopy
#if ACCOUNT_ON
using SEContactManager.WebApi.Contracts;

namespace SEContactManager.WebApi.Controllers
{
    partial class GenericEntityController<TModel, TEntity, TContract>
    {
        #region partial methods
        partial void OnReadContextAccessor(IContextAccessor contextAccessor)
        {
            contextAccessor.SessionToken = SessionToken;
        }
        #endregion partial methods
    }
}
#endif
