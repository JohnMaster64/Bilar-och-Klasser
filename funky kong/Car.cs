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
  
    internal class Car
    {
        string _manufacturer;
        string _model;
        int _seats;
        int _speed;
        string _numberPlate;
        int _manufactureYear;
        bool _on_off;
        string _colour;
        int _fuelamount;
        string _fueltype;
        int _distanceTraveled;

        public Car()
        {
            
            _manufacturer = "";
            _model = "";
            _seats = 0;
            _speed = 0;
            _numberPlate = "";
            _manufactureYear = 0;
            _on_off = false;
            _colour = "";
            _fuelamount = 0;
            _fueltype = "";
            _distanceTraveled = 0;

            

        }

        public Car(string manufacturer, string model, int seats, string numberPlate, int manufactureYear,
            bool oNOFF, string colour, int fuelamount, string fueltype, int distanceTraveled)
        {
            _manufacturer = manufacturer;
            _model = model;
            _seats = seats;
            _numberPlate = numberPlate;
            _manufactureYear = manufactureYear;
            _fuelamount = fuelamount;  
            _colour = colour;
            _fueltype = fueltype;
            _distanceTraveled = distanceTraveled;



               
        }


        public void TurnOnCar() 
        { 
        _on_off = true;
            _speed = 5;
        }


        public void Drive() 
        { 
        
            
            if(_on_off == true)
            {

                while (_on_off = true)
                    _distanceTraveled += _speed;
                
                

            }
            else 
            {
                Console.WriteLine("Car is not on");
            }
        }
        public void printCar()
        {
            Console.WriteLine($"Registreringsnummer: {_numberPlate}\n" +
               $"Märke: {_manufacturer}\n" +
               $"Modell: {_model}\n" +
               $"Färg: {_colour}\n" +
            $"Årsmodell {_manufactureYear}\n" +
               $"Bränsletyp {_fuelamount}\n" +
               $"Tankvolym {_fueltype}\n" +
               $"Miltal: {_distanceTraveled}");
        }






    }

    
}
