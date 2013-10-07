/*
 * Created by SharpDevelop.
 * User: b
 * Date: 03/09/2013
 * Time: 6:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace charactertest
{
	partial class CharStats
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.fighterButton = new System.Windows.Forms.Button();
			this.rangerButton = new System.Windows.Forms.Button();
			this.mageButton = new System.Windows.Forms.Button();
			this.trollButton = new System.Windows.Forms.Button();
			this.bFighterButton = new System.Windows.Forms.Button();
			this.bRangerButton = new System.Windows.Forms.Button();
			this.bMageButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Player";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(222, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Enemy";
			// 
			// fighterButton
			// 
			this.fighterButton.Location = new System.Drawing.Point(38, 40);
			this.fighterButton.Name = "fighterButton";
			this.fighterButton.Size = new System.Drawing.Size(75, 23);
			this.fighterButton.TabIndex = 1;
			this.fighterButton.Text = "Fighter";
			this.fighterButton.UseVisualStyleBackColor = true;
			this.fighterButton.Click += new System.EventHandler(this.FighterButtonClick);
			// 
			// rangerButton
			// 
			this.rangerButton.Location = new System.Drawing.Point(38, 69);
			this.rangerButton.Name = "rangerButton";
			this.rangerButton.Size = new System.Drawing.Size(75, 23);
			this.rangerButton.TabIndex = 1;
			this.rangerButton.Text = "Ranger";
			this.rangerButton.UseVisualStyleBackColor = true;
			this.rangerButton.Click += new System.EventHandler(this.RangerButtonClick);
			// 
			// mageButton
			// 
			this.mageButton.Location = new System.Drawing.Point(38, 98);
			this.mageButton.Name = "mageButton";
			this.mageButton.Size = new System.Drawing.Size(75, 23);
			this.mageButton.TabIndex = 1;
			this.mageButton.Text = "Mage";
			this.mageButton.UseVisualStyleBackColor = true;
			this.mageButton.Click += new System.EventHandler(this.MageButtonClick);
			// 
			// trollButton
			// 
			this.trollButton.Location = new System.Drawing.Point(222, 39);
			this.trollButton.Name = "trollButton";
			this.trollButton.Size = new System.Drawing.Size(110, 23);
			this.trollButton.TabIndex = 1;
			this.trollButton.Text = "Troll";
			this.trollButton.UseVisualStyleBackColor = true;
			this.trollButton.Click += new System.EventHandler(this.TrollButtonClick);
			// 
			// bFighterButton
			// 
			this.bFighterButton.Location = new System.Drawing.Point(222, 69);
			this.bFighterButton.Name = "bFighterButton";
			this.bFighterButton.Size = new System.Drawing.Size(110, 23);
			this.bFighterButton.TabIndex = 1;
			this.bFighterButton.Text = "Bandit Fighter";
			this.bFighterButton.UseVisualStyleBackColor = true;
			this.bFighterButton.Click += new System.EventHandler(this.BFighterButtonClick);
			// 
			// bRangerButton
			// 
			this.bRangerButton.Location = new System.Drawing.Point(222, 98);
			this.bRangerButton.Name = "bRangerButton";
			this.bRangerButton.Size = new System.Drawing.Size(110, 23);
			this.bRangerButton.TabIndex = 1;
			this.bRangerButton.Text = "Bandit Ranger";
			this.bRangerButton.UseVisualStyleBackColor = true;
			this.bRangerButton.Click += new System.EventHandler(this.BRangerButtonClick);
			// 
			// bMageButton
			// 
			this.bMageButton.Location = new System.Drawing.Point(222, 127);
			this.bMageButton.Name = "bMageButton";
			this.bMageButton.Size = new System.Drawing.Size(110, 23);
			this.bMageButton.TabIndex = 1;
			this.bMageButton.Text = "Bandit Mage";
			this.bMageButton.UseVisualStyleBackColor = true;
			this.bMageButton.Click += new System.EventHandler(this.BMageButtonClick);
			// 
			// CharStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 174);
			this.Controls.Add(this.bMageButton);
			this.Controls.Add(this.bRangerButton);
			this.Controls.Add(this.mageButton);
			this.Controls.Add(this.bFighterButton);
			this.Controls.Add(this.rangerButton);
			this.Controls.Add(this.trollButton);
			this.Controls.Add(this.fighterButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CharStats";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button bMageButton;
		private System.Windows.Forms.Button bRangerButton;
		private System.Windows.Forms.Button bFighterButton;
		private System.Windows.Forms.Button trollButton;
		private System.Windows.Forms.Button mageButton;
		private System.Windows.Forms.Button rangerButton;
		private System.Windows.Forms.Button fighterButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
