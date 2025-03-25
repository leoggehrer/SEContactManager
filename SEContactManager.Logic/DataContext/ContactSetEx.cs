#if GENERATEDCODE_ON
using SEContactManager.Logic.Entities;

namespace SEContactManager.Logic.DataContext
{
    partial class ContactSet
    {
        protected override void BeforeAdding(Contact entity)
        {
            Contact.Validate(entity);
        }
    }
}
#endif