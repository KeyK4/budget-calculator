using System;
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
    public partial class Main_screen : Form
    {
        public Main_screen()
        {
            var action_list = new List<string>();
            action_list.Add("Номенал \tНаименование \tКатегория \tДата\r\n");
            action_list.Add("-1000 \tЗаправка \tАвтомобиль \t12.04.22\r\n");
            action_list.Add("+10000 \tЗарплата жены \tЗаработная плата \t9.04.22\r\n");
            InitializeComponent();
            foreach (var action in action_list)
            {
                action_textbox.Text += action;
            }
        }

        private void cost_Click(object sender, EventArgs e)
        {

        }

        private void action_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
