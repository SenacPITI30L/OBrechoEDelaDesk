using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brechó
{
    internal class classButtonCheck : frmConsultaEstoque
    {
        private int codBarras;
        private decimal valEst;

        public void ConsultaClick(int check, string value)
        {
            switch (check)
            {
                case 0:
                    MessageBox.Show("Por favor, insira algum dado");
                    break;

                case 1:
                    codBarras = int.Parse(value);

                    this.tabEstoqueTableAdapter.FillByCodBarras(this.oBrechoEDelaDBDataSet.tabEstoque, codBarras);
                    break;

                case 2:
                    this.tabEstoqueTableAdapter.FillByNomeEst(this.oBrechoEDelaDBDataSet.tabEstoque, value);
                    break;

                case 3:
                    this.tabEstoqueTableAdapter.FillByTipoEst(this.oBrechoEDelaDBDataSet.tabEstoque, value);
                    break;

                case 4:
                    this.tabEstoqueTableAdapter.FillByQuantEst(this.oBrechoEDelaDBDataSet.tabEstoque, value);
                    break;

                case 5:
                    valEst = decimal.Parse(value);

                    this.tabEstoqueTableAdapter.FillByValEst(this.oBrechoEDelaDBDataSet.tabEstoque, valEst);
                    break;

                case 6:
                    this.tabEstoqueTableAdapter.FillByCodForn(this.oBrechoEDelaDBDataSet.tabEstoque, value);
                    break;
            }
        }
    }
}
