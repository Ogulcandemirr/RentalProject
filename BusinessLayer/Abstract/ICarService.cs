using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        public Car TGetCarWithGuide(int id);
        public List<Car> TGetLastCarOffer();

        void TChangeToTrueByCar(int id);
        void TChangeToFalseByCar(int id);

    }
}
