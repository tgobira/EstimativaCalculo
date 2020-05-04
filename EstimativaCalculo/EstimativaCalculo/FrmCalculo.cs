using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstimativaCalculo
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        public static decimal CalculaVlrEstimadoFaixa(decimal medida, decimal vlrFaixa)
        {
            var vlr = Convert.ToDecimal(0.0);

            vlr = medida * vlrFaixa;

            return Decimal.Round(vlr, 2);
        }

        private void CalcularVlrFaixas(object sender, EventArgs e)
        {
            #region Limpa os Labels utilizados
            this.lbMedidaFaixa1.Text = "-";
            this.lbMedidaFaixa2.Text = "-";
            this.lbMedidaFaixa3.Text = "-";
            this.lbMedidaFaixa4.Text = "-";
            this.lbMedidaFaixa5.Text = "-";
            this.lbMedidaFaixa6.Text = "-";
            this.lbMedidaFaixa7.Text = "-";

            this.lbVlrFaixa1.Text = "-";
            this.lbVlrFaixa2.Text = "-";
            this.lbVlrFaixa3.Text = "-";
            this.lbVlrFaixa4.Text = "-";
            this.lbVlrFaixa5.Text = "-";
            this.lbVlrFaixa6.Text = "-";
            this.lbVlrFaixa7.Text = "-";
            #endregion

            var medida = Convert.ToDecimal(0.0);
            var vlrMedida = Convert.ToDecimal(0.0);
            var vlrEstimado = Convert.ToDecimal(0.0);

            bool validacao = decimal.TryParse(this.txtConsumoMensal.Text.Replace(".",","), out medida);

            if (validacao)
            {
                #region Preenchimento das Medidas por faixa
                if (medida >= 3)
                {
                    if (medida >= 6)
                    {
                        if (medida >= 10)
                        {
                            if (medida >= 15)
                            {
                                if (medida >= 20)
                                {
                                    if (medida >= 40)
                                    {
                                        this.lbMedidaFaixa1.Text = "3";
                                        this.lbMedidaFaixa2.Text = "3";
                                        this.lbMedidaFaixa3.Text = "4";
                                        this.lbMedidaFaixa4.Text = "5";
                                        this.lbMedidaFaixa5.Text = "5";
                                        this.lbMedidaFaixa6.Text = "20";
                                        this.lbMedidaFaixa7.Text = (medida - 40).ToString();
                                    }
                                    else
                                    {
                                        this.lbMedidaFaixa1.Text = "3";
                                        this.lbMedidaFaixa2.Text = "3";
                                        this.lbMedidaFaixa3.Text = "4";
                                        this.lbMedidaFaixa4.Text = "5";
                                        this.lbMedidaFaixa5.Text = "5";
                                        this.lbMedidaFaixa6.Text = (medida - 20).ToString();
                                    }
                                }
                                else
                                {
                                    this.lbMedidaFaixa1.Text = "3";
                                    this.lbMedidaFaixa2.Text = "3";
                                    this.lbMedidaFaixa3.Text = "4";
                                    this.lbMedidaFaixa4.Text = "5";
                                    this.lbMedidaFaixa5.Text = (medida - 15).ToString();
                                }
                            }
                            else
                            {
                                this.lbMedidaFaixa1.Text = "3";
                                this.lbMedidaFaixa2.Text = "3";
                                this.lbMedidaFaixa3.Text = "4";
                                this.lbMedidaFaixa4.Text = (medida - 10).ToString();
                            }
                        }
                        else
                        {
                            this.lbMedidaFaixa1.Text = "3";
                            this.lbMedidaFaixa2.Text = "3";
                            this.lbMedidaFaixa3.Text = (medida - 6).ToString();
                        }
                    }
                    else
                    {
                        this.lbMedidaFaixa1.Text = "3";
                        this.lbMedidaFaixa2.Text = (medida - 3).ToString();
                    }
                }
                else
                {
                    this.lbMedidaFaixa1.Text = this.txtConsumoMensal.Text;
                }
                #endregion

                #region Preenchimento dos Valores Estimados por Faixa
                if (decimal.TryParse(this.lbMedidaFaixa1.Text, out medida))
                {
                    vlrMedida = Convert.ToDecimal(0.47);

                    lbVlrFaixa1.Text = CalculaVlrEstimadoFaixa(medida, vlrMedida).ToString();
                }
                if (decimal.TryParse(this.lbMedidaFaixa2.Text, out medida))
                {
                    vlrMedida = Convert.ToDecimal(0.742);

                    lbVlrFaixa2.Text = CalculaVlrEstimadoFaixa(medida, vlrMedida).ToString();
                }
                if (decimal.TryParse(this.lbMedidaFaixa3.Text, out medida))
                {
                    vlrMedida = Convert.ToDecimal(1.767);

                    lbVlrFaixa3.Text = CalculaVlrEstimadoFaixa(medida, vlrMedida).ToString();
                }
                if (decimal.TryParse(this.lbMedidaFaixa4.Text, out medida))
                {
                    vlrMedida = Convert.ToDecimal(3.385);

                    lbVlrFaixa4.Text = CalculaVlrEstimadoFaixa(medida, vlrMedida).ToString();
                }
                if (decimal.TryParse(this.lbMedidaFaixa5.Text, out medida))
                {
                    vlrMedida = Convert.ToDecimal(4.135);

                    lbVlrFaixa5.Text = CalculaVlrEstimadoFaixa(medida, vlrMedida).ToString();
                }
                if (decimal.TryParse(this.lbMedidaFaixa6.Text, out medida))
                {
                    vlrMedida = Convert.ToDecimal(4.791);

                    lbVlrFaixa6.Text = CalculaVlrEstimadoFaixa(medida, vlrMedida).ToString();
                }
                if (decimal.TryParse(this.lbMedidaFaixa7.Text, out medida))
                {
                    vlrMedida = Convert.ToDecimal(7.298);

                    lbVlrFaixa7.Text = CalculaVlrEstimadoFaixa(medida, vlrMedida).ToString();
                }
                #endregion

                medida = 0;

                #region Calcula Valor Estimado Final
                if (decimal.TryParse(this.lbVlrFaixa1.Text, out medida))
                {
                    vlrEstimado += medida;
                }
                if (decimal.TryParse(this.lbVlrFaixa2.Text, out medida))
                {
                    vlrEstimado += medida;
                }
                if (decimal.TryParse(this.lbVlrFaixa3.Text, out medida))
                {
                    vlrEstimado += medida;
                }
                if (decimal.TryParse(this.lbVlrFaixa4.Text, out medida))
                {
                    vlrEstimado += medida;
                }
                if (decimal.TryParse(this.lbVlrFaixa5.Text, out medida))
                {
                    vlrEstimado += medida;
                }
                if (decimal.TryParse(this.lbVlrFaixa6.Text, out medida))
                {
                    vlrEstimado += medida;
                }
                if (decimal.TryParse(this.lbVlrFaixa7.Text, out medida))
                {
                    vlrEstimado += medida;
                }
                #endregion

                tbVlrConsumoEstimado.Text = "R$ " + vlrEstimado.ToString("#.##");
            }
            else
            {
                MessageBox.Show("O campo de medida deve conter apenas números");
            }
        }
    }
}
