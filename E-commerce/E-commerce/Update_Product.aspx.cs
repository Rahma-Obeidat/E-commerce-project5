﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace E_commerce
{
    public partial class Update_Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                SqlConnection cc = new SqlConnection("data source = DESKTOP-78B3490\\SQLEXPRESS; database = kitchenProject ; integrated security=SSPI");

                //SqlCommand comand = new SqlCommand("select * from name_and_password", cc);
                cc.Open();

                string query = "select * from  category";
                SqlCommand cmd = new SqlCommand(query, cc);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapt.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "cName";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/images/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            FileUpload1.SaveAs(folderPath + "//" + Path.GetFileName(FileUpload1.FileName));
            Label2.Text = Path.GetFileName(FileUpload1.FileName);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Request.QueryString["id"];
                SqlConnection cc = new SqlConnection("data source = DESKTOP-78B3490\\SQLEXPRESS; database = kitchenProject ; integrated security=SSPI");

               
                cc.Open();
                //string query = $"UPDATE customer_15 SET name ={txtName.Text},age={txtAge.Text},city_id={DropDownList1.SelectedValue} ";
                string query = "  Update product set PName= '" + TextBox1.Text + "',description= '" + TextArea1.Value + "',price='" + TextBox2.Text + "',pImage='" + Label2.Text + "',catId='" + DropDownList1.SelectedValue + "'  where id = '" + Convert.ToInt32(str) + "'";

               SqlCommand cmd = new SqlCommand(query, cc);
                cmd.ExecuteNonQuery();
                cc.Close();
            }
            catch (SqlException q)
            {
                Response.Write(q.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("show_product.aspx");

        }
    }
}
