namespace Brechó
{
    partial class frmMetododePagamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculaVenda = new System.Windows.Forms.Button();
            this.nud_Parcelas = new System.Windows.Forms.NumericUpDown();
            this.txt_Valorpag = new System.Windows.Forms.TextBox();
            this.txt_Troco = new System.Windows.Forms.TextBox();
            this.btnCancelaVenda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.cb_MtPagamento = new System.Windows.Forms.ComboBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Parcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Método de pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parcelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pagos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Troco";
            // 
            // btnCalculaVenda
            // 
            this.btnCalculaVenda.Location = new System.Drawing.Point(432, 340);
            this.btnCalculaVenda.Name = "btnCalculaVenda";
            this.btnCalculaVenda.Size = new System.Drawing.Size(155, 50);
            this.btnCalculaVenda.TabIndex = 10;
            this.btnCalculaVenda.Text = "Calcular";
            this.btnCalculaVenda.UseVisualStyleBackColor = true;
            this.btnCalculaVenda.Click += new System.EventHandler(this.btnCalculaVenda_Click);
            // 
            // nud_Parcelas
            // 
            this.nud_Parcelas.Location = new System.Drawing.Point(167, 196);
            this.nud_Parcelas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Parcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Parcelas.Name = "nud_Parcelas";
            this.nud_Parcelas.Size = new System.Drawing.Size(195, 20);
            this.nud_Parcelas.TabIndex = 11;
            this.nud_Parcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Parcelas.Validating += new System.ComponentModel.CancelEventHandler(this.nud_Parcelas_Validating);
            // 
            // txt_Valorpag
            // 
            this.txt_Valorpag.Location = new System.Drawing.Point(134, 61);
            this.txt_Valorpag.Name = "txt_Valorpag";
            this.txt_Valorpag.Size = new System.Drawing.Size(157, 20);
            this.txt_Valorpag.TabIndex = 15;
            this.txt_Valorpag.TextChanged += new System.EventHandler(this.txt_Valorpag_TextChanged);
            this.txt_Valorpag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valorpag_KeyPress);
            this.txt_Valorpag.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Valorpag_Validating);
            // 
            // txt_Troco
            // 
            this.txt_Troco.Location = new System.Drawing.Point(134, 321);
            this.txt_Troco.Name = "txt_Troco";
            this.txt_Troco.Size = new System.Drawing.Size(228, 20);
            this.txt_Troco.TabIndex = 16;
            this.txt_Troco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Troco.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Troco_Validating);
            // 
            // btnCancelaVenda
            // 
            this.btnCancelaVenda.Location = new System.Drawing.Point(593, 340);
            this.btnCancelaVenda.Name = "btnCancelaVenda";
            this.btnCancelaVenda.Size = new System.Drawing.Size(155, 50);
            this.btnCancelaVenda.TabIndex = 17;
            this.btnCancelaVenda.Text = "Cancelar Venda";
            this.btnCancelaVenda.UseVisualStyleBackColor = true;
            this.btnCancelaVenda.Click += new System.EventHandler(this.btnCancelaVenda_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(532, 198);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(171, 20);
            this.txtDesconto.TabIndex = 23;
            // 
            // cb_MtPagamento
            // 
            this.cb_MtPagamento.FormattingEnabled = true;
            this.cb_MtPagamento.Items.AddRange(new object[] {
            "Crédifo",
            "Débito",
            "Dinheiro",
            "Pix"});
            this.cb_MtPagamento.Location = new System.Drawing.Point(259, 118);
            this.cb_MtPagamento.Name = "cb_MtPagamento";
            this.cb_MtPagamento.Size = new System.Drawing.Size(140, 21);
            this.cb_MtPagamento.TabIndex = 24;
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(139, 258);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(171, 20);
            this.txtPagamento.TabIndex = 25;
            // 
            // frmMetododePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.cb_MtPagamento);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelaVenda);
            this.Controls.Add(this.txt_Troco);
            this.Controls.Add(this.txt_Valorpag);
            this.Controls.Add(this.nud_Parcelas);
            this.Controls.Add(this.btnCalculaVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMetododePagamento";
            this.Text = "Método de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Parcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculaVenda;
        private System.Windows.Forms.NumericUpDown nud_Parcelas;
        private System.Windows.Forms.TextBox txt_Valorpag;
        private System.Windows.Forms.TextBox txt_Troco;
        private System.Windows.Forms.Button btnCancelaVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.ComboBox cb_MtPagamento;
        private System.Windows.Forms.TextBox txtPagamento;
    }
}