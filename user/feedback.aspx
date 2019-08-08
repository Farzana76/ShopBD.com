<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="user_feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

<div style="padding-top:5px; height:25px; width:720px; border-style:solid; border-width:1px; background:url(css/images/l1.jpg); color:White; font-size:25px; text-align:center;">
<label>Customers' Feedback</label>
</div>

<asp:DataList ID="d1" runat="server">
<HeaderTemplate>
<table>
</HeaderTemplate>
<ItemTemplate>
<div style="width:720px; border-style:solid; border-width:1px; border-color:Maroon;">
<tr>
<td>Date & Time: <%#Eval("date") %></td>
</tr>
<tr>
<td>Customer name: <%#Eval("name") %></td>
</tr>
<tr>
<td>Product name: <%#Eval("product_name") %></td>
</tr>
<tr>
<td>Feedback: <%#Eval("message") %></td>

</tr>
</div>

</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:DataList>

<br /><br /><br /><br /><br />
<div style="height:20px; width:720px; border-style:solid; border-width:2px; background:Maroon; color:White; font-size:medium; text-align:center;">
<label>Submit Your Feedback</label>
</div>

<table width="720px" border="Maroon">
<tr>
<td>Enter Your Name: </td>
<td><asp:TextBox ID="t2" runat="server" Width="474px" BorderColor="Maroon"></asp:TextBox></td>
</tr>

<tr>
<td>Enter Product Name: </td>
<td><asp:TextBox ID="t3" runat="server" Width="473px" BorderColor="Maroon" 
        Height="39px"></asp:TextBox></td>
</tr>

<tr>
<td>Enter Your Message: </td>
<td><asp:TextBox ID="t4" runat="server" Height="189px" Width="472px" 
        BorderColor="Maroon"></asp:TextBox></td>
</tr>

<tr>
<td colspan="2" align="center">
<asp:Button ID="b1" runat="server" Text="Submit" onclick="b1_Click" 
        BackColor="Maroon" ForeColor="White" Height="25px" Width="100px" />
</td>
</tr>

</table>
</asp:Content>

