using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tthk_graz_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewContactPage : ContentPage
    {
        public NewContactPage()
        {
            InitializeComponent();
        }

        private void AddContactToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Contact contactToAdd = new Contact()
            {
                FirstName = firstNameCell.Text,
                LastName = lastNameCell.Text,
                Phone = phoneCell.Text,
                Twitter = twitterCell.Text
            };
            if (!String.IsNullOrEmpty(contactToAdd.FirstName))
            {
                App.Database.SaveItem(contactToAdd);
            }

            this.Navigation.PopAsync();
        }
    }
}