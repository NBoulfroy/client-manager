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
                        ShowClients();
                        break;
                    case "2":
                        ShowClients();
                        AddClient();
                        break;
                    case "3":
                        ShowClients();
                        UpdateClient();
                        break;
                    case "4":
                        ShowClients();
                        DeleteClient();
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
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Client-Manager console application");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Show all clients");
            Console.WriteLine("2. Add client");
            Console.WriteLine("3. Update client");
            Console.WriteLine("4. Delete client");
            Console.WriteLine("5. Print in CVS file");
            Console.WriteLine("6. Exit");
            Console.WriteLine("----------------------------------");
            Console.Write("Choice: ");
        }

        static void ShowClients()
        {
            Console.WriteLine("Client list: ");
            Console.WriteLine("--------------------------------------------\n");

            foreach (Client client in link.GetData().GetClients())
            {
                Console.WriteLine("{0}. {1} {2}", client.GetId(), client.GetLastName(), client.GetFirstName());
            }
        }

        static void AddClient()
        {
            Console.Write("\nClient's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Client's first name: ");
            string firstName = Console.ReadLine();

            if (lastName != "" && lastName != null && firstName != null && firstName != "")
            {
                Console.WriteLine("\n" + link.AddClient(lastName, firstName));
            }
            else
            {
                Console.WriteLine("\nInvalid input, please try again.");
            }
        }

        static void UpdateClient()
        {
            Console.Write("\nClient's identity: ");
            string id = Console.ReadLine();
            Console.Write("Client's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Client's first name: ");
            string firstName = Console.ReadLine();

            if (int.TryParse(id, out int identity) && lastName != "" && lastName != null && firstName != null && firstName != "")
            {
                Console.WriteLine("\n" + link.UpdateClient(Convert.ToInt32(id), lastName, firstName));
            }
            else
            {
                Console.WriteLine("\nInvalid input, please try again.");
            }
        }

        static void DeleteClient()
        {
            Console.Write("\nClient's identity: ");
            string id = Console.ReadLine();

            if (int.TryParse(id, out int identity))
            {
                Console.WriteLine("\n" + link.DeleteClient(identity));
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
            csv.AddContent(link.GetData().GetClients());
            
            if (File.Exists(csv.GetPath() + csv.GetFile()))
            {
                File.Delete(csv.GetPath() + csv.GetFile());
            }

            csv.FileCreation();

            Console.WriteLine("Document created with success on desktop.");
        }
    }
}
