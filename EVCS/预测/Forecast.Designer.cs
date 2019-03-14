namespace EVCS.预测
{
    partial class Forecas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDays = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAnalysisDayly = new System.Windows.Forms.DateTimePicker();
            this.chartDays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.recordsTableAdapter = new EVCS.EVCSDataSetTableAdapters.RecordsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDays);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDays
            // 
            this.tabPageDays.Controls.Add(this.label1);
            this.tabPageDays.Controls.Add(this.dateTimePickerAnalysisDayly);
            this.tabPageDays.Controls.Add(this.chartDays);
            this.tabPageDays.Location = new System.Drawing.Point(4, 22);
            this.tabPageDays.Name = "tabPageDays";
            this.tabPageDays.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDays.Size = new System.Drawing.Size(921, 410);
            this.tabPageDays.TabIndex = 1;
            this.tabPageDays.Text = "每日装载分析";
            this.tabPageDays.UseVisualStyleBackColor = true;
            this.tabPageDays.Click += new System.EventHandler(this.tabPageDays_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "月份：";
            // 
            // dateTimePickerAnalysisDayly
            // 
            this.dateTimePickerAnalysisDayly.CustomFormat = "yyyy-MM";
            this.dateTimePickerAnalysisDayly.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickerAnalysisDayly.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAnalysisDayly.Location = new System.Drawing.Point(86, 7);
            this.dateTimePickerAnalysisDayly.Name = "dateTimePickerAnalysisDayly";
            this.dateTimePickerAnalysisDayly.ShowUpDown = true;
            this.dateTimePickerAnalysisDayly.Size = new System.Drawing.Size(153, 27);
            this.dateTimePickerAnalysisDayly.TabIndex = 1;
            this.dateTimePickerAnalysisDayly.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chartDays
            // 
            chartArea1.AxisX.Title = "日期";
            chartArea1.AxisY.Title = "体积（m³）";
            chartArea1.Name = "ChartArea1";
            this.chartDays.ChartAreas.Add(chartArea1);
            this.chartDays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordsBindingSource, "Volume", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            legend1.Name = "Legend1";
            this.chartDays.Legends.Add(legend1);
            this.chartDays.Location = new System.Drawing.Point(8, 40);
            this.chartDays.Name = "chartDays";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "体积";
            series1.Name = "Series1";
            this.chartDays.Series.Add(series1);
            this.chartDays.Size = new System.Drawing.Size(905, 362);
            this.chartDays.TabIndex = 0;
            this.chartDays.Text = "chart1";
            this.chartDays.Click += new System.EventHandler(this.chartDays_Click);
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "Records";
            this.recordsBindingSource.DataSource = this.eVCSDataSet;
            // 
            // eVCSDataSet
            // 
            this.eVCSDataSet.DataSetName = "EVCSDataSet";
            this.eVCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // Forecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 436);
            this.Controls.Add(this.tabControl1);
            this.Name = "Forecas";
            this.Text = "预测";
            this.Load += new System.EventHandler(this.Analysis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDays.ResumeLayout(false);
            this.tabPageDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDays;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnalysisDayly;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDays;
        private EVCSDataSet eVCSDataSet;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private EVCSDataSetTableAdapters.RecordsTableAdapter recordsTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}