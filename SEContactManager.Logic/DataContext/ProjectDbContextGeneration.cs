﻿//@GeneratedCode
namespace SEContactManager.Logic.DataContext
{
    /// <summary>
    /// Generated by the generator
    /// </summary>
    partial class ProjectDbContext
    {
        #region properties
        /// <summary>
        /// Generated by the generator.
        /// </summary>
        private DbSet<Entities.Contact> DbContactSet { get; set; }
        /// <summary>
        /// Generated by the generator.
        /// </summary>
        public Contracts.IEntitySet<Entities.Contact> ContactSet => new DataContext.ContactSet(this, DbContactSet);
        #endregion properties

        #region partial methods
        /// <summary>
        /// Generated by the generator
        /// </summary>
        partial void GetGeneratorDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : Entities.EntityObject
        {
            if (typeof(E) == typeof(Entities.Contact))
            {
                dbSet = DbContactSet as DbSet<E>;
                handled = true;
            }
        }
        #endregion partial methods
    }
}
