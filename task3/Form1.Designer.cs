namespace task3
{
    partial class frmSector
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColvoEl = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.chartSector = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btGenerate = new System.Windows.Forms.Button();
            this.btCreateDiag = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSector)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.txtColvoEl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(821, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вхідні дані";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btCreateDiag);
            this.groupBox2.Controls.Add(this.chartSector);
            this.groupBox2.Location = new System.Drawing.Point(13, 211);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(821, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Побудова діаграми";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть кількість елементів:";
            // 
            // txtColvoEl
            // 
            this.txtColvoEl.Location = new System.Drawing.Point(269, 32);
            this.txtColvoEl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColvoEl.Name = "txtColvoEl";
            this.txtColvoEl.Size = new System.Drawing.Size(84, 26);
            this.txtColvoEl.TabIndex = 1;
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(8, 70);
            this.dgvMass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 51;
            this.dgvMass.RowTemplate.Height = 24;
            this.dgvMass.Size = new System.Drawing.Size(790, 112);
            this.dgvMass.TabIndex = 2;
            // 
            // chartSector
            // 
            this.chartSector.BackColor = System.Drawing.Color.SkyBlue;
            this.chartSector.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartSector.BackSecondaryColor = System.Drawing.Color.Blue;
            chartArea4.Name = "ChartArea1";
            this.chartSector.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSector.Legends.Add(legend4);
            this.chartSector.Location = new System.Drawing.Point(8, 27);
            this.chartSector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartSector.Name = "chartSector";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Sector";
            this.chartSector.Series.Add(series4);
            this.chartSector.Size = new System.Drawing.Size(619, 272);
            this.chartSector.TabIndex = 0;
            this.chartSector.Text = "chart1";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(392, 23);
            this.btGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(406, 39);
            this.btGenerate.TabIndex = 3;
            this.btGenerate.Text = "Згенерувати порожній одновимірний масив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // btCreateDiag
            // 
            this.btCreateDiag.Location = new System.Drawing.Point(665, 48);
            this.btCreateDiag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCreateDiag.Name = "btCreateDiag";
            this.btCreateDiag.Size = new System.Drawing.Size(133, 92);
            this.btCreateDiag.TabIndex = 1;
            this.btCreateDiag.Text = "Побудувати секторну діаграму";
            this.btCreateDiag.UseVisualStyleBackColor = true;
            this.btCreateDiag.Click += new System.EventHandler(this.btCreateDiag_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(665, 166);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(133, 92);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSector";
            this.Text = "Секторна діаграма";
            this.Load += new System.EventHandler(this.frmSector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.TextBox txtColvoEl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCreateDiag;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSector;
    }
}

