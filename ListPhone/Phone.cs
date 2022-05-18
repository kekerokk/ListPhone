using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPhone
{
    internal class Phone : IComparer<Phone>
    {
        public string Name;
        public int Price;

        public Phone()
        {
        }

        public Phone(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}    Цена: {Price}";
        }

        public int Compare(Phone x, Phone y)
        {
            if (x.Price < y.Price)
                return 1;
            else if (x.Price > y.Price)
                return -1;
            else 
                return 0;
            //throw new NotImplementedException();
        }
    }
}
