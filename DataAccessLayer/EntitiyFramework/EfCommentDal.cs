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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> TGetListCommentWithCar()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Car).ToList();
            }
        }

        public List<Comment> TGetListCommentWithCarAndUser(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Where(x => x.CarId==id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
