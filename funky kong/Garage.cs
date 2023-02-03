using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace funky_kong
{
    internal class Garage
    {
        List<Car> _Garage = new List<Car>();


        public void AddToGarage(string manufacturer, string model, int seats, string numberPlate, int manufactureYear, bool oNOFF, string colour, int fuelamount, string fueltype, int distanceTraveled)
        {
            _Garage.Add(new Car(manufacturer, model, seats, numberPlate, manufactureYear,
                oNOFF, colour, fuelamount, fueltype, distanceTraveled));
        }

        



        public void printWholeGarage()
        {
            Console.WriteLine("The Garage contains");
            for(int i = 0; i < _Garage.Count; i++) 
            {
                _Garage[i].printCar();
            }
        }

        public Car GetCar(int i)
        {
            return _Garage[i];
        }
    }

   
}
