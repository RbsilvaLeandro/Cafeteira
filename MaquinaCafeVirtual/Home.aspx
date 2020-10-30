<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MaquinaCafeVirtual.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h4>Cafeteira virtual</h4>
            <br />
            <div class="row">
                <div class="col-sm-6">
                    <asp:Label ID="lbl_SelecaoMoeda" runat="server">Selecione o valor da moeda e ser inserida</asp:Label>
                    <asp:DropDownList ID="ddl_ValorMoeda" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddl_ValorMoeda_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Value="0,01" Text="0.01" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="0,05" Text="0.05"></asp:ListItem>
                        <asp:ListItem Value="0,10" Text="0.10"></asp:ListItem>
                        <asp:ListItem Value="0,25" Text="0.25"></asp:ListItem>
                        <asp:ListItem Value="0,50" Text="0.50"></asp:ListItem>
                        <asp:ListItem Value="1,00" Text="1.00"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="col-sm-6">
                    Valor Inserido<br />
                    <asp:TextBox ID="txt_valorInserido" runat="server"  CssClass="form-control" Text="0,00" Enabled="false"></asp:TextBox>
                </div>

            </div>
            <div class="form-group">
                <br />
                <asp:Label ID="lbl_feedback" runat="server"></asp:Label>
            </div>
            <div class="form-group">
                <div class="col-sm-12">
                    <asp:RadioButtonList ID="rbl_Produtos" runat="server" Enabled="false">
                        <asp:ListItem Value="1" Text="Café com leite - R$3.00"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Cappucino -  R$3.50"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Mocha - R$4.00"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <br />
                <div class="col-sm-12">
                    <asp:Button ID="btn_SolicitaBebida" runat="server" CssClass="btn btn-primary" Text="Solicitar Bebida" OnClick="btn_SolicitaBebida_Click" />
                </div>
            </div>
            <asp:Panel ID="pnl_troco" runat="server" Visible="false">
                <div class="card">
                    <div class="card-body">
                        <h4>Troco</h4>
                        <asp:Label ID="lbl_Troco" runat="server"></asp:Label>
                    </div>
                </div>
            </asp:Panel>
            <br />
            <asp:Label ID="lbl_FeedbackUsuario" runat="server"></asp:Label>
    </form>
</body>
</html>
