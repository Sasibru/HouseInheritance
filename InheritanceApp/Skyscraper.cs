﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
	public class Skyscraper : House
	{
		public int Floors {  get; set; }
		public Skyscraper(int squareMeters, int year, string color) : base(squareMeters, year, color)
		{
			Floors = 15;
		}
	}
}
