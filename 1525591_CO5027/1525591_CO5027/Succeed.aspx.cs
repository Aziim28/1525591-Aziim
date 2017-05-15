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
    public partial class Succeed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<watchCart> wcarts = (List<watchCart>)Session[User.Identity.GetUserId()];

            PwCartModel pwcmodel = new PwCartModel();
            pwcmodel.MarkWordersAsPaid(wcarts);

            Session[User.Identity.GetUserId()] = null;
        }
    }
}