namespace Brechó
{
    partial class frmConsultaEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codBarrasLabel;
            System.Windows.Forms.Label nomeEstLabel;
            System.Windows.Forms.Label tipoEstLabel;
            System.Windows.Forms.Label codFornLabel;
            System.Windows.Forms.Label quantEstLabel;
            System.Windows.Forms.Label valEstLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEstoque));
            this.oBrechoEDelaDBDataSet = new Brechó.OBrechoEDelaDBDataSet();
            this.tabEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabEstoqueTableAdapter = new Brechó.OBrechoEDelaDBDataSetTableAdapters.tabEstoqueTableAdapter();
            this.tableAdapterManager = new Brechó.OBrechoEDelaDBDataSetTableAdapters.TableAdapterManager();
            this.tabEstoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtForn = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            codBarrasLabel = new System.Windows.Forms.Label();
            nomeEstLabel = new System.Windows.Forms.Label();
            tipoEstLabel = new System.Windows.Forms.Label();
            codFornLabel = new System.Windows.Forms.Label();
            quantEstLabel = new System.Windows.Forms.Label();
            valEstLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oBrechoEDelaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEstoqueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codBarrasLabel
            // 
            codBarrasLabel.AutoSize = true;
            codBarrasLabel.Location = new System.Drawing.Point(28, 137);
            codBarrasLabel.Name = "codBarrasLabel";
            codBarrasLabel.Size = new System.Drawing.Size(40, 13);
            codBarrasLabel.TabIndex = 2;
            codBarrasLabel.Text = "Código";
            // 
            // nomeEstLabel
            // 
            nomeEstLabel.AutoSize = true;
            nomeEstLabel.Location = new System.Drawing.Point(28, 163);
            nomeEstLabel.Name = "nomeEstLabel";
            nomeEstLabel.Size = new System.Drawing.Size(35, 13);
            nomeEstLabel.TabIndex = 4;
            nomeEstLabel.Text = "Nome";
            // 
            // tipoEstLabel
            // 
            tipoEstLabel.AutoSize = true;
            tipoEstLabel.Location = new System.Drawing.Point(28, 189);
            tipoEstLabel.Name = "tipoEstLabel";
            tipoEstLabel.Size = new System.Drawing.Size(28, 13);
            tipoEstLabel.TabIndex = 6;
            tipoEstLabel.Text = "Tipo";
            // 
            // codFornLabel
            // 
            codFornLabel.AutoSize = true;
            codFornLabel.Location = new System.Drawing.Point(28, 215);
            codFornLabel.Name = "codFornLabel";
            codFornLabel.Size = new System.Drawing.Size(61, 13);
            codFornLabel.TabIndex = 8;
            codFornLabel.Text = "Fornecedor";
            // 
            // quantEstLabel
            // 
            quantEstLabel.AutoSize = true;
            quantEstLabel.Location = new System.Drawing.Point(28, 241);
            quantEstLabel.Name = "quantEstLabel";
            quantEstLabel.Size = new System.Drawing.Size(62, 13);
            quantEstLabel.TabIndex = 10;
            quantEstLabel.Text = "Quantidade";
            // 
            // valEstLabel
            // 
            valEstLabel.AutoSize = true;
            valEstLabel.Location = new System.Drawing.Point(28, 267);
            valEstLabel.Name = "valEstLabel";
            valEstLabel.Size = new System.Drawing.Size(35, 13);
            valEstLabel.TabIndex = 12;
            valEstLabel.Text = "Preço";
            // 
            // oBrechoEDelaDBDataSet
            // 
            this.oBrechoEDelaDBDataSet.DataSetName = "OBrechoEDelaDBDataSet";
            this.oBrechoEDelaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabEstoqueBindingSource
            // 
            this.tabEstoqueBindingSource.DataMember = "tabEstoque";
            this.tabEstoqueBindingSource.DataSource = this.oBrechoEDelaDBDataSet;
            // 
            // tabEstoqueTableAdapter
            // 
            this.tabEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabDespesasTableAdapter = null;
            this.tableAdapterManager.tabEstoqueTableAdapter = this.tabEstoqueTableAdapter;
            this.tableAdapterManager.tabFornecedorTableAdapter = null;
            this.tableAdapterManager.tabLoginTableAdapter = null;
            this.tableAdapterManager.tabVendasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Brechó.OBrechoEDelaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabEstoqueDataGridView
            // 
            this.tabEstoqueDataGridView.AutoGenerateColumns = false;
            this.tabEstoqueDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabEstoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabEstoqueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tabEstoqueDataGridView.DataSource = this.tabEstoqueBindingSource;
            this.tabEstoqueDataGridView.Location = new System.Drawing.Point(238, -1);
            this.tabEstoqueDataGridView.Name = "tabEstoqueDataGridView";
            this.tabEstoqueDataGridView.RowTemplate.ReadOnly = true;
            this.tabEstoqueDataGridView.Size = new System.Drawing.Size(526, 371);
            this.tabEstoqueDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codBarras";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeEst";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipoEst";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codForn";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantEst";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valEst";
            this.dataGridViewTextBoxColumn6.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "statusEst";
            this.dataGridViewTextBoxColumn7.HeaderText = "statusEst";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEstoqueBindingSource, "nomeEst", true));
            this.txtNome.Location = new System.Drawing.Point(105, 160);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 16;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEstoqueBindingSource, "tipoEst", true));
            this.txtTipo.Location = new System.Drawing.Point(105, 186);
            this.txtTipo.MaxLength = 100;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 17;
            this.txtTipo.Click += new System.EventHandler(this.txtTipo_Click);
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtForn
            // 
            this.txtForn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEstoqueBindingSource, "codForn", true));
            this.txtForn.Location = new System.Drawing.Point(105, 212);
            this.txtForn.MaxLength = 10;
            this.txtForn.Name = "txtForn";
            this.txtForn.ReadOnly = true;
            this.txtForn.Size = new System.Drawing.Size(100, 20);
            this.txtForn.TabIndex = 18;
            this.txtForn.Click += new System.EventHandler(this.txtForn_Click);
            this.txtForn.TextChanged += new System.EventHandler(this.txtForn_TextChanged);
            // 
            // txtQuant
            // 
            this.txtQuant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEstoqueBindingSource, "quantEst", true));
            this.txtQuant.Location = new System.Drawing.Point(105, 238);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.ReadOnly = true;
            this.txtQuant.Size = new System.Drawing.Size(100, 20);
            this.txtQuant.TabIndex = 19;
            this.txtQuant.Click += new System.EventHandler(this.txtQuant_Click);
            this.txtQuant.TextChanged += new System.EventHandler(this.txtQuant_TextChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEstoqueBindingSource, "valEst", true));
            this.txtPreco.Location = new System.Drawing.Point(105, 264);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 20;
            this.txtPreco.Click += new System.EventHandler(this.txtPreco_Click);
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 99);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(71, 317);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 27;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEstoqueBindingSource, "codBarras", true));
            this.txtCodigo.Location = new System.Drawing.Point(105, 134);
            this.txtCodigo.Mask = "00000";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 28;
            this.txtCodigo.Click += new System.EventHandler(this.txtCodigo_Click_1);
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged_1);
            // 
            // frmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 390);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtForn);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(codBarrasLabel);
            this.Controls.Add(nomeEstLabel);
            this.Controls.Add(tipoEstLabel);
            this.Controls.Add(codFornLabel);
            this.Controls.Add(quantEstLabel);
            this.Controls.Add(valEstLabel);
            this.Controls.Add(this.tabEstoqueDataGridView);
            this.Name = "frmConsultaEstoque";
            this.Text = "frmConsultaEstoque";
            this.Load += new System.EventHandler(this.frmConsultaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oBrechoEDelaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEstoqueDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OBrechoEDelaDBDataSet oBrechoEDelaDBDataSet;
        private System.Windows.Forms.BindingSource tabEstoqueBindingSource;
        private OBrechoEDelaDBDataSetTableAdapters.tabEstoqueTableAdapter tabEstoqueTableAdapter;
        private OBrechoEDelaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tabEstoqueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtForn;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
    }
}