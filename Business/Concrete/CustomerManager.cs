using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer) 
        {
            _customerDal.Add(customer);
        }

        public void Update(Customer customer) 
        {
            _customerDal.Update(customer);
        }

        public void Delete(Customer customer) 
        { 
            try { _customerDal.Delete(customer); }
            catch { throw new Exception("Hata!"); }
        }

        public List<Customer> GetAll() 
        { 
            return _customerDal.GetAll();
        }

        public List<Customer> GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetByIsNew(byte IsNew)
        {
            throw new NotImplementedException();
        }
    }
}
