<%@ Page Title="Tourist - View Profile" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="viewTRProfile.aspx.cs" Inherits="viewTRProfile" Debug ="true" %>

<asp:Content ID ="loginUser" ContentPlaceHolderID="loginUser" runat="server">
    Logged in: <b><u>Tourist</u></b>
</asp:Content>

<asp:Content ID ="menubarViewTRProfile" ContentPlaceHolderID="menubar" runat="server">
    <ul>
        <li>
             <img src = "GoWhere/Images/back.png" height = "30" width = "30">
             <asp:HyperLink ID="backHomeTourG" runat="server" NavigateUrl="~/homeTR.aspx"> HOME </asp:HyperLink>
       </li>
       <li>
             <img src = "GoWhere/Images/upcoming.png" height = "30" width = "30">
             <asp:HyperLink ID="upcomingTour" runat="server" NavigateUrl="~/viewUpTourListTR.aspx"> VIEW UPCOMING TOURS </asp:HyperLink>    
       </li>
        <li>
             <img src = "GoWhere/Images/history.png" height = "30" width = "30">
             <asp:HyperLink ID="tourHistory" runat="server" NavigateUrl="~/viewTHistoryListTR.aspx"> VIEW TOUR HISTORY </asp:HyperLink>
       </li>
        <li>
             <img src = "GoWhere/Images/feedback.png" height = "30" width = "30">
             <asp:HyperLink ID="TGfeedback" runat="server" NavigateUrl="~/viewFBTR.aspx"> VIEW FEEDBACK </asp:HyperLink>
       </li>
         <li>
             <img src = "GoWhere/Images/ratings.png" height = "30" width = "30">
             <asp:HyperLink ID="TGRatings" runat="server" NavigateUrl="~/viewRTR.aspx"> VIEW RATINGS </asp:HyperLink>
       </li>
    </ul> 
</asp:Content>

<asp:Content ID="viewTRProfileContent" ContentPlaceHolderID="content" Runat="Server">
    <asp:Table ID="TTProfileTable" runat="server">
        <asp:TableHeaderRow>
            <asp:TableCell ColumnSpan ="2"> 
                <b> VIEW MY TOURIST PROFILE </b>
            </asp:TableCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ID" runat="server" Text="ID:"></asp:Label>
                 <asp:TextBox ID="TRID" runat="server" MaxLength="10" Width="90px"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
             <asp:TableCell>
                <asp:Label ID="fname" runat="server" Text="Firstname:"></asp:Label>
                 <asp:TextBox ID="TGFName" runat="server" Width="200px"></asp:TextBox>  
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lname" runat="server" Text="Lastname:"></asp:Label>
                 <asp:TextBox ID="TGLName" runat="server" Width="200px"></asp:TextBox>  
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
             <asp:TableCell>
                <asp:Label ID="email" runat="server" Text="Email:"></asp:Label>
                 <asp:TextBox ID="TGEmail" runat="server" Width="200px"></asp:TextBox>  
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="country" runat="server" Text="Country:"></asp:Label>
                 <asp:TextBox ID="TGCountry" runat="server" Width="200px"></asp:TextBox>  
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>



