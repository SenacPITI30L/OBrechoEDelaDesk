﻿namespace Brechó
{
    partial class frmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnConsultarEstoque = new System.Windows.Forms.Button();
            this.btnDespesas = new System.Windows.Forms.Button();
            this.btnConsignados = new System.Windows.Forms.Button();
            this.btnRelatoriosAnteriores = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnAdicionarEstoque = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtNovaVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarEstoque
            // 
            this.btnConsultarEstoque.Location = new System.Drawing.Point(12, 29);
            this.btnConsultarEstoque.Name = "btnConsultarEstoque";
            this.btnConsultarEstoque.Size = new System.Drawing.Size(284, 71);
            this.btnConsultarEstoque.TabIndex = 0;
            this.btnConsultarEstoque.Text = "Consultar estoque";
            this.btnConsultarEstoque.UseVisualStyleBackColor = true;
            // 
            // btnDespesas
            // 
            this.btnDespesas.Location = new System.Drawing.Point(12, 121);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Size = new System.Drawing.Size(284, 72);
            this.btnDespesas.TabIndex = 1;
            this.btnDespesas.Text = "Despesas";
            this.btnDespesas.UseVisualStyleBackColor = true;
            // 
            // btnConsignados
            // 
            this.btnConsignados.Location = new System.Drawing.Point(12, 214);
            this.btnConsignados.Name = "btnConsignados";
            this.btnConsignados.Size = new System.Drawing.Size(284, 70);
            this.btnConsignados.TabIndex = 2;
            this.btnConsignados.Text = "Consignados";
            this.btnConsignados.UseVisualStyleBackColor = true;
            // 
            // btnRelatoriosAnteriores
            // 
            this.btnRelatoriosAnteriores.Location = new System.Drawing.Point(12, 304);
            this.btnRelatoriosAnteriores.Name = "btnRelatoriosAnteriores";
            this.btnRelatoriosAnteriores.Size = new System.Drawing.Size(284, 70);
            this.btnRelatoriosAnteriores.TabIndex = 3;
            this.btnRelatoriosAnteriores.Text = "Relatórios anteriores";
            this.btnRelatoriosAnteriores.UseVisualStyleBackColor = true;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(637, 256);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(114, 42);
            this.btnGrafico.TabIndex = 5;
            this.btnGrafico.Text = "Gráfico despesas ";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(40, 416);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(182, 66);
            this.btnNovaVenda.TabIndex = 6;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnAdicionarEstoque
            // 
            this.btnAdicionarEstoque.Location = new System.Drawing.Point(452, 407);
            this.btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            this.btnAdicionarEstoque.Size = new System.Drawing.Size(182, 66);
            this.btnAdicionarEstoque.TabIndex = 7;
            this.btnAdicionarEstoque.Text = "Adicionar ao estoque";
            this.btnAdicionarEstoque.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(695, 407);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(182, 66);
            this.btnGerarRelatorio.TabIndex = 8;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(331, 29);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.LabelForeColor = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Despesas do mês";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Valores";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(440, 362);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "Despesas";
            // 
            // txtNovaVenda
            // 
            this.txtNovaVenda.Location = new System.Drawing.Point(255, 440);
            this.txtNovaVenda.Name = "txtNovaVenda";
            this.txtNovaVenda.Size = new System.Drawing.Size(134, 20);
            this.txtNovaVenda.TabIndex = 9;
            this.txtNovaVenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNovaVenda_KeyUp);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 541);
            this.Controls.Add(this.txtNovaVenda);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnAdicionarEstoque);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnRelatoriosAnteriores);
            this.Controls.Add(this.btnConsignados);
            this.Controls.Add(this.btnDespesas);
            this.Controls.Add(this.btnConsultarEstoque);
            this.Name = "frmInicio";
            this.Text = "Home Page";

            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarEstoque;
        private System.Windows.Forms.Button btnDespesas;
        private System.Windows.Forms.Button btnConsignados;
        private System.Windows.Forms.Button btnRelatoriosAnteriores;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Button btnAdicionarEstoque;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtNovaVenda;
    }
}

