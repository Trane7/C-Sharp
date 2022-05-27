using System; // 
using System.Collections.Generic;

namespace CatWorx.BadgeMaker // This is usually the companys name to help show uniquiness
{
    class Program
    {
        static void Main(string[] args) // Main() is the entry point of the app
        {
            string[] favFoods = new string[3]{ "pizza", "doughnuts", "icream" };
            string firstFood =  favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("I like {0}, {1}, {2}", firstFood, secondFood, thirdFood);

        }
    }
}
