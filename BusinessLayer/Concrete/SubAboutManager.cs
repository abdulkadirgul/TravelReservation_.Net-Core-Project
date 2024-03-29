﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDAL _subAboutDAL;
        public SubAboutManager(ISubAboutDAL subAboutDAL)
        {
          _subAboutDAL = subAboutDAL;
        }
        public void TAdd(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDAL.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
