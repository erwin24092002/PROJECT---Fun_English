using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_mini
{
    public partial class fCompleted : Form
    {
        SoundPlayer successSound = new SoundPlayer("success.wav");
        public fCompleted(string player, int score, int time)
        {
            InitializeComponent();
            lbPlayer.Text = "Player: " + player;
            lbScore.Text = "Score: " + score.ToString();
            lbTime.Text = "Time: " + time.ToString();
            if (Sound.Flag)
                successSound.Play();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            successSound.Stop();
            this.Close();
        }
    }
}
