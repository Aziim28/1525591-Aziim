using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1525591_CO5027.App_Code
{
    public class watchProdModel
    {
        public string InsertwatchProd(watchProduct watchproduct)
        {
            try
            {
                db_1525591_co5027_aziimEntities1 db = new db_1525591_co5027_aziimEntities1();
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
                db_1525591_co5027_aziimEntities1 db = new db_1525591_co5027_aziimEntities1();
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
                db_1525591_co5027_aziimEntities1 db = new db_1525591_co5027_aziimEntities1();
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
    }
}