using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Website
    {
        string NameWebsite;
        string way;
        string INFOWeb;
        string ip;

        public void SetName()
        {
            Console.WriteLine("Enter website name");
            NameWebsite = Console.ReadLine();
        }

        public void SetWay()
        {
            Console.WriteLine("Enter way");
            way = Console.ReadLine();
        }

        public void SetINFO()
        {
            Console.WriteLine("Enter INFO");
            INFOWeb = Console.ReadLine();
        }
        public void SetIP()
        {
            Console.WriteLine("Enter ip");
            ip = Console.ReadLine();
        }


        public Website() 
        {
            SetName();
            SetWay();
            SetINFO();
            SetIP();
        }

        public Website(string nameWebsite, string way, string iNFOWeb, string ip)
        {
            NameWebsite = nameWebsite;
            this.way = way;
            INFOWeb = iNFOWeb;
            this.ip = ip;
        }

        public void Print()
        {
            Console.WriteLine("Name website :" + NameWebsite);
            Console.WriteLine("Way          :" + way);
            Console.WriteLine("Info website :" + INFOWeb);
            Console.WriteLine("IP           :" + ip);
        }
    }
}
