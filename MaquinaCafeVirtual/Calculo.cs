using System;
using System.Text;

namespace MaquinaCafeVirtual
{
    public class Calculo
    {   
        public StringBuilder CalculaTroco(float ValorVenda, float ValorDepositado)
        {
            StringBuilder RetornoFunc = new StringBuilder();
            try

            {

                float[] moedas = { 1, 0.50f, 0.25f, 0.10f, 0.01f };
                var troco = Math.Round(ValorDepositado - ValorVenda, 2);

                RetornoFunc.Append("Troco = R$ " + troco + "<br/>");

                foreach (var moeda in moedas)
                {
                    var qtdMoedas = (int)(troco / moeda);
                    if (qtdMoedas > 0)
                    {
                        troco -= Math.Round(qtdMoedas * moeda, 2);
                        RetornoFunc.Append($"Devolver ({qtdMoedas} - Moeda de {moeda.ToString("N2")})" + "<br/>");
                    }
                }
            }
            catch(Exception ex)
            {
                RetornoFunc.Append("<p class='alert alert-danger'>Houve ums falha ao calcular o troco</p>");
            }
            

            return RetornoFunc;
        }
    }
}