using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brechó
{
    public class Botoes
    {
        private double btnNovaVenda;
        private string btnAdicinarEstoque;
        private string btnGerarRelatorio;
        private string btnConsultarEstoque;
        private string btnDespesas;
        private string btnConsignados;
        private string btnRelatoriosAnteriores;
    
        public Botoes(double btnNovaVenda, string btnAdicinarEstoque, string btnGerarRelatorio, string btnConsultarEstoque, string btnDespesas, string btnConsignados, string btnRelatoriosAnteriores)
        {
            this.btnNovaVenda = btnNovaVenda;
            this.btnAdicinarEstoque = btnAdicinarEstoque;
            this.btnGerarRelatorio = btnGerarRelatorio;
            this.btnConsultarEstoque = btnConsultarEstoque;
            this.btnDespesas = btnDespesas;
            this.btnConsignados = btnConsignados;
            this.btnRelatoriosAnteriores = btnRelatoriosAnteriores;
        }
        public void Nova_Venda(double valor) 
        {
            this.btnNovaVenda = valor; 
        }
        //MessageBox.Show("O valor da venda é de " + Nova_Venda.valor);
        
    }
}


    
    

