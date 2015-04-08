using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsAndArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // create an array
            string[] food = new string[10];
            string[] foo2 = { "taco", "pizza" };
            food[1] = "taco";
            food[2] = "pizza";
            food[3] = "watermelon";
            Console.WriteLine(food[3]);
            // keep the console open
            Console.ReadKey();

            //lists
            List<string> foodList = new List<string>() { "taco", "pizza", "watermelon"};
            foodList.Add("ice cream");
            foodList.Add("cheeseburger");

            // add at an index
            foodList.Insert(0, "apple");

            //replace value
            foodList[2] = "banana";

            // Get value from list
            string temp = foodList.ElementAt(3);
            string temp2 = foodList[3];

            // get a value by name
            for (int i = 0; i < foodList.Count; i++)
            {
                if (true)
                {
                }
                //removing elements
                foodList.Remove("apple");
                foodList.RemoveAt(3);
                foodList.Clear();

                // sorting 
                foodList.Sort(); //alphabetic
                foodList.Reverse(); //reverses 
            }
        }
    }
}