namespace budget_calculator
{
    partial class Main_screen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cost = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.action_textbox = new System.Windows.Forms.TextBox();
            this.cost_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cost_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(145, 166);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(124, 40);
            this.cost.TabIndex = 0;
            this.cost.Text = "Расход";
            this.cost.UseVisualStyleBackColor = true;
            this.cost.Click += new System.EventHandler(this.cost_Click);
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(409, 166);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(124, 40);
            this.income.TabIndex = 1;
            this.income.Text = "Доход";
            this.income.UseVisualStyleBackColor = true;
            // 
            // action_textbox
            // 
            this.action_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_textbox.Location = new System.Drawing.Point(63, 212);
            this.action_textbox.Multiline = true;
            this.action_textbox.Name = "action_textbox";
            this.action_textbox.ReadOnly = true;
            this.action_textbox.Size = new System.Drawing.Size(546, 192);
            this.action_textbox.TabIndex = 2;
            this.action_textbox.TextChanged += new System.EventHandler(this.action_textbox_TextChanged);
            // 
            // cost_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.cost_chart.ChartAreas.Add(chartArea1);
            this.cost_chart.Location = new System.Drawing.Point(63, 16);
            this.cost_chart.Name = "cost_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cost_chart.Series.Add(series1);
            this.cost_chart.Size = new System.Drawing.Size(166, 144);
            this.cost_chart.TabIndex = 3;
            this.cost_chart.Text = "chart1";
            // 
            // Main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.cost_chart);
            this.Controls.Add(this.action_textbox);
            this.Controls.Add(this.income);
            this.Controls.Add(this.cost);
            this.Name = "Main_screen";
            this.Text = "Калькулятор семейного бюджета";
            ((System.ComponentModel.ISupportInitialize)(this.cost_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cost;
        private System.Windows.Forms.Button income;
        private System.Windows.Forms.TextBox action_textbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart cost_chart;
    }
}

