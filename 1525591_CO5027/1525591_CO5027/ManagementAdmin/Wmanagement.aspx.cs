using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//reference from-https://www.youtube.com/watch?v=hkiYuPBwnkQ&index=4&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9
namespace _1525591_CO5027.ManagementAdmin
{
    public partial class Wmanagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

      
        protected void grdWproducts_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //getting the selected row
            GridViewRow rowWatch = grdWproducts.Rows[e.NewEditIndex];

            //getting the id selected row
            int rowidwatch = Convert.ToInt32(rowWatch.Cells[1].Text);

            Response.Redirect("../ManagementAdmin/AdminWatch.aspx?id=" + rowidwatch);

            


        }
    }
}