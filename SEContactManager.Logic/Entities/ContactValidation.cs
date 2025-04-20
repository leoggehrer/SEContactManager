using SEContactManager.Logic.Contracts;
using SEContactManager.Logic.Modules.Exceptions;

namespace SEContactManager.Logic.Entities
{
    partial class Contact : IValidatableEntity
    {
        public void Validate(IContext context, EntityState entityState)
        {
            ValidateProperties(this);
        }
        public static void ValidateProperties(Contact contact)
        {
            ArgumentNullException.ThrowIfNull(contact);

            if (contact.FirstName.Length < 3)
                throw new BusinessRuleException("FirstName is to short!");

            if (contact.LastName.Length < 3)
            {
                throw new BusinessRuleException("LastName is to short!");
            }
        }
    }
}
