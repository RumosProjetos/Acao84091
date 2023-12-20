using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MinhaSolucao.WebForms
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFuncao_Click(object sender, EventArgs e)
        {
            lblTexto.Text = txtTexto.Text;
        }
    }
}