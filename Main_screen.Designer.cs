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
            this.cost = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.action_textbox = new System.Windows.Forms.TextBox();
            this.cost_category = new System.Windows.Forms.TextBox();
            this.income_category = new System.Windows.Forms.TextBox();
            this.goal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(91, 22);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(124, 40);
            this.cost.TabIndex = 0;
            this.cost.Text = "Расход";
            this.cost.UseVisualStyleBackColor = true;
            this.cost.Click += new System.EventHandler(this.cost_Click);
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(273, 22);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(124, 40);
            this.income.TabIndex = 1;
            this.income.Text = "Доход";
            this.income.UseVisualStyleBackColor = true;
            this.income.Click += new System.EventHandler(this.income_Click);
            // 
            // action_textbox
            // 
            this.action_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_textbox.Location = new System.Drawing.Point(68, 81);
            this.action_textbox.Multiline = true;
            this.action_textbox.Name = "action_textbox";
            this.action_textbox.ReadOnly = true;
            this.action_textbox.Size = new System.Drawing.Size(546, 192);
            this.action_textbox.TabIndex = 2;
            this.action_textbox.TextChanged += new System.EventHandler(this.action_textbox_TextChanged);
            // 
            // cost_category
            // 
            this.cost_category.Location = new System.Drawing.Point(68, 307);
            this.cost_category.Multiline = true;
            this.cost_category.Name = "cost_category";
            this.cost_category.ReadOnly = true;
            this.cost_category.Size = new System.Drawing.Size(245, 109);
            this.cost_category.TabIndex = 3;
            // 
            // income_category
            // 
            this.income_category.Location = new System.Drawing.Point(365, 307);
            this.income_category.Multiline = true;
            this.income_category.Name = "income_category";
            this.income_category.ReadOnly = true;
            this.income_category.Size = new System.Drawing.Size(249, 109);
            this.income_category.TabIndex = 4;
            // 
            // goal
            // 
            this.goal.Location = new System.Drawing.Point(457, 22);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(124, 40);
            this.goal.TabIndex = 5;
            this.goal.Text = "Цель";
            this.goal.UseVisualStyleBackColor = true;
            // 
            // Main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.income_category);
            this.Controls.Add(this.cost_category);
            this.Controls.Add(this.action_textbox);
            this.Controls.Add(this.income);
            this.Controls.Add(this.cost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main_screen";
            this.Text = "Калькулятор семейного бюджета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cost;
        private System.Windows.Forms.Button income;
        private System.Windows.Forms.TextBox action_textbox;
        private System.Windows.Forms.TextBox cost_category;
        private System.Windows.Forms.TextBox income_category;
        private System.Windows.Forms.Button goal;
    }
}

