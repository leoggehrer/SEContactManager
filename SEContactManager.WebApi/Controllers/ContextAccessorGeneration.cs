﻿//@GeneratedCode
namespace SEContactManager.WebApi.Controllers
{
    /// <summary>
    /// Generated by the generator
    /// </summary>
    partial class ContextAccessor
    {
        /// <summary>
        /// Generated by the generator
        /// </summary>
        partial void GetEntitySetHandler<TEntity>(ref Logic.Contracts.IEntitySet<TEntity>? entitySet, ref bool handled) where TEntity : Logic.Entities.EntityObject, new()
        {
            if (typeof(TEntity) == typeof(SEContactManager.Logic.Entities.Contact))
            {
                entitySet = GetContext().ContactSet as Logic.Contracts.IEntitySet<TEntity>;
                handled = true;
            }
        }
    }
}
