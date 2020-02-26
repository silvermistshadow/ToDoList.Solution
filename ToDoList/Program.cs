using System;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        public static void Main()
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
                    new Item($"{i.ToString()}. {Console.ReadLine()}");
                    i++;
                }
                else if (input.ToLower() == "view")
                {
                    List<string> descList = new List<string>();
                    foreach (Item Item in Item.GetAll())
                    {
                        descList.Add(Item.Description);
                    }
                    string viewList = string.Join(", ", descList);
                    Console.WriteLine($"{viewList}");
                }


            }
            Environment.Exit(0);
        }
    }
}