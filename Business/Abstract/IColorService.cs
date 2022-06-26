using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IColorService
    {
        List<Color> GetAllColor();
        List<Color> GetCarsByColorId(int id);
    }
}
