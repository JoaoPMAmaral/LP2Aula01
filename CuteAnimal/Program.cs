using System;

namespace CuteAnimal
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Cat cat = new Cat("Joe");

            Console.WriteLine(cat.GetName());
            Console.WriteLine(cat.GetEnergy());
            Console.WriteLine(cat.GetMood());
            Console.WriteLine(cat.GetFeedStat());
        }
    }
}
