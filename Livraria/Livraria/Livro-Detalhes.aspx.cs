using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Livraria
{
    public partial class Livro_Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID_Livro"] != null)
                {
                    using (livrariaEntities context = new livrariaEntities())
                    {
                        int idLivro = int.Parse(Request.QueryString["ID_Livro"]);

                        Livro objLivro;

                        List<Livro> liLivros = (from c in context.Livro
                                                select c).Where(item => item.ID_Livro == idLivro).ToList();

                        objLivro = liLivros[0];
                        txtTitulo.Text = objLivro.Titulo.ToString();
                        txtEditora.Text = objLivro.Editora.ToString();
                        txtISBN.Text = objLivro.ISBN.ToString();
                        txtAno.Text = objLivro.Ano.ToString();
                        txtAutor.Text = objLivro.Autor.ToString();
                        txtPreco.Text = objLivro.Preco.ToString();
                        ddlCategoria.Text = objLivro.Categoria.ToString();

                        btnExcluir.Attributes.Add("onClick", "return confirm ('Deseja confirmar a exclusão desse registro?')");
                    }
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            using (livrariaEntities context = new livrariaEntities())
            {
                int idLivro = 0;

                if (Request.QueryString["ID_Livro"] != null)
                    idLivro = Convert.ToInt32(Request.QueryString["ID_Livro"]);

                //Verifica registros já existentes

                List<Livro> liLivros = (from c in context.Livro
                                        select c).Where(item => item.ID_Livro == idLivro).ToList();

                Livro objLivro;

                #region Inserir

                if(liLivros.Count == 0)
                {
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
                }

                #endregion Inserir

                #region Editar

                else
                {
                    objLivro = liLivros[0];

                    objLivro.Titulo = txtTitulo.Text;
                    objLivro.Editora = txtEditora.Text;
                    objLivro.ISBN = txtISBN.Text;
                    objLivro.Ano = Convert.ToInt32(txtAno.Text);
                    objLivro.Autor = txtAutor.Text;
                    objLivro.Preco = Convert.ToDecimal(txtPreco.Text);
                    objLivro.Categoria = Convert.ToInt32(ddlCategoria.Text);
                }

                #endregion Editar

                context.SaveChanges();
                Response.Redirect("PagPrincipal.aspx");
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int idLivro = 0;

            if (Request.QueryString["ID_Livro"] != null)
                idLivro = Convert.ToInt32(Request.QueryString["ID_Livro"]);

            using (livrariaEntities context = new livrariaEntities())
            {
                var objLivro = context.Livro.Where(c => c.ID_Livro == idLivro).First();

                context.Livro.Remove(objLivro);
                context.SaveChanges();
            }

            Response.Redirect("PagPrincipal.aspx");
        }
    }
}