using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        Context context = new Context();
        public Car GetCarWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Cars.Where(x=>x.CarId==id ).Include(x => x.Guide).FirstOrDefault();
            }
        }

		public List<Car> GetLastCarOffer()
		{
            using (var context = new Context())
            {
                var values=context.Cars.Take(4).OrderByDescending(x => x.CarId).ToList();
                return values;
            } 
		}

        public void ChangeToFalseByCar(int id)
        {
            var values = context.Cars.Find(id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();

        }

        public void ChangeToTrueByCar(int id)
        {
            var values = context.Cars.Find(id);
            values.Status = true;
            context.Update(values);
            context.SaveChanges();

        }
    }
}
