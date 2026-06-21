using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekMenusuÖdev
{
    class Menu
    {
        public List<Food> liste = new List<Food>();

        public void Add(Food y)
        {
            liste.Add(y);
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < liste.Count)
                liste.RemoveAt(index);
        }

        public void RemoveIndex(int index)
        {
            if(index >= 0 && index < liste.Count) liste.RemoveAt(index);
        }

        public double CalculateTotal()
        {
            return liste.Sum(food => food.Price * (1 + food.KdvOrani));
        }


        public List<Food> menuPrintout()
        {
            return liste;
        }
    }
}
