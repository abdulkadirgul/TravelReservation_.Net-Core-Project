using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDAL _destinationDAL;

        public DestinationManager(IDestinationDAL destinationDAL)
        {
            _destinationDAL = destinationDAL;
        }

        public void TAdd(Destination t)
        {
            _destinationDAL.Insert(t);
        }

        public Destination TGetByID(int id)
        {
            return _destinationDAL.GetByID(id);
        }

        public void TDelete(Destination t)
        {
            _destinationDAL.Delete(t);
        }

        public Destination TGetById(int id)
        {
            return _destinationDAL.GetByID(id);
        }

        public List<Destination> TGetList()
        {
           return _destinationDAL.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destinationDAL.Update(t);
            
        }
    }
}
