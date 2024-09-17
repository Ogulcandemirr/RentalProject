using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carsDal)
        {
            _carDal = carsDal;
        }

        public void Tadd(Car t)
        {
          _carDal.Insert(t);
        }

        public void TDelete(Car t)
        {
           _carDal.Delete(t);
            
        }

        public Car TGetById(int id)
        {
            return _carDal.GetById(id);
        }

        public Car TGetCarWithGuide(int id)
        {
            return _carDal.GetCarWithGuide(id);

        }

		public List<Car> TGetLastCarOffer()
		{
			return _carDal.GetLastCarOffer();
		}

		public List<Car> TGetList()
        {
            return _carDal.GetList();
        }

        public void TUpdate(Car t)
        {
            _carDal.Update(t);
        }

        public void TChangeToTrueByCar(int id)
        {
            _carDal.ChangeToTrueByCar(id);
        }

        public void TChangeToFalseByCar(int id)
        {
            _carDal.ChangeToFalseByCar(id);
        }
    }
}

