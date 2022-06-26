using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
//using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            foreach(var ss in carManager.GetCarsByBrandId(1))
            {
                //Console.WriteLine(ss.ColorId); //brand idsi1 olanların color id si
                Console.WriteLine(ss.BrandId);
            }
            foreach (var ss in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine("Renk Kodu "+ ss.ColorId); //brand idsi1 olanların color id si
            }

        }
    }
}
