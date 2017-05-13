using _1525591_CO5027.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1525591_CO5027.ManagementAdmin
{
    public partial class AdminWatch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSubmitW_Click(object sender, EventArgs e)
        {
            PwTypeModel model = new PwTypeModel();
            watchProdType pt = createwatchProdType();

            lblResultW.Text = model.InsertwatchProd(pt);
        }

        private watchProdType createwatchProdType()
        {
            watchProdType p = new watchProdType();
            p.watchName = txtNameW.Text;

            return p;
        }
    }
}