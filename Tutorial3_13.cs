using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class ProductDetails
    {
        public int prodId { get; set; }

        public String prodName { get; set; }

        public double price { get; set; }

        public int quantity { get; set; }

        public double CalculateBill()
        {
            return price * quantity;
        }

        public void Display()
        { 
            Console.WriteLine("Product ID: " + prodId);
            Console.WriteLine("Product Name: " + prodName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total Bill: " + CalculateBill());
        }
    }

    class Class1_Tutorial3_13
    {
        public static void Tutorial3_13Main(string[] args)
        {
            ProductDetails product = new ProductDetails();

            Console.WriteLine("Enter Product ID: ");
            product.prodId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name: ");
            product.prodName = Console.ReadLine();

            Console.WriteLine("Enter Price: ");
            product.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Quantity: ");
            product.quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------Product Details--------");
            product.Display();
        }
    }   
}
