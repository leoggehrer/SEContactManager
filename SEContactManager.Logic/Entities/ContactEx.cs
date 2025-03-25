namespace SEContactManager.Logic.Entities
{
    partial class Contact : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        public static void Validate(Contact contact)
        {
            if (contact == null) throw new ArgumentNullException(nameof(contact));

            if (contact.FirstName.Length < 3)
                throw new Exception("FirstName is to short!");

            if (contact.LastName.Length < 3)
            {
                throw new Exception("LastName is to short!");
            }
        }
    }
}
