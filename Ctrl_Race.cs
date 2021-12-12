using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Columbus
{
    public partial class Ctrl_Race : UserControl
    {
        public Ctrl_Race()
        {
            InitializeComponent();
        }

        public void Ctrl_Race_Load()
        {
            lbxRace.Items.Clear();
            lbxRace.Refresh();

            for (int i = 0; i < Global.Race.Pigeons.Count; i++)
            {
                Pigeon pigeon = Global.Race.Pigeons[i];

                string position = pigeon.Position.ToString();

                string next = "-";
                for (int o = i + 1; o < Global.Race.Pigeons.Count; o++)
                {
                    if (pigeon.Owner == Global.Race.Pigeons[o].Owner)
                    {
                        next = Convert.ToString(o + 1);
                        break;
                    }
                }

                string owner = pigeon.Owner.Name;
                string ownerCount = pigeon.Owner.PigeonCount().ToString();
                string mark = pigeon.Mark.ToString();
                string distance = Math.Round((pigeon.Owner.Distance / 1000), 3).ToString();
                string ring = pigeon.RingNumber.ToString();
                string arrivalTime = (pigeon.ArrivalTime.Year > 1) ? pigeon.ArrivalTime.ToString() : "";
                string speed = Math.Round(pigeon.Speed, 3).ToString();
                string points = pigeon.Points.ToString();

                string[] line = { position, next, owner, ownerCount, mark, distance, ring, arrivalTime, speed, points };

                if (Global.Filters.Count > 0)
                {
                    foreach (string rule in Global.Filters)
                    {
                        string[] ruleMembers = rule.Split(':');

                        int columnIndex = -1;
                        for (int o = 0; o < lbxRace.Columns.Count; o++)
                        {
                            ColumnHeader columnHeader = lbxRace.Columns[o];
                            if (columnHeader.Text == ruleMembers[0])
                            {
                                columnIndex = o;
                                break;
                            }
                        }
                        switch (ruleMembers[1])
                        {
                            case "=":
                                {
                                    if (line[columnIndex] == ruleMembers[2])
                                    {
                                        ListViewItem listviewItem = new ListViewItem(line);
                                        lbxRace.Items.Add(listviewItem);
                                    }
                                    break;
                                }
                            case ">":
                                {
                                    if (Convert.ToInt32(line[columnIndex]) > Convert.ToInt32(ruleMembers[2]))
                                    {
                                        ListViewItem listviewItem = new ListViewItem(line);
                                        lbxRace.Items.Add(listviewItem);
                                    }
                                    break;
                                }
                            case ">=":
                                {
                                    if (Convert.ToInt32(line[columnIndex]) >= Convert.ToInt32(ruleMembers[2]))
                                    {
                                        ListViewItem listviewItem = new ListViewItem(line);
                                        lbxRace.Items.Add(listviewItem);
                                    }
                                    break;
                                }
                            case "<":
                                {
                                    if (Convert.ToInt32(line[columnIndex]) < Convert.ToInt32(ruleMembers[2]))
                                    {
                                        ListViewItem listviewItem = new ListViewItem(line);
                                        lbxRace.Items.Add(listviewItem);
                                    }
                                    break;
                                }
                            case "<=":
                                {
                                    if (Convert.ToInt32(line[columnIndex]) <= Convert.ToInt32(ruleMembers[2]))
                                    {
                                        ListViewItem listviewItem = new ListViewItem(line);
                                        lbxRace.Items.Add(listviewItem);
                                    }
                                    break;
                                }
                            case "!=":
                                {
                                    if (Convert.ToInt32(line[columnIndex]) != Convert.ToInt32(ruleMembers[2]))
                                    {
                                        ListViewItem listviewItem = new ListViewItem(line);
                                        lbxRace.Items.Add(listviewItem);
                                    }
                                    break;
                                }
                        }
                    }
                } else
                {
                    ListViewItem listviewItem = new ListViewItem(line);
                    lbxRace.Items.Add(listviewItem);
                }
            }
        }
    }
}
