namespace MileageCalculator
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
            this.stMileage = new System.Windows.Forms.NumericUpDown();
            this.enMileage = new System.Windows.Forms.NumericUpDown();
            this.calculate = new System.Windows.Forms.Button();
            this.amOwed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dislpayMiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // stMileage
            // 
            this.stMileage.Location = new System.Drawing.Point(143, 20);
            this.stMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.stMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stMileage.Name = "stMileage";
            this.stMileage.Size = new System.Drawing.Size(120, 22);
            this.stMileage.TabIndex = 0;
            this.stMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // enMileage
            // 
            this.enMileage.Location = new System.Drawing.Point(143, 57);
            this.enMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.enMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enMileage.Name = "enMileage";
            this.enMileage.Size = new System.Drawing.Size(120, 22);
            this.enMileage.TabIndex = 1;
            this.enMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(26, 132);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // amOwed
            // 
            this.amOwed.AutoSize = true;
            this.amOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amOwed.Location = new System.Drawing.Point(143, 97);
            this.amOwed.Name = "amOwed";
            this.amOwed.Size = new System.Drawing.Size(25, 25);
            this.amOwed.TabIndex = 3;
            this.amOwed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Owed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ending Mileage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Starting Mileage";
            // 
            // dislpayMiles
            // 
            this.dislpayMiles.Location = new System.Drawing.Point(143, 132);
            this.dislpayMiles.Name = "dislpayMiles";
            this.dislpayMiles.Size = new System.Drawing.Size(120, 23);
            this.dislpayMiles.TabIndex = 7;
            this.dislpayMiles.Text = "Display Miles";
            this.dislpayMiles.UseVisualStyleBackColor = true;
            this.dislpayMiles.Click += new System.EventHandler(this.dislpayMiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 167);
            this.Controls.Add(this.dislpayMiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amOwed);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.enMileage);
            this.Controls.Add(this.stMileage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculate Mileage-";
            ((System.ComponentModel.ISupportInitialize)(this.stMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown stMileage;
        private System.Windows.Forms.NumericUpDown enMileage;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label amOwed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dislpayMiles;
    }
}

