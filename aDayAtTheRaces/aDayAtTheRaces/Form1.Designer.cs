namespace aDayAtTheRaces
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            this.BobRadioButton = new System.Windows.Forms.RadioButton();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.BetButton = new System.Windows.Forms.Button();
            this.RaceButton = new System.Windows.Forms.Button();
            this.BetNumeric = new System.Windows.Forms.NumericUpDown();
            this.DogNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinBet = new System.Windows.Forms.Label();
            this.BettingParlor = new System.Windows.Forms.GroupBox();
            this.AlsLabel = new System.Windows.Forms.Label();
            this.BobsLabel = new System.Windows.Forms.Label();
            this.JoesLabel = new System.Windows.Forms.Label();
            this.BetsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumeric)).BeginInit();
            this.BettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(14, 57);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(77, 20);
            this.JoeRadioButton.TabIndex = 0;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.Text = "Joe has";
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            // 
            // BobRadioButton
            // 
            this.BobRadioButton.AutoSize = true;
            this.BobRadioButton.Location = new System.Drawing.Point(14, 82);
            this.BobRadioButton.Name = "BobRadioButton";
            this.BobRadioButton.Size = new System.Drawing.Size(79, 20);
            this.BobRadioButton.TabIndex = 1;
            this.BobRadioButton.TabStop = true;
            this.BobRadioButton.Text = "Bob has";
            this.BobRadioButton.UseVisualStyleBackColor = true;
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Location = new System.Drawing.Point(14, 108);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(66, 20);
            this.AlRadioButton.TabIndex = 2;
            this.AlRadioButton.TabStop = true;
            this.AlRadioButton.Text = "Al has";
            this.AlRadioButton.UseVisualStyleBackColor = true;
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(14, 134);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(75, 23);
            this.BetButton.TabIndex = 3;
            this.BetButton.Text = "Bets";
            this.BetButton.UseVisualStyleBackColor = true;
            // 
            // RaceButton
            // 
            this.RaceButton.Location = new System.Drawing.Point(462, 131);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(75, 26);
            this.RaceButton.TabIndex = 4;
            this.RaceButton.Text = "Race!";
            this.RaceButton.UseVisualStyleBackColor = true;
            // 
            // BetNumeric
            // 
            this.BetNumeric.Location = new System.Drawing.Point(95, 135);
            this.BetNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetNumeric.Name = "BetNumeric";
            this.BetNumeric.Size = new System.Drawing.Size(66, 22);
            this.BetNumeric.TabIndex = 5;
            this.BetNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DogNumeric
            // 
            this.DogNumeric.Location = new System.Drawing.Point(403, 134);
            this.DogNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogNumeric.Name = "DogNumeric";
            this.DogNumeric.Size = new System.Drawing.Size(53, 22);
            this.DogNumeric.TabIndex = 6;
            this.DogNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinBet
            // 
            this.MinBet.AutoSize = true;
            this.MinBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBet.Location = new System.Drawing.Point(11, 25);
            this.MinBet.Name = "MinBet";
            this.MinBet.Size = new System.Drawing.Size(151, 16);
            this.MinBet.TabIndex = 7;
            this.MinBet.Text = "Minimum bet 5 bucks";
            // 
            // BettingParlor
            // 
            this.BettingParlor.Controls.Add(this.AlsLabel);
            this.BettingParlor.Controls.Add(this.BobsLabel);
            this.BettingParlor.Controls.Add(this.JoesLabel);
            this.BettingParlor.Controls.Add(this.BetsLabel);
            this.BettingParlor.Controls.Add(this.DogNumeric);
            this.BettingParlor.Controls.Add(this.MinBet);
            this.BettingParlor.Controls.Add(this.RaceButton);
            this.BettingParlor.Controls.Add(this.BetNumeric);
            this.BettingParlor.Controls.Add(this.BetButton);
            this.BettingParlor.Controls.Add(this.JoeRadioButton);
            this.BettingParlor.Controls.Add(this.AlRadioButton);
            this.BettingParlor.Controls.Add(this.BobRadioButton);
            this.BettingParlor.Location = new System.Drawing.Point(12, 252);
            this.BettingParlor.Name = "BettingParlor";
            this.BettingParlor.Size = new System.Drawing.Size(604, 180);
            this.BettingParlor.TabIndex = 8;
            this.BettingParlor.TabStop = false;
            this.BettingParlor.Text = "Betting Parlor";
            // 
            // AlsLabel
            // 
            this.AlsLabel.AutoSize = true;
            this.AlsLabel.Location = new System.Drawing.Point(404, 104);
            this.AlsLabel.Name = "AlsLabel";
            this.AlsLabel.Size = new System.Drawing.Size(136, 16);
            this.AlsLabel.TabIndex = 11;
            this.AlsLabel.Text = "Al hasn\'t placed a bet";
            // 
            // BobsLabel
            // 
            this.BobsLabel.AutoSize = true;
            this.BobsLabel.Location = new System.Drawing.Point(403, 81);
            this.BobsLabel.Name = "BobsLabel";
            this.BobsLabel.Size = new System.Drawing.Size(149, 16);
            this.BobsLabel.TabIndex = 10;
            this.BobsLabel.Text = "Bob hasn\'t placed a bet";
            // 
            // JoesLabel
            // 
            this.JoesLabel.AutoSize = true;
            this.JoesLabel.Location = new System.Drawing.Point(403, 52);
            this.JoesLabel.Name = "JoesLabel";
            this.JoesLabel.Size = new System.Drawing.Size(147, 16);
            this.JoesLabel.TabIndex = 9;
            this.JoesLabel.Text = "Joe hasn\'t placed a bet";
            // 
            // BetsLabel
            // 
            this.BetsLabel.AutoSize = true;
            this.BetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetsLabel.Location = new System.Drawing.Point(403, 20);
            this.BetsLabel.Name = "BetsLabel";
            this.BetsLabel.Size = new System.Drawing.Size(39, 16);
            this.BetsLabel.TabIndex = 8;
            this.BetsLabel.Text = "Bets";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(26, 134);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(26, 187);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 444);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BettingParlor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BetNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumeric)).EndInit();
            this.BettingParlor.ResumeLayout(false);
            this.BettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.RadioButton BobRadioButton;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.NumericUpDown BetNumeric;
        private System.Windows.Forms.NumericUpDown DogNumeric;
        private System.Windows.Forms.Label MinBet;
        private System.Windows.Forms.GroupBox BettingParlor;
        private System.Windows.Forms.Label AlsLabel;
        private System.Windows.Forms.Label BobsLabel;
        private System.Windows.Forms.Label JoesLabel;
        private System.Windows.Forms.Label BetsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;

    }
}

