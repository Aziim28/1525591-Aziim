using _1525591_CO5027.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1525591_CO5027
{
    public partial class WatchShopCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //to retrieve the id of current logged in user and display the items in cart
            string wuserId = User.Identity.GetUserId();
            GetPurchasesInWcart(wuserId);

        }

        private void GetPurchasesInWcart(string wuserId)
        {
            PwCartModel wmodel = new PwCartModel();
            double subWtotal = 0;

            //to make HTML for each purchase list
            List<watchCart> purchaseWlist = wmodel.GetOrdersInCart(wuserId);
            CreateShopTable(purchaseWlist, out subWtotal);

            //add the total to website page
            double tax = subWtotal * 0.15;
            double totalWamount = subWtotal + tax + 10;

            //to display the value in the website
            litWtotal.Text = "$ " + subWtotal;
            litWtax.Text = "$ " + tax;
            litWtotalAmount.Text = "$ " + totalWamount;
        }

        private void CreateShopTable(List<watchCart> purchaseWlist, out double subWtotal)
        {
            subWtotal = new Double();
            PwModel wmodel = new PwModel();

            foreach(watchCart watchcart in purchaseWlist)
            {
                watchProduct watchproduct = wmodel.GetwatchProduct(watchcart.watchProID);

                //to create image btn
                ImageButton btnWimage = new ImageButton
                {
                    ImageUrl = string.Format("~/swatch/picswatch/{0}", watchproduct.watchImage),
                    PostBackUrl = string.Format("~/Prodak.aspx?id={0}", watchproduct.ID)
                };

                //to create the delete link
                LinkButton lnkWdelete = new LinkButton
                {
                    PostBackUrl = string.Format("~/WatchShopCart.aspx?productId={0}", watchcart.ID),
                    Text = "Delete Item",
                    ID = "del" + watchcart.ID
                };

                //to add an onclick event
                lnkWdelete.Click += Delete_Item;

                //to create the quantity of ddl which is the  generrate list number from 1-20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                DropDownList ddlWamount = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = watchcart.ID.ToString()
                };

                ddlWamount.DataBind();
                ddlWamount.SelectedValue = watchcart.watchAmount.ToString();
                ddlWamount.SelectedIndexChanged += ddlWamount_SelectedIndexChanged;

                //to create html table ith 2 rows
                Table wtable = new Table { CssClass = "watchcartTable" };
                TableRow wa = new TableRow();
                TableRow wb = new TableRow();

                //create 6cells for row wa
                TableCell wa1 = new TableCell { RowSpan = 2, Width = 50};
                TableCell wa2 = new TableCell { Text = string.Format("<h4>{0}</h4><hr/>{1}<hr/>In Stock",
                    watchproduct.watchName, "Item No: " + watchproduct.ID),
                    HorizontalAlign = HorizontalAlign.Left, Width=350};
                TableCell wa3 = new TableCell { Text = "Unit Price<hr/>"};
                TableCell wa4 = new TableCell { Text = "Quantity<hr/>" };
                TableCell wa5 = new TableCell { Text = "Total Item<hr/>" };
                TableCell wa6 = new TableCell { };

                //create 6cells for row wb
                TableCell wb1 = new TableCell { };
                TableCell wb2 = new TableCell { Text = "$ " + watchproduct.watchPrice};
                TableCell wb3 = new TableCell { };
                TableCell wb4 = new TableCell { Text = "$ " + Math.Round((watchcart.watchAmount * (double)watchproduct.watchPrice), 2)};
                TableCell wb5 = new TableCell { };
                TableCell wb6 = new TableCell { };

                //to set special controls
                wa1.Controls.Add(btnWimage);
                wa6.Controls.Add(lnkWdelete);
                wb3.Controls.Add(ddlWamount);

                //to ad cells to row
                wa.Cells.Add(wa1);
                wa.Cells.Add(wa2);
                wa.Cells.Add(wa3);
                wa.Cells.Add(wa4);
                wa.Cells.Add(wa5);
                wa.Cells.Add(wa6);

                wb.Cells.Add(wb1);
                wb.Cells.Add(wb2);
                wb.Cells.Add(wb3);
                wb.Cells.Add(wb4);
                wb.Cells.Add(wb5);
                wb.Cells.Add(wb6);

                //to add rows into the table
                wtable.Rows.Add(wa);
                wtable.Rows.Add(wb);

                //to add table to pnlWshopCart
                pnlWshopCart.Controls.Add(wtable);

                //to add the total amount of item into the cart to subwtotal
                subWtotal += (watchcart.watchAmount * (double)watchproduct.watchPrice);

            }

            //to add current user's shopping cart to a session
            Session[User.Identity.GetUserId()] = purchaseWlist;

        }

       
        private void Delete_Item(object sender, EventArgs e)
        {
            LinkButton selectedWlink = (LinkButton)sender;
            string wlink = selectedWlink.ID.Replace("del", "");
            int watchcartId = Convert.ToInt32(wlink);

            PwCartModel pwcmodel = new PwCartModel();
            pwcmodel.DeletewatchProd(watchcartId);

            Response.Redirect("~/WatchShopCart.aspx");
        }

        private void ddlWamount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList selectedWlist = (DropDownList)sender;
            int wquantity = Convert.ToInt32(selectedWlist.SelectedValue);
            int watchcartId = Convert.ToInt32(selectedWlist.ID);

            PwCartModel pwcmodel = new PwCartModel();
            pwcmodel.UpdateWquantity(watchcartId, wquantity);

            Response.Redirect("~/WatchShopCart.aspx");

        }
    }
}