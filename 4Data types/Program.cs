using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of a string, an integer, a boolean, a char and a decimal.
            string name = "Kwandenhle";
            int age = 10;
            bool isTall = true;
            double weight = 88.2;
            char initial = 'K';

            //print to screen
            Console.WriteLine("Her name is " + name + " making her intitial " + initial + ",she is " + age + " and it is known and " + isTall +" that she is tall.");
            Console.WriteLine("Her weight in KG is " + weight);

            name = "Nono";
            age = 19;
            isTall = false;
            weight = 19.7;
            initial = 'N';

            Console.WriteLine("Her name is " + name + " making her intitial " + initial + ",she is " + age + " and it is known and " + isTall + " that she is tall.");
            Console.WriteLine("Her weight in KG is " + weight);

            //freeze console
            Console.ReadLine();
        }
    }
}
