using System;
using System.Collections.Generic;

namespace DufflinMunder
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Dufflin/Munder Cardboard Co." + "\n" +
                "Sales Portal!");
            Console.WriteLine("1. Enter Sales");
            Console.WriteLine("2. Generate Report For Accountant");
            Console.WriteLine("3. Add New Sales Employee");
            Console.WriteLine("4. Find a Sale");
            Console.WriteLine("5. Exit");
            string response = Console.ReadLine();


            var AllEmployees = new List<AccountantEmployee>();
            var accountant = new AccountantEmployee("Kevin", "Duren");
            var accountant1 = new AccountantEmployee("Angelina", "Simmons");

            AllEmployees.Add(accountant);
            AllEmployees.Add(accountant1);


            switch (response)
            {
                case "1":
                    GetAllEmployees();
                    break;
                case "2":
                    //code block
                    break;
                case "3":
                    //code block
                    break;
                case "4":
                    //code block
                    break;
                case "5":
                    //code block
                    break;

            }

            //-----------------Methods-------------------------------//

            void GetAllEmployees()
            {
                Console.WriteLine("Which Sales Employee Are You?");
                int i = 1;
                var employeeDictionary = new Dictionary<int, Employee>();

                foreach (var employee in AllEmployees)
                {
                    Console.WriteLine($"{i}. { employee.FirstName} { employee.LastName}");
                    employeeDictionary.Add(i, employee);
                    i++;

                }

                var response1 = Console.ReadLine();

                foreach (var employee in employeeDictionary)
                {
                    if (response1 == employee.Key.ToString())
                    {
                        Console.WriteLine($"Hi, { employee.Value.FirstName}!");
                        Console.WriteLine("Enter A Sale");

                    }
                }

              



            }

        }

    }
}



