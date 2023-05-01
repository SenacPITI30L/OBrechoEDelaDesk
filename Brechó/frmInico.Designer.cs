namespace Brechó
{
    partial class frmInico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnConsultarEstoque = new System.Windows.Forms.Button();
            this.btnDespesas = new System.Windows.Forms.Button();
            this.btnConsignados = new System.Windows.Forms.Button();
            this.btnRelatoriosAnteriores = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnAditaEstoque = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCadastrodeCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarEstoque
            // 
            this.btnConsultarEstoque.Location = new System.Drawing.Point(0, 308);
            this.btnConsultarEstoque.Name = "btnConsultarEstoque";
            this.btnConsultarEstoque.Size = new System.Drawing.Size(284, 71);
            this.btnConsultarEstoque.TabIndex = 0;
            this.btnConsultarEstoque.Text = "Consultar estoque";
            this.btnConsultarEstoque.UseVisualStyleBackColor = true;
            this.btnConsultarEstoque.Click += new System.EventHandler(this.btnConsultarEstoque_Click);
            // 
            // btnDespesas
            // 
            this.btnDespesas.Location = new System.Drawing.Point(0, 78);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Size = new System.Drawing.Size(284, 72);
            this.btnDespesas.TabIndex = 1;
            this.btnDespesas.Text = "Despesas";
            this.btnDespesas.UseVisualStyleBackColor = true;
            // 
            // btnConsignados
            // 
            this.btnConsignados.Location = new System.Drawing.Point(0, 156);
            this.btnConsignados.Name = "btnConsignados";
            this.btnConsignados.Size = new System.Drawing.Size(284, 70);
            this.btnConsignados.TabIndex = 2;
            this.btnConsignados.Text = "Consignados";
            this.btnConsignados.UseVisualStyleBackColor = true;
            // 
            // btnRelatoriosAnteriores
            // 
            this.btnRelatoriosAnteriores.Location = new System.Drawing.Point(0, 232);
            this.btnRelatoriosAnteriores.Name = "btnRelatoriosAnteriores";
            this.btnRelatoriosAnteriores.Size = new System.Drawing.Size(284, 70);
            this.btnRelatoriosAnteriores.TabIndex = 3;
            this.btnRelatoriosAnteriores.Text = "Relatórios anteriores";
            this.btnRelatoriosAnteriores.UseVisualStyleBackColor = true;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(617, 184);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(114, 42);
            this.btnGrafico.TabIndex = 5;
            this.btnGrafico.Text = "Gráfico despesas ";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(0, -4);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(284, 76);
            this.btnNovaVenda.TabIndex = 6;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnAditaEstoque
            // 
            this.btnAditaEstoque.Location = new System.Drawing.Point(0, 390);
            this.btnAditaEstoque.Name = "btnAditaEstoque";
            this.btnAditaEstoque.Size = new System.Drawing.Size(284, 74);
            this.btnAditaEstoque.TabIndex = 7;
            this.btnAditaEstoque.Text = "Editar Estoque";
            this.btnAditaEstoque.UseVisualStyleBackColor = true;
            this.btnAditaEstoque.Click += new System.EventHandler(this.btnAditaEstoque_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(0, 470);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(284, 73);
            this.btnGerarRelatorio.TabIndex = 8;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(333, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Despesas do mês";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Valores";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(413, 365);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "Despesas";
            // 
            // btnCadastrodeCliente
            // 
            this.btnCadastrodeCliente.Location = new System.Drawing.Point(333, 413);
            this.btnCadastrodeCliente.Name = "btnCadastrodeCliente";
            this.btnCadastrodeCliente.Size = new System.Drawing.Size(218, 72);
            this.btnCadastrodeCliente.TabIndex = 9;
            this.btnCadastrodeCliente.Text = "Cadastro de Cliente";
            this.btnCadastrodeCliente.UseVisualStyleBackColor = true;
            this.btnCadastrodeCliente.Click += new System.EventHandler(this.btnCadastrodeCliente_Click);
            // 
            // frmInico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 541);
            this.Controls.Add(this.btnCadastrodeCliente);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnAditaEstoque);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnRelatoriosAnteriores);
            this.Controls.Add(this.btnConsignados);
            this.Controls.Add(this.btnDespesas);
            this.Controls.Add(this.btnConsultarEstoque);
            this.Name = "frmInico";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarEstoque;
        private System.Windows.Forms.Button btnDespesas;
        private System.Windows.Forms.Button btnConsignados;
        private System.Windows.Forms.Button btnRelatoriosAnteriores;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Button btnAditaEstoque;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCadastrodeCliente;
    }
}

