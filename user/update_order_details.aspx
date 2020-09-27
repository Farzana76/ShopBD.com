<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="update_order_details.aspx.cs" Inherits="user_update_order_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

<div style="padding-top:5px; height:25px; width:720px; border-style:solid; border-width:1px; background:url(css/images/l1.jpg); color:White; font-size:25px; text-align:center;">
<label>Confirm Details</label>
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
<td>Address: </td>
<td><asp:TextBox ID="t3" runat="server" Height="101px" Width="251px" 
        TextMode="MultiLine"></asp:TextBox></td>
</tr>

<tr>
<td>City: </td>
<td><asp:TextBox ID="t4" runat="server" Height="31px" Width="251px"></asp:TextBox></td>
</tr>

<tr>
<td>Mobile: </td>
<td><asp:TextBox ID="t5" runat="server" Height="31px" Width="251px"></asp:TextBox></td>
</tr>

<tr>
<td colspan="2" align="center">
<asp:Button ID="b1" runat="server" Text="Update & Continue" Height="35px" Width="123px" 
        Backcolor="Maroon" ForeColor="white" onclick="b1_Click" />
</td>
</tr>
</table>
<br />
<br />
<br />
<br />
<br />

</asp:Content>

