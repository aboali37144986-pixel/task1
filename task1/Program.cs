using System.Runtime.CompilerServices;
using System.Xml;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                    Console.WriteLine("please enter numbers of small carpets");

            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_________________________________");

            Console.WriteLine("please enter numbers of large carpets");

            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_________________________________");

                      Console.WriteLine($"number of small carpets -> {smallCarpets}");

                      Console.WriteLine($"number of large carpets -> {largeCarpets}");
            Console.WriteLine("_________________________________");

                  Console.WriteLine("cost of small carpets =25$");
            Console.WriteLine("cost of large carpets =40$");
            Console.WriteLine("tax rate = 6%");
            Console.WriteLine("_________________________________");
            //Console.WriteLine($"cost ={smallCarpets * 25 + largeCarpets * 40} ");
            double cost = smallCarpets * 25 + largeCarpets * 40;
            double tax = cost * 0.06;
            Console.WriteLine($"cost = {cost}");
            Console.WriteLine($"tax = {tax}");
            Console.WriteLine("====================================");
            Console.WriteLine($"total estimated: {cost+tax}");


        }






    }
}
