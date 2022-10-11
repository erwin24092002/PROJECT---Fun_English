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
using System.Media;

namespace Game_mini
{
    public partial class fLearn : Form
    {
        DataTable data = new DataTable();
        public fLearn(DataTable da)
        {
            InitializeComponent();
            data = da;
            refSoundIcon();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLearn_Load(object sender, EventArgs e)
        {
            ResourceManager Animals = new ResourceManager("Game_mini.Properties.Animals", Assembly.GetExecutingAssembly());
            ResourceManager Clothing = new ResourceManager("Game_mini.Properties.Clothing", Assembly.GetExecutingAssembly());
            ResourceManager Fruits = new ResourceManager("Game_mini.Properties.Fruits", Assembly.GetExecutingAssembly());
            ResourceManager Plants = new ResourceManager("Game_mini.Properties.Plants", Assembly.GetExecutingAssembly());
            ResourceManager Vegetables = new ResourceManager("Game_mini.Properties.Vegetables", Assembly.GetExecutingAssembly());
            ResourceManager Transportation = new ResourceManager("Game_mini.Properties.Transportation", Assembly.GetExecutingAssembly());
            
            foreach (DataRow row in data.Rows)
            {
                Button btn = new Button() { Width = 430, Height = 100 };
                btn.Text = row["En"].ToString() /*+ Environment.NewLine + row["Vn"].ToString()*/;
                btn.TextAlign = ContentAlignment.MiddleCenter;

                int w = 100;
                int h = 95;
                Bitmap bm = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(bm);

                switch (row["Topic"])
                {
                    case "Animals":
                        g.DrawImage((Image)Animals.GetObject(btn.Text), 0, 0, w, h);
                        btn.BackColor = Color.LightSkyBlue;
                        break;
                    case "Clothing":
                        g.DrawImage((Image)Clothing.GetObject(btn.Text), 0, 0, w, h);
                        btn.BackColor = Color.LightSlateGray;
                        break;
                    case "Fruits":
                        g.DrawImage((Image)Fruits.GetObject(btn.Text), 0, 0, w, h);
                        btn.BackColor = Color.LightCyan;
                        break;
                    case "Plants":
                        g.DrawImage((Image)Plants.GetObject(btn.Text), 0, 0, w, h);
                        btn.BackColor = Color.LightGoldenrodYellow;
                        break;
                    case "Transportation":
                        g.DrawImage((Image)Transportation.GetObject(btn.Text), 0, 0, w, h);
                        btn.BackColor = Color.LightGreen;
                        break;
                    case "Vegetables":
                        g.DrawImage((Image)Vegetables.GetObject(btn.Text), 0, 0, w, h);
                        btn.BackColor = Color.LightSkyBlue;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                g.Dispose();
                btn.Image = bm;
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                /*btn.TextImageRelation = TextImageRelation.ImageBeforeText;*/
                flpLearn.Controls.Add(btn);
            }
        }

        private void ptbSound_Click(object sender, EventArgs e)
        {
            Sound.Flag = false;
            Sound.MainSound.Stop();
            refSoundIcon();
        }

        private void ptbUnSound_Click(object sender, EventArgs e)
        {
            Sound.Flag = true;
            Sound.MainSound.PlayLooping();
            refSoundIcon();
        }

        void refSoundIcon()
        {
            if (!Sound.Flag)
            {
                ptbSound.Enabled = false;
                ptbSound.Visible = false;
                ptbUnSound.Enabled = true;
                ptbUnSound.Visible = true;
            }
            else
            {
                ptbSound.Enabled = true;
                ptbSound.Visible = true;
                ptbUnSound.Enabled = false;
                ptbUnSound.Visible = false;
            }
        }
    }
}
