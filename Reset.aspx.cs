using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Configuration;

namespace InventoryManagement1._1
{
    public partial class Reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string t = txtText.Text.Trim();
            string conStr = ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            string dbQuery = "select * from logintable4 where email = '" + t + "' or username ='" + t + "';";
            SqlCommand sc = new SqlCommand(dbQuery, con);
            con.Open();
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                string email = sdr["email"].ToString().Trim();
                string password = sdr["password"].ToString().Trim();
                try
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("nashirnisar@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Reset password";
                        mail.Body = "your password is " + password;
                        mail.IsBodyHtml = true;
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new System.Net.NetworkCredential("nashirnisar@gmail.com", "ybtizwvnddjbxwgg");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            lblStatus.Visible = true;
                            lblStatus.Text = "Password Sent To Registered Email";

                        }
                    }
                }
                catch (Exception ee)
                {                
                    lblStatus.Text = "Something went wrong";
                }
            }
            else
            {
                lblStatus.Text = "user not found";
            }
        }
    }
}