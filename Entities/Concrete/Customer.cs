using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long TcNo { get; set; }
        public bool IsAdult { get; set; }
        public long PhoneNo { get; set; }
        public int? RoomNo { get; set; }
        public int? TourId { get; set; }
        public bool IsNew {get;set;}

    }
}
