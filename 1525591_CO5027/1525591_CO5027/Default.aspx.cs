using _1525591_CO5027.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1525591_CO5027
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillSite();
        }
        
        private void FillSite()
        {
            //get the list of all products in db
            PwModel pwmodel = new PwModel();
            List<watchProduct> watchproducts = pwmodel.GetAllwatchProducts();

            //to make sure the product is available in db
            if (watchproducts != null)
            {
                //Create a new panel with an image button and 2 labels for each prodcut
                foreach (watchProduct watchproduct in watchproducts)
                {
                    Panel watchPanel = new Panel();
                    ImageButton watchimageButton = new ImageButton();
                    Label lblWatchName = new Label();
                    Label lblwatchPrice = new Label();

                    //to set childcontrols properties
                    watchimageButton.ImageUrl = "~/swatch/picswatch/" + watchproduct.watchImage;
                    watchimageButton.CssClass = "productImage";
                    watchimageButton.PostBackUrl = "../Prodak.aspx?id=" + watchproduct.ID;

                    lblWatchName.Text = watchproduct.watchName;
                    lblWatchName.CssClass = "productName";

                    lblwatchPrice.Text = "$ " + watchproduct.watchPrice;
                    lblwatchPrice.CssClass = "productPrice";

                    //add child controls to panel
                    watchPanel.Controls.Add(watchimageButton);
                    watchPanel.Controls.Add(new Literal {Text = "<br />" });
                    watchPanel.Controls.Add(lblWatchName);
                    watchPanel.Controls.Add(new Literal { Text = "<br />" });
                    watchPanel.Controls.Add(lblwatchPrice);

                    //add dynamic panels to static parent panel
                    pnlProds.Controls.Add(watchPanel);

                }
            }
            else
            {
                //no products are found
                pnlProds.Controls.Add(new Literal { Text = "Sorry, There are no products are found" });
            }
        }
    }
}