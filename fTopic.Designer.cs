namespace Game_mini
{
    partial class fTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTopic));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.btnFruits = new System.Windows.Forms.Button();
            this.btnTransportation = new System.Windows.Forms.Button();
            this.btnPlants = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClothing = new System.Windows.Forms.Button();
            this.btnVegetables = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(594, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Topics";
            // 
            // btnAnimals
            // 
            this.btnAnimals.BackgroundImage = global::Game_mini.Properties.Animals.AnimalsIcon;
            this.btnAnimals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnimals.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnimals.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAnimals.Location = new System.Drawing.Point(222, 85);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(240, 230);
            this.btnAnimals.TabIndex = 3;
            this.btnAnimals.Text = "Animals";
            this.btnAnimals.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnimals.UseVisualStyleBackColor = true;
            this.btnAnimals.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnFruits
            // 
            this.btnFruits.BackgroundImage = global::Game_mini.Properties.Fruits.FruitsIcon;
            this.btnFruits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFruits.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFruits.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFruits.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFruits.Location = new System.Drawing.Point(522, 85);
            this.btnFruits.Name = "btnFruits";
            this.btnFruits.Size = new System.Drawing.Size(240, 230);
            this.btnFruits.TabIndex = 4;
            this.btnFruits.Text = "Fruits";
            this.btnFruits.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFruits.UseVisualStyleBackColor = true;
            this.btnFruits.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnTransportation
            // 
            this.btnTransportation.BackgroundImage = global::Game_mini.Properties.Transportation.TransportationIcon;
            this.btnTransportation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransportation.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransportation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTransportation.Location = new System.Drawing.Point(522, 331);
            this.btnTransportation.Name = "btnTransportation";
            this.btnTransportation.Size = new System.Drawing.Size(240, 230);
            this.btnTransportation.TabIndex = 5;
            this.btnTransportation.Text = "Transportation";
            this.btnTransportation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransportation.UseVisualStyleBackColor = true;
            this.btnTransportation.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnPlants
            // 
            this.btnPlants.BackgroundImage = global::Game_mini.Properties.Plants.PlantsIcon;
            this.btnPlants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlants.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlants.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPlants.Location = new System.Drawing.Point(222, 331);
            this.btnPlants.Name = "btnPlants";
            this.btnPlants.Size = new System.Drawing.Size(240, 230);
            this.btnPlants.TabIndex = 6;
            this.btnPlants.Text = "Plants";
            this.btnPlants.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlants.UseVisualStyleBackColor = true;
            this.btnPlants.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(46, 596);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 53);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClothing
            // 
            this.btnClothing.BackgroundImage = global::Game_mini.Properties.Clothing.ClothingIcon;
            this.btnClothing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClothing.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClothing.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClothing.Location = new System.Drawing.Point(817, 85);
            this.btnClothing.Name = "btnClothing";
            this.btnClothing.Size = new System.Drawing.Size(240, 230);
            this.btnClothing.TabIndex = 10;
            this.btnClothing.Text = "Clothing";
            this.btnClothing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClothing.UseVisualStyleBackColor = true;
            this.btnClothing.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnVegetables
            // 
            this.btnVegetables.BackgroundImage = global::Game_mini.Properties.Vegetables.VegetablesIcon;
            this.btnVegetables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVegetables.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVegetables.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVegetables.Location = new System.Drawing.Point(817, 331);
            this.btnVegetables.Name = "btnVegetables";
            this.btnVegetables.Size = new System.Drawing.Size(240, 230);
            this.btnVegetables.TabIndex = 11;
            this.btnVegetables.Text = "Vegetables";
            this.btnVegetables.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVegetables.UseVisualStyleBackColor = true;
            this.btnVegetables.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Gold;
            this.btnPlay.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.Location = new System.Drawing.Point(1070, 596);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(160, 53);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(371, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Your Name:";
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Font = new System.Drawing.Font("Cooper Black", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPlayerName.ForeColor = System.Drawing.Color.OrangeRed;
            this.txbPlayerName.Location = new System.Drawing.Point(594, 609);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(332, 40);
            this.txbPlayerName.TabIndex = 23;
            this.txbPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // fTopic
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_mini.Properties.FormBackground.fTopic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 683);
            this.Controls.Add(this.ptbUnSound);
            this.Controls.Add(this.ptbSound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPlayerName);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnVegetables);
            this.Controls.Add(this.btnClothing);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlants);
            this.Controls.Add(this.btnTransportation);
            this.Controls.Add(this.btnFruits);
            this.Controls.Add(this.btnAnimals);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Game";
            this.Load += new System.EventHandler(this.fTopic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAnimals;
        private Button btnFruits;
        private Button btnTransportation;
        private Button btnPlants;
        private Button btnBack;
        private Button btnClothing;
        private Button btnVegetables;
        private Button btnPlay;
        private Label label3;
        private TextBox txbPlayerName;
        private PictureBox ptbUnSound;
        private PictureBox ptbSound;
    }
}