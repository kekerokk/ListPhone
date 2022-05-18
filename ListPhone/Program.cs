using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPhone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Phone> Phones = new List<Phone>();
            Phone cp = new Phone();

            Phones.Add(new Phone("Iphone 7", 12000));
            Phones.Add(new Phone("Iphone 7 plus", 14000));
            Phones.Add(new Phone("Iphone 8", 16000));
            Phones.Add(new Phone("Iphone 8 plus", 17000));
            Phones.Add(new Phone("Xiaomi", 9000));
            Phones.Add(new Phone("Iphone 9", 10000000));
            foreach (Phone a in Phones)
                Console.WriteLine(a);

            Phones.Sort(cp.Compare);
            Console.WriteLine("\nОтсротированно:");
            foreach (Phone a in Phones)
                Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
