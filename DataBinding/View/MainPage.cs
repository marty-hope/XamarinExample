using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace DataBinding
{
	public partial class MainPage : ContentPage
	{
		MainPageViewModel _vm;
		
		public MainPage()
		{
			_vm = new MainPageViewModel();
			BindingContext = _vm;
			InitializeComponent();
		}


		void OnItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var contact = e.Item as Contact;
			DisplayAlert("Ah Ha!", string.Format("You selected {0} {1}"
							     , contact.FirstName, contact.LastName), "OK");
		}
	}
}
