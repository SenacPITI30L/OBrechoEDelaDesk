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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            frmInico inicio = new frmInico();

            if (txt_Login.Text == "admin" && txt_Senha.Text == "admin") 
            {
                inicio.ShowDialog(); 
            }
            else 
            {
                MessageBox.Show("Login ou senha estão incorretos");
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario cad = new FrmCadastroUsuario();
            cad.ShowDialog();
        }
    }
}
