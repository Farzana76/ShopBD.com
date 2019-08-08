<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="display_desc.aspx.cs" Inherits="user_display_desc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

<div style="padding-top:5px; height:25px; width:720px; border-style:solid; border-width:1px; background:url(css/images/l1.jpg); color:White; font-size:25px; text-align:center;">
<label>Product Description</label>
</div>

<asp:Repeater ID="d1" runat="server">

<HeaderTemplate>
</HeaderTemplate>

<ItemTemplate>
<div style="height:300px; width:600px; border-style:solid; border-width:1px;">

<div style="height:300px; width:199px; float:left; border-style:solid; border-width:1px;">
<img src='../<%#Eval("p_image")%>' height="300" width="199" />

</div>

<div style="height:300px; width:397px; float:left; border-style:solid; border-width:1px; font-family:Algerian; font-size:medium;">
Product Name:<br /> <%#Eval("p_name")%><br /><br />
Price:<br />BDT <%#Eval("p_price")%><br /><br />
Available:<br /><%#Eval("p_quantity")%><br /><br />
Description:<br /><%#Eval("p_description")%><br /><br />



</div>

</div>
</ItemTemplate>

<FooterTemplate>
</FooterTemplate>

</asp:Repeater>
<br />
<table>
<tr>
<td><asp:Label ID="l2" runat="server" Text="Enter Quantity"></asp:Label></td>
<td><asp:TextBox ID="t1" runat="server"></asp:TextBox></td>
<td><asp:Button ID="b1" runat="server" Text="Add to Cart" OnClick="b1_Click" /></td>
</tr>
<tr>
<td colspan="3">
<asp:Label ID="l1" runat="server" Text="" ForeColor="Red"></asp:Label>
</td>
</tr>
</table>



</asp:Content>

