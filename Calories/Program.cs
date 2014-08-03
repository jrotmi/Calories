using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("How many Calories did you eat today?");
            string userCalories = Console.ReadLine();

            string message = "";

            int inCalories;
            bool isValid = int.TryParse(userCalories, out inCalories);
            if (isValid)
            {
                if (inCalories <= 1500)
                    message = "You didn't eat too many calories today!";
                else if ((inCalories > 1500) && (inCalories <= 2000))
                    message = "You ate a moderate amount of calories today!";
                else if (inCalories > 2000)
                    message = "You ate A LOT!";
            }
            else
            {
                message = "Please insert a string of numbers";
            }
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}