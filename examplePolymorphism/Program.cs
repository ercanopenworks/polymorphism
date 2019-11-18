using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examplePolymorphism
{
    class Program
    {

        public class Product
        {
            public string productName { get; set; }
            public double productPrice { get; set; }

            public virtual double computeVAT()
            {
                return productPrice * 1.08;
            }

            public Product()
            {

            }

            public Product(string _name, double _price)
            {
                productName = _name;
                productPrice = _price;
            }
        }


        public enum SizeOfDress
        {
            S = 1,
            M = 2,
            L = 3,
            XL = 4,
            XXL = 5
            

        }
        public class Dress : Product
        {
            public string type { get; set; }
            public SizeOfDress size { get; set; }

            public Dress(string _productName, double _productPrice, string _type, SizeOfDress _size)
            {
                productName = _productName;
                productPrice = _productPrice;
                type = _type;
                size = _size;

            }

            public override double computeVAT()
            {
                return productPrice * 1.03;
            }
        }

        public class Phone : Product
        {
            public string properties { get; set; }
            public string brand { get; set; }

            public Phone(string _productName, double _productPrice, string _properties, string _brand)
            {
                productName = _productName;
                productPrice = _productPrice;
                properties = _properties;
                brand = _brand;

            }

            public override double computeVAT()
            {
                return productPrice * 1.05;
            }
        }



        static void Main(string[] args)
        {
            Phone newPhone = new Phone("x11", 1000, "black", "apple");
            double priceWithTax = newPhone.computeVAT();

            Console.WriteLine(string.Format("Price with tax for {0} = ${1}", newPhone.productName, priceWithTax.ToString()));

            Dress newDress = new Dress("t-shirt", 10, "colorful", SizeOfDress.L);
            priceWithTax = newDress.computeVAT();

            Console.WriteLine(string.Format("Price with tax for {0} = ${1}", newDress.productName, priceWithTax.ToString()));

            Console.ReadKey();

        }
    }
}
