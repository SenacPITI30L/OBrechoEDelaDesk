using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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
        private double valorItem;
        private string formadePagamento;
        private decimal Parcelas;
        private double Pagos;
        private double Troco;
        private double Desconto;

        public NovaVenda() { 
            this.nome = new Cliente();  
            this.valorItem = valorItem;
            this.formadePagamento = formadePagamento;
            this.Parcelas = Parcelas;
            this.Pagos = Pagos;
            this.Troco = Troco;
            this.Desconto = Desconto;
        }  

        public void setvalorItem(double valorItem)
        {
            this.valorItem = valorItem;
        }
        public void setformadePagamento(string formadePagamento) 
        {
            this.formadePagamento = formadePagamento;
        }
        public void setParcelas(decimal Parcelas)
        {
            this.Parcelas = Parcelas;
        }
        public void setPagos(double Pagos) 
        {
            this.Pagos = Pagos;
        }
        public void setTroco(double Troco) 
        {
            this.Troco = Troco;
        }
        public void setDesconto(double Desconto) 
        {
            this.Desconto = Desconto;
        }

        public double getValorItem() 
        {
            return this.valorItem;  
        }
        public string getformadePagamento() 
        {
            return this.formadePagamento;
        }
        public decimal getParcelas() 
        {
            return this.Parcelas;
        }
        public double getPagos() 
        {
            return this.Pagos;
        }
        public double getTroco()
        {
            return this.Troco;
        }
        public double getDesconto()
        {
            return this.Desconto;
        }
    }
    
}
