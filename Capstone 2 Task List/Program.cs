using System;
using System.Collections.Generic;

namespace Capstone_2_Task_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Do> grandCircusTasks = new List<Do>
            {
                new Do("aaron", "alpha", "03/01/2020", "update alpha program" ),
                new Do("brian", "bravo", "03/02/2020", "update beta program"),
                new Do("Cherie", "charlie", "03/03/2020", "update charlie program"),
            };

            Console.WriteLine("Welcome to the Task Manager!");
            Console.WriteLine(" 1. List tasks \n 2. Add task \n 3. Delete Task \n 4. Mark Task Complete \n 5. Quit");
            
            string menuSelection = "";
            bool tryAgain = true;

            while (tryAgain)
            {
                string userInput = Console.ReadLine().ToLower();
                tryAgain = false;
                switch (userInput)
                {
                    case "1":
                    case "list task":
                        menuSelection = "list task";
                        break;

                    case "2":
                    case "add task":
                        menuSelection = "add task";
                        break;

                    case "3":
                    case "delete task":
                        menuSelection = "delete task";
                        break;

                    case "4":
                    case "mark task complete":
                        menuSelection = "mark task complete";
                        break;
                    case "5":
                    case "quit":
                        break;
                    default:
                        tryAgain = true;
                        Console.WriteLine("Invalid. Please enter a valid entry number from the menu.");
                        break;

                }
            }
            if (menuSelection == "1" || menuSelection == "list task")
            {
                Do.PrintTaskList(name);
            }
            
        }
        
    }
}
