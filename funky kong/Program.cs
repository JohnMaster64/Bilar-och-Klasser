namespace funky_kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage.AddToGarage("Cayan Pepper", "Spicy Gonzales", 4, "478VN9024", 1982, false, "Spicy Red", 10, "diesel",36000);
            garage.AddToGarage("Baby Driver", "The Boss", 2, "956OD95767", 2014, false, "baby blue", 7, "biogas", 23000);

            

            garage.printWholeGarage();

            Console.WriteLine("Vilken bil vill du köra");
            int billar = int.Parse(Console.ReadLine());

            garage.GetCar(1).TurnOnCar();

        }
    }
}