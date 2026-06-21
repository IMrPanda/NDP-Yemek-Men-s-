using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekMenusuÖdev
{
    class Dessert : Food
    {
        public Dessert(string name, string type, double price, double kdvOrani, double calorie)
        : base(name, type, price, kdvOrani, calorie)
        {
        }

        public override string printout()
        {
            return base.printout(); // Artık calorie bilgisi base sınıfta
        }
    }
}
