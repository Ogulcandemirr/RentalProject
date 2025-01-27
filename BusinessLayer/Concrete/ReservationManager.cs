﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Tadd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetlistWithReservationByAccepted(int id)
        {
            return _reservationDal.GetlistWithReservationByAccepted(id);

        }

        public List<Reservation> GetlistWithReservationByPrevious(int id)
        {
            return _reservationDal.GetlistWithReservationByPrevious(id);

        }

        public List<Reservation> GetlistWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetlistWithReservationByWaitApproval(id);
        }
    }
}