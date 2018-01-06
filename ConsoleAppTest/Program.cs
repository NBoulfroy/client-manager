using System;
using System.Collections.Generic;
using ClassLibrary;
using System.IO;

namespace ConsoleAppTest
{
    class Program
    {
        private static Link link = new Link();

        static void Main(string[] args)
        {
            link.LoadData();
            ShowMenu();
            string choice = Console.ReadLine();
            while (choice != "6")
            {
                Console.Clear();
                switch(choice)
                {
                    default:
                        Console.WriteLine("Nonexistent option, please try again.");
                        break;
                    case "1":
                        ShowCustomers();
                        break;
                    case "2":
                        ShowCustomers();
                        AddCustomer();
                        break;
                    case "3":
                        ShowCustomers();
                        UpdateCustomer();
                        break;
                    case "4":
                        ShowCustomers();
                        DeleteCustomer();
                        break;
                    case "5":
                        PrintCSV();
                        break;
                }
                Console.WriteLine("\nPress any other key to return to the menu ...");
                Console.ReadKey();
                Console.Clear();
                ShowMenu();
                choice = Console.ReadLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Customer-Manager console application");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Show all customers");
            Console.WriteLine("2. Add customer");
            Console.WriteLine("3. Update customer");
            Console.WriteLine("4. Delete customer");
            Console.WriteLine("5. Print in CVS file");
            Console.WriteLine("6. Exit");
            Console.WriteLine("------------------------------------");
            Console.Write("Choice: ");
        }

        static void ShowCustomers()
        {
            Console.WriteLine("Customer list: ");
            Console.WriteLine("--------------------------------------------\n");

            foreach (Customer customer in link.GetData().GetCustomers())
            {
                Console.WriteLine("{0}. {1} {2}", customer.GetId(), customer.GetLastName(), customer.GetFirstName());
            }
        }

        static void AddCustomer()
        {
            Console.Write("\nCustomer's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Customer's first name: ");
            string firstName = Console.ReadLine();

            if (lastName != null && lastName != "" && lastName != " " && firstName != null && firstName != "" && firstName != " ")
            {
                Console.WriteLine("\n" + link.AddCustomer(lastName, firstName));
            }
            else
            {
                Console.WriteLine("\nInvalid input, please try again.");
            }
        }

        static void UpdateCustomer()
        {
            Console.Write("\nCustomer's identity: ");
            string id = Console.ReadLine();
            Console.Write("Customer's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Customer's first name: ");
            string firstName = Console.ReadLine();

            if (int.TryParse(id, out int identity) 
                && lastName != null && lastName != "" && lastName != " " 
                && firstName != null && firstName != "" && firstName != " ")
            {
                Console.WriteLine("\n" + link.UpdateCustomer(Convert.ToInt32(identity), lastName, firstName));
            }
            else
            {
                Console.WriteLine("\nInvalid input, please try again.");
            }
        }

        static void DeleteCustomer()
        {
            Console.Write("\nCustomer's identity: ");
            string id = Console.ReadLine();

            if (int.TryParse(id, out int identity))
            {
                Console.WriteLine("\n" + link.DeleteCustomer(identity));
            }
            else
            {
                Console.WriteLine("\nInvalid input, please try again.");
            }
            
        }

        static void PrintCSV()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            desktopPath += "\\";
            CSV csv = new CSV(desktopPath);
            List<string> items = new List<string> { "Last name", "First name" };
            csv.HeaderBuilder(items);
            csv.AddContent(link.GetData().GetCustomers());
            
            if (File.Exists(csv.GetPath() + csv.GetFile()))
            {
                File.Delete(csv.GetPath() + csv.GetFile());
            }

            csv.FileCreation();

            Console.WriteLine("Document created with success on desktop.");
        }
    }
}
