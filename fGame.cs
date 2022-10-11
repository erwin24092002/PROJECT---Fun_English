using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Media;

namespace Game_mini
{
    public partial class fGame : Form
    {
        ResourceManager rm;
        public int index = 0;
        public int[] flag = new int[15];
        public string player;
        public string topic;
        public int score = 0;
        public int round = 1; 
        public DataRow[] dr;
        public Button[] btnQ = new Button[10];
        public Label[] lbQ = new Label[10];
        int TimeTick = 0;
        SoundPlayer correctSound = new SoundPlayer("correct.wav");
        SoundPlayer incorrectSound = new SoundPlayer("incorrect.wav");


        public fGame(string topicName, DataTable da, string playerName)
        {
            InitializeComponent();
            lbPlayerName.Text = "Player: " + playerName;
            player = playerName;
            topic = topicName;
            rm = new ResourceManager("Game_mini.Properties."+topicName, Assembly.GetExecutingAssembly());
            /*ResourceManager bg = new ResourceManager("Game_mini.Properties.FormBackground", Assembly.GetExecutingAssembly());
            this.BackgroundImage = (Image)bg.GetObject(topicName)!;
            this.BackgroundImageLayout = ImageLayout.Stretch;*/
            dr = da.Select("Topic='" + topicName + "'");
            btnQ[1] = btnQ1;
            btnQ[2] = btnQ2;
            btnQ[3] = btnQ3;
            btnQ[4] = btnQ4;
            btnQ[5] = btnQ5;
            lbQ[1] = lbQ1;
            lbQ[2] = lbQ2;
            lbQ[3] = lbQ3;
            lbQ[4] = lbQ4;
            lbQ[5] = lbQ5;
            this.AcceptButton = btnStart;
            refSoundIcon();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;
            btnNext.Enabled = true;
            btnQ[round].Image = null;
            if (txbInpText.Text == dr[index]["En"].ToString())
            {
                score += 10;
                txbScore.Text = score.ToString();
                btnQ[round].Text = "";
                ResourceManager bg = new ResourceManager("Game_mini.Properties.FormBackground", Assembly.GetExecutingAssembly());
                btnQ[round].Image = (Image)bg.GetObject("correct")!;
                lbQ[round].Visible = true;
                lbQ[round].Text = dr[index]["En"].ToString();
                lbQ[round].ForeColor = Color.Green;
                if(Sound.Flag)
                    correctSound.Play();
            }
            else
            {
                btnQ[round].Text = "";
                ResourceManager bg = new ResourceManager("Game_mini.Properties.FormBackground", Assembly.GetExecutingAssembly());
                btnQ[round].Image = (Image)bg.GetObject("incorrect")!;
                lbQ[round].Visible = true;
                lbQ[round].Text = dr[index]["En"].ToString();
                lbQ[round].ForeColor = Color.Firebrick;
                if(Sound.Flag)
                    incorrectSound.Play();
            }
            round += 1;
            if (round > 5)
            {
                btnCheck.Enabled = false;
                btnCheck.Visible = false;
                btnNext.Enabled = false;
                btnNext.Visible = false;
                btnFinish.Enabled = true;
                btnFinish.Visible = true;
                txbInpText.TabIndex = 3;
                this.AcceptButton = btnFinish;
            }
            timer1.Stop();
            this.AcceptButton = btnNext;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            btnNext.Enabled = false;
            txbInpText.Text = "";
            lbRound.Text = "Round " + round.ToString();
            Random rd = new Random();
            index = rd.Next(dr.Length);
            while (flag[index]!=0)
            {
                index = rd.Next(dr.Length);
            }
            flag[index] = 1;
            btnQ[round].Enabled = true;
            this.ptbVocalImage.Image = (Image)rm.GetObject(dr[index]["En"].ToString()!)!;
            timer1.Start();
            this.AcceptButton = btnCheck;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            btnCheck.Visible = true;
            btnNext.Enabled = false;
            btnNext.Visible = true;
            btnStart.Enabled = false;
            btnStart.Visible = false;
            lbRound.Text = "Round " + round.ToString();
            Random rd = new Random();
            index = rd.Next(dr.Length);
            flag[index] = 1;
            this.ptbVocalImage.Image = (Image)rm.GetObject(dr[index]["En"].ToString()!)!;
            btnQ1.Enabled = true;
            timer1.Start();
            this.AcceptButton = btnCheck;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string filePath = @"rank.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            lines.Add(topic + ", " + player + ", " + score.ToString() + ", " + txbTime.Text);
            File.WriteAllLines(filePath, lines.ToArray());

            fCompleted f = new fCompleted(player, score, TimeTick);
            f.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTick++;
            txbTime.Text = TimeTick.ToString();
        }

        private void ptbSound_Click(object sender, EventArgs e)
        {
            Sound.Flag = false;
            refSoundIcon();
        }

        private void ptbUnSound_Click(object sender, EventArgs e)
        {
            Sound.Flag = true;
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
