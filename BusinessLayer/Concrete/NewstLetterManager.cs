using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewstLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewstLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void Tadd(NewsLetter t)
        {
            _newsLetterDal.Insert(t);
        }

        public void TDelete(NewsLetter t)
        {
           _newsLetterDal.Delete(t);
        }

        public NewsLetter TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> TGetList()
        {
            return _newsLetterDal.GetList();
        }

        public void TUpdate(NewsLetter t)
        {
            _newsLetterDal.Update(t);
        }
    }
}
