namespace Game_mini
{
    partial class fHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbUnSound = new System.Windows.Forms.PictureBox();
            this.ptbSound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.Gold;
            this.btnPlay.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Location = new System.Drawing.Point(546, 425);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(160, 53);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.Gold;
            this.btnQuit.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(546, 602);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(160, 53);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnRank
            // 
            this.btnRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRank.BackColor = System.Drawing.Color.Gold;
            this.btnRank.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRank.Location = new System.Drawing.Point(546, 543);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(160, 53);
            this.btnRank.TabIndex = 2;
            this.btnRank.Text = "Rank";
            this.btnRank.UseVisualStyleBackColor = false;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLearn.BackColor = System.Drawing.Color.Gold;
            this.btnLearn.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLearn.Location = new System.Drawing.Point(546, 484);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(160, 53);
            this.btnLearn.TabIndex = 3;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(336, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 107);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fun English";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbUnSound
            // 
            this.ptbUnSound.BackColor = System.Drawing.Color.Transparent;
            this.ptbUnSound.BackgroundImage = global::Game_mini.Properties.FormBackground.unsound;
            this.ptbUnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUnSound.Enabled = false;
            this.ptbUnSound.Location = new System.Drawing.Point(1209, 12);
            this.ptbUnSound.Name = "ptbUnSound";
            this.ptbUnSound.Size = new System.Drawing.Size(61, 60);
            this.ptbUnSound.TabIndex = 40;
            this.ptbUnSound.TabStop = false;
            this.ptbUnSound.Visible = false;
            this.ptbUnSound.Click += new System.EventHandler(this.ptbUnSound_Click);
            // 
            // ptbSound
            // 
            this.ptbSound.BackColor = System.Drawing.Color.Transparent;
            this.ptbSound.BackgroundImage = global::Game_mini.Properties.FormBackground.sound;
            this.ptbSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbSound.Location = new System.Drawing.Point(1209, 12);
            this.ptbSound.Name = "ptbSound";
            this.ptbSound.Size = new System.Drawing.Size(61, 60);
            this.ptbSound.TabIndex = 39;
            this.ptbSound.TabStop = false;
            this.ptbSound.Click += new System.EventHandler(this.ptbSound_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_mini.Properties.FormBackground.fHome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 683);
            this.Controls.Add(this.ptbUnSound);
            this.Controls.Add(this.ptbSound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fHome_FormClosing);
            this.Load += new System.EventHandler(this.fHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPlay;
        private Button btnQuit;
        private Button btnRank;
        private Button btnLearn;
        private Label label1;
        private PictureBox ptbUnSound;
        private PictureBox ptbSound;
    }
}