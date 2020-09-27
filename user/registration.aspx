<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="user_registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

<div style="padding-top:5px; height:25px; width:720px; border-style:solid; border-width:1px; background:url(css/images/l1.jpg); color:White; font-size:25px; text-align:center;">
<label>Customer Registration Form</label>
</div>

<table style="width: 458px; font-size:14px; color:Maroon;" >
<br /><br />
<tr>
<td>First Name: </td>
<td><asp:TextBox ID="t1" runat="server" Height="31px" Width="250px"></asp:TextBox></td>
</tr>

<tr>
<td>Last Name: </td>
<td><asp:TextBox ID="t2" runat="server" Height="31px" Width="250px"></asp:TextBox></td>
</tr>

<tr>
<td>Email: </td>
<td><asp:TextBox ID="t3" runat="server" Height="31px" Width="251px"></asp:TextBox></td>
</tr>

<tr>
<td>Password: </td>
<td><asp:TextBox ID="t4" runat="server" Height="31px" Width="251px" 
        TextMode="Password"></asp:TextBox></td>
</tr>

<tr>
<td>Address: </td>
<td><asp:TextBox ID="t5" runat="server" Height="101px" Width="251px" 
        TextMode="MultiLine"></asp:TextBox></td>
</tr>

<tr>
<td>City: </td>
<td><asp:TextBox ID="t6" runat="server" Height="31px" Width="251px"></asp:TextBox></td>
</tr>

<tr>
<td>Pincode: </td>
<td><asp:TextBox ID="t7" runat="server" Height="31px" Width="251px"></asp:TextBox></td>
</tr>

<tr>
<td>Mobile: </td>
<td><asp:TextBox ID="t8" runat="server" Height="31px" Width="251px"></asp:TextBox></td>
</tr>

<tr>
<td colspan="2" align="center">
<asp:Button ID="b1" runat="server" Text="Sign Up" Height="35px" Width="82px" 
        Backcolor="Maroon" ForeColor="white" onclick="b1_Click" />
</td>
</tr>

<tr>
<td colspan="2" align="center">
<asp:Label ID="l1" runat="server" Text="" ForeColor="Red"></asp:Label>
<br />
<br />
<br />
<br />
<br />
<br />
<br />

</td>
</tr>

</table>
</asp:Content>

