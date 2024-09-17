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
    public class TestİmonialManager : ITestİmonialService
    {
        ITestİmonialDal _testİmonialDal;

        public TestİmonialManager(ITestİmonialDal testİmonialDal)
        {
            _testİmonialDal = testİmonialDal;
        }

        public void Tadd(Testİmonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testİmonial t)
        {
            throw new NotImplementedException();
        }

        public Testİmonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testİmonial> TGetList()
        {
            return _testİmonialDal.GetList();
        }

        public void TUpdate(Testİmonial t)
        {
            throw new NotImplementedException();
        }
    }
}
