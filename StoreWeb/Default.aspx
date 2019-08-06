<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StoreWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <title>Store</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Store</h1>
            <div class="row">
                <div class="col">
                    <asp:ListBox Style="width: 100%; height: 100%" ID="lsbProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lsbProducts_SelectedChanged"></asp:ListBox>
                </div>
                <div class="col">
                    <asp:Image ID="imgProduct" Width="75%" runat="server" />
                    <div class="row">
                        <div class="col">
                            <asp:Button ID="btnClick" runat="server" Text="Show Cost" OnClick="btnClick_Click" />
                        </div>

                        <div class="col">
                            <asp:Label ID="lblCost" Font-Bold="true" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
