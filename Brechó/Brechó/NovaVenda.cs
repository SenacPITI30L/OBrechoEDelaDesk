using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Brechó.Cliente;


namespace Brechó 
{
    internal class NovaVenda
    {
        private Cliente nome;
        private Cliente endereco;
        private Cliente telefone;
        private Cliente email;

        private string formaDePagamento;
        private int Desconto;
        private int dataDeVencimento;
        private int Troco;
        private string totalVenda;
        private int Parcelas;

        public NovaVenda() 
        {
            this.formaDePagamento = formaDePagamento;
            this.Desconto= 0;
            this.dataDeVencimento = dataDeVencimento;
            this.Troco = 0;
            this.totalVenda = totalVenda;
            this.Parcelas = 0;
        }

        public void FormaDePagamento()
        {
            double pagamento;
            pagamento = double.Parse(cbFormadePagamento.Text);
            
        }

    }
    
}
