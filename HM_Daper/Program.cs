using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Daper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdService prodService = new ProdService();

            Console.WriteLine("----------------- Before Add Product -----------------");
            foreach (var item in prodService.GetAllProducts())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------- After Add Product -----------------");
            //prodService.AddProduct(new Product { Name = "Keyboard", Price = 50 });
            foreach (var item in prodService.GetAllProducts())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------- After Update Product -----------------");
            prodService.UpdateProduct(new Product { ProductId = 5, Name = "UPDATEKeyboard", Price = 500 });
            foreach (var item in prodService.GetAllProducts())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------- After Remove Product -----------------");
            prodService.DeleteProduct(5);
            foreach (var item in prodService.GetAllProducts())
            {
                Console.WriteLine(item);
            }
        }
    }
}
