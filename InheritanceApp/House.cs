using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
	public class House
	{
		public int SquareMeters { get; private set; }
		public int Year { get; set; }
		public string Color { get; set; }
		public int MonthlyPrice { get; private set; }
		public House(int squareMeters, int year = 0, string color = "Unknown Color") 
		{
			SquareMeters = squareMeters;
			Year = year;
			Color = color;
		}

		public int GetSquareMeters()
		{
			return SquareMeters;
		}

		public void SetSquareMeters(int squareMeters)
		{
			if (SquareMeters == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(squareMeters), squareMeters, "The house cannot be 0 squaremeters");
			}
			else
			{
				SquareMeters = squareMeters;
			}	
		}

		public int GetPricePerSqrMeters(int price)
		{
			int monthlySum = price / 12;
			return monthlySum / SquareMeters;
		}

		public virtual string ContentAsString()
		{
			return $"This house has {SquareMeters}m ammount of floor space.";
		}
	}
}
