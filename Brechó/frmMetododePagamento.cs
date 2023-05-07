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
            this.Close();
        }

        private void txt_Valorpag_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Valorpag_KeyPress(object sender, KeyPressEventArgs e)
        {
            

                if (!char.IsDigit(e.KeyChar))

                {

                    e.Handled = true;

                }
        }

        private void txt_Valorpag_Validating(object sender, CancelEventArgs e)
        {
            txt_Valorpag.Text = String.Format("{0:c}", Convert.ToDouble(txt_Valorpag.Text.Replace("R$ ", "")));
        }

        private void txt_Troco_Validating(object sender, CancelEventArgs e)
        {
            txt_Troco.Text = String.Format("{0:c}", Convert.ToDouble(txt_Troco.Text.Replace("R$ ", "")));
        }

        private void nud_Parcelas_Validating(object sender, CancelEventArgs e)
        {
            nud_Parcelas.Text = String.Format("{0:c}", Convert.ToDouble(nud_Parcelas.Text.Replace("R$ ", "")));

        }

        private void nud_Pagos_Validating(object sender, CancelEventArgs e)
        {
            txtPagamento.Text = String.Format("{0:c}", Convert.ToDouble(txtPagamento.Text.Replace("R$ ", "")));

        }

        private void btnCalculaVenda_Click(object sender, EventArgs e)
        {
            NovaVenda venda = new NovaVenda();

            venda.setvalorItem(txt_Valorpag.Text);

            try
            {

            }
            catch 
            { 
            
            }
        }
    }
}
