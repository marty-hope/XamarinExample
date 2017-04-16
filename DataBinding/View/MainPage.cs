﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace DataBinding
{
	public partial class MainPage : ContentPage
	{
		public ObservableCollection<Grouping<string, Contact>> ContactGroup
		{
			get;
			set;
		}
		public MainPage()
		{
			Init();
			BindingContext = ContactGroup;
			InitializeComponent();
		}

		private void Init()
		{
			var listOfContacts = ContactGenerator.CreateContacts();
			var sorted = from c in listOfContacts
				     orderby c.FirstName
		                      group c by c.FirstName[0].ToString()
		                      into theGroup
				     select new Grouping<string, Contact>(theGroup.Key, theGroup);
			ContactGroup = new ObservableCollection<Grouping<string, Contact>>(sorted);
		}

		void OnItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var contact = e.Item as Contact;
			DisplayAlert("Ah Ha!", string.Format("You selected {0} {1}"
							     , contact.FirstName, contact.LastName), "OK");
		}
	}
}
