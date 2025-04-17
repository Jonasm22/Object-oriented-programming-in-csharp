using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; } 
        public string ContactNumber { get; set; }


        //Standar Constructor
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;    
            Address = address;
            ContactNumber = contactNumber;  

        }

        public Customer(string name)
        {
            Name = name;    

        }



        //Default Constructor

        public Customer()
        {
            Name = "New Customer: ";
            Address = "New Adress: ";
            ContactNumber = "New Contact Number: ";
        }




        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;


        }






    }

}
