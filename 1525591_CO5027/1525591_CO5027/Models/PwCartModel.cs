using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//guidance from-https://www.youtube.com/watch?v=BKujvivVFKI&index=3&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9
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

        public List<watchCart> GetOrdersInCart(string wuserId)
        {
            db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
            List<watchCart> worders = (from x in db.watchCarts
                                       where x.watchCustID == wuserId
                                       && x.watchIsInCart
                                       orderby x.watchDateBuy
                                       select x).ToList();
            return worders;
        }

        public int GetAmountOfWorders(string wuserId)
        {
            try
            {
                db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
                int wamount = (from x in db.watchCarts
                               where x.watchCustID == wuserId
                               && x.watchIsInCart
                               select x.watchAmount).Sum();

                return wamount;
            }
            catch
            {
                return 0;
            }
        }

        public void UpdateWquantity(int wid, int wquantity)
        {
            db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();
            watchCart watchcart = db.watchCarts.Find(wid);
            watchcart.watchAmount = wquantity;

            db.SaveChanges();
        }

        public void MarkWordersAsPaid(List<watchCart> watchcarts)
        {
            db_1525591_co5027_aziimEntities db = new db_1525591_co5027_aziimEntities();

            if(watchcarts !=null)
            {
                foreach(watchCart watchcart in watchcarts)
                {
                    watchCart woldCart = db.watchCarts.Find(watchcart.ID);
                    woldCart.watchDateBuy = DateTime.Now;
                    woldCart.watchIsInCart = false;
                }

                db.SaveChanges();

            }
        }

    }
}
