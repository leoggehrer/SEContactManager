using Avalonia.Controls;
using SEContactManager.MVVMApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEContactManager.MVVMApp.ViewModels
{
    public partial class ContactsViewModel : GenericItemsViewModel<Models.Contact>
    {
        protected override GenericItemViewModel<Contact> CreateViewModel()
        {
            return new ContactViewModel();
        }

        protected override Window CreateWindow()
        {
            return new Views.ContactWindow();
        }
    }
}
