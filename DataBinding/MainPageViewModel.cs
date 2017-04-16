using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
namespace DataBinding
{
	public class MainPageViewModel
	{
		public ObservableCollection<Grouping<string, Contact>> ContactGroup
		{
			get;
			set;
		}
		public MainPageViewModel()
		{
			Init();
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

	}
}
