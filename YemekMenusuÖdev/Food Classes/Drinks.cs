using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekMenusuÖdev
{
    class Drinks : Food
    {
        public Drinks(string name, string type, double price, double kdvOrani, double calorie)
        : base(name, type, price, kdvOrani, calorie)
        {
        }

        public override string printout()
        {
            return base.printout(); // Artık calorie bilgisi base sınıfta
        }
    }
}
