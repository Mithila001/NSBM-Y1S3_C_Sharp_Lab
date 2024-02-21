using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2024_02_14__Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(101, "Laptop", 800, 10);
            Console.WriteLine("Product ID: " + product1.productID);
            Console.WriteLine("Product Name: " + product1.productName);
            Console.WriteLine("Product Price: " + product1.price);
            Console.WriteLine("Product Qunatity: " + product1.quantityInStock);
        }

        
    }

    public class Product
    {
        public int productID { get; }
        public string productName;
        public double price;
        public int quantityInStock;

        public Product(int productID, string productName, double price, int quantityInStock)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public void addProduct()
        {

        }
        public void BuyProduct()
        {

        }
    }
}
