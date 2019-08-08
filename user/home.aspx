<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="user_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

<div style="padding-top:5px; height:25px; width:720px; border-style:solid; border-width:1px; background:url(css/images/l1.jpg); color:White; font-size:25px; text-align:center;">
<label>New Arrivals!!!</label>
</div>

<asp:Repeater ID="d1" runat="server">

<HeaderTemplate>
<ul>
</HeaderTemplate>
<ItemTemplate>

          <li class="product"> <a href="display_desc.aspx?id=<%#Eval("id") %>"><img src="../<%#Eval("p_image")%>" alt="" /></a>
            <div class="product-info">
              <h3><%#Eval("p_name")%></h3>
              <div class="product-desc">
                <h4>Available: <%#Eval("p_quantity")%></h4>
                <p><%#Eval("p_description")%></p>
                <strong class="price">BDT <%#Eval("p_price")%></strong> </div>
            </div>
          </li>
          

</ItemTemplate>

<FooterTemplate>
</ul>
</FooterTemplate>

</asp:Repeater>
</asp:Content>

