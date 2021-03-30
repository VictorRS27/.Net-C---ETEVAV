<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagPrincipal.aspx.cs" Inherits="Livraria.WebForm1" %>

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
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 174px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style1">Página inicial - Livraria</span><br />
            <br />
            Categorias:<br />
            <br />
            <asp:GridView ID="gvCategorias" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField HeaderText="Código" DataField="ID_Categoria" SortExpression="Id"/>
                    <asp:BoundField HeaderText="Categoria" DataField="Categoria" SortExpression="Categoria"/>
                </Columns>
            </asp:GridView>
            <br />
            Livros:<br />
            <br />
                <asp:GridView ID="gvLivros" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField HeaderText="Código" DataField="ID_Livro" SortExpression="Id"/>
                    <asp:BoundField HeaderText="Titulo" DataField="Titulo" SortExpression="Titulo"/>
                    <asp:BoundField HeaderText="Editora" DataField="Editora" SortExpression="Editora"/>
                    <asp:BoundField HeaderText="ISBN" DataField="ISBN" SortExpression="ISBN"/>
                    <asp:BoundField HeaderText="Ano" DataField="Ano" SortExpression="Ano"/>
                    <asp:BoundField HeaderText="Autor" DataField="Autor" SortExpression="Autor"/>
                    <asp:BoundField HeaderText="Preço" DataField="Preco" SortExpression="Preco"/>
                    <asp:BoundField HeaderText="Categoria" DataField="Categoria" SortExpression="Categoria"/>
                <asp:TemplateField>
                    <ItemTemplate>
                       <asp:LinkButton ID="lbDetalhes" CommandArgument='<%#Eval("ID_Livro")%>' runat="server" OnClick="lbDetalhes_Click">Detalhes</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">
            <strong>
            <asp:Button ID="btnIrCadCategoria" runat="server" OnClick="Button1_Click" Text="Cadastrar categoria" Width="145px" />
            </strong></td>
                    <td class="auto-style2">
            <strong>
            <asp:Button ID="btnIrCadLivro" runat="server" OnClick="btnIrCadLivro_Click" Text="Cadastrar livro" Width="144px" />
            </strong></td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            </strong>
        </div>
    </form>
</body>
</html>
