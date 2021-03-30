using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Livraria
{
    public partial class FormCadLivro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (livrariaEntities context = new livrariaEntities())
            {
                Livro objLivro;

                objLivro = new Livro()
                {
                    Titulo = txtTitulo.Text,
                    Editora = txtEditora.Text,
                    ISBN = txtISBN.Text,
                    Ano = Convert.ToInt32(txtAno.Text),
                    Autor = txtAutor.Text,
                    Preco = Convert.ToDecimal(txtPreco.Text),
                    Categoria = Convert.ToInt32(ddlCategoria.Text)

                };

                context.Livro.Add(objLivro);

                context.SaveChanges();
                Response.Redirect("PagPrincipal.aspx");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}