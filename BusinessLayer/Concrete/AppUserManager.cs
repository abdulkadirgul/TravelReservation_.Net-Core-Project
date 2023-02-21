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
    public class AppUserManager : IAppUserService
    {
        IAppUserDAL _appUserDAL;

        public AppUserManager(IAppUserDAL appUserDAL)
        {
            _appUserDAL = appUserDAL;
        }

        public void TAdd(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            return _appUserDAL.GetList();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }
    }
}
