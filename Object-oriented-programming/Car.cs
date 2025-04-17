using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
    class Car
    {
        //Property
        private string _model = "";
        private string _brand= "";
        private bool _isLuxury;

        // Getter and Setter with lambda expression 
        public string Model { get => _model; set => _model = value; }
       
        
        public string Brand
        {
            get
            {
                if (_isLuxury)
                {
                    return _brand + "- Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }

            set
            {
                /* Returns true if the string is null or empty ("").
                 Check if a string has no value or is empty.*/

                if (string.IsNullOrEmpty(value))
                {

                    Console.WriteLine("You entered NOTHING");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }

            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        //Custom Construtor
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            
            Console.WriteLine($"A {Brand} of the" + $" model {Model} has been created");
        }



        public void Drive()
        {
            Console.WriteLine($"I am a Model: {Model} and i am Driving");
        }


    }
}
