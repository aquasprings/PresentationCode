<%@ Page Title="" Language="C#" MasterPageFile="~/Order.Master" AutoEventWireup="true" CodeBehind="OrderView.aspx.cs" Inherits="OrderUI.OrderView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" >
        <Columns>
            <asp:BoundField DataField="Orderid" HeaderText="OrderId" ReadOnly="True" SortExpression="Orderid" />
            <asp:BoundField DataField="Itemname" HeaderText="Item Name" SortExpression="Itemname" />
            <asp:BoundField DataField="Quantityneeded" HeaderText="Quantity Needed" SortExpression="Quantityneeded" />
            <asp:BoundField DataField="Customername" HeaderText="Customer Name" SortExpression="Customername" />
            <asp:BoundField DataField="Contact" HeaderText="Contact" SortExpression="Contact" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Total" HeaderText="Total Price" SortExpression="Total" />
            <asp:BoundField DataField="Mandate" HeaderText="Manufacturing Date" SortExpression="Mandate" />
            <asp:TemplateField HeaderText="Cancel Order">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="can" CommandArgument='<%#Eval("Orderid")%>'>Cancel</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <p>
    </p>
    </asp:Content>
