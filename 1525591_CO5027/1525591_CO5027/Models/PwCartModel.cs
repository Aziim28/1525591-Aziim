using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1525591_CO5027.Models 
{
    public class PwCartModel
    {
      
            public string InsertwatchProd(watchCart watchcart)
            {
                try
                {
                    db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
                    db.watchCarts.Add(watchcart);
                    db.SaveChanges();

                    return watchcart.watchDateBuy + "was just added to your cart";
                }
                catch (Exception e)
                {
                    return "Error:" + e;
                }
            }

            public string UpdatewatchProd(int id, watchCart watchcart)
            {
                try
                {
                    db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
                    //take object from database
                    watchCart prod = db.watchCarts.Find(id);

                    prod.watchDateBuy = watchcart.watchDateBuy;
                    prod.watchCustID = watchcart.watchCustID;
                    prod.watchAmount = watchcart.watchAmount;
                    prod.watchIsInCart = watchcart.watchIsInCart;
                    prod.watchProID = watchcart.watchProID;

                    db.SaveChanges();

                    return watchcart.watchDateBuy + "was just updated";
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
                    watchCart watchcart = db.watchCarts.Find(id);

                    db.watchCarts.Attach(watchcart);
                    db.watchCarts.Remove(watchcart);
                    db.SaveChanges();

                    return watchcart.watchDateBuy + "was just removed";
                }
                catch (Exception e)
                {
                    return "Error:" + e;
                }
            }
        }
    }
