using System;

namespace YemekMenusuÖdev
{
    class Fruit : Food
    {
        public Fruit(string name, string type, double price, double kdvOrani, double calorie)
        : base(name, type, price, kdvOrani, calorie)
        {
        }

        public override string printout()
        {
            return base.printout(); 
        }

    }
}
