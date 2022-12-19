<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_Product.aspx.cs" Inherits="E_commerce.Update_Product" %>

<!DOCTYPE html>
 <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
        .big_div{
            position:relative;
            background-color:#D2CECE;
        }
        .div_form{
            position:absolute;
             border:solid 5px #2B3467;
            width:400px;
            height:520px;
            border-radius:18px;
            margin-left:35%;
            margin-top:8%;
           
        }
        h2{
            color:#2B3467;
            margin-left:25%;
            margin-top:5%;
        }
        .textbox{
            margin-left:23%;
            width:240px;
        }
        .textarea{
            margin-left:50px;
        }
        .lable{
            color:#2B3467;
            margin-left:25%;
        }
        .upload{
             margin-left:5%;
        }
        .btn_upload{
               color:white;
            background-color:#2B3467;
            border:solid 5px #2B3467;
            padding:5px;
            border-radius:12px;
           /* margin-left:32%;*/

        }
        .btn_add{
             color:white;
            background-color:#2B3467;
            border:solid 5px #2B3467;
            padding:5px;
            border-radius:12px;
            margin-left:15%;
            margin-top:10%;
        }
           .btn_show{
             color:white;
            background-color:#2B3467;
            border:solid 5px #2B3467;
            padding:5px;
            border-radius:12px;
            margin-left:5%;
           /* margin-top:10%;*/
        }

    </style>
</head>
<body style=" background-color:#D2CECE;">
    <form id="form1" runat="server">
        <div class="big_div">
            <div class="div_form">
                <h2>Update Product</h2><br />
                <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" placeholder="Product Name"></asp:TextBox><br /><br />
                 <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" placeholder="Product Price"></asp:TextBox><br /><br />
                <%-- <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox" placeholder="Description" type="textarea"></asp:TextBox><br /><br />--%>
                <textarea id="TextArea1" cols="30" rows="2" placeholder="Description" style="margin-left:23%" runat="server"></textarea><br />
                <asp:Label ID="Label1" runat="server" Text="Label" CssClass="lable">Categories:</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br /><br />
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="upload" />  <asp:Button ID="Button1" runat="server" Text="Upload" CssClass="btn_upload" OnClick="Button1_Click" />

                <asp:Button ID="Button2" runat="server" Text="Update Product"  CssClass="btn_add" OnClick="Button2_Click"/><asp:Button ID="Button3" runat="server" Text="Show All Product"  CssClass="btn_show" OnClick="Button3_Click"/>

              
            </div>
            <asp:Label ID="Label2" runat="server" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
