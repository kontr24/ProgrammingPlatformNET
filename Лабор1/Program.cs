using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Лаб1
{
    /*public static class StringHelper
    {
        public static string Shorten(this string Company, int value)
        {
            return
                value > 3 && Company.Length > value ?
                Company.Substring(0, value - 3) + "..." : Company;
        }
    }*/
    class Program
    {

        /*public Program() { x = "Электроинструменты"; y = 18; a = 177; xxx = " "; yyy = 34; aaa = 56; }

        public override string ToString()
        {
            return  x + "\t" + y + "\t" + a + "\t" + xxx + "\t" + yyy + "\t" + "\t" + aaa;
        }*/

        static void Main(string[] args)
        {

            List<Drill> products = new List<Drill>();
            /*products.Add(new Drill("Makita", View.безударный, " ", 100, 4, 1999)); //фирма, вид, класс прибора, уровень шума(Дб), вес, цена
            products.Add(new Drill("Metabo", View.ударный, " ", 95, 4, 2999));
            products.Add(new Drill("Bosch", View.безударный, " ", 100, 4, 3599));
            products.Add(new Drill("HILTI", View.ударный, " ", 95, 3, 3699));
            products.Add(new Drill("DeWalt", View.безударный, " ", 100, 4, 3299));
            products.Add(new Drill("HITACHI", View.безударный, " ", 95, 4, 3199));
            products.Add(new Drill("DWT", View.ударный, " ", 95, 3, 1899));
            products.Add(new Drill("AEG", View.безударный, " ", 90, 3, 3299));
            products.Add(new Drill("Kolner", View.ударный, " ", 100, 3, 2599));
            products.Add(new Drill("Hammer", View.безударный, " ", 95, 4, 2499));
            products.Add(new Drill("Oasis", View.ударный, " ", 95, 3, 2599));
            products.Add(new Drill("Einhell", View.безударный, " ", 90, 4, 3199));
            products.Add(new Drill("Зубр", View.ударный, " ", 95, 4, 2399));
            products.Add(new Drill("Bort", View.безударный, " ", 100, 3, 2899));
            products.Add(new Drill("Dorkel", View.ударный, " ", 100, 4, 2299));*/
            products.Add(new Drill("Makita", View.безударный, true || false, 100, 4, 1999)); //фирма, вид, класс прибора, уровень шума(Дб), вес, цена
            products.Add(new Drill("Metabo", View.ударный, true || false, 95, 4, 2999));
            products.Add(new Drill("Bosch", View.безударный, true || false, 100, 4, 3599));
            products.Add(new Drill("HILTI", View.ударный, true || false, 95, 3, 3699));
            products.Add(new Drill("DeWalt", View.безударный, true || false, 100, 4, 3299));
            products.Add(new Drill("HITACHI", View.безударный, true || false, 95, 4, 3199));
            products.Add(new Drill("DWT", View.ударный, true || false, 95, 3, 1899));
            products.Add(new Drill("AEG", View.безударный, true || false, 90, 3, 3299));
            products.Add(new Drill("Kolner", View.ударный, true || false, 100, 3, 2599));
            products.Add(new Drill("Hammer", View.безударный, true || false, 95, 4, 2499));
            products.Add(new Drill("Oasis", View.ударный, true || false, 95, 3, 2599));
            products.Add(new Drill("Einhell", View.безударный, true || false, 90, 4, 3199));
            products.Add(new Drill("Зубр", View.ударный, true || false, 95, 4, 2399));
            products.Add(new Drill("Bort", View.безударный, true || false, 100, 3, 2899));
            products.Add(new Drill("Dorkel", View.ударный, true || false, 100, 4, 2299));
            /* 2) products.Add(new Drill("Metabo", View.ударный, "тяжёлый", 95, 4, 2999));
            products.Add(new Drill("Bosch", View.безударный, "легкий", 100, 4, 3599));
            products.Add(new Drill("HILTI", View.ударный, "тяжёлый", 95, 3, 3699));
            products.Add(new Drill("DeWalt", View.безударный, "легкий", 100, 4, 3299));
            products.Add(new Drill("HITACHI", View.безударный, "тяжёлый", 95, 4, 3199));
            products.Add(new Drill("DWT", View.ударный, "легкий", 95, 3, 1899));
            products.Add(new Drill("AEG", View.безударный, "тяжёлый", 90, 3, 3299));
            products.Add(new Drill("Kolner", View.ударный, "легкий", 100, 3, 2599));
            products.Add(new Drill("Hammer", View.безударный, "тяжёлый", 95, 4, 2499));
            products.Add(new Drill("Oasis", View.ударный, "легкий", 95, 3, 2599));
            products.Add(new Drill("Einhell", View.безударный, "тяжёлый", 90, 4, 3199));
            products.Add(new Drill("Зубр", View.ударный, "легкий", 95, 4, 2399));
            products.Add(new Drill("Bort", View.безударный, "тяжёлый", 100, 3, 2899));
            products.Add(new Drill("Dorkel", View.ударный, "легкий", 100, 4, 2299));*/
            /*products.FindAll(s => s.Weight == 3).ForEach(x =>
                x.DeviceClass() = "лёгкий");*/
            /*3) products.Add(new Program() { x ="Дрель"  }) ;
            products.Add(new Program() { x = "Лобзик" });
            products.Add(new Program() { x = "Болгарка" });
            products.Add(new Program() { x = "Строительный фен" });
            products.Add(new Program() { x = "Шлифовальна машинка" });
            products.Add(new Program() { x = "Электрический рубанок" });
            products.Add(new Program() { x = "Строительная пила" });
            products.Add(new Program() { x = "Электрорубанок" });
            products.Add(new Program() { x = "Гравер" });
            products.Add(new Program() { x = "Осцилляторная пила" });
            products.Add(new Program() { x = "Штроборез" });
            products.Add(new Program() { x = "Фрезер" });
            products.Add(new Program() { x = "Реноватор" });
            products.Add(new Program() { x = "Перфоратор" });
            products.Add(new Program() { x = "Шуруповёрт" });*/

            foreach (Drill p in products)
            {

                Console.WriteLine(p);


            }

        }
    }
}



