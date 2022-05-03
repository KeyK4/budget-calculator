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
    public partial class Main_screen : Form
    {
        public Main_screen()
        {
            Dictionary<string, int> category_cost = new Dictionary<string, int>();
            Dictionary<string, int> category_income = new Dictionary<string, int>();
            float count_cost = 0;
            float count_income = 0;
            var action_list = new List<string>();
            action_list.Add("Номенал \tНаименование \tКатегория \tДата\r\n");
            string filename = "D:\\C#\\budget-calculator\\budget-calculator\\Action.txt";
            using (var sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    bool cost_operation = true;
                    var elems = line.Split(';');
                    if (elems[0][0] == '+')
                        cost_operation = false;

                    if (elems[1].Length > 17)
                        elems[1] = elems[1].Substring(0, 15) + '…';

                    if (cost_operation)
                    {
                        int val = Int32.Parse(elems[0].Substring(1, elems[0].Length-1));
                        count_cost += val;
                        if (category_cost.TryGetValue(elems[2], out int i))
                            category_cost[elems[2]] += val;
                        else
                        {
                            category_cost.Add(elems[2], val);
                        }
                    }
                    else
                    {
                        int val = Int32.Parse(elems[0].Substring(1, elems[0].Length-1));
                        count_income += val;
                        if (category_income.TryGetValue(elems[2], out int i))
                            category_income[elems[2]] += val;
                        else
                        {
                            category_income.Add(elems[2], val);
                        }
                    }


                    if (elems[0].Length > 8)
                        elems[0] = elems[0].Substring(0, 7) + '…';

                    if (elems[2].Length > 17)
                        elems[2] = elems[2].Substring(0, 15) + '…';

                    if (elems[3].Length > 8)
                        elems[3] = elems[3].Substring(0, 7) + '…';

                    action_list.Add(String.Format("{0,-3}\t{1,-17}\t{2,-17}\t{3,-10}\r\n", elems[0], elems[1], elems[2], elems[3]));
                }
            }
            InitializeComponent();
            foreach (var action in action_list)
            {
                action_textbox.Text += action;
            }
            foreach (var category in category_cost)
            {
                var procent = Math.Round((category.Value / count_cost), 3)*100;
                cost_category.Text += $"{category.Key} {procent}%\r\n";
            }
            foreach (var category in category_income)
            {
                var procent = Math.Round((category.Value / count_income), 3) * 100;
                income_category.Text += $"{category.Key} {procent}%\r\n";
            }

        }

        private void cost_Click(object sender, EventArgs e)
        {

        }

        private void action_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void income_Click(object sender, EventArgs e)
        {

        }
    }
}
