using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            dbclient client = new dbclient();
            client.Start();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "c":
                    client.Create();
                    break;
                case "r":
                    client.Read();
                    break;
                case "u":
                    client.Update();
                    break;
                case "d":
                    client.Delete();
                    break;
                default:
                    Console.WriteLine("Prøv igen.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
