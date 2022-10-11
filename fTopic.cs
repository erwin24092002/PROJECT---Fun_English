using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Game_mini
{
    public partial class fTopic : Form
    {
        public string topicName = "Animals";
        DataTable data = new DataTable();

        public fTopic(DataTable da)
        {
            InitializeComponent();
            data = da;
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.White;
                btn.FlatAppearance.BorderSize = 2;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            topicName = (sender as Button).Text;
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Text == "Animals" || btn.Text == "Clothing" || btn.Text == "Fruits" || btn.Text == "Plants" || btn.Text == "Transportation" || btn.Text == "Vegetables")
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.ForeColor = Color.MidnightBlue;
                    btn.FlatAppearance.BorderSize = 2;
                }
                if (btn.Text == (sender as Button).Text)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Red;
                    btn.ForeColor = Color.Gold;
                    btn.FlatAppearance.BorderSize = 3;
                }
                
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txbPlayerName.Text!="")
            { fGame f = new fGame(topicName, data, txbPlayerName.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You need to enter name before playing!", "Announcement");
            }
        }

        private void fTopic_Load(object sender, EventArgs e)
        {
            
        }
    }
}
