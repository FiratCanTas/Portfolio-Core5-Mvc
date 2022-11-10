using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal:GenericRepository<About>,IAboutDal //Olurda ileride Crud işlemleri dışında ayrı sadece bir entiy ye ait bir işlem gerçekleştirmek istersek diye kendi interface inden de kalıtım aldırıyoruz
    {

    }
}
