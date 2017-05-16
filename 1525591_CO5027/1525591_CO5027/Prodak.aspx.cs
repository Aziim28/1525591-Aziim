using _1525591_CO5027.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//reference from -https://www.youtube.com/watch?v=SFDQ6Lkp8Ec&t=1s

namespace _1525591_CO5027
{
    public partial class Collections : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillSite();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string watchcustId = Context.User.Identity.GetUserId();

                if (watchcustId != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    int amounts = Convert.ToInt32(ddlAmounts.SelectedValue);

                    watchCart watchcart = new watchCart
                    {
                        watchAmount = amounts,
                        watchCustID = watchcustId,
                        watchDateBuy = DateTime.Now,
                        watchIsInCart = true,
                        watchProID = id
                    };

                    PwCartModel model = new PwCartModel();
                    lblResults.Text = model.InsertwatchProd(watchcart);
                }
                else
                {
                    lblResults.Text = "You need to Sign In if you want to order this watch or you can register now for free!";
                }
            }
        }

        private void FillSite()
        {
            //get selected products data
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                PwModel pwmodel = new PwModel();
                watchProduct watchproduct = pwmodel.GetwatchProduct(id);

                //fill page with infomation
                lblMoney.Text = "Price per watch: $ " + watchproduct.watchPrice;
                lblHead.Text = watchproduct.watchName;
                lblDescrip.Text = watchproduct.watchDescription;
                lblProdNo.Text = id.ToString();

                imgProds.ImageUrl = "~/swatch/picswatch/" + watchproduct.watchImage;

                //fill droplist form 1-20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmounts.DataSource = amount;
                ddlAmounts.AppendDataBoundItems = true;
                ddlAmounts.DataBind();
            }
        }

       
    }
}