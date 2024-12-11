namespace Cseresznye_TAAYQB
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            openDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            highDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lowDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            closeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monthlyTimeSeriesBindingSource = new BindingSource(components);
            button2 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            btntoCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthlyTimeSeriesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(1192, 567);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "&Vissza";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { openDataGridViewTextBoxColumn, highDataGridViewTextBoxColumn, lowDataGridViewTextBoxColumn, closeDataGridViewTextBoxColumn, volumeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = monthlyTimeSeriesBindingSource;
            dataGridView1.Location = new Point(63, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(576, 259);
            dataGridView1.TabIndex = 2;
            // 
            // openDataGridViewTextBoxColumn
            // 
            openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            openDataGridViewTextBoxColumn.HeaderText = "Open";
            openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            // 
            // highDataGridViewTextBoxColumn
            // 
            highDataGridViewTextBoxColumn.DataPropertyName = "High";
            highDataGridViewTextBoxColumn.HeaderText = "High";
            highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            // 
            // lowDataGridViewTextBoxColumn
            // 
            lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            lowDataGridViewTextBoxColumn.HeaderText = "Low";
            lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            // 
            // closeDataGridViewTextBoxColumn
            // 
            closeDataGridViewTextBoxColumn.DataPropertyName = "Close";
            closeDataGridViewTextBoxColumn.HeaderText = "Close";
            closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            // 
            // monthlyTimeSeriesBindingSource
            // 
            monthlyTimeSeriesBindingSource.DataSource = typeof(MonthlyTimeSeries);
            // 
            // button2
            // 
            button2.Location = new Point(428, 50);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Mehet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(723, 68);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(468, 300);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // button3
            // 
            button3.Location = new Point(63, 442);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Elemzés";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(233, 443);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 118);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // btntoCsv
            // 
            btntoCsv.Location = new Point(1021, 443);
            btntoCsv.Name = "btntoCsv";
            btntoCsv.Size = new Size(75, 23);
            btntoCsv.TabIndex = 7;
            btntoCsv.Text = "CSV export";
            btntoCsv.UseVisualStyleBackColor = true;
            btntoCsv.Click += btnCsv_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 602);
            Controls.Add(btntoCsv);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(chart1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)monthlyTimeSeriesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button3;
        private RichTextBox richTextBox1;
        private Button btntoCsv;
        private DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private BindingSource monthlyTimeSeriesBindingSource;
    }
}