using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface IWorkerService
    {
        void Add(Worker worker);
        void Update(Worker worker);
        void Delete(Worker worker);
        List<Worker> GetAll();
        List<Worker> GetByName(string name);
        List<Worker> GetByPosition(byte position);
    }
}
