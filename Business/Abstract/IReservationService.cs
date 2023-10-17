using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface IReservationService
    {
        void Add(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(Reservation reservation);
        List<Reservation> GetAll();
        List<Reservation> GetByName(string name);
        List<Reservation> GetByReservationNo(int reservationNo);
    }
}
