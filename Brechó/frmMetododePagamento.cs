using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Brechó
{
    public partial class frmMetododePagamento : Form
    {
        public frmMetododePagamento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelaVenda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?", "*** FINALIZADO ***", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void txt_Troco_Validating(object sender, CancelEventArgs e)
        {
            txt_Troco.Text = String.Format("{0:c}", Convert.ToDouble(txt_Troco.Text.Replace("R$ ", "")));
        }

        private void nud_Parcelas_Validating(object sender, CancelEventArgs e)
        {
            nud_Parcelas.Text = String.Format("{0:c}", Convert.ToDouble(nud_Parcelas.Text.Replace("R$ ", "")));

        }
        private void btnCalculaVenda_Click(object sender, EventArgs e)
        {
            NovaVenda venda = new NovaVenda();

            try
            {
            venda.setvalorItem(double.Parse(txt_Valorpag.Text));
            venda.setformadePagamento(cb_MtPagamento.Text);
            venda.setParcelas(nud_Parcelas.Value); //Aqui ele está procurando a propriedade desse nudparcelas
            venda.setPagos(double.Parse(txt_Pagos.Text));
            venda.setTroco(double.Parse(txt_Troco.Text));
            venda.setDesconto(double.Parse(txt_Desconto.Text));


            }
            catch (Exception erro) 
            { 
            
            }

            if (MessageBox.Show("Deseja efetuar venda?", "FINALIZANDO VENDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAplicarDesconto_Click (object sender, EventArgs e) 
        {
            try 
            {
                double preco, desconto, descontofinal, totalCompra, valdoDesc;

                preco = double.Parse(txt_Valorpag.Text);
                desconto = double.Parse(txt_Desconto.Text);
                

                descontofinal = preco * desconto / 100;
                txt_valDescontado.Text = descontofinal.ToString();

                valdoDesc = double.Parse(txt_valDescontado.Text);
                totalCompra = preco - valdoDesc;
                txt_Compra.Text = totalCompra.ToString(); 
            }
            catch(Exception ex) 
            {
                MessageBox.Show("O valor inserido não é válido");
            }
            finally
            {
                MessageBox.Show("Desconto finalizado");
            }

        }

     
    }
}
