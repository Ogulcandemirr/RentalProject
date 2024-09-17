using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RentConditionManager : IRentConditionService
    {
        IRentConditionDal _rentConditionDal;

        public RentConditionManager(IRentConditionDal rentConditionDal)
        {
            _rentConditionDal = rentConditionDal;
        }

        public void Tadd(RentCondition t)
        {
           _rentConditionDal.Insert(t);
        }

        public void TDelete(RentCondition t)
        {
            _rentConditionDal.Delete(t);
        }

        public RentCondition TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RentCondition> TGetList()
        {
            return _rentConditionDal.GetList();
        }

        public void TUpdate(RentCondition t)
        {
           _rentConditionDal.Update(t);
        }
    }
}
