using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace Лабор2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Drill> products = new List<Drill>();
            products.Add(new Drill("Makita", MechanismType.безударный, true, 100, 4, 1999)); //фирма, вид, класс прибора, уровень шума(Дб), вес, цена
            products.Add(new Drill("Metabo", MechanismType.ударный, true, 95, 4, 2999));
            products.Add(new Drill("Bosch", MechanismType.безударный, true, 100, 4, 3599));
            products.Add(new Drill("HILTI", MechanismType.ударный, true, 95, 3, 3699));
            products.Add(new Drill("DeWalt", MechanismType.безударный, true, 100, 4, 3299));
            products.Add(new Drill("HITACHI", MechanismType.безударный, true, 95, 4, 3199));
            products.Add(new Drill("DWT", MechanismType.ударный, true, 95, 3, 1899));
            products.Add(new Drill("AEG", MechanismType.безударный, true, 90, 3, 3299));
            products.Add(new Drill("Kolner", MechanismType.ударный, true, 100, 3, 2599));
            products.Add(new Drill("Hammer", MechanismType.безударный, true, 95, 4, 2499));
            products.Add(new Drill("Oasis", MechanismType.ударный, true, 95, 3, 2599));
            products.Add(new Drill("Einhell", MechanismType.безударный, true, 90, 4, 3199));
            products.Add(new Drill("Зубр", MechanismType.ударный, true, 95, 4, 2399));
            products.Add(new Drill("Bort", MechanismType.безударный, true, 100, 3, 2899));
            products.Add(new Drill("Dorkel", MechanismType.ударный, true, 100, 4, 2299));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t                 Список товаров:\n");
            Console.ResetColor();
            foreach (Drill p in products)
            {
                Console.WriteLine(p);
            }

            Shop obj = new Shop();
            obj.Products = products;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\n1. Сортировка списка товаров по названию фирмы(A-Z, А-Я):\n ↓");
            Console.ResetColor();
            obj.CompanySort();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\n2. Сортировка списка товаров по виду (пузырьковая сортировка):\n              ↓");
            Console.ResetColor();
            obj.MechanismTypeSort();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\n3. Сортировка списка товаров по классу прибора (сортировка Шелла):\n                                 ↓");
            Console.ResetColor();
            obj.DeviceClassSort();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\n4. Сортировка списка товаров по уровню шума (X):\n                                           ↓");
            Console.ResetColor();
            obj.NoiseLevelSort();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\n5. Сортировка списка товаров по весу (глупая сортировка):\n                                                 ↓");
            Console.ResetColor();
            obj.WeightSorterSort();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\n6. Сортировка списка товаров по цене (сортировка выбором):\n                                                         ↓");
            Console.ResetColor();
            obj.PriceSort();
            Console.ReadKey();
        }
    }
}



