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
            if (MessageBox.Show("Deseja sair do programa?", "*** FINALIZANDO ***", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnCalculaVenda_Click(object sender, EventArgs e)
        {
            double preco, valdoDesc, totalCompra;
            //preco = double.Parse(txt_Valorpag.Text);

            if (double.TryParse(txt_Valorpag.Text, out preco))
            {
                valdoDesc = double.Parse(txt_valDescontado.Text);
                totalCompra = preco - valdoDesc;
                txt_Compra.Text = totalCompra.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.", "Erro de formato");
            }

            NovaVenda venda = new NovaVenda();

            venda.setformadePagamento(cb_MtPagamento.Text);

            if (venda.getformadePagamento() == "Crédito" ) 
            {
                MessageBox.Show("Você selecionou crédito");
            }
            if (venda.getformadePagamento() == "Débito")
            {
                MessageBox.Show("Você selecionou débito");
            }
            if (venda.getformadePagamento() == "Dinheiro")
            {
                MessageBox.Show("Você selecionou dinheiro");
            }
            if (venda.getformadePagamento() == "Pix")
            {
                MessageBox.Show("Você selecionou pix");
            }

            try
            {
                venda.setvalorItem(double.Parse(txt_Valorpag.Text));
                venda.setformadePagamento(cb_MtPagamento.Text);
                venda.setParcelas(nud_Parcelas.Value); //Aqui ele está procurando a propriedade desse nudparcelas
                venda.setPagos(double.Parse(txt_Pagos.Text));
                venda.setTroco(double.Parse(txt_Troco.Text));
                venda.setDesconto(double.Parse(txt_Desconto.Text));
                venda.settotalValor(txt_Compra.Text);
                venda.getformadePagamento();
            }
            catch (Exception erro) 
            { 
                
            }

            if (MessageBox.Show("Deseja finalizar venda?", "FINALIZANDO VENDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
