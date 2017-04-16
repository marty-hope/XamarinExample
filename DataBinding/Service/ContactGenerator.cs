using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace DataBinding
{
	public class ContactGenerator
	{
		private static List<string> FirstNames = new List<string> {
			"Aiden", "Liam", "Lucas", "Noah", "Mason", "Ethan", "Caden", "Jacob", "Logan", "Jayden", "Elijah", "Jack", "Luke", "Michael", "Benjamin",
			"Alexander", "James", "Jayce", "Caleb", "Connor", "William", "Carter", "Ryan", "Oliver", "Matthew", "Daniel", "Gabriel", "Henry", "Owen",
			"Grayson", "Lincoln", "Jordan", "Tristan", "Jason", "Josiah", "Xavier", "Camden", "Chase", "Declan", "Carson", "Colin", "Brody", "Asher",
			"Jeremiah", "Micah", "Easton", "Xander", "Ryder", "Nathaniel", "Elliot", "Sean"
		};

		private static List<string> LastNames = new List<string> {
			"SMITH", "JOHNSON", "WILLIAMS", "BROWN", "JONES", "MILLER", "DAVIS", "GARCIA", "RODRIGUEZ", "WILSON", "MARTINEZ", "ANDERSON", "TAYLOR", "THOMAS HERNANDEZ",
			"RICHARDSON", "WOOD", "WATSON", "BROOKS", "BENNETT GRAY", "JAMES", "REYES", "CRUZ", "HUGHES", "PRICE", "MYERS", "LONG", "FOSTER SANDERS", "ROSS",
			"MORALES", "POWELL", "SULLIVAN", "RUSSELL ORTIZ", "JENKINS", "GUTIERREZ", "PERRY", "BUTLER", "BARNES FISHER", "HENDERSON", "COLEMAN", "SIMMONS", "PATTERSON",
			"JORDAN", "REYNOLDS"
		};

		public static List<Contact> CreateContacts(){
			var random = new Random();
			var contacts = new List<Contact>();
			for (int i = 0; i < 25; i++)
			{
				var firstName = FirstNames[random.Next(FirstNames.Count - 1)];
				var contact = new Contact
				{
					FirstName = InitCap(firstName),
					LastName = InitCap(LastNames[random.Next(LastNames.Count -1)]),
					Email = firstName + "@gmail.com"
				};
				contacts.Add(contact);
			}
			return contacts;
		}

		private static string InitCap(string name)
		{
			var letters = name.ToLower().ToCharArray();
			letters[0] = letters[0].ToString().ToUpper().ToCharArray()[0];
			return new String(letters);
		}
	}
}
