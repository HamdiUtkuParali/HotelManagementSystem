using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface IRoomService
    {
        void Add(Room room);
        void Update(Room room);
        void Delete(Room room);
        List<Room> GetAll();
        List<Room> GetByRoomNo(int roomNo);
        List<Room> GetByBed(byte bed);
    }
}
