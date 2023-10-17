using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface ITourService
    {
        void Add(Tour tour);
        void Update(Tour tour);
        void Delete(Tour tour);
        List<Tour> GetAll();
        List<Tour> GetByName(string name);
        List<Tour> GetByIsFull(int capacity,int currentSize);
    }
}
