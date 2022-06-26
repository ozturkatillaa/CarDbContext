using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAllBrand();
        void AddBrand(Brand brand);
        List<Brand> GetCarsByBrandId(int id);
    }
}
