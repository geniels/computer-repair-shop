using ComputerRepairShop.Domain.Enum;
using ComputerRepairShop.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerRepairShop.Console
{
    public class UserInterface
    {
        private short userMenuOption;
        public short UserMenuOption => userMenuOption;

        public UserInterface()
        {
            this.userMenuOption = 0;
            SelectUserOption();
        }
        public void SelectUserOption()
        {
            System.Console.WriteLine("************************************************************");
            System.Console.WriteLine("****************************MENU****************************");
            System.Console.WriteLine("Selec one option with numbers");
            System.Console.WriteLine("Register new client = 1");
            System.Console.WriteLine("Register product = 2");
            System.Console.WriteLine("Exit program = 3");
            this.userMenuOption = short.Parse(System.Console.ReadLine());

            if (userMenuOption == 1)
            {
                GetClientInformation();
            }
            else if (userMenuOption == 2)
            {
                RegisterProduct();
            }
            else if (userMenuOption == 2)
            {
                RegisterProduct();
            }
        }

        private void RegisterProduct()
        {
            Computer computer = new Computer();

            System.Console.WriteLine("Selected option 'Register product' ");
            System.Console.WriteLine();
            System.Console.WriteLine("What's the product id ");
            computer.Id = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Portable? S/N");
            var idBool = System.Console.ReadLine();
            if (idBool.ToUpper() == "S")
            {
                computer.Portable = true;
            }
            else if (idBool.ToUpper() == "N")
            {
                computer.Portable = false;
            }
            else
            {
                System.Console.WriteLine("S OR N ONLY");
            }
            System.Console.WriteLine("What's the service?");

            System.Console.WriteLine(Enum.GetName(typeof(ServiceTypes), 0));
        }

        private void GetClientInformation()
        {
            Address address = new Address();
            Client client = new Client();

            System.Console.WriteLine("Selected option 'Register new client' ");
            System.Console.WriteLine();
            System.Console.Write("What's your name?: ");
            client.Name = System.Console.ReadLine();
            System.Console.Write("What's your state?: ");
            address.State = System.Console.ReadLine();
            System.Console.Write("What's your city?: ");
            address.City = System.Console.ReadLine();
            System.Console.Write("What's your CEP?: ");
            address.Cep = System.Console.ReadLine();
            System.Console.Write("What's your street?: ");
            address.Street = System.Console.ReadLine();
            System.Console.Write("What's your street number?: ");
            address.StreetNumber = int.Parse(System.Console.ReadLine());
        }
    }
}
