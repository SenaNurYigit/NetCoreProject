using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID 
    //Single responsibility
    //Open-closed 
    //Liskov substitution
    //Interface segregation
    //Dependency Inversion 

    //Open closed prensibine göre mevcuttaki kodlara dokunmadan yeni bir özellik ekleyebiliyor olmamız lazım.
    class Program
    {
        static void Main(string[] args) 
        {
            ProductManager productManager = new ProductManager(new EFProductDal ());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}