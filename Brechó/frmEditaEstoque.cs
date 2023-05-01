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
    public partial class frmEditaEstoque : Form
    {
        
        public frmEditaEstoque()
        {
            InitializeComponent();
        }

        private void tabEstoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabEstoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oBrechoEDelaDBDataSet);

        }

        private void frmEditaEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oBrechoEDelaDBDataSet.tabEstoque'. Você pode movê-la ou removê-la conforme necessário.
            this.tabEstoqueTableAdapter.Fill(this.oBrechoEDelaDBDataSet.tabEstoque);

        }
    }
}
