using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1525591_CO5027.Models 
{
    public class PwTypeModel
    {
        public string InsertwatchProd(watchProdType watchproductType)
        {
            try
            {
                db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
                db.watchProdTypes.Add(watchproductType);
                db.SaveChanges();

                return watchproductType.watchName + "was just added to your cart";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdatewatchProd(int id, watchProdType watchproductType)
        {
            try
            {
                db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
                //take object from database
                watchProdType prod = db.watchProdTypes.Find(id);

                prod.watchName = watchproductType.watchName;

                db.SaveChanges();

                return watchproductType.watchName + "was just updated";
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
                watchProdType watchproductType = db.watchProdTypes.Find(id);

                db.watchProdTypes.Attach(watchproductType);
                db.watchProdTypes.Remove(watchproductType);
                db.SaveChanges();

                return watchproductType.watchName + "was just removed";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}