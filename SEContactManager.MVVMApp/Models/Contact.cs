﻿//@GeneratedCode
namespace SEContactManager.MVVMApp.Models
{
    using System;
    /// <summary>
    /// This model represents a transmission model for the 'Contact' data unit.
    /// </summary>

    public partial class Contact : SEContactManager.Common.Contracts.IContact
    {
        /// <summary>
        /// Initializes the class (created by the generator).
        /// </summary>
        static Contact()
        {
            ClassConstructing();
            ClassConstructed();
        }
        /// <summary>
        /// This method is called before the construction of the class.
        /// </summary>
        static partial void ClassConstructing();
        /// <summary>
        /// This method is called when the class is constructed.
        /// </summary>
        static partial void ClassConstructed();

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class (created by the generator.)
        /// </summary>
        public Contact()
        {
            Constructing();

            Constructed();
        }
        /// <summary>
        /// This method is called the object is being constraucted.
        /// </summary>
        partial void Constructing();
        /// <summary>
        /// This method is called when the object is constructed.
        /// </summary>
        partial void Constructed();
        /// <summary>
        /// Property 'FirstName' generated by the generator.
        /// </summary>
        public System.String FirstName { get; set; } = string.Empty;
        /// <summary>
        /// Property 'LastName' generated by the generator.
        /// </summary>
        public System.String LastName { get; set; } = string.Empty;
        /// <summary>
        /// Property 'Email' generated by the generator.
        /// </summary>
        public System.String Email { get; set; } = string.Empty;
        /// <summary>
        /// Property 'PhoneNumber' generated by the generator.
        /// </summary>
        public System.String PhoneNumber { get; set; } = string.Empty;
        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Contact other)
            {
                result = Id == other.Id;
            }
            return result;
        }
        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        public override int GetHashCode()
        {
            return this.CalculateHashCode(FirstName, LastName, Email, PhoneNumber, Id);
        }
    }
}
