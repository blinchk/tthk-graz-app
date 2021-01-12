using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace tthk_graz_app
{
    public partial class MainPage : ContentPage
    {
        public List<Contact> ContactList { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            List<Contact> contactList = new List<Contact>();
            contactList = App.Database.GetItems() as List<Contact>;
            contactsList.ItemsSource = contactList;
            ContactList = contactList;
            this.BindingContext = this;
            base.OnAppearing();
        }

        private void AddContactToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewContactPage());
        }
    }
}
