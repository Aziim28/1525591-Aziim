using System;
using System.Net.Mail;

namespace _1525591_CO5027.Sites
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    MailMessage emailTexts = new MailMessage();
                    emailTexts.From = new MailAddress(fieldEmail.Text);
                    emailTexts.To.Add("temper2834@gmail.com");
                    emailTexts.Subject = fieldTopic.Text;

                    emailTexts.Body = "<b>Sender's Name : </b>" + fieldName.Text + "<br/>"
                        + "<b>Sender's Email : </b>" + fieldEmail.Text + "<br/>"
                        + "<b>Comments : </b>" + fieldComments.Text;
                    emailTexts.IsBodyHtml = true;

                    SmtpClient bigClient = new SmtpClient("Smtp.gmail.com", 587);
                    bigClient.EnableSsl = true;
                    bigClient.Credentials = new System.Net.NetworkCredential("temper2834@gmail.com", "dummytext28");
                    bigClient.Send(emailTexts);

                    word.ForeColor = System.Drawing.Color.LightBlue;
                    word.Text = "Your email has been sent,Thank you";

                    fieldName.Enabled = false;
                    fieldEmail.Enabled = false;
                    fieldTopic.Enabled = false;
                    fieldComments.Enabled = false;
                    submitbtn.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                // Log - Event Viewer or table
                word.ForeColor = System.Drawing.Color.LightBlue;
                word.ForeColor = System.Drawing.Color.Red;
                word.Text = "Problem has been detected,try again";
            }
      }          
     }
}