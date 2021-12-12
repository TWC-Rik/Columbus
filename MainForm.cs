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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Global.Filters = new List<string>();
        }

        private void btnSelectUDP_Click(object sender, EventArgs e)
        {
            udpPathDialog.ShowDialog();
            string filePath = udpPathDialog.FileName;

            if (filePath != "")
            {
                UDP udp = new UDP(filePath);
                udp.GetOwners();
                Global.Race = udp.GetRace();
                Global.Race.RankPigeons();

                ctlRace.Ctrl_Race_Load();
            }
        }

        private void handleNewFilters(object sender, EventArgs e)
        {
            string filePath = udpPathDialog.FileName;
            if (filePath != "")
            {
                ctlRace.Ctrl_Race_Load();
            }
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filterForm = new Filters();
            filterForm.Show();
            filterForm.FormClosed += handleNewFilters;
        }
    }
}
