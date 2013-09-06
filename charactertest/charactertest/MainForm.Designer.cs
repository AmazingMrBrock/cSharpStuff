/*
 * Created by SharpDevelop.
 * User: b
 * Date: 03/09/2013
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace charactertest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.nameLabel = new System.Windows.Forms.Label();
			this.stLabel = new System.Windows.Forms.Label();
			this.agLabel = new System.Windows.Forms.Label();
			this.healthLabel = new System.Windows.Forms.Label();
			this.manaLabel = new System.Windows.Forms.Label();
			this.intLabel = new System.Windows.Forms.Label();
			this.pcNameLabel = new System.Windows.Forms.Label();
			this.pcStLabel = new System.Windows.Forms.Label();
			this.pcAgLabel = new System.Windows.Forms.Label();
			this.pcHealthLabel = new System.Windows.Forms.Label();
			this.pcManaLabel = new System.Windows.Forms.Label();
			this.pcIntLabel = new System.Windows.Forms.Label();
			this.enNameLabel = new System.Windows.Forms.Label();
			this.enStLabel = new System.Windows.Forms.Label();
			this.enAgLabel = new System.Windows.Forms.Label();
			this.enHealthLabel = new System.Windows.Forms.Label();
			this.enManaLabel = new System.Windows.Forms.Label();
			this.enIntLabel = new System.Windows.Forms.Label();
			this.pcMeleeButt = new System.Windows.Forms.Button();
			this.pcRangedButt = new System.Windows.Forms.Button();
			this.pcFireballButt = new System.Windows.Forms.Button();
			this.pcHealingButt = new System.Windows.Forms.Button();
			this.chClassButt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(13, 13);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(144, 23);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name                          -";
			// 
			// stLabel
			// 
			this.stLabel.Location = new System.Drawing.Point(13, 80);
			this.stLabel.Name = "stLabel";
			this.stLabel.Size = new System.Drawing.Size(144, 23);
			this.stLabel.TabIndex = 0;
			this.stLabel.Text = "Strength                       -";
			// 
			// agLabel
			// 
			this.agLabel.Location = new System.Drawing.Point(14, 104);
			this.agLabel.Name = "agLabel";
			this.agLabel.Size = new System.Drawing.Size(143, 23);
			this.agLabel.TabIndex = 0;
			this.agLabel.Text = "Agility                           -";
			// 
			// healthLabel
			// 
			this.healthLabel.Location = new System.Drawing.Point(14, 36);
			this.healthLabel.Name = "healthLabel";
			this.healthLabel.Size = new System.Drawing.Size(143, 23);
			this.healthLabel.TabIndex = 0;
			this.healthLabel.Text = "Health                         -";
			// 
			// manaLabel
			// 
			this.manaLabel.Location = new System.Drawing.Point(14, 58);
			this.manaLabel.Name = "manaLabel";
			this.manaLabel.Size = new System.Drawing.Size(143, 23);
			this.manaLabel.TabIndex = 0;
			this.manaLabel.Text = "Mana                           -";
			// 
			// intLabel
			// 
			this.intLabel.Location = new System.Drawing.Point(15, 128);
			this.intLabel.Name = "intLabel";
			this.intLabel.Size = new System.Drawing.Size(143, 23);
			this.intLabel.TabIndex = 0;
			this.intLabel.Text = "Intelligence                -";
			// 
			// pcNameLabel
			// 
			this.pcNameLabel.Location = new System.Drawing.Point(194, 13);
			this.pcNameLabel.Name = "pcNameLabel";
			this.pcNameLabel.Size = new System.Drawing.Size(137, 23);
			this.pcNameLabel.TabIndex = 0;
			// 
			// pcStLabel
			// 
			this.pcStLabel.Location = new System.Drawing.Point(207, 80);
			this.pcStLabel.Name = "pcStLabel";
			this.pcStLabel.Size = new System.Drawing.Size(100, 23);
			this.pcStLabel.TabIndex = 0;
			// 
			// pcAgLabel
			// 
			this.pcAgLabel.Location = new System.Drawing.Point(208, 104);
			this.pcAgLabel.Name = "pcAgLabel";
			this.pcAgLabel.Size = new System.Drawing.Size(100, 23);
			this.pcAgLabel.TabIndex = 0;
			// 
			// pcHealthLabel
			// 
			this.pcHealthLabel.Location = new System.Drawing.Point(205, 36);
			this.pcHealthLabel.Name = "pcHealthLabel";
			this.pcHealthLabel.Size = new System.Drawing.Size(100, 23);
			this.pcHealthLabel.TabIndex = 0;
			// 
			// pcManaLabel
			// 
			this.pcManaLabel.Location = new System.Drawing.Point(206, 58);
			this.pcManaLabel.Name = "pcManaLabel";
			this.pcManaLabel.Size = new System.Drawing.Size(100, 23);
			this.pcManaLabel.TabIndex = 0;
			// 
			// pcIntLabel
			// 
			this.pcIntLabel.Location = new System.Drawing.Point(207, 128);
			this.pcIntLabel.Name = "pcIntLabel";
			this.pcIntLabel.Size = new System.Drawing.Size(100, 23);
			this.pcIntLabel.TabIndex = 0;
			// 
			// enNameLabel
			// 
			this.enNameLabel.Location = new System.Drawing.Point(367, 13);
			this.enNameLabel.Name = "enNameLabel";
			this.enNameLabel.Size = new System.Drawing.Size(100, 23);
			this.enNameLabel.TabIndex = 0;
			// 
			// enStLabel
			// 
			this.enStLabel.Location = new System.Drawing.Point(392, 80);
			this.enStLabel.Name = "enStLabel";
			this.enStLabel.Size = new System.Drawing.Size(100, 23);
			this.enStLabel.TabIndex = 0;
			// 
			// enAgLabel
			// 
			this.enAgLabel.Location = new System.Drawing.Point(392, 104);
			this.enAgLabel.Name = "enAgLabel";
			this.enAgLabel.Size = new System.Drawing.Size(100, 23);
			this.enAgLabel.TabIndex = 0;
			// 
			// enHealthLabel
			// 
			this.enHealthLabel.Location = new System.Drawing.Point(389, 36);
			this.enHealthLabel.Name = "enHealthLabel";
			this.enHealthLabel.Size = new System.Drawing.Size(100, 23);
			this.enHealthLabel.TabIndex = 0;
			// 
			// enManaLabel
			// 
			this.enManaLabel.Location = new System.Drawing.Point(392, 58);
			this.enManaLabel.Name = "enManaLabel";
			this.enManaLabel.Size = new System.Drawing.Size(100, 23);
			this.enManaLabel.TabIndex = 0;
			// 
			// enIntLabel
			// 
			this.enIntLabel.Location = new System.Drawing.Point(397, 128);
			this.enIntLabel.Name = "enIntLabel";
			this.enIntLabel.Size = new System.Drawing.Size(100, 23);
			this.enIntLabel.TabIndex = 0;
			// 
			// pcMeleeButt
			// 
			this.pcMeleeButt.Location = new System.Drawing.Point(140, 204);
			this.pcMeleeButt.Name = "pcMeleeButt";
			this.pcMeleeButt.Size = new System.Drawing.Size(75, 23);
			this.pcMeleeButt.TabIndex = 1;
			this.pcMeleeButt.Text = "Melee";
			this.pcMeleeButt.UseVisualStyleBackColor = true;
			this.pcMeleeButt.Click += new System.EventHandler(this.PcMeleeButtClick);
			// 
			// pcRangedButt
			// 
			this.pcRangedButt.Location = new System.Drawing.Point(140, 233);
			this.pcRangedButt.Name = "pcRangedButt";
			this.pcRangedButt.Size = new System.Drawing.Size(75, 23);
			this.pcRangedButt.TabIndex = 1;
			this.pcRangedButt.Text = "Ranged";
			this.pcRangedButt.UseVisualStyleBackColor = true;
			this.pcRangedButt.Click += new System.EventHandler(this.PcRangedButtClick);
			// 
			// pcFireballButt
			// 
			this.pcFireballButt.Location = new System.Drawing.Point(221, 204);
			this.pcFireballButt.Name = "pcFireballButt";
			this.pcFireballButt.Size = new System.Drawing.Size(75, 23);
			this.pcFireballButt.TabIndex = 1;
			this.pcFireballButt.Text = "Fireball";
			this.pcFireballButt.UseVisualStyleBackColor = true;
			this.pcFireballButt.Click += new System.EventHandler(this.PcFireballButtClick);
			// 
			// pcHealingButt
			// 
			this.pcHealingButt.Location = new System.Drawing.Point(221, 233);
			this.pcHealingButt.Name = "pcHealingButt";
			this.pcHealingButt.Size = new System.Drawing.Size(75, 23);
			this.pcHealingButt.TabIndex = 1;
			this.pcHealingButt.Text = "Healing";
			this.pcHealingButt.UseVisualStyleBackColor = true;
			this.pcHealingButt.Click += new System.EventHandler(this.PcHealingButtClick);
			// 
			// chClassButt
			// 
			this.chClassButt.Location = new System.Drawing.Point(15, 204);
			this.chClassButt.Name = "chClassButt";
			this.chClassButt.Size = new System.Drawing.Size(75, 23);
			this.chClassButt.TabIndex = 2;
			this.chClassButt.Text = "Change Class\'";
			this.chClassButt.UseVisualStyleBackColor = true;
			this.chClassButt.Click += new System.EventHandler(this.ChClassButtClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 292);
			this.Controls.Add(this.chClassButt);
			this.Controls.Add(this.pcHealingButt);
			this.Controls.Add(this.pcFireballButt);
			this.Controls.Add(this.pcRangedButt);
			this.Controls.Add(this.pcMeleeButt);
			this.Controls.Add(this.enIntLabel);
			this.Controls.Add(this.pcIntLabel);
			this.Controls.Add(this.intLabel);
			this.Controls.Add(this.enManaLabel);
			this.Controls.Add(this.pcManaLabel);
			this.Controls.Add(this.manaLabel);
			this.Controls.Add(this.enHealthLabel);
			this.Controls.Add(this.pcHealthLabel);
			this.Controls.Add(this.healthLabel);
			this.Controls.Add(this.enAgLabel);
			this.Controls.Add(this.pcAgLabel);
			this.Controls.Add(this.agLabel);
			this.Controls.Add(this.enStLabel);
			this.Controls.Add(this.pcStLabel);
			this.Controls.Add(this.stLabel);
			this.Controls.Add(this.enNameLabel);
			this.Controls.Add(this.pcNameLabel);
			this.Controls.Add(this.nameLabel);
			this.Name = "MainForm";
			this.Text = "charactertest";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button chClassButt;
		private System.Windows.Forms.Button pcHealingButt;
		private System.Windows.Forms.Button pcFireballButt;
		private System.Windows.Forms.Button pcRangedButt;
		private System.Windows.Forms.Button pcMeleeButt;
		private System.Windows.Forms.Label enIntLabel;
		private System.Windows.Forms.Label enManaLabel;
		private System.Windows.Forms.Label enHealthLabel;
		private System.Windows.Forms.Label enAgLabel;
		private System.Windows.Forms.Label enStLabel;
		private System.Windows.Forms.Label enNameLabel;
		private System.Windows.Forms.Label pcIntLabel;
		private System.Windows.Forms.Label pcManaLabel;
		private System.Windows.Forms.Label pcHealthLabel;
		private System.Windows.Forms.Label pcAgLabel;
		private System.Windows.Forms.Label pcStLabel;
		private System.Windows.Forms.Label pcNameLabel;
		private System.Windows.Forms.Label intLabel;
		private System.Windows.Forms.Label manaLabel;
		private System.Windows.Forms.Label healthLabel;
		private System.Windows.Forms.Label agLabel;
		private System.Windows.Forms.Label stLabel;
		private System.Windows.Forms.Label nameLabel;
	}
}
