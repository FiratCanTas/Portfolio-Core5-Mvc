using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent //Burada tanımlanan metotlar hep Invoke olarak tanımlanır
    {
        //Invoke a bağlı calısacak view lerı Shared içindeki Components klasöründe arıyoruz
        //Components içine --> ekleyeceğimiz klasör ismi view componentle aynı olmalı (FeatureList klasoru)
        //FeatureList içerisine bir partialview ekliyoruz ve ismi "default" olmalı
        //Partial view a göre View Componentlere Url üzerinden direkt erişim yoktur avantaj olarak kullabiliriz.


        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var values = featureManager.TgetList();
            return View(values);
        }
    }
}
