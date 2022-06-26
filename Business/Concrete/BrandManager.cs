using Business.Abstract;
using DataAccess.Abstract;
//using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal iBrandDal)
        {
            _brandDal = iBrandDal;
        }
        public void AddBrand(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine("Marka Eklendi.");
        }

        public List<Brand> GetAllBrand()
        {

            return _brandDal.GetAll();

        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandDal.GetAll(p=>p.Id==id);
        }
    }
}
