using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//guidance from-https://www.youtube.com/watch?v=BKujvivVFKI&index=3&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9
namespace _1525591_CO5027.Models
{
    public class PwModel
    {
        public string InsertwatchProd(watchProduct watchproduct)
        {
            try
            {
                db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
                db.watchProducts.Add(watchproduct);
                db.SaveChanges();

                return watchproduct.watchName + "was just added to your cart";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdatewatchProd(int id, watchProduct watchproduct)
        {
            try
            {
                db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
                //take object from database
                watchProduct prod = db.watchProducts.Find(id);

                prod.watchName = watchproduct.watchName;
                prod.watchPrice = watchproduct.watchPrice;
                prod.watchProID = watchproduct.watchProID;
                prod.watchDescription = watchproduct.watchDescription;
                prod.watchImage = watchproduct.watchImage;

                db.SaveChanges();

                return watchproduct.watchName + "was just updated";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeletewatchProd(int id)
        {
            try
            {
                db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
                watchProduct watchproduct = db.watchProducts.Find(id);

                db.watchProducts.Attach(watchproduct);
                db.watchProducts.Remove(watchproduct);
                db.SaveChanges();

                return watchproduct.watchName + "was just removed";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public watchProduct GetwatchProduct(int id)
        {
            try
            {
                using (db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities())
                {
                    watchProduct watchproduct = db.watchProducts.Find(id);
                    return watchproduct;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<watchProduct> GetAllwatchProducts()
        {
            try
            {
                using (db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities())
                {
                    List<watchProduct> watchproducts = (from x in db.watchProducts
                                                        select x).ToList();
                    return watchproducts;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<watchProduct> GetwatchProductsByType(int watchprotypeid)
        {
            try
            {
                using (db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities())
                {
                    List<watchProduct> watchproducts = (from x in db.watchProducts
                                                        where x.watchProID == watchprotypeid
                                                        select x).ToList();
                    return watchproducts;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}