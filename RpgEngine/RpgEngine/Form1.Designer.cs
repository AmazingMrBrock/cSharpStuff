namespace RpgEngine
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
            this.components = new System.ComponentModel.Container();
            this.nextLevel = new System.Windows.Forms.Button();
            this.currentLevel = new System.Windows.Forms.Button();
            this.addXp = new System.Windows.Forms.Button();
            this.xpLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.nextLevelLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xpLevelListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpReqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpToNextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelingListDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelingListDataSet = new RpgEngine.LevelingListDataSet();
            this.xpLevelListTableAdapter = new RpgEngine.LevelingListDataSetTableAdapters.XpLevelListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpLevelListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelingListDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelingListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nextLevel
            // 
            this.nextLevel.Location = new System.Drawing.Point(100, 324);
            this.nextLevel.Name = "nextLevel";
            this.nextLevel.Size = new System.Drawing.Size(102, 23);
            this.nextLevel.TabIndex = 0;
            this.nextLevel.Text = "To Next Level";
            this.nextLevel.UseVisualStyleBackColor = true;
            this.nextLevel.Click += new System.EventHandler(this.LevelSystemTest_Click);
            // 
            // currentLevel
            // 
            this.currentLevel.Location = new System.Drawing.Point(100, 353);
            this.currentLevel.Name = "currentLevel";
            this.currentLevel.Size = new System.Drawing.Size(102, 23);
            this.currentLevel.TabIndex = 1;
            this.currentLevel.Text = "Current Level";
            this.currentLevel.UseVisualStyleBackColor = true;
            this.currentLevel.Click += new System.EventHandler(this.currentLevel_Click);
            // 
            // addXp
            // 
            this.addXp.Location = new System.Drawing.Point(100, 382);
            this.addXp.Name = "addXp";
            this.addXp.Size = new System.Drawing.Size(102, 23);
            this.addXp.TabIndex = 2;
            this.addXp.Text = "Add 1000 xp";
            this.addXp.UseVisualStyleBackColor = true;
            this.addXp.Click += new System.EventHandler(this.addXp_Click);
            // 
            // xpLabel
            // 
            this.xpLabel.AutoSize = true;
            this.xpLabel.Location = new System.Drawing.Point(222, 382);
            this.xpLabel.Name = "xpLabel";
            this.xpLabel.Size = new System.Drawing.Size(69, 16);
            this.xpLabel.TabIndex = 3;
            this.xpLabel.Text = "Current Xp";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(221, 353);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(86, 16);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Current Level";
            // 
            // nextLevelLabel
            // 
            this.nextLevelLabel.AutoSize = true;
            this.nextLevelLabel.Location = new System.Drawing.Point(224, 324);
            this.nextLevelLabel.Name = "nextLevelLabel";
            this.nextLevelLabel.Size = new System.Drawing.Size(71, 16);
            this.nextLevelLabel.TabIndex = 5;
            this.nextLevelLabel.Text = "Next Level";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.levelIDDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.xpReqDataGridViewTextBoxColumn,
            this.xpToNextDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xpLevelListBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(638, 294);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.VirtualMode = true;
            // 
            // xpLevelListBindingSource
            // 
            this.xpLevelListBindingSource.DataMember = "XpLevelList";
            this.xpLevelListBindingSource.DataSource = this.levelingListDataSetBindingSource;
            // 
            // levelIDDataGridViewTextBoxColumn
            // 
            this.levelIDDataGridViewTextBoxColumn.DataPropertyName = "LevelID";
            this.levelIDDataGridViewTextBoxColumn.HeaderText = "LevelID";
            this.levelIDDataGridViewTextBoxColumn.Name = "levelIDDataGridViewTextBoxColumn";
            this.levelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            // 
            // xpReqDataGridViewTextBoxColumn
            // 
            this.xpReqDataGridViewTextBoxColumn.DataPropertyName = "XpReq";
            this.xpReqDataGridViewTextBoxColumn.HeaderText = "XpReq";
            this.xpReqDataGridViewTextBoxColumn.Name = "xpReqDataGridViewTextBoxColumn";
            // 
            // xpToNextDataGridViewTextBoxColumn
            // 
            this.xpToNextDataGridViewTextBoxColumn.DataPropertyName = "XpToNext";
            this.xpToNextDataGridViewTextBoxColumn.HeaderText = "XpToNext";
            this.xpToNextDataGridViewTextBoxColumn.Name = "xpToNextDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // levelingListDataSetBindingSource
            // 
            this.levelingListDataSetBindingSource.DataSource = this.levelingListDataSet;
            this.levelingListDataSetBindingSource.Position = 0;
            // 
            // levelingListDataSet
            // 
            this.levelingListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xpLevelListTableAdapter
            // 
            this.xpLevelListTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nextLevelLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.xpLabel);
            this.Controls.Add(this.addXp);
            this.Controls.Add(this.currentLevel);
            this.Controls.Add(this.nextLevel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpLevelListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelingListDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelingListDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextLevel;
        private System.Windows.Forms.Button currentLevel;
        private System.Windows.Forms.Button addXp;
        private System.Windows.Forms.Label xpLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label nextLevelLabel;
        private System.Windows.Forms.BindingSource levelingListDataSetBindingSource;
        private LevelingListDataSet levelingListDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource xpLevelListBindingSource;
        private LevelingListDataSetTableAdapters.XpLevelListTableAdapter xpLevelListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpReqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpToNextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}

