using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Livraria
{
    public partial class FormCadCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadCategoria_Click(object sender, EventArgs e)
        {
            using (livrariaEntities context = new livrariaEntities())
            {
                Categorias objCategorias;

                objCategorias = new Categorias()
                {
                    Categoria = txtCategoria.Text
                };

                context.Categorias.Add(objCategorias);

                context.SaveChanges();
                Response.Redirect("PagPrincipal.aspx");
            }
        }
    }
}