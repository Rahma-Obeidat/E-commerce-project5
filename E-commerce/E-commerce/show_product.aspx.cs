﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                try
                {
                    HyperLink l = new HyperLink();
                    l.Text = "navigate";

                    HyperLink l1 = new HyperLink();
                    l1.Text = "navigate";


                    SqlConnection cc = new SqlConnection("data source = DESKTOP-78B3490\\SQLEXPRESS; database = kitchenProject ; integrated security=SSPI");
                    string query = "select * from   product";
                    SqlCommand cmd = new SqlCommand(query, cc);
                    cc.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    string table = "<table class='table table-striped'> <tr> <th> Name</th><th> Description</th><th> Price</th><th>Image</th><th> catId</th><th></th><th></th></tr>";
                    while (sdr.Read())
                    {
                        //link.NavigateUrl = "page_edit.aspx?id=" + sdr[3];
                        l.NavigateUrl = "Update_Product.aspx?id="+ sdr[0];
                        l1.NavigateUrl = "delete_category.aspx?id="+sdr[0];

                        table += $"<tr><td>{sdr[1]}</td><td>{sdr[2]}</td><td>{sdr[3]}</td><td><img src =images\\{sdr[4]}  width=200px; height=200px /></td><td>{sdr[5]}</td> <td> <a href={l.NavigateUrl} > Edit <a /> </td><td> <a href={l1.NavigateUrl} > Delete <a /> </td></tr>";
                    }
                    table += "</table>";
                    Label2.Text = table;

                }
                catch (SqlException q)
                {
                    Response.Write(q.Message);
                }



            }
        }
    }
}