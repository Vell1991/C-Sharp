using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Magazine
    {
        public string Name { get; set; }
        public int yaer { get; set; }
        public string INFO { get; set; }
        public string telefhone { get; set; }
        public string email { get; set; }

        public Magazine(string name, int yaer, string iNFO, string telefhone, string email)
        {
            Name = name;
            this.yaer = yaer;
            INFO = iNFO;
            this.telefhone = telefhone;
            this.email = email;
        }

        public Magazine(){}
         
        public void Print()
        {
            Console.WriteLine("Name      : " + Name);
            Console.WriteLine("Year      : " + yaer.ToString());
            Console.WriteLine("INFO      : " + INFO);
            Console.WriteLine("Telefhone : " + telefhone);
            Console.WriteLine("E-mail    : " + email);
        }
    }
}
