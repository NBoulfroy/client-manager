using System;
using System.IO;
using DatabaseLibrary;
using DataLibrary;
using DocumentLibrary;

namespace ConsoleApp
{
    class Program
    {
        private static Database link = new Database();
        private static readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\";

        static void Main(string[] args)
        {
            link.LoadData();
            ShowMenu();
            string choice = Console.ReadLine();
            while (choice != "9")
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
                        Spreadsheet("ods", "spreadsheet.ods");
                        break;
                    case "7":
                        Spreadsheet("excel", "spreadsheet.xls");
                        break;
                    case "8":
                        Spreadsheet("excel", "spreadsheet.xlsx");
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
        /// Displays console application module.
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
            Console.WriteLine("8. Print xlsx file");
            Console.WriteLine("9. Exit");
            Console.WriteLine("------------------------------------");
            Console.Write("Choice: ");
        }

        /// <summary>
        /// Shows in list all customers load from Access database.
        /// </summary>
        static void ShowCustomers()
        {
            Console.WriteLine("Customer list: ");
            Console.WriteLine("--------------------------------------------\n");

            foreach (Customer customer in link.GetData().GetCustomers())
            {
                Console.WriteLine("{0}. {1} {2}", customer.Customer_id, customer.Customer_lastName, customer.Customer_firstName);
            }
        }

        /// <summary>
        /// Adds customer in memory and in Access database.
        /// </summary>
        static void AddCustomer()
        {
            Console.Write("\nCustomer's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Customer's first name: ");
            string firstName = Console.ReadLine();

            if (lastName != null && lastName != "" && lastName != " " && firstName != null && firstName != "" && firstName != " ")
            {
                Console.WriteLine(link.AddCustomer(lastName, firstName));
            }
            else
            {
                Console.WriteLine("\nInvalid input, please try again.");
            }
        }

        /// <summary>
        /// Updates a customer in memory and in Access database.
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
        /// Deletes a customer in memory and in Access database.
        /// </summary>
        static void DeleteCustomer()
        {
            Console.Write("\nCustomer's identity: ");
            string id = Console.ReadLine();

            if (int.TryParse(id, out int identity))
            {
                Console.WriteLine("\n" + link.RemoveCustomer(Convert.ToInt32(identity)));
            }
            else
            {
                Console.WriteLine("\nInvalid input, please try again.");
            }
        }
        
        /// <summary>
        /// Creates CSV file (.CSV).
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
        /// Creates spreadsheet file (.ODS, .XLS & .XLSX).
        /// </summary>
        /// <param name="file"></param>
        static void Spreadsheet(string type, string file)
        {
            // File existing verification.
            if (File.Exists(desktopPath + file))
            {
                File.Delete(desktopPath + file);
            }

            switch (type)
            {
                case "ods":
                    // OpenDocument Spreadsheet.
                    OpenDocument spreadsheet = new OpenDocument(desktopPath, file);
                    spreadsheet.DocumentBuilder(link.GetData().GetCustomers());
                    break;
                case "excel":
                    // Microsoft Excel spreadsheet.
                    Excel excel = new Excel(desktopPath, file);
                    // File creation.
                    excel.DocumentBuilder(link.GetData().GetCustomers());
                    break;
            }

            Console.WriteLine("\nSpreadsheet file created with success on desktop.");
        }
    }
}
