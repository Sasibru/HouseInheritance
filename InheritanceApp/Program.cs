namespace InheritanceApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			House tinyHouse = new(50);
            Console.WriteLine(tinyHouse.GetPricePerSqrMeters(120000));
        }
	}
}