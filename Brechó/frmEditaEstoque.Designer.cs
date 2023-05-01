namespace Brechó
{
    partial class frmEditaEstoque
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oBrechoEDelaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEstoqueDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tabEstoqueDataGridView.Location = new System.Drawing.Point(286, -1);
            this.tabEstoqueDataGridView.Name = "tabEstoqueDataGridView";
            this.tabEstoqueDataGridView.ReadOnly = true;
            this.tabEstoqueDataGridView.Size = new System.Drawing.Size(516, 449);
            this.tabEstoqueDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codBarras";
            this.dataGridViewTextBoxColumn1.HeaderText = "codBarras";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeEst";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeEst";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipoEst";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipoEst";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codForn";
            this.dataGridViewTextBoxColumn4.HeaderText = "codForn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantEst";
            this.dataGridViewTextBoxColumn5.HeaderText = "quantEst";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valEst";
            this.dataGridViewTextBoxColumn6.HeaderText = "valEst";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "statusEst";
            this.dataGridViewTextBoxColumn7.HeaderText = "statusEst";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEditaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabEstoqueDataGridView);
            this.Name = "frmEditaEstoque";
            this.Text = "frmEditaEstoque";
            this.Load += new System.EventHandler(this.frmEditaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oBrechoEDelaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEstoqueDataGridView)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
    }
}