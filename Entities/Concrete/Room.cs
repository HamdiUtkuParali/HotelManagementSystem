using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Room:IEntity
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public byte Bed { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
    }
}
