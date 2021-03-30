<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCadLivro.aspx.cs" Inherits="Livraria.FormCadLivro" %>

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
            width: 100%;
        }
        .auto-style3 {
            font-size: medium;
            width: 77px;
            text-align: right;
        }
        .auto-style4 {
            margin-left: 13px;
        }
        .auto-style5 {
            font-size: medium;
            width: 77px;
            text-align: right;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
        }
        .auto-style7 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Cadastro de livro<strong/>
            <br />
            <table class="auto-style2">
                <tr>
                    <td id="lblTitulo" class="auto-style3">Título:</td>
                    <td><strong>
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="auto-style4" Width="165px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo" CssClass="auto-style7" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td id="lblEditora" class="auto-style3">Editora:</td>
                    <td><strong>
                        <asp:TextBox ID="txtEditora" runat="server" CssClass="auto-style4" Width="165px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEditora" runat="server" ControlToValidate="txtEditora" CssClass="auto-style7" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td id="lblISBN" class="auto-style5">ISBN:</td>
                    <td class="auto-style6"><strong>
                        <asp:TextBox ID="txtISBN" runat="server" CssClass="auto-style4" Width="165px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvISBN" runat="server" ControlToValidate="txtISBN" CssClass="auto-style7" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                        </strong></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td id="lblAno" class="auto-style3">Ano:</td>
                    <td><strong>
                        <asp:TextBox ID="txtAno" runat="server" CssClass="auto-style4" Width="165px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvAno" runat="server" ControlToValidate="txtAno" CssClass="auto-style7" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td id="lblAutor" class="auto-style3">Autor:</td>
                    <td><strong>
                        <asp:TextBox ID="txtAutor" runat="server" CssClass="auto-style4" Width="165px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvAutor" runat="server" ControlToValidate="txtAutor" CssClass="auto-style7" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td id="lblPreco" class="auto-style3">Preço:</td>
                    <td><strong>
                        <asp:TextBox ID="txtPreco" runat="server" CssClass="auto-style4" Width="165px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPreco" runat="server" ControlToValidate="txtPreco" CssClass="auto-style7" ErrorMessage="Campo obrigatório!"></asp:RequiredFieldValidator>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td id="lblcategoria" class="auto-style3">Categoria:</td>
                    <td>
                        <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="auto-style4" Height="24px" Width="173px" DataSourceID="SqlDataSource1" DataTextField="Categoria" DataValueField="ID_Categoria" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:livrariaConnectionString %>" SelectCommand="SELECT [ID_Categoria], [Categoria] FROM [Categorias]"></asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnCadLivro" runat="server" OnClick="Button1_Click" Text="Cadastar" />
            </strong>
        </div>
    </form>
</body>
</html>
