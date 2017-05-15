using _1525591_CO5027.Models;
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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> wuserStore = new UserStore<IdentityUser>();

            wuserStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.
                ConnectionStrings["db_1525591_co5027_aziimConnectionString"].ConnectionString;

            UserManager<IdentityUser> wmanager = new UserManager<IdentityUser>(wuserStore);

            //to create a new user in database and to store in it
            IdentityUser wuser = new IdentityUser();
            wuser.UserName = txtWuserName.Text;

            if(txtWpassword.Text == txtWconfirmPassword.Text)
            {
                try
                {
                    //to create user
                    //the database will be created
                    IdentityResult wresult = wmanager.Create(wuser, txtWpassword.Text);

                    if (wresult.Succeeded)
                    {
                        UsercustInfo winfo = new UsercustInfo
                        {
                            Address = txtAdd.Text,
                            FirstName = txtFname.Text,
                            LastName = txtLname.Text,
                            PostalCode = Convert.ToInt32(txtPostal.Text),
                            GUID = wuser.Id
                        };

                        PwUserInfoModel wmodel = new PwUserInfoModel();
                        wmodel.InsertCustInformation(winfo);


                        //to store user in database
                        var wauthenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                        //to set to log in new user by using cookie
                        var wuserIdentity = wmanager.CreateIdentity(wuser, DefaultAuthenticationTypes.ApplicationCookie);

                        //log in the new user and redirec it to default.aspx page
                        wauthenticationManager.SignIn(new AuthenticationProperties(), wuserIdentity);
                        Response.Redirect("~/Default.aspx");
                    }
                    else
                    {
                        litWstatus.Text = wresult.Errors.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    litWstatus.Text = ex.ToString();
                }
            }
            else
            {
                litWstatus.Text = "Error, password must be match as above";
            }
        }
    }
}