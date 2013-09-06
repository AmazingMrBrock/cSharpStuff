
namespace dicegui
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.sidesLabel = new System.Windows.Forms.Label();
			this.diceLabel = new System.Windows.Forms.Label();
			this.dLabel = new System.Windows.Forms.Label();
			this.diceNumeric = new System.Windows.Forms.NumericUpDown();
			this.sidesNumeric = new System.Windows.Forms.NumericUpDown();
			this.rollButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.diceNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sidesNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// sidesLabel
			// 
			this.sidesLabel.Location = new System.Drawing.Point(135, 20);
			this.sidesLabel.Name = "sidesLabel";
			this.sidesLabel.Size = new System.Drawing.Size(110, 23);
			this.sidesLabel.TabIndex = 0;
			this.sidesLabel.Text = "Number of sides";
			// 
			// diceLabel
			// 
			this.diceLabel.Location = new System.Drawing.Point(10, 20);
			this.diceLabel.Name = "diceLabel";
			this.diceLabel.Size = new System.Drawing.Size(110, 23);
			this.diceLabel.TabIndex = 1;
			this.diceLabel.Text = "Number of dice";
			// 
			// dLabel
			// 
			this.dLabel.Location = new System.Drawing.Point(118, 47);
			this.dLabel.Name = "dLabel";
			this.dLabel.Size = new System.Drawing.Size(20, 23);
			this.dLabel.TabIndex = 2;
			this.dLabel.Text = "d";
			// 
			// diceNumeric
			// 
			this.diceNumeric.Location = new System.Drawing.Point(25, 45);
			this.diceNumeric.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.diceNumeric.Name = "diceNumeric";
			this.diceNumeric.Size = new System.Drawing.Size(70, 22);
			this.diceNumeric.TabIndex = 0;
			this.diceNumeric.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// sidesNumeric
			// 
			this.sidesNumeric.Location = new System.Drawing.Point(155, 45);
			this.sidesNumeric.Minimum = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.sidesNumeric.Name = "sidesNumeric";
			this.sidesNumeric.Size = new System.Drawing.Size(70, 22);
			this.sidesNumeric.TabIndex = 4;
			this.sidesNumeric.Value = new decimal(new int[] {
									2,
									0,
									0,
									0});
			// 
			// rollButton
			// 
			this.rollButton.Location = new System.Drawing.Point(27, 82);
			this.rollButton.Name = "rollButton";
			this.rollButton.Size = new System.Drawing.Size(75, 23);
			this.rollButton.TabIndex = 6;
			this.rollButton.Text = "Roll";
			this.rollButton.UseVisualStyleBackColor = true;
			this.rollButton.Click += new System.EventHandler(this.RollButtonClick);
			// 
			// resultLabel
			// 
			this.resultLabel.Location = new System.Drawing.Point(155, 85);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(100, 23);
			this.resultLabel.TabIndex = 7;
			this.resultLabel.Text = "Result";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(245, 117);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.rollButton);
			this.Controls.Add(this.sidesNumeric);
			this.Controls.Add(this.diceNumeric);
			this.Controls.Add(this.dLabel);
			this.Controls.Add(this.diceLabel);
			this.Controls.Add(this.sidesLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "dicegui";
			((System.ComponentModel.ISupportInitialize)(this.diceNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sidesNumeric)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Button rollButton;
		private System.Windows.Forms.NumericUpDown sidesNumeric;
		private System.Windows.Forms.NumericUpDown diceNumeric;
		private System.Windows.Forms.Label dLabel;
		private System.Windows.Forms.Label diceLabel;
		private System.Windows.Forms.Label sidesLabel;
	}
}
