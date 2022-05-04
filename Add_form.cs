using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budget_calculator
{
    public partial class Add_form : Form
    {
        bool isCost;
        public Add_form(bool isCost)
        {
            this.isCost = isCost;
            InitializeComponent();
            if (isCost)
                caption.Text += " траты";
            else
                caption.Text += " дохода";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string filename = "D:\\C#\\budget-calculator\\budget-calculator\\Action.txt";
            using (var sw = File.AppendText(filename))
            {
                if (isCost)
                    sw.WriteLine("-" + nom_box.Text + ";" + name_box.Text + ";" + category_box.Text + ";" + date_box.Text + ";");
                else
                    sw.WriteLine("+" + nom_box.Text + ";" + name_box.Text + ";" + category_box.Text + ";" + date_box.Text + ";");
            }
        }
    }
}
