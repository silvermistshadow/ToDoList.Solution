using System;
using ToDoList.Models;

namespace ToDoList
{
    class Program
    {
        public static void main()
        {
            int i = 1;
            Console.WriteLine("Welcome to the To Do List.");

            while (true)
            {
                Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View/Quit) (nothing is saved upon quitting)");
                string input = Console.ReadLine();
                if(input.ToLower() == "quit")
                {
                    break;
                }
                
                if(input.ToLower() == "add")
                {
                    Console.WriteLine("Please enter the description for the new item.");
                    string desc = Console.ReadLine();
                    new Item($"{i.ToString()}. ${desc}");
                }


                i++;
            }
            Environment.Exit(0);
        }
    }
}