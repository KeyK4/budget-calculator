namespace budget_calculator
{
    partial class Add_form
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
            this.nom_lab = new System.Windows.Forms.Label();
            this.name_lab = new System.Windows.Forms.Label();
            this.category_lab = new System.Windows.Forms.Label();
            this.date_lab = new System.Windows.Forms.Label();
            this.caption = new System.Windows.Forms.Label();
            this.nom_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.category_box = new System.Windows.Forms.TextBox();
            this.date_box = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nom_lab
            // 
            this.nom_lab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nom_lab.Location = new System.Drawing.Point(31, 55);
            this.nom_lab.Name = "nom_lab";
            this.nom_lab.Size = new System.Drawing.Size(105, 23);
            this.nom_lab.TabIndex = 0;
            this.nom_lab.Text = "Номинал";
            this.nom_lab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name_lab
            // 
            this.name_lab.AutoSize = true;
            this.name_lab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lab.Location = new System.Drawing.Point(2, 96);
            this.name_lab.Name = "name_lab";
            this.name_lab.Size = new System.Drawing.Size(134, 21);
            this.name_lab.TabIndex = 1;
            this.name_lab.Text = "Наименование";
            // 
            // category_lab
            // 
            this.category_lab.AutoSize = true;
            this.category_lab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_lab.Location = new System.Drawing.Point(46, 138);
            this.category_lab.Name = "category_lab";
            this.category_lab.Size = new System.Drawing.Size(90, 21);
            this.category_lab.TabIndex = 2;
            this.category_lab.Text = "Категория";
            // 
            // date_lab
            // 
            this.date_lab.AutoSize = true;
            this.date_lab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_lab.Location = new System.Drawing.Point(86, 178);
            this.date_lab.Name = "date_lab";
            this.date_lab.Size = new System.Drawing.Size(50, 21);
            this.date_lab.TabIndex = 3;
            this.date_lab.Text = "Дата";
            // 
            // caption
            // 
            this.caption.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption.Location = new System.Drawing.Point(2, 0);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(364, 40);
            this.caption.TabIndex = 4;
            this.caption.Text = "Добавление ";
            this.caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nom_box
            // 
            this.nom_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nom_box.Location = new System.Drawing.Point(143, 53);
            this.nom_box.Name = "nom_box";
            this.nom_box.Size = new System.Drawing.Size(210, 27);
            this.nom_box.TabIndex = 5;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.Location = new System.Drawing.Point(142, 93);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(210, 27);
            this.name_box.TabIndex = 6;
            // 
            // category_box
            // 
            this.category_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_box.Location = new System.Drawing.Point(143, 135);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(210, 27);
            this.category_box.TabIndex = 7;
            // 
            // date_box
            // 
            this.date_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_box.Location = new System.Drawing.Point(143, 175);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(210, 27);
            this.date_box.TabIndex = 8;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(143, 225);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(102, 32);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 269);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.nom_box);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.date_lab);
            this.Controls.Add(this.category_lab);
            this.Controls.Add(this.name_lab);
            this.Controls.Add(this.nom_lab);
            this.Name = "Add_form";
            this.Text = "Add_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom_lab;
        private System.Windows.Forms.Label name_lab;
        private System.Windows.Forms.Label category_lab;
        private System.Windows.Forms.Label date_lab;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.TextBox nom_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox category_box;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.Button add_button;
    }
}