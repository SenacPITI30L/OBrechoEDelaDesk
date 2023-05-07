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

        //Concetar o tipo da variavel para double
        private string valorItem;
        private string formadePagemento;
        private int Parcelas;
        private int Pagos;
        private double Troco;
        private double Desconto;

        public NovaVenda() { 
            this.nome = new Cliente();  
            this.valorItem = valorItem;
            this.formadePagemento = formadePagemento;
            this.Parcelas = Parcelas;
            this.Pagos = Pagos;
            this.Troco = Troco;
            this.Desconto = Desconto;
        }  

        public void setvalorItem(string valorItem)
        {
            this.valorItem = valorItem;
        }
    }
    
}
