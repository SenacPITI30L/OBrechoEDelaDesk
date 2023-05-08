using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brechó.OBrechoEDelaDBDataSetTableAdapters;

namespace Brechó
{
    class ConsultaEstoque
    {
        private int check;
        private string value;
        private int codBarras;
        private decimal valEst;
        private string msg = ": Por favor, insira apenas caracteres válidos!";
        private string stringTabela;

        public string ConsultaBotao (int check, string value)
        {
            switch (check)
            {
                case 0:
                    MessageBox.Show("Por favor, insira algum dado");
                    break;

                case 1:

                    try
                    {
                        codBarras = int.Parse(value);

                        stringTabela = "this.tabEstoqueTableAdapter.FillByCodBarras(this.oBrechoEDelaDBDataSet.tabEstoque," + codBarras + ");";
                        
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(msg + error.Message, "#### FORMATO INCORRETO ###", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;


                case 2:
                    stringTabela = "this.tabEstoqueTableAdapter.FillByNomeEst(this.oBrechoEDelaDBDataSet.tabEstoque," + value + ");";
                    break;

                case 3:
                    stringTabela = "this.tabEstoqueTableAdapter.FillByTipoEst(this.oBrechoEDelaDBDataSet.tabEstoque," + value + ");";
                    break;

                case 4:

                    stringTabela = "this.tabEstoqueTableAdapter.FillByQuantEst(this.oBrechoEDelaDBDataSet.tabEstoque," + value + ");";
                    break;

                case 5:
                    
                    try
                    {
                    valEst = decimal.Parse(value);

                        stringTabela = "this.tabEstoqueTableAdapter.FillByValEst(this.oBrechoEDelaDBDataSet.tabEstoque," + valEst + ");";
                        
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(msg + error.Message, "#### FORMATO INCORRETO ###", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case 6:
                    stringTabela = "this.tabEstoqueTableAdapter.FillByCodForn(this.oBrechoEDelaDBDataSet.tabEstoque," + value + ");";
                    break;
            }

            return stringTabela;
        }

        #region Check Setters & Getters
        public void setCheckCodigo()
        {
            check = 1;
        }
        public void setCheckNome()
        {
            check = 2;
        }
        public void setCheckTipo()
        {
            check = 3;
        }
        public void setCheckQuant()
        {
            check = 4;
        }
        public void setCheckPreco()
        {
            check = 5;
        }
        public void setCheckForn()
        {
            check = 6;
        }

        public int getCheck()
        {
            return check;
        }
        #endregion

#region Txt Setters & Getters
        public void setValue (string value)
        {
            this.value = value;
        }
        public string getValue()
        {
            return value;
        }
        #endregion
    }
}
