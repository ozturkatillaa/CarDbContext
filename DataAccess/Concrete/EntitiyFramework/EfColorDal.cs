using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (CarContext context = new CarContext())
            {
                var addColor = context.Entry(entity);
                addColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (CarContext context = new CarContext())
            {
                var delColor = context.Entry(entity);
                delColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (CarContext context = new CarContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (CarContext context = new CarContext())
            {
                var upColor = context.Entry(entity);
                upColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
