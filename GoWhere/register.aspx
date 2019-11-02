<%@ Page Title="GoWhere - Create" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" Debug ="True"%>

<asp:Content ID="registerContent" ContentPlaceHolderID="content" Runat="Server">
    <asp:Table ID="registerTable" runat="server">
        <asp:TableHeaderRow>
            <asp:TableCell ColumnSpan ="2"> 
                <b> CREATE USER ACCOUNT INFORMATION </b>
            </asp:TableCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="username" runat="server" Text="Username:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell> 
                 <asp:TextBox ID="registerUser" runat="server" Width="200px" ToolTip="Enter Username"></asp:TextBox>  
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="password" type="password" runat="server" Text="Password:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell> 
                 <asp:TextBox ID="registerPwd" runat="server" Width="200px" ToolTip="Enter Password"></asp:TextBox>  
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="email"  runat="server" Text="Email:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell> 
                 <asp:TextBox ID="registerEmail" runat="server" Width="200px" ToolTip="Enter Email"></asp:TextBox>  
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="country"  runat="server" Text="Country:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell> 
                 <asp:TextBox ID="registerCountry" runat="server" Width="200px" ToolTip="Enter Country"></asp:TextBox>  
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="backbtn" runat="server" Text="Back" PostBackUrl="~/default.aspx" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="registerbtn" runat="server" Text="Create" PostBackUrl="~/homeUA.aspx" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>

