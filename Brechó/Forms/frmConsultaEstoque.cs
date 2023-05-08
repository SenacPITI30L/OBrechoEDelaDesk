using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;
using static System.Net.Mime.MediaTypeNames;

namespace Brechó
{
    public partial class frmConsultaEstoque : Form 
    {
        ConsultaEstoque consulta = new ConsultaEstoque();
        string stringTabela;
        int checkout;
        string value;
       

        public frmConsultaEstoque()
        {
            InitializeComponent();
        }

        private void tabEstoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabEstoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oBrechoEDelaDBDataSet);

        }

        private void frmConsultaEstoque_Load(object sender, EventArgs e)
        {
        }

#region Setando o estado dos textbox ao clicar
        private void txtCodigo_Click_1(object sender, EventArgs e)
        {
            Default();
            txtCodigo.ReadOnly = false;
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            Default();
            txtNome.ReadOnly = false;
        }

        private void txtTipo_Click(object sender, EventArgs e)
        {
            Default();
            txtTipo.ReadOnly = false;
        }

        private void txtForn_Click(object sender, EventArgs e)
        {
            Default();
            txtForn.ReadOnly = false;
        }

        private void txtQuant_Click(object sender, EventArgs e)
        {
            Default();
            txtQuant.ReadOnly = false;
        }

        private void txtPreco_Click(object sender, EventArgs e)
        {
            Default();
            txtPreco.ReadOnly = false;
        }
        #endregion

#region setando o check e os values
        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            consulta.setCheckCodigo();
            consulta.setValue(txtCodigo.Text);
            value = consulta.getValue();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            consulta.setCheckNome();
            consulta.setValue(txtNome.Text);
            value = consulta.getValue();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            consulta.setCheckTipo();
            consulta.setValue(txtTipo.Text);
            value = consulta.getValue();
        }

        private void txtForn_TextChanged(object sender, EventArgs e)
        {
            consulta.setCheckForn();
            consulta.setValue(txtForn.Text);
            value = consulta.getValue();
        }

        private void txtQuant_TextChanged(object sender, EventArgs e)
        {
            consulta.setCheckQuant();
            consulta.setValue(txtQuant.Text);
            value = consulta.getValue();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            consulta.setCheckPreco();
            consulta.setValue(txtPreco.Text);
            value = consulta.getValue();
        }
#endregion

        //Botão de consulta. Com Try...Catches para corrigir erros de caracteres errado
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            checkout = consulta.getCheck();
            stringTabela = consulta.ConsultaBotao(checkout, value).ToString();
            Eval(stringTabela);
                
        }

#region Método Default
    private void Default()
        {
            //Para resetar os estados das textbox
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtForn.ReadOnly = true;
            txtPreco.ReadOnly = true;
            txtQuant.ReadOnly = true;
            txtTipo.ReadOnly = true;

            //Para resetar o texto das textbox
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtForn.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQuant.Text = string.Empty;
            txtTipo.Text = string.Empty;
        }
        #endregion
#region Método eval
        // Eval > Evaluates C# sourcelanguage
        public static object Eval(string sCSCode)
        {

            CSharpCodeProvider c = new CSharpCodeProvider();
            ICodeCompiler icc = c.CreateCompiler();
            CompilerParameters cp = new CompilerParameters();

            cp.ReferencedAssemblies.Add("system.dll");
            cp.ReferencedAssemblies.Add("system.xml.dll");
            cp.ReferencedAssemblies.Add("system.data.dll");
            cp.ReferencedAssemblies.Add("system.windows.forms.dll");
            cp.ReferencedAssemblies.Add("system.drawing.dll");

            cp.CompilerOptions = "/t:library";
            cp.GenerateInMemory = true;

            StringBuilder sb = new StringBuilder("");
            sb.Append("using System;\n");
            sb.Append("using System.Xml;\n");
            sb.Append("using System.Data;\n");
            sb.Append("using System.Data.SqlClient;\n");
            sb.Append("using System.Windows.Forms;\n");
            sb.Append("using System.Drawing;\n");

            sb.Append("namespace CSCodeEvaler{ \n");
            sb.Append("public class CSCodeEvaler{ \n");
            sb.Append("public object EvalCode(){\n");
            sb.Append("return " + sCSCode + "; \n");
            sb.Append("} \n");
            sb.Append("} \n");
            sb.Append("}\n");

            CompilerResults cr = icc.CompileAssemblyFromSource(cp, sb.ToString());
            if (cr.Errors.Count > 0)
            {
                MessageBox.Show("ERROR: " + cr.Errors[0].ErrorText,
                   "Error evaluating cs code", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return null;
            }

            System.Reflection.Assembly a = cr.CompiledAssembly;
            object o = a.CreateInstance("CSCodeEvaler.CSCodeEvaler");

            Type t = o.GetType();
            MethodInfo mi = t.GetMethod("EvalCode");

            object s = mi.Invoke(o, null);
            return s;

        }
        #endregion
    }
}
