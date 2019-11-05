﻿<%@ Page Title="Tourist - View Tours" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="viewT.aspx.cs" Inherits="viewT" Debug ="true" %>

<asp:Content ID ="loginUser" ContentPlaceHolderID="loginUser" runat="server">
    Logged in: <b><u>Tourist</u></b>
</asp:Content> 

<asp:Content ID ="menubarViewTours" ContentPlaceHolderID="menubar" runat="server">
    <ul>
        <li>
             <img src = "GoWhere/Images/back.png" height = "30" width = "30">
             <asp:HyperLink ID="backHomeTourG" runat="server" NavigateUrl="~/homeTR.aspx"> HOME </asp:HyperLink>
       </li>
    </ul> 
</asp:Content>

<asp:Content ID="viewToursContent" ContentPlaceHolderID="content" Runat="Server">
    <asp:Table ID="TRTourTable" runat="server">
        <asp:TableHeaderRow>
            <asp:TableCell ColumnSpan ="3"> 
                <b> VIEW TOURS LIST</b>
            </asp:TableCell>
        </asp:TableHeaderRow>
         <asp:TableRow>
             <asp:TableCell>
                <asp:Label ID="startdate" runat="server" Text="Start Date"></asp:Label>
            </asp:TableCell>
             <asp:TableCell>
                <asp:Label ID="ID" runat="server" Text="ID"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:DropDownList ID="tourDate" runat="server">
                    <asp:ListItem Selected="True" Value ="#">####</asp:ListItem>
                    <asp:ListItem Value="#">####</asp:ListItem>
                    <asp:ListItem Value="#">####</asp:ListItem>
                </asp:DropDownList> 
            </asp:TableCell>
            <asp:TableCell> 
                <asp:HyperLink ID="tourID" runat="server" NavigateUrl="~/viewTInfo.aspx"> # </asp:HyperLink> 
            </asp:TableCell>
            <asp:TableCell> 
                 <asp:TextBox ID="tourName" runat="server" Width="400px"></asp:TextBox>  
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
