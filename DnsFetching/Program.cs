using System;
using System.Net;

namespace DnsFetching
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a url: ");
                string dns = Console.ReadLine();
                IPHostEntry hostInfo = Dns.GetHostEntry(dns);
                Console.Write("\nCorresponding dns address: ");
                Console.WriteLine(hostInfo.AddressList[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
