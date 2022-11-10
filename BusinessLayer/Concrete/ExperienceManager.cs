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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Tadd(Experience t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Experience t)
        {
            throw new NotImplementedException();
        }

        public Experience TgetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TgetList()
        {
           return _experienceDal.GetList();
        }

        public void Tupdate(Experience t)
        {
            throw new NotImplementedException();
        }
    }
}
