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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceService;

        public ServiceManager(IServiceDal serviceService)
        {
            _serviceService = serviceService;
        }

        public void Tadd(Service t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Service t)
        {
            throw new NotImplementedException();
        }

        public Service TgetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> TgetList()
        {
            return _serviceService.GetList();
        }

        public void Tupdate(Service t)
        {
            throw new NotImplementedException();
        }
    }
}
