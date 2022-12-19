using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = TextBox1.Text;
                string pass = TextBox2.Text;
               
                SqlConnection cc = new SqlConnection("Data Source=DESKTOP-78B3490\\SQLEXPRESS; database=kitchenProject; integrated security=SSPI");
                cc.Open();
               string qry = "select * from userReg where Email='" + email + "' and Password='" + pass + "'  ";
               // string qry = "select * from userReg  ";
                SqlCommand cmd = new SqlCommand(qry, cc);
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    string Email =Convert.ToString( sdr[2]);
                    string Pass = Convert.ToString(sdr[4]);
                    int x =Convert.ToInt32( sdr[5]);
                   
                    if (x == 1 && TextBox1.Text== "yasmeen@gmail.com" && TextBox2.Text=="12345")
                    {
                        Response.Redirect("admin.aspx? x="+x);
                    }
                    else if (x == 2 && Email ==TextBox1.Text && TextBox2.Text == Pass)
                    {
                        Response.Redirect("category.aspx? x="+x);
                    }
                    else if (x!= 2 || Email != TextBox1.Text || Pass !=TextBox2.Text)
                    {
                        Label4.Visible = true;
                        
                       // Label4.Text = "email or Password Is not correct";
                    }
                }
                //if (sdr.Read())
                //{
                //    Response.Redirect("category.aspx");
                //}
                //else if (TextBox1.Text=="yasmeen@gmail.com" && TextBox2.Text=="12345" && (sdr[2]=="2" ))
                //{
                //    Response.Redirect("admin.aspx");
                //}
                //else
                //{
                //    Label4.Text = "email or Password Is not correct";

                //}
                cc.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
        }
}