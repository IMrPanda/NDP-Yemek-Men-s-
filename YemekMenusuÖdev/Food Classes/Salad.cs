using System;


namespace YemekMenusuÖdev
{
    class Salad : Food
    {
        public Salad(string name, string type, double price, double kdvOrani, double calorie)
        : base(name, type, price, kdvOrani, calorie)
        {
        }

        public override string printout()
        {
            return base.printout(); // Artık calorie bilgisi base sınıfta
        }
    }
}
