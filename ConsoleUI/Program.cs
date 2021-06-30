using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            //InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            //foreach (var productCategory in inMemoryProductDal.GetAllByCategory(1)) 
            //{
            //    Console.WriteLine("Cat = " + productCategory.CategoryId);
            //}
        }
    }
}
