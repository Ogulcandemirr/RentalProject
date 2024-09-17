using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetlistWithReservationByWaitApproval(int id);
        List<Reservation> GetlistWithReservationByAccepted(int id);
        List<Reservation> GetlistWithReservationByPrevious(int id);

    }
}
