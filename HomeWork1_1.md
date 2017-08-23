# HomeWork1_1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("National:");
            string National = Console.ReadLine();
            Console.Write("Species:");
            string Species = Console.ReadLine();
            Console.Write("Height:");
            string Height = Console.ReadLine();
            Console.Write("Weight:");
            string Weight = Console.ReadLine();
            Console.Write("Japanese:");
            string Japanese = Console.ReadLine();
            Console.WriteLine("National:" + National + "\n" + "Species:" + Species + "\n" + "Height:" + Height + "\n" + "Weight:" + Weight + "\n" + "Japanese:" + Japanese);
        }
    }
}