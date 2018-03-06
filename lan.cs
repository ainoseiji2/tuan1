using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Net;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            String strHostName = Dns.GetHostName();
            Console.WriteLine("Host Name: " + strHostName);
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            int nIP = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP #" + ++nIP + ": " +
                                  ipaddress.ToString());
            }
        }
    }
}
