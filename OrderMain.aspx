<%@ Page Title="" Language="C#" MasterPageFile="~/Order.Master" AutoEventWireup="true" CodeBehind="Ordermain.aspx.cs" Inherits="OrderUI.Ordermain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #0000FF;
        }
        .auto-style2 {
            width: 206px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#CCCCCC" BorderColor="Gray" ForeColor="#0066FF" NavigateUrl="~/OrderView.aspx">VIEW ALL ORDER DETAILS</asp:HyperLink>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Item Name-</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Item Name" ForeColor="#3366FF"></asp:RequiredFieldValidator>
&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Only Alphabets Allowed" ForeColor="Lime" ValidationExpression="^[a-zA-Z ]+$"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Quantity Needed-</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Quantity Needed" ForeColor="#0066FF"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Customer Name-</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Customer Name" ForeColor="#0066FF"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Customer Contact-</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Mobile Number" ForeColor="#0066FF"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Only Numbers" ForeColor="Lime" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Customer Email-</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Email"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter Email ID" ForeColor="#0066FF"></asp:RequiredFieldValidator>
&nbsp; </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"><h3>&nbsp;</h3></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"><h3>YOUR ORDER ID IS-</h3></td>
            <td>
                <asp:Label ID="oid" runat="server" Text="null"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"><h3>YOUR TOTAL PRICE IS-</h3></td>
            <td>
                <asp:Label ID="tp" runat="server" Text="null"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>
