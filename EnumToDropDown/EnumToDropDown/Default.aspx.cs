using System;
using System.Linq;
using System.Web.UI.WebControls;
using EnumToDropDown.Enumerators;

namespace EnumToDropDown
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //chama o método responsável por popular o dropdownlist
                this.FillDropDownListWithEnum();
            }
        }

        /// <summary>
        /// Popula o dropdown ddlEnum com os valores do Enum Profissao
        /// </summary>
        protected void FillDropDownListWithEnum()
        {
            var profissoes = from pName in Enum.GetNames(typeof(Profissao)) //obtém os itens do enum em formato de string
                             orderby pName //ordena os valores do enum
                             //cria um novo elemento ListItem com o nome e valor que é obtido com o parse do item do enum
                             select new ListItem(pName.Replace("_", " "), Enum.Parse(typeof(Profissao), pName).GetHashCode().ToString());

            //atribui o objeto com os itens do enum para ser o datasource
            ddlEnum.DataSource = profissoes;
            //necessário para indicar que o campo Texto do ListItem será o campo de texto do dropdown
            ddlEnum.DataTextField = "Text";
            //necessário para indicar que o campo Value do ListItem será o campo de valor do dropdown
            ddlEnum.DataValueField = "Value";
            //faz o bind dos dados
            ddlEnum.DataBind();
        }

        /// <summary>
        /// Evento click do botão btnValorSelecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnValorSelecionado_Click(object sender, EventArgs e)
        {
            //popula a label com o texto selecionado no dropdown
            lblTextoSelecionado.Text = ddlEnum.SelectedItem.Text;
            //popula a label com o valor selecionado no dropdown
            lblValorSelecionado.Text = ddlEnum.SelectedValue;
        }
    }
}
