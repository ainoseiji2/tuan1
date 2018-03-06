using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string DnSAdd = "www.tinhte.vn";
            IPHostEntry entry = Dns.Resolve(DnSAdd);
            Console.WriteLine(entry.AddressList[0]);
            Console.WriteLine(entry.HostName);
        }
    }
}
