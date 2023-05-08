using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Brechó
{
    public partial class frmConsultaEstoque : Form
    {
        string check = "default";
        string msg = ": Por favor, não utilize letras!";

        public frmConsultaEstoque()
        {
            InitializeComponent();
        }

        private void tabEstoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabEstoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oBrechoEDelaDBDataSet);

        }

        private void frmConsultaEstoque_Load(object sender, EventArgs e)
        {
        }

#region Setando o estado dos textbox ao clicar
        private void txtCodigo_Click_1(object sender, EventArgs e)
        {
            Default();
            txtCodigo.ReadOnly = false;
            check = default;
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            Default();
            txtNome.ReadOnly = false;
            check = default;
        }

        private void txtTipo_Click(object sender, EventArgs e)
        {
            Default();
            txtTipo.ReadOnly = false;
            check = default;
        }

        private void txtForn_Click(object sender, EventArgs e)
        {
            Default();
            txtForn.ReadOnly = false;
            check = default;
        }

        private void txtQuant_Click(object sender, EventArgs e)
        {
            Default();
            txtQuant.ReadOnly = false;
            check = default;
        }

        private void txtPreco_Click(object sender, EventArgs e)
        {
            Default();
            txtPreco.ReadOnly = false;
            check = default;
        }
        #endregion

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            check = "codigo";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            check = "nome";
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            check = "tipo";
        }

        private void txtForn_TextChanged(object sender, EventArgs e)
        {
            check = "forn";
        }

        private void txtQuant_TextChanged(object sender, EventArgs e)
        {
            check = "quant";
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            check = "preco";
        }


        //Botão de consulta. Com Try...Catches para corrigir erros de caracteres errado
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if(check == "default")
            {
                MessageBox.Show("Insira algum dado");
            }
            else if (check == "codigo")
            {
                string codigo = txtCodigo.Text;
                int codBarras = int.Parse(codigo);

                this.tabEstoqueTableAdapter.FillByCodBarras(this.oBrechoEDelaDBDataSet.tabEstoque, codBarras);
            }
            else if (check == "nome")
            {
                string nomeEst = txtNome.Text;

                this.tabEstoqueTableAdapter.FillByNomeEst(this.oBrechoEDelaDBDataSet.tabEstoque, nomeEst);
            }
            else if (check == "tipo")
            {
                string tipoEst = txtTipo.Text;

                this.tabEstoqueTableAdapter.FillByTipoEst(this.oBrechoEDelaDBDataSet.tabEstoque, tipoEst);

            }
            else if (check == "quant")
            {
                try 
                {
                    string quantEst = txtQuant.Text;

                    this.tabEstoqueTableAdapter.FillByQuantEst(this.oBrechoEDelaDBDataSet.tabEstoque, quantEst);
                }
                catch (Exception error)
                {
                    string erro = error.Message;
                    if (MessageBox.Show(msg + erro, "#### ERRO ####", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        txtQuant.Text = string.Empty;
                        txtQuant.Focus();
                    }
                }
                
            }
            else if (check == "preco")
            {
                try { 
                    string preco = txtPreco.Text;
                    decimal valEst = decimal.Parse(preco);

                    this.tabEstoqueTableAdapter.FillByValEst(this.oBrechoEDelaDBDataSet.tabEstoque, valEst);
                }
                catch (Exception error)
                {
                    string erro = error.Message;
                    if (MessageBox.Show(erro + msg, "#### ERRO ####", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        txtPreco.Text = string.Empty;
                        txtPreco.Focus();
                    }
                    
                }
            }
            else if (check == "forn")
            {
                string codForn = txtForn.Text;

                this.tabEstoqueTableAdapter.FillByCodForn(this.oBrechoEDelaDBDataSet.tabEstoque, codForn);
            }
        }

#region Método Default
        private void Default()
        {
            //Para resetar os estados das textbox
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtForn.ReadOnly = true;
            txtPreco.ReadOnly = true;
            txtQuant.ReadOnly = true;
            txtTipo.ReadOnly = true;

            //Para resetar o texto das textbox
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtForn.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQuant.Text = string.Empty;
            txtTipo.Text = string.Empty;
        }
#endregion
    }
}
