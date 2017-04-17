using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1525591_CO5027.Management
{
    public partial class CollectionManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendbtn_Click(object sender, EventArgs e)
        {
            watchProdTypeModel watchmodel = new watchProdTypeModel();
            watchProdType wptype = CreatewatchProdType;

            endlabel.Text = watchmodel.InsertwatchProdType(wptype);
        }

     
        private watchProdType CreatewatchProdType()
        {
            watchProdType prod = new watchProdType();
            prod.watchName = namatxt.Text;

            return prod;
        }
    }
}
