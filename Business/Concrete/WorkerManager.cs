using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WorkerManager : IWorkerService
    {
        private IWorkerDal _workerDal;

        public WorkerManager(IWorkerDal workerDal)
        {
            _workerDal = workerDal;
        }

        public void Add(Worker worker)
        {
            _workerDal.Add(worker);
        }

        public void Update(Worker worker)
        {
            _workerDal.Update(worker);
        }

        public void Delete(Worker worker)
        {
            _workerDal.Delete(worker);
        }

        public List<Worker> GetAll()
        {
            return _workerDal.GetAll();
        }

        public List<Worker> GetByName(string name)
        {
            return _workerDal.GetAll(p => p.Name.ToLower().Contains(name.ToLower()));
        }

        public List<Worker> GetByPosition(bool position)
        {
            return _workerDal.GetAll(p=>p.Position==position);
        }

        public Worker GetByUserName(string userName)
        {
            return _workerDal.Get(p=>p.UserName==userName);
        }
    }
}
