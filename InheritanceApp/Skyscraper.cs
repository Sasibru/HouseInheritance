using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
	public class Skyscraper : House
	{
		int Floors {  get; set; }
		public Skyscraper(int squareMeters, int floors = 15) : base(squareMeters)
		{
			Floors = floors;	
		}
	}
}
