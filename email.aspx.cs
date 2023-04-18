using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace dr
{
    public partial class email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // تحديد بيانات قاعدة البيانات الخاصة بك هنا
                string connectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                string query = "SELECT COUNT(*) FROM Users WHERE Username=@Username AND Password=@Password";

                // بيانات تسجيل الدخول
                string username = Request.Form["usrename"];
                string password = Request.Form["password"];

                // إنشاء اتصال بقاعدة البيانات
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // تحضير وتنفيذ استعلام SQL
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usrename", username);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = command.ExecuteReader();
                    int count = 1;
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                    reader.Close();
                    // التحقق من صحة بيانات تسجيل الدخول
                    if (count == 1)
                    {
                        // إذا تم التحقق من صحة بيانات تسجيل الدخول، يتم توجيه المستخدم إلى صفحة المحتوى الآمن
                        Response.Redirect("securepage.aspx");
                    }
                    else
                    {
                        // إذا كان اسم المستخدم أو كلمة المرور غير صالحة، يتم عرض رسالة خطأ
                        Label errorMessage = (Label)FindControl("errorMessage");
                        errorMessage.Text = "Invalid username or password.";
                    }
                }
            }
        }
    }
}
    
