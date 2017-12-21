using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ICT13580096EndB.Model
{
	public class Product
	{

		[NotNull]
		[MaxLength(100)]
		public string Trycar { get; set; }
		public string Brand { get; set; }
		public String Model { get; set; }
		public int Years { get; set; }
		public String Mile { get; set; }
		public String Color { get; set; }
		public String Deler { get; set; }

		public String Tel { get; set; }
		public String Price { get; set; }
		public string Address { get; set; }

		[NotNull]
		[MaxLength(200)]
		public String Deital
		{ get; set; }



	}
}