using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Game_mini
{
    public partial class fRank : Form
    {
        public DataTable rank = new DataTable();
        

        public fRank()
        {
            InitializeComponent();
            rank.Columns.Add("Topic");
            rank.Columns.Add("Name");
            rank.Columns.Add("Score");
            rank.Columns.Add("Time");
            string filePath = @"rank.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] infos = line.Split(", ");
                rank.Rows.Add(infos[0], infos[1], infos[2], infos[3]);
            }
        }

        private void fRank_Load(object sender, EventArgs e)
        {
            /*MessageBox.Show(rank.Select("Topic='Animals'")[0]["Name"].ToString());
            load_rankTable("Animals");*/
        }

        private void load_rankTable(string rankTopic)
        {
            lsvRank.Items.Clear();
            DataRow[] rankr = rank.Select("Topic='" + rankTopic + "'");
            for (int i = 0; i<rankr.Length; i++)
            {
                for (int j = i+1; j<rankr.Length; j++)
                {
                    if (Int32.Parse(rankr[j]["Score"].ToString()) > Int32.Parse(rankr[i]["Score"].ToString()))
                    {
                        DataRow tmp = rankr[i];
                        rankr[i] = rankr[j];
                        rankr[j] = tmp;
                    }
                    else if (Int32.Parse(rankr[j]["Score"].ToString()) == Int32.Parse(rankr[i]["Score"].ToString()) && Int32.Parse(rankr[j]["Time"].ToString()) < Int32.Parse(rankr[i]["Time"].ToString()))
                    {
                        DataRow tmp = rankr[i];
                        rankr[i] = rankr[j];
                        rankr[j] = tmp;
                    }
                }
            }
            int rat = 1;
            foreach (DataRow row in rankr)
            {
                ListViewItem lsvItem = new ListViewItem(rat.ToString());
                lsvItem.SubItems.Add(row["Name"].ToString());
                lsvItem.SubItems.Add(row["Score"].ToString());
                lsvItem.SubItems.Add(row["Time"].ToString());
                lsvRank.Items.Add(lsvItem);
                rat++;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            load_rankTable((sender as Button)!.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
