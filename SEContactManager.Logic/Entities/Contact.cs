namespace SEContactManager.Logic.Entities
{
    [Table("Contacts")]
    public partial class Contact : EntityObject
    {
        [MaxLength(64)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(64)]
        public string LastName { get; set; } = string.Empty;
        [MaxLength(128)]
        public string Email { get; set; } = string.Empty;
        [MaxLength(32)]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
