﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tthk_graz_app
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        private Contact contact;
        public ContactPage(Contact contact)
        {
            this.contact = contact;
            InitializeComponent();
            string fullName = contact.FirstName + " " + contact.LastName;
            Title = fullName;
            Dictionary<string, string> contactData = new Dictionary<string, string>();
            contactData.Add("Telefoninumber", contact.Phone);
            contactData.Add("E-post", contact.Email);
            contactData.Add("Telegram", contact.Telegram);
            contactData.Add("VK", contact.VK);
            contactData.Add("Twitter", contact.Twitter);
            contactFullNameLabel.Text = fullName;
            contactInitialsLabel.Text = contact.Initials;
            contactInitialsCircle.BackgroundColor = contact.CircleColor;
            contactDataListView.ItemsSource = contactData;
            contactDataListView.SelectionMode = ListViewSelectionMode.None;
            contactDataListView.ItemTapped += ContactDataListViewOnItemTapped;
            contactDataListView.ItemTemplate = new DataTemplate(() =>
            {
                Label fieldTitleLabel = new Label()
                {
                    FontSize = 10
                };
                fieldTitleLabel.SetBinding(Label.TextProperty, "Key");
                Label fieldDataLabel = new Label()
                {
                    FontSize = 17
                };
                fieldDataLabel.SetBinding(Label.TextProperty, "Value");
                return new ViewCell()
                {
                    View = new StackLayout()
                    {
                        Padding = new Thickness(10),
                        Orientation = StackOrientation.Vertical,
                        Children = { fieldTitleLabel, fieldDataLabel }
                    }
                };
            });
        }

        private void ContactDataListViewOnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var field = (KeyValuePair<string, string>) e.Item;
            string communicationTool = field.Key;
            string communicationToolData = field.Value;
            if (!String.IsNullOrEmpty(communicationToolData))
            {
                switch (communicationTool)
                {
                    case "Telefoninumber":

                        break;
                    case "E-post":
                        break;
                    case "Telegram":

                        break;
                    case "VK":

                        break;
                    case "Twitter":

                        break;
                    default:
                        break;
                }
            }
            
        }

        private void DeleteContactMenuItemOnClicked(object sender, EventArgs e)
        {
            App.Database.DeleteItem(contact.Id);
            Navigation.PopAsync();
        }

        private void ChangeContactMenuItemOnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditContactPage(contact));
        }
    }
}