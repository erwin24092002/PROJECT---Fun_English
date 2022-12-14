namespace Game_mini
{
    partial class fLearn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.flpLearn = new System.Windows.Forms.FlowLayoutPanel();
            this.ptbUnSound = new System.Windows.Forms.PictureBox();
            this.ptbSound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(218, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 57);
            this.label1.TabIndex = 13;
            this.label1.Text = "Learn";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(12, 618);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 53);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flpLearn
            // 
            this.flpLearn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLearn.AutoScroll = true;
            this.flpLearn.BackColor = System.Drawing.Color.Azure;
            this.flpLearn.Location = new System.Drawing.Point(53, 73);
            this.flpLearn.Name = "flpLearn";
            this.flpLearn.Size = new System.Drawing.Size(475, 528);
            this.flpLearn.TabIndex = 15;
            // 
            // ptbUnSound
            // 
            this.ptbUnSound.BackColor = System.Drawing.Color.Transparent;
            this.ptbUnSound.BackgroundImage = global::Game_mini.Properties.FormBackground.unsound;
            this.ptbUnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUnSound.Enabled = false;
            this.ptbUnSound.Location = new System.Drawing.Point(509, 12);
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
            this.ptbSound.Location = new System.Drawing.Point(509, 12);
            this.ptbSound.Name = "ptbSound";
            this.ptbSound.Size = new System.Drawing.Size(61, 60);
            this.ptbSound.TabIndex = 39;
            this.ptbSound.TabStop = false;
            this.ptbSound.Click += new System.EventHandler(this.ptbSound_Click);
            // 
            // fLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_mini.Properties.FormBackground.fLearn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 683);
            this.Controls.Add(this.ptbUnSound);
            this.Controls.Add(this.ptbSound);
            this.Controls.Add(this.flpLearn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "fLearn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn";
            this.Load += new System.EventHandler(this.fLearn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnBack;
        private FlowLayoutPanel flpLearn;
        private PictureBox ptbUnSound;
        private PictureBox ptbSound;
    }
}