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
            this.show_income = new System.Windows.Forms.Label();
            this.show_cost = new System.Windows.Forms.Label();
            this.show_analytic = new System.Windows.Forms.Label();
            this.refresh_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cost
            // 
            this.cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            this.cost.FlatAppearance.BorderSize = 0;
            this.cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(146, 22);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(124, 40);
            this.cost.TabIndex = 0;
            this.cost.Text = "Расход";
            this.cost.UseVisualStyleBackColor = false;
            this.cost.Click += new System.EventHandler(this.cost_Click);
            this.cost.MouseEnter += new System.EventHandler(this.cost_MouseEnter);
            this.cost.MouseLeave += new System.EventHandler(this.cost_MouseLeave);
            // 
            // income
            // 
            this.income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            this.income.FlatAppearance.BorderSize = 0;
            this.income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.income.Location = new System.Drawing.Point(377, 22);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(124, 40);
            this.income.TabIndex = 1;
            this.income.Text = "Доход";
            this.income.UseVisualStyleBackColor = false;
            this.income.Click += new System.EventHandler(this.income_Click);
            this.income.MouseEnter += new System.EventHandler(this.income_MouseEnter);
            this.income.MouseLeave += new System.EventHandler(this.income_MouseLeave);
            // 
            // action_textbox
            // 
            this.action_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            this.action_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_textbox.Location = new System.Drawing.Point(68, 81);
            this.action_textbox.Multiline = true;
            this.action_textbox.Name = "action_textbox";
            this.action_textbox.ReadOnly = true;
            this.action_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.action_textbox.Size = new System.Drawing.Size(546, 192);
            this.action_textbox.TabIndex = 2;
            // 
            // cost_category
            // 
            this.cost_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            this.cost_category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_category.Location = new System.Drawing.Point(68, 295);
            this.cost_category.Multiline = true;
            this.cost_category.Name = "cost_category";
            this.cost_category.ReadOnly = true;
            this.cost_category.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cost_category.Size = new System.Drawing.Size(245, 109);
            this.cost_category.TabIndex = 3;
            // 
            // income_category
            // 
            this.income_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            this.income_category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.income_category.Location = new System.Drawing.Point(365, 295);
            this.income_category.Multiline = true;
            this.income_category.Name = "income_category";
            this.income_category.ReadOnly = true;
            this.income_category.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.income_category.Size = new System.Drawing.Size(249, 109);
            this.income_category.TabIndex = 4;
            // 
            // show_income
            // 
            this.show_income.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_income.Location = new System.Drawing.Point(-1, 407);
            this.show_income.Name = "show_income";
            this.show_income.Size = new System.Drawing.Size(680, 34);
            this.show_income.TabIndex = 6;
            this.show_income.Text = "Сумма доходов:";
            this.show_income.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_cost
            // 
            this.show_cost.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_cost.Location = new System.Drawing.Point(0, 414);
            this.show_cost.Name = "show_cost";
            this.show_cost.Size = new System.Drawing.Size(247, 23);
            this.show_cost.TabIndex = 7;
            this.show_cost.Text = "Сумма расходов:";
            this.show_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_analytic
            // 
            this.show_analytic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_analytic.Location = new System.Drawing.Point(425, 414);
            this.show_analytic.Name = "show_analytic";
            this.show_analytic.Size = new System.Drawing.Size(254, 23);
            this.show_analytic.TabIndex = 8;
            this.show_analytic.Text = "Профицит:";
            this.show_analytic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refresh_but
            // 
            this.refresh_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            this.refresh_but.BackgroundImage = global::budget_calculator.Properties.Resources.refresh_icon;
            this.refresh_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh_but.FlatAppearance.BorderSize = 0;
            this.refresh_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_but.Location = new System.Drawing.Point(571, 22);
            this.refresh_but.Name = "refresh_but";
            this.refresh_but.Size = new System.Drawing.Size(43, 40);
            this.refresh_but.TabIndex = 9;
            this.refresh_but.UseVisualStyleBackColor = false;
            this.refresh_but.Click += new System.EventHandler(this.refresh_but_Click);
            this.refresh_but.MouseEnter += new System.EventHandler(this.refresh_but_MouseEnter);
            this.refresh_but.MouseLeave += new System.EventHandler(this.refresh_but_MouseLeave);
            // 
            // Main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.refresh_but);
            this.Controls.Add(this.show_analytic);
            this.Controls.Add(this.show_cost);
            this.Controls.Add(this.show_income);
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
        private System.Windows.Forms.Label show_income;
        private System.Windows.Forms.Label show_cost;
        private System.Windows.Forms.Label show_analytic;
        private System.Windows.Forms.Button refresh_but;
    }
}

