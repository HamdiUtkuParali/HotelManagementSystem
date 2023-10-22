using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Worker:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long TcNo { get; set; }
        public long PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Position { get; set; }
    }
}
