
using System;

namespace YemekMenusuÖdev
{
    class Food
    {
        
        private string _name;
        private string _type;
        private double _price;
        private double _kdvOrani;
        private double _calorie;

        
        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new ArgumentException("Name cannot be empty!");
        }

        public string Type
        {
            get => _type;
            set => _type = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new ArgumentException("Type cannot be empty!");
        }

        public double Price
        {
            get => _price;
            set => _price = value >= 0
                ? value
                : throw new ArgumentException("Price cannot be negative!");
        }

        public double KdvOrani
        {
            get => _kdvOrani;
            set => _kdvOrani = (value >= 0 && value <= 1)
                ? value
                : throw new ArgumentException("KDV must be between 0 and 1!");
        }

        public double Calorie
        {
            get => _calorie;
            set => _calorie = value >= 0
                ? value
                : throw new ArgumentException("Calorie cannot be negative!");
        }

        // Kurucu metotlar
        public Food()
        {
            _name = "";
            _type = "";
            _price = 0;
            _kdvOrani = 0;
            _calorie = 0;
        }

        public Food(string name, string type, double price, double kdvOrani, double calorie)
        {
           
            Name = name;
            Type = type;
            Price = price;
            KdvOrani = kdvOrani;
            Calorie = calorie;
        }

        public virtual string printout()
        {
            return string.Format("{0,-15} {1,-10} {2,10} ₺ {3,5} {4,5} kcal {5,-10}",
                       Name,
                       Type,
                       Price.ToString("N2"),
                       (KdvOrani * 100).ToString("0") + "%",
                       Calorie.ToString("0"),
                       this.GetType().Name);
        }
    }
}