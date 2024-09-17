using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetlistWithReservationByWaitApproval(int id);
        List<Reservation> GetlistWithReservationByAccepted(int id);
        List<Reservation> GetlistWithReservationByPrevious(int id);
    }
}
