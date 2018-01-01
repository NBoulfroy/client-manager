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
            Data data = new Data();
            data = link.LoadData();
            SortedDictionary<int, Client> clients = data.GetClients();
            int choice;

            do
            {
                choice = ShowMenu();
                string message;

                switch (choice)
                {
                    default:
                        Console.Clear();
                        ShowMenu();
                        break;
                    case 1:
                        Console.Clear();
                        ShowClients(clients);
                        Console.WriteLine("\nPress enter to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        ShowClients(clients);
                        message = AddClient();
                        Console.WriteLine("\nSystem: " + message);
                        Console.WriteLine("Press enter to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        ShowClients(clients);
                        message = UpdateClient(clients);
                        Console.WriteLine("\nSystem: " + message);
                        Console.WriteLine("Press enter to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        ShowClients(clients);
                        message = DeleteClient();
                        Console.WriteLine("\nSystem: " + message);
                        Console.WriteLine("Press enter to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        message = PrintCSV(data);
                        Console.WriteLine("\nSystem: " + message);
                        Console.WriteLine("Press enter to continue ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Environment.Exit(6);
                        break;
                }

            } while (choice != 6);
        }

        static int ShowMenu()
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

            dynamic choice = Console.ReadLine();
            return Convert.ToInt32(choice);
        }

        static void ShowClients(SortedDictionary<int, Client> clients)
        {
            Console.WriteLine("Client list:\n");

            foreach (KeyValuePair<int, Client> client in clients)
            {
                Console.WriteLine("{0}. {1} {2}", client.Value.GetId(), client.Value.GetLastName(), client.Value.GetFirstName());
                Console.WriteLine("--------------------------------------");
            }
        }

        public static string AddClient()
        {
            Console.Write("\nClient's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Client's first name: ");
            string firstName = Console.ReadLine();

            string message = link.AddClient(lastName, firstName);
            return message;
        }

        public static string UpdateClient(SortedDictionary<int, Client> clients)
        {
            Console.Write("\nClient's number: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Client's last name: ");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.Write("Client's first name: ");
            string firstName = Convert.ToString(Console.ReadLine());

            string message = link.UpdateClient(id, lastName, firstName);
            return message;
        }

        public static string DeleteClient()
        {
            Console.Write("\nClient number : ");
            int id = Convert.ToInt32(Console.ReadLine());
            string message = link.DeleteClient(id);
            return message;
        }

        public static string PrintCSV(Data data)
        {
            CSV csv = new CSV();
            List<string> items = new List<string> { "Last name", "First name" };
            csv.HeaderBuilder(items);
            csv.AddContent(data.GetClients());
            
            if (File.Exists(csv.GetFile()))
            {
                File.Delete(csv.GetFile());
            }

            csv.FileCreation();

            string message = "Document created with success.";
            return message;
        }
    }
}
