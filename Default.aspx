<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Principle Amount:<br />
        <asp:TextBox ID="LoanAmount" runat="server"></asp:TextBox>
        <br />
        <br />
        Annual Interest Rate:<br />
        <asp:TextBox ID="InterestRate" runat="server"></asp:TextBox>
        <br />
        <br />
        Mortgage Length:<br />
        <asp:TextBox ID="length" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="PerformCalButton" runat="server" Text="Compute Montgage Quote" 
            Width="228px" />
    
        <br />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
