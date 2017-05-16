using _1525591_CO5027.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//reference from-https://www.youtube.com/watch?v=BKujvivVFKI&index=3&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9
namespace _1525591_CO5027.ManagementAdmin
{
    public partial class AdminWatch1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetPictures();

                //to check if url contains an id parameter
                if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    FillPage(id);
                }
            }
                
        }

        protected void btnSubmitP_Click(object sender, EventArgs e)
        {
            PwModel pwmodel = new PwModel();
            watchProduct watchproduct = CreatewatchProduct();

            //checking if the url contains id parameter
            if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //id is exist thus update current row
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lblResultP.Text = pwmodel.UpdatewatchProd(id, watchproduct);
            }
            else
            {
                //id is not exist thus create new row
                lblResultP.Text = pwmodel.InsertwatchProd(watchproduct);
            }
            
        }

        private void FillPage(int id)
        {
            //retrieve product which are selected from database
            PwModel pwmodel = new PwModel();
            watchProduct watchproduct = pwmodel.GetwatchProduct(id);

            //Fill in textboxes
            txtDescP.Text = watchproduct.watchDescription;
            txtNameP.Text = watchproduct.watchName;
            txtPriceP.Text = watchproduct.watchPrice.ToString();

            //set ddl values
            ddlPicP.SelectedValue = watchproduct.watchImage;
            ddlTypeP.SelectedValue = watchproduct.watchProID.ToString();

        }

        private void GetPictures()
        {
            try
            {
                //for getting the picture's path
                string[] pictures = Directory.GetFiles(Server.MapPath("~/swatch/picswatch/"));

                //get all pics name and add it to array
                ArrayList pictureList = new ArrayList();

                foreach (string picture in pictures)
                {
                    string pictureName = picture.Substring(picture.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    pictureList.Add(pictureName);
                }

               
                ddlPicP.DataSource = pictureList;
                ddlPicP.AppendDataBoundItems = true;
                ddlPicP.DataBind();
            }
            catch (Exception e)
            {
                lblResultP.Text = e.ToString();
            }
        }

        private watchProduct CreatewatchProduct()
        {
            watchProduct watchproduct = new watchProduct();

            watchproduct.watchName = txtNameP.Text;
            watchproduct.watchPrice = Convert.ToInt32(txtPriceP.Text);
            watchproduct.watchProID = Convert.ToInt32(ddlTypeP.SelectedValue);
            watchproduct.watchDescription = txtDescP.Text;
            watchproduct.watchImage = ddlPicP.SelectedValue;

            return watchproduct;
        }

        
    }
}