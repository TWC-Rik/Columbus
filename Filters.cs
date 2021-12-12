using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Columbus
{
    public partial class Filters : Form
    {
        public Filters()
        {
            InitializeComponent();
        }

        private void Filters_Load(object sender, EventArgs e)
        {
            foreach (string rule in Global.Filters)
            {
                lbxFilters.Items.Add(rule.Replace(':', ' '));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxField.Text == "" || cbxType.Text == "" || tbxValue.Text == "")
                return;

            string rule = $"{cbxField.Text}:{cbxType.Text}:{tbxValue.Text}";
            Global.Filters.Add(rule);
            lbxFilters.Items.Add(rule.Replace(':', ' '));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = lbxFilters.SelectedIndex;
            string rule = lbxFilters.Items[index].ToString();
            Global.Filters.Remove(rule.Replace(':', ' '));
            lbxFilters.Items.RemoveAt(index);
        }
    }
}
