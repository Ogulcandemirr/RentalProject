using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICarDal:IGenericDal<Car>
    {
        public Car GetCarWithGuide(int id);
        public List<Car> GetLastCarOffer();
        void ChangeToTrueByCar(int id);
        void ChangeToFalseByCar(int id);
    }
}
