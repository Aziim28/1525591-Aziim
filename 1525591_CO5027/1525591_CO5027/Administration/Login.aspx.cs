using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1525591_CO5027.Administration
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> wuserStore = new UserStore<IdentityUser>();

            wuserStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.
                ConnectionStrings["db_1525591_co5027_aziimConnectionString"].ConnectionString;

            UserManager<IdentityUser> wmanager = new UserManager<IdentityUser>(wuserStore);

            var wuser = wmanager.Find(txtWuserName.Text, txtWpassword.Text);
            
            if(wuser!= null)
            {
                //call owin functionality
                var wauthenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var wuserIdentity = wmanager.CreateIdentity(wuser, DefaultAuthenticationTypes.ApplicationCookie);

                //sign in user
                wauthenticationManager.SignIn(new AuthenticationProperties
                {
                    IsPersistent = false
                },wuserIdentity);

                //redirect user to default.aspx page
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                litWstatus.Text = "The Username or Password that you entered is invalid";
            }
        }
    }
}