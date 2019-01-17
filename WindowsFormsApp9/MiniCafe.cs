using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    class Oil
    {
        public string KindOfOil { get; private set; }
        public double PriceOfOil { get; private set; }

        public Oil(string kindOfOil, double priceOfOil)
        {
            KindOfOil = kindOfOil;
            PriceOfOil = priceOfOil;
        }
    } 

    static class MiniCafe
    {
        public static double Hamburger { get; set; }
        public static double Hot_dog { get; set; }
        public static double Coco_cola { get; set; }
        public static double Cappuchino { get; set; }
        public static double Americano { get; set; }
    }

    class Check
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public double Quantity { get; private set; }

        public Check(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
