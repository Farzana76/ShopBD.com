<%@ Page Title="" Language="C#" MasterPageFile="~/compare.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
<asp:Repeater ID="d1" runat="server">

<HeaderTemplate>
<ul>
</HeaderTemplate>
<ItemTemplate>

          <li class="product"> <a href="display_desc.aspx?id=<%#Eval("id") %>"><img src="<%#Eval("p_image")%>" alt="" /></a>
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

<asp:Content ID="Content2" ContentPlaceHolderID="c2" Runat="Server">
<asp:Repeater ID="d2" runat="server">

<HeaderTemplate>
<ul>
</HeaderTemplate>
<ItemTemplate>

          <li class="product"> <a href="display_desc.aspx?id=<%#Eval("id") %>"><img src="<%#Eval("p_image")%>" alt="" /></a>
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

<asp:Content ID="Content3" ContentPlaceHolderID="c3" Runat="Server">
<asp:Repeater ID="d3" runat="server">

<HeaderTemplate>
<ul>
</HeaderTemplate>
<ItemTemplate>

          <li class="product"> <a href="display_desc.aspx?id=<%#Eval("id") %>"><img src="<%#Eval("p_image")%>" alt="" /></a>
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
