<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="view_cart.aspx.cs" Inherits="user_view_cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
    <div>
    <asp:DataList ID="d1" runat="server" BorderColor="Maroon" BorderStyle="Solid" 
            BorderWidth="1px">
    <HeaderTemplate>
    <table border="Maroon">
                        <tr style="color:White ;background:Maroon; font-weight: bold">
                            
                            <td>Product Image</td>
                            <td>Product Name</td>
                            <td>Product Price</td>
                            <td>Product Quantity</td>
                            <td>Product Description</td>
                            
                        </tr>
    </HeaderTemplate>

    <ItemTemplate>
    <tr>
    <td><img src="../<%#Eval("p_image") %>" height="100" width="100" /></td>
    <td><%#Eval("p_name") %></td>
    <td><%#Eval("p_price") %></td>
    <td><%#Eval("p_quantity") %></td>
    <td><%#Eval("p_description") %></td>
    <td><a href="delete_cart.aspx?id=<%#Eval("id") %>">delete</a></td>
    </tr>
    </ItemTemplate>

    <FooterTemplate>
    </table>
    </FooterTemplate>
     
    </asp:DataList>
    <br />

    <p align="center">
    <asp:Label ID="l1" runat="server"></asp:Label><br />
    <asp:Button ID="b1" runat="server" Text="Checkout" onclick="b1_Click" />
    </p>


    </div>
    </asp:Content>

