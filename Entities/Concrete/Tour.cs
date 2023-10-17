using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tour:IEntity
    {
        public int Id { get; set; }
        public string TourName { get; set; }
        public byte Capacity { get; set; }
        public byte CurrentSize { get; set; }
        public decimal Price { get; set; }
    }
}
