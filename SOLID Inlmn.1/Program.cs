using System;
using System.Collections.Generic;

namespace SOLID_Inlmn._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICustomer> customerlist = new List<ICustomer>();

            customerlist.Add(new Customer("John Doe", 001, "Sasha", "Home", "None", "0 Kr"));
            customerlist.Add(new Customer("Sarrah Doe", 002, "Jackob", "Here", "Both", "2000 Kr"));

            string commands = Console.ReadLine();
            

            if (commands == "-l")
            {
                Data();
            }
            if (commands == "-add")
            {
                AddCustomer();
            }

            void Data()
            {
                foreach (var Customer in customerlist)
                {
                    Console.WriteLine("");
                    Console.WriteLine(value: $"Customer {Customer.Userid}        Name: {Customer.Fullname}");
                    Console.WriteLine(value: $"                  Pet: {Customer.Petname}");
                    Console.WriteLine(value: $"                  Status: {Customer.Status}");
                    Console.WriteLine(value: $"                  Service: {Customer.Service}");
                    Console.WriteLine(value: $"                  Total {Customer.Total}");
                    Console.WriteLine("");

                }
                return;
            }
            void AddCustomer()
            {
                string Name;
                int id = customerlist.Count + 1;
                string Petname;
                string Status;
                string Service;
                string Total;

                Console.WriteLine("Insert Full Name");
                Name = Console.ReadLine();
                Console.WriteLine("Insert Name of Pet");
                Petname = Console.ReadLine();
                Console.WriteLine("Is it Home / Here");
                Status = Console.ReadLine();
                Console.WriteLine("Choose one: None, Both, Wash, Trim?");
                Service = Console.ReadLine();
                Console.WriteLine("Total Cost");
                Total = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Please Wait");

                customerlist.Add(new Customer(Name, id, Petname, Status, Service, Total));

                Console.WriteLine("Clearing Cache");
                Name = null;
                id = 0;
                Petname = null;
                Status = null;
                Service = null;
                Total = null;

                Data();

            }


        }
    }
}
