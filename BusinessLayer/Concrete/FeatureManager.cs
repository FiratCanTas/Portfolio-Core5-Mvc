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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Tadd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void Tdelete(Feature t)
        {
            _featureDal.Delete(t);  
        }

        public Feature TgetByID(int id)
        {
           return _featureDal.GetByID(id);
        }

        public List<Feature> TgetList()
        {
            return _featureDal.GetList();
        }

        public void Tupdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
