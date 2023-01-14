using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace InventoryManagement1._1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Reset.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;

            string conStr = ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            string dbQuery = "select * from logintable4 where username='" + u + "' and password='" + p + "';";
            SqlCommand sc = new SqlCommand(dbQuery, con);
            con.Open();
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                string role = sdr["role"].ToString().Trim();
                Session["rl"] = role;
                string username = sdr["username"].ToString().Trim();
                Session["username"] = username;
                Session["deptname"] = sdr["deptname"].ToString();
                Session["userid"] = sdr["userid"].ToString();
              
                
                FormsAuthenticationTicket tkt = new FormsAuthenticationTicket(1, username, DateTime.Now,
                DateTime.Now.AddMinutes(30), false, role);
                string cookiestr = FormsAuthentication.Encrypt(tkt);
                HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                ck.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(ck);
             

                switch(role)
                {
                    case "admin": Response.Redirect("~/Admin/Admin.aspx",true); break;
                    case "issuer": Response.Redirect("~/Issuer/Issuer.aspx", true); break;
                    case "principal": Response.Redirect("~/Principal/Principal.aspx", true); break;
                    case "dataentry": Response.Redirect("~/DataEntry/Dashboard.aspx", true); break;
                    case "department": Response.Redirect("~/Department/Department.aspx", true); break;
                    case "pc": Response.Redirect("~/PurchasingCommittee/PurchasingCommittee.aspx", true); break;
                    case "estateofficer": Response.Redirect("~/EstateOffice/EstateOffice.aspx", true); break;
                }
              

            }
            else
            lblMessage.Visible = true;
            lblMessage.Text = "Invalid Login Details";
            con.Close();
        }
    }
}