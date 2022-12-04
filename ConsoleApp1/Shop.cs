using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shop
    {
        string? name { get; set; }
        string? address { get; set; }
        string INFO { get; set; }
        string telefhone { get; set; }
        string email { get; set; }

        public Shop(string? name, string? address, string iNFO, string telefhone, string email)
        {
            this.name = name;
            this.address = address;
            INFO = iNFO;
            this.telefhone = telefhone;
            this.email = email;
        }

        public Shop() 
        {
            Console.WriteLine("Enter name shop");
            name = Console.ReadLine();
            Console.WriteLine("Address");
            address = Console.ReadLine();
            Console.WriteLine("INFO");
            INFO = Console.ReadLine();
            Console.WriteLine("Telefhone");
            telefhone = Console.ReadLine();
            Console.WriteLine("E-mail");
            email = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Name :" + name + " Address :" + address + " INFO :" + INFO + " Telefhone : " + telefhone + " E-mail " + email);
           
        }
    }
}
