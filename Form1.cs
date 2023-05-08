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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Despesas do mês"].Points.AddXY("Roupas", 1500);
            this.chart1.Series["Valores"].Points.AddXY("Roupas", 1500);

            this.chart1.Series["Despesas do mês"].Points.AddXY("Bolsas", 1000);
            this.chart1.Series["Valores"].Points.AddXY("Bolsas", 1000);

            this.chart1.Series["Despesas do mês"].Points.AddXY("Bijuterias", 530);
            this.chart1.Series["Valores"].Points.AddXY("Bijuterias", 530);

            this.chart1.Series["Despesas do mês"].Points.AddXY("Sapatos", 1700);// aqui teremos que mudar os valores dos eixos
            this.chart1.Series["Valores"].Points.AddXY("Sapatos", 1700);


        }

        private void txtNovaVenda_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                MessageBox.Show(txtNovaVenda.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
