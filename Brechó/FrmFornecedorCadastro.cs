﻿using System;
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
    public partial class FrmFornecedorCadastro : Form
    {
        public FrmFornecedorCadastro()
        {
            InitializeComponent();
        }

        private void btncdc_Cancela_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

       
    }
}
