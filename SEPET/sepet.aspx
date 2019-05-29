<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sepet.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 58px">  
        <asp:Label ID="label" runat="server" Text="SEPETİNİZDE ÜRÜN YOK" ></asp:Label>
        
      
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" BorderStyle="Groove" PostBackUrl="~/ANASAYFA.aspx">Alışverişe Devam Et</asp:LinkButton>
        
      
        </div>
    </form>
</body>
</html>
