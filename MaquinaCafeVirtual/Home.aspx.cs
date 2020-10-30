using System;

namespace MaquinaCafeVirtual
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void ddl_ValorMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaValorInserido(double.Parse(txt_valorInserido.Text), double.Parse(ddl_ValorMoeda.SelectedValue));
        }

        private void AtualizaValorInserido(double valorAtual, double valorSelecionado)
        {
            try
            {
                double valor = 0;

                if (valorSelecionado < 0.1)
                {
                    lbl_feedback.Text = "<p class='alert alert-danger'>Moeda não aceita</p>";
                }
                else
                {
                    lbl_feedback.Text = "";
                    valor = (valorAtual + valorSelecionado);
                    txt_valorInserido.Text = valor.ToString("N2");

                    if (valor < 3.00)
                    {
                        rbl_Produtos.Items[0].Enabled = false;
                        rbl_Produtos.Items[1].Enabled = false;
                        rbl_Produtos.Items[2].Enabled = false;
                    }

                    else if (valor >= 3.00 && valor < 3.50)
                    {
                        rbl_Produtos.Enabled = true;
                        rbl_Produtos.Items[0].Enabled = true;
                        rbl_Produtos.Items[1].Enabled = false;
                        rbl_Produtos.Items[2].Enabled = false;
                    }
                    else if (valor >= 3.50 && valor < 4.00)
                    {
                        rbl_Produtos.Enabled = true;
                        rbl_Produtos.Items[0].Enabled = true;
                        rbl_Produtos.Items[1].Enabled = true;
                        rbl_Produtos.Items[2].Enabled = false;
                    }
                    else
                    {
                        rbl_Produtos.Enabled = true;
                        rbl_Produtos.Items[0].Enabled = true;
                        rbl_Produtos.Items[1].Enabled = true;
                        rbl_Produtos.Items[2].Enabled = true;
                    }
                }
            }
            catch(Exception ex)
            {
                lbl_FeedbackUsuario.Text = "<p class='alert alert-danger'>Houve uma falha ao contabilizar o valor inserido</p>";
            }            
        }

        protected void btn_SolicitaBebida_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbl_Produtos.SelectedIndex > -1)
                {

                    var c = new Calculo();

                    switch (rbl_Produtos.SelectedValue)
                    {
                        case "1":
                            lbl_Troco.Text = c.CalculaTroco(float.Parse("3,00"), float.Parse(txt_valorInserido.Text)).ToString();
                            break;
                        case "2":
                            lbl_Troco.Text = c.CalculaTroco(float.Parse("3,50"), float.Parse(txt_valorInserido.Text)).ToString();
                            break;
                        case "3":
                            lbl_Troco.Text = c.CalculaTroco(float.Parse("4,00"), float.Parse(txt_valorInserido.Text)).ToString();
                            break;
                    }

                    pnl_troco.Visible = true;
                    lbl_FeedbackUsuario.Text = "<p class='alert alert-success'>Retire sua bebida</p>";
                }
                else
                {
                    lbl_FeedbackUsuario.Text = "<p class='alert alert-danger'>Selecione uma bebida</p>";
                }
            }
            catch(Exception ex)
            {
                lbl_FeedbackUsuario.Text = "<p class='alert alert-danger'>Houve uma falha ao preparar o troco.</p>";
            }
            
        }
    }
}