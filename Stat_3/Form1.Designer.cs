namespace Stat_3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TabPage();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.rbThree = new System.Windows.Forms.RadioButton();
            this.rbTen = new System.Windows.Forms.RadioButton();
            this.rbFive = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.DatSave = new System.Windows.Forms.Button();
            this.DatOpen = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartDisp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbResult.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbResult);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbData
            // 
            this.tbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbData.Location = new System.Drawing.Point(3, 3);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(716, 352);
            this.tbData.TabIndex = 0;
            // 
            // tbResult
            // 
            this.tbResult.Controls.Add(this.rbFour);
            this.tbResult.Controls.Add(this.rbThree);
            this.tbResult.Controls.Add(this.rbTen);
            this.tbResult.Controls.Add(this.rbFive);
            this.tbResult.Controls.Add(this.textBox1);
            this.tbResult.Controls.Add(this.Calculate);
            this.tbResult.Controls.Add(this.DatSave);
            this.tbResult.Controls.Add(this.DatOpen);
            this.tbResult.Location = new System.Drawing.Point(4, 22);
            this.tbResult.Name = "tbResult";
            this.tbResult.Padding = new System.Windows.Forms.Padding(3);
            this.tbResult.Size = new System.Drawing.Size(722, 361);
            this.tbResult.TabIndex = 1;
            this.tbResult.Text = "Statistic";
            this.tbResult.UseVisualStyleBackColor = true;
            // 
            // rbFour
            // 
            this.rbFour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbFour.AutoSize = true;
            this.rbFour.Location = new System.Drawing.Point(84, 299);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(46, 17);
            this.rbFour.TabIndex = 7;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "Four";
            this.rbFour.UseVisualStyleBackColor = true;
            // 
            // rbThree
            // 
            this.rbThree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbThree.AutoSize = true;
            this.rbThree.Location = new System.Drawing.Point(84, 249);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(53, 17);
            this.rbThree.TabIndex = 6;
            this.rbThree.TabStop = true;
            this.rbThree.Text = "Three";
            this.rbThree.UseVisualStyleBackColor = true;
            // 
            // rbTen
            // 
            this.rbTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbTen.AutoSize = true;
            this.rbTen.Location = new System.Drawing.Point(226, 299);
            this.rbTen.Name = "rbTen";
            this.rbTen.Size = new System.Drawing.Size(44, 17);
            this.rbTen.TabIndex = 5;
            this.rbTen.TabStop = true;
            this.rbTen.Text = "Ten";
            this.rbTen.UseVisualStyleBackColor = true;
            // 
            // rbFive
            // 
            this.rbFive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbFive.AutoSize = true;
            this.rbFive.Location = new System.Drawing.Point(225, 249);
            this.rbFive.Name = "rbFive";
            this.rbFive.Size = new System.Drawing.Size(45, 17);
            this.rbFive.TabIndex = 4;
            this.rbFive.TabStop = true;
            this.rbFive.Text = "Five";
            this.rbFive.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(332, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 349);
            this.textBox1.TabIndex = 3;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(84, 180);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(186, 40);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // DatSave
            // 
            this.DatSave.Location = new System.Drawing.Point(84, 117);
            this.DatSave.Name = "DatSave";
            this.DatSave.Size = new System.Drawing.Size(186, 38);
            this.DatSave.TabIndex = 1;
            this.DatSave.Text = "Save";
            this.DatSave.UseVisualStyleBackColor = true;
            // 
            // DatOpen
            // 
            this.DatOpen.Location = new System.Drawing.Point(84, 50);
            this.DatOpen.Name = "DatOpen";
            this.DatOpen.Size = new System.Drawing.Size(186, 40);
            this.DatOpen.TabIndex = 0;
            this.DatOpen.Text = "Open";
            this.DatOpen.UseVisualStyleBackColor = true;
            this.DatOpen.Click += new System.EventHandler(this.DatOpen_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartDisp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(722, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visual";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartDisp
            // 
            this.chartDisp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDisp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDisp.Legends.Add(legend1);
            this.chartDisp.Location = new System.Drawing.Point(4, 3);
            this.chartDisp.Name = "chartDisp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.LegendText = "Dispersion";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Edge Of Deviation";
            series2.Name = "Edge";
            this.chartDisp.Series.Add(series1);
            this.chartDisp.Series.Add(series2);
            this.chartDisp.Size = new System.Drawing.Size(709, 355);
            this.chartDisp.TabIndex = 0;
            this.chartDisp.Text = "Graph";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Stat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbResult.ResumeLayout(false);
            this.tbResult.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TabPage tbResult;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button DatSave;
        private System.Windows.Forms.Button DatOpen;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDisp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.RadioButton rbThree;
        private System.Windows.Forms.RadioButton rbTen;
        private System.Windows.Forms.RadioButton rbFive;
    }
}

