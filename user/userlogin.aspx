<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="userlogin.aspx.cs" Inherits="user_userlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

<div style="padding-top:5px; height:25px; width:720px; border-style:solid; border-width:1px; background:url(css/images/l1.jpg); color:White; font-size:25px; text-align:center;">
<label>Customer Login Form</label>
</div>

<table style="Font-size:14px; color:Maroon">
<br />
<br />
<tr>
<td>Enter Email: </td>
<td><asp:TextBox ID="t1" runat="server" Height="32px" Width="251px"></asp:TextBox></td>
</tr>

<tr>
<td>Enter Password: </td>
<td><asp:TextBox ID="t2" runat="server" Height="32px" TextMode="Password" 
        Width="251px" ></asp:TextBox></td>
</tr>

<tr>
<td colspan="2" align="center">
<asp:Button ID="b1" runat="server" Text="Login" Height="37px" onclick="b1_Click" 
        Width="70px" BackColor="Maroon" ForeColor="White" Font-Size="16px" />
</td>
</tr>

<tr>
<td colspan="2" align="center">
<asp:Label ID="l1" runat="server" Text="" ForeColor="Red"></asp:Label>
</td>
</tr>

</table>
<br />
<br />
<br />
<br />
<br />
<br />
</asp:Content>

