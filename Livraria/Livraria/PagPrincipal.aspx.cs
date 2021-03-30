using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Data;

namespace Livraria
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (livrariaEntities context = new livrariaEntities())
                {
                    var DadosLivro = (from c in context.Livro
                                 orderby c.Titulo, c.Editora
                                 select new
                                 {
                                     c.ID_Livro,
                                     c.Titulo,
                                     c.Editora,
                                     c.ISBN,
                                     c.Ano,
                                     c.Autor,
                                     c.Preco,
                                     c.Categoria
                                 }).ToList();
                    gvLivros.DataSource = DadosLivro;
                    gvLivros.DataBind();

                    var DadosCat = (from c in context.Categorias
                                      orderby c.ID_Categoria
                                      select new
                                      {
                                          c.ID_Categoria,
                                          c.Categoria
                                      }).ToList();
                    gvCategorias.DataSource = DadosCat;
                    gvCategorias.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormCadCategoria.aspx");
        }

        protected void btnIrCadLivro_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormCadLivro.aspx");
        }

        protected void lbDetalhes_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            Response.Redirect("Livro-Detalhes.aspx?ID_Livro=" + lb.CommandArgument);
        }
    }
}