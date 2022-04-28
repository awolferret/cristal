using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько у вас золота?");
            int gold = Convert.ToInt32(Console.ReadLine());
            int cristalPrice = 14;
            int possibleToBuy = gold / cristalPrice;
            Console.WriteLine($"Вы можете купить {possibleToBuy} кристаллов");
            Console.WriteLine("Сколько вы хотите купить?");
            int buy = Convert.ToInt32(Console.ReadLine());
            int goldRemains = gold - (cristalPrice * buy);
            Console.WriteLine($"Вы купили {buy} кристаллов и у вас осталось {goldRemains}");
        }
    }
}
