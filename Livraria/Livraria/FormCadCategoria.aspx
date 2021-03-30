<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCadCategoria.aspx.cs" Inherits="Livraria.FormCadCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            height: 24px;
            width: 214px;
        }
        .auto-style3 {
            height: 24px;
            width: 80px;
        }
        .auto-style4 {
            width: 66%;
        }
        .auto-style5 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Cadastro de categoria<br />
            <br />
            <table class="auto-style4">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblCategoria" runat="server" CssClass="auto-style5" Text="Categoria:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCategoria" runat="server" Width="204px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvCategoria" runat="server" ControlToValidate="txtCategoria" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnCadCategoria" runat="server" Text="Cadastrar" OnClick="btnCadCategoria_Click" />
            </strong>
        </div>
    </form>
</body>
</html>
