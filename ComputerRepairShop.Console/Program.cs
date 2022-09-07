using ComputerRepairShop.Domain.Modules;
using System;

namespace ComputerRepairShop.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Address address = new Address();
           Client client = new Client();

            System.Console.WriteLine("************************************************************");
            System.Console.WriteLine("****************************MENU****************************");
            System.Console.WriteLine("Selec one option with numbers");
            System.Console.WriteLine("Register new client = 1");
            System.Console.WriteLine("Register product = 2");
            var optionMenu = int.Parse(System.Console.ReadLine());

            if ( optionMenu == 1)
            {  
                System.Console.WriteLine("Selected option 'Register new client' ");
                System.Console.WriteLine();
                System.Console.Write("What you name?: ");
                client.Name = System.Console.ReadLine();
                System.Console.Write("What you state?: ");
                address.State = System.Console.ReadLine();
                System.Console.Write("What you city?: ");
                address.City = System.Console.ReadLine();
                System.Console.Write("What you CEP?: ");
                address.Cep = System.Console.ReadLine();
                System.Console.Write("What you street?: ");
                address.Street = System.Console.ReadLine();
                System.Console.Write("What you street number?: ");
                address.StreetNumber = int.Parse(System.Console.ReadLine());
            }
            else if ( optionMenu == 2)
            {
                System.Console.WriteLine("Selected option 'Register product' ");
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }
    }
}
