using System.Collections.Generic;
using System; // 


namespace CatWorx.BadgeMaker // This is usually the companys name to help show uniquiness
{
    class Program
    {
        static void Main(string[] args) // Main() is the entry point of the app
        {
            List<string> employees = new List<string>() { "adam", "amy"};

            employees.Add("barbara");
            employees.Add("billy");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
