namespace InheritanceApp
{
	internal class Program
	{
		static void Main()
		{
			List<House> houseList = new()
			{
				new House(420),
				new House(120),
				new Skyscraper(64000, 3, "green")
			};

			foreach (House house in houseList)
			{
                Console.WriteLine(house.ContentAsString());
            }

			int sqrMetersSum = houseList.Sum(x => x.GetSquareMeters());
            Console.WriteLine(sqrMetersSum);
        }
	}
}