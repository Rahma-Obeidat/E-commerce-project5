using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
//using System.Reflection.Emit;

namespace E_commerce
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        //    if (!IsPostBack)
        //    {
                //bool s = false;
                try
                {
                    SqlConnection cc = new SqlConnection("Data Source=DESKTOP-78B3490\\SQLEXPRESS; database=kitchenProject; integrated security=SSPI");
                    cc.Open();

                    // string query1 = "select * from  userReg";
                    // cmd1 = new SqlCommand(query1, cc);
                    // SqlDataReader sdr = cmd1.ExecuteReader();

                    //while (sdr.Read())
                    //{
                    //    if (TextBox3.Text == sdr[3]) { s = true; }


                    //}
                    //if (s)
                    //{
                    //    Label la = new Label();
                    //    this.Controls.Add(la);
                    //    la.Text = "You Are Already Exist";
                    //}
                    /**************************************************/
                    //SqlCommand comand = new SqlCommand("select * from name_and_password", cc);

                    string query = "insert into userReg (Fname,Email,PhoneNumber,Password,RolLogin) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + 2 + "') ";
                    SqlCommand cmd = new SqlCommand(query, cc);
                    cmd.ExecuteNonQuery();
                    Label1.Visible = true;

                    cc.Close();
                }
                catch (SqlException q)
                {
                    Response.Write(q.Message);
                }
            
        }
              
            
}
    }
