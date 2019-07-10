using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace XamaFilm.Models
{
	public class MyCompany
	{
		public string Name { get; set; }
		public List<Delegation> Delegations { get; set; }
	}
	public class Delegation
	{
		public string Name { get; set; }
		public string City { get; set; }
		public Position Position { get; set; }
	}
}
