using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class encapsulation
    {
        private string productname;
        private int price;
        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value > price)
                    price = value;
            }
        }
        public void display()
        {
            Console.WriteLine("Productname:{0}\tPrice:{1}",Productname,Price);
        }
    }
}
