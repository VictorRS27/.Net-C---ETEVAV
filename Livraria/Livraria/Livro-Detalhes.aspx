<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Livro-Detalhes.aspx.cs" Inherits="Livraria.Livro_Detalhes" %>

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
            width: 105px;
            text-align: right;
        }
        .auto-style3 {
            width: 105px;
            font-size: medium;
            text-align: right;
        }
        .auto-style4 {
            width: 105px;
            height: 13px;
            font-size: medium;
            text-align: right;
        }
        .auto-style5 {
            height: 13px;
        }
        .auto-style6 {
            width: 105px;
            font-size: medium;
            text-align: right;
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style8 {
            margin-left: 10px;
        }
        .auto-style9 {
            height: 23px;
            width: 195px;
        }
        .auto-style10 {
            height: 13px;
            width: 195px;
        }
        .auto-style11 {
            width: 195px;
        }
        .auto-style12 {
            width: 105px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style1">Detalhes do livro</span><br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style6">
            <strong>Título</strong>:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="auto-style8" Width="165px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitulo" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Editora:</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtEditora" runat="server" CssClass="auto-style8" Width="165px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEditora" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ISBN:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtISBN" runat="server" CssClass="auto-style8" Width="165px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtISBN" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Ano:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtAno" runat="server" CssClass="auto-style8" Width="165px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAno" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Autor:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtAutor" runat="server" CssClass="auto-style8" Width="165px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAutor" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Preço:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtPreco" runat="server" CssClass="auto-style8" Width="165px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPreco" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Categoria:</td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="auto-style8" DataSourceID="SqlDataSource1" DataTextField="Categoria" DataValueField="ID_Categoria" Height="25px" Width="172px">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:livrariaConnectionString %>" SelectCommand="SELECT [ID_Categoria], [Categoria] FROM [Categorias]"></asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
                    </td>
                    <td class="auto-style11">
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            
        </div>
    </form>
</body>
</html>
