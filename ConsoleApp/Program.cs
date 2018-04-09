using System;
using System.IO;
using ClassLibrary;
using DatabaseLibrary;
using DocumentLibrary;

namespace ConsoleApp
{
    class Program
    {
        private static Access link = new Access();
        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\";

        static void Main(string[] args)
        {
            link.LoadData();
            ShowMenu();
            string choice = Console.ReadLine();
            while (choice != "8")
            {
                Console.Clear();
                switch (choice)
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
                        CSV();
                        break;
                    case "6":
                        Spreadsheet("spreadsheet.ods");
                        break;
                    case "7":
                        Spreadsheet("spreadsheet.xls");
                        break;
                }
                Console.WriteLine("\nPress any other key to return to the menu ...");
                Console.ReadKey();
                Console.Clear();
                ShowMenu();
                choice = Console.ReadLine();
            }
        }

        /// <summary>
        /// Display console application module.
        /// </summary>
        static void ShowMenu()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Customer-Manager console application");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Show all customers");
            Console.WriteLine("2. Add customer");
            Console.WriteLine("3. Update customer");
            Console.WriteLine("4. Delete customer");
            Console.WriteLine("5. Print CSV file");
            Console.WriteLine("6. Print ODS file");
            Console.WriteLine("7. Print xls file");
            Console.WriteLine("8. Exit");
            Console.WriteLine("------------------------------------");
            Console.Write("Choice: ");
        }

        /// <summary>
        /// Show in list all customers load from Access database.
        /// </summary>
        static void ShowCustomers()
        {
            Console.WriteLine("Customer list: ");
            Console.WriteLine("--------------------------------------------\n");

            foreach (Customer customer in link.GetData().GetCustomers())
            {
                Console.WriteLine("{0}. {1} {2}", customer.GetId(), customer.GetLastName(), customer.GetFirstName());
            }
        }

        /// <summary>
        /// Add customer in memory and in Access database.
        /// </summary>
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

        /// <summary>
        /// Update customer in memory and in Access database.
        /// </summary>
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

        /// <summary>
        /// Delete customer in memory and in Access database.
        /// </summary>
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
        
        /// <summary>
        /// Create CSV file (.CSV).
        /// </summary>
        static void CSV()
        {
            // Get OS desktop directory.
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            desktopPath += "\\";

            // Object 
            CSV csv = new CSV(desktopPath, "spreadsheet.csv");

            // File existing verification.
            if (File.Exists(csv.GetPath() + csv.GetFile()))
            {
                File.Delete(csv.GetPath() + csv.GetFile());
            }

            // File creation.
            csv.DocumentBuilder(link.GetData().GetCustomers());

            Console.WriteLine("CSV file created with success on desktop.");
        }

        /// <summary>
        /// Create spreadsheet file (.ODS, .XLS & .XLSX).
        /// </summary>
        /// <param name="file"></param>
        static void Spreadsheet(string file)
        {
            // ODS object 
            Spreadsheet spreadsheet = new Spreadsheet(desktopPath, file);

            // File existing verification.
            if (File.Exists(spreadsheet.GetPath() + spreadsheet.GetFile()))
            {
                File.Delete(spreadsheet.GetPath() + spreadsheet.GetFile());
            }

            // File creation.
            spreadsheet.DocumentBuilder(link.GetData().GetCustomers());

            Console.WriteLine("\nSpreadsheet file created with success on desktop.");
        }
    }
}
