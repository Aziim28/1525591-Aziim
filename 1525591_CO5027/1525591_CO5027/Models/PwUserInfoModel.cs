using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1525591_CO5027.Models
{
    public class PwUserInfoModel
    {
        public UsercustInfo GetUsercustInfo(string wguId)
        {
            db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
            UsercustInfo info = (from x in db.UsercustInfoes
                                 where x.GUID == wguId
                                 select x).FirstOrDefault();
            return info;
        }

        public void InsertCustInformation(UsercustInfo info)
        {
            db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
            db.UsercustInfoes.Add(info);
            db.SaveChanges();
        }
    }
}