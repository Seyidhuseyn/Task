using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        private string Name;
        private int Price;

        public Product(string name, int price)
        {
            string Name = name;
            double Price = price;
        }
        private string Name
        {
            get { return name; }
            set 
            {
                if (name.Length>=6 && name.Length<=25)
                {
                name = value; 
                }
                else
                {
                    Console.WriteLine("Adi duzgun daxil edin");
                }
            }
        }


        public static bool CheckPassword(string name, int price)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if ()
                {

                }
            }
        }
    }
}
