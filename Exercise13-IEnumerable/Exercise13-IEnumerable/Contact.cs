using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_IEnumerable
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact()
        {
            
        }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public void Call()
        {
            Console.WriteLine($"Calling to {this.Name}." +
                $" Phone Number is {this.PhoneNumber}");
        }
    }
}
