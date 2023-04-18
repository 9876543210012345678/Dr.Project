using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


//namespace dr
//{
//    public partial class WebForm1 : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
         
//        }
//          protected void Button1_Click(object sender, EventArgs e)
//        {
//            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@Username AND Password=@Password", cmd);
//            string username = txtusername.Text.Trim();
//            string password = txtpassword.Text.Trim();

//            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
//            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
//            username = null;
//            password = null;
//            cmd.Open();
//            int result = (int)cmd.ExecuteScalar();
//            if (result > 0)
//            {
//                // Login successful
//                Session["username"] = txtusername.Text.Trim();
//                Response.Redirect("Home.aspx");
//            }
//            else
//            {
//                // Login failed
//                lblError.Text = "Invalid username or password";
//            }
//    }
//}