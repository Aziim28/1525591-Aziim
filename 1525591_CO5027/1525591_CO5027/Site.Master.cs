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
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var wuser = Context.User.Identity;

            if(wuser.IsAuthenticated)
            {
                lnkLogin.Visible = false;
                lnkReg.Visible = false;

                btnLogout.Visible = true;
                litWstatus.Visible = true;

                PwCartModel pwcmodel = new PwCartModel();
                string wuserId = HttpContext.Current.User.Identity.GetUserId();
                litWstatus.Text = string.Format("{0} ({1})", Context.User.Identity.Name,
                    pwcmodel.GetAmountOfWorders(wuserId));
            }
            else
            {
                lnkLogin.Visible = true;
                lnkReg.Visible = true;

                btnLogout.Visible = false;
                litWstatus.Visible = false;
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            var wauthenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            wauthenticationManager.SignOut();

            Response.Redirect("~/Default.aspx");
        }
    }
}