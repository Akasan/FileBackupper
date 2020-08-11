namespace FileBuckupper
{
    partial class NewTrackingForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filePathRemoveReferenceButton = new System.Windows.Forms.Button();
            this.fileListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePathAddReferenceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.folderListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderPathRemoveReferenceButton = new System.Windows.Forms.Button();
            this.folderPathAddReferenceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeUnitComboBox = new System.Windows.Forms.ComboBox();
            this.frequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.finishConfigurationButton = new System.Windows.Forms.Button();
            this.highLevelConfiguration = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 260);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filePathRemoveReferenceButton);
            this.tabPage1.Controls.Add(this.fileListView);
            this.tabPage1.Controls.Add(this.filePathAddReferenceButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ファイル";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filePathRemoveReferenceButton
            // 
            this.filePathRemoveReferenceButton.Location = new System.Drawing.Point(156, 15);
            this.filePathRemoveReferenceButton.Name = "filePathRemoveReferenceButton";
            this.filePathRemoveReferenceButton.Size = new System.Drawing.Size(49, 23);
            this.filePathRemoveReferenceButton.TabIndex = 5;
            this.filePathRemoveReferenceButton.Text = "削除";
            this.filePathRemoveReferenceButton.UseVisualStyleBackColor = true;
            this.filePathRemoveReferenceButton.Click += new System.EventHandler(this.filePathRemoveReferenceButton_Click);
            // 
            // fileListView
            // 
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(23, 50);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(824, 178);
            this.fileListView.TabIndex = 4;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ファイル名";
            this.columnHeader1.Width = 824;
            // 
            // filePathAddReferenceButton
            // 
            this.filePathAddReferenceButton.Location = new System.Drawing.Point(85, 15);
            this.filePathAddReferenceButton.Name = "filePathAddReferenceButton";
            this.filePathAddReferenceButton.Size = new System.Drawing.Size(49, 23);
            this.filePathAddReferenceButton.TabIndex = 3;
            this.filePathAddReferenceButton.Text = "追加";
            this.filePathAddReferenceButton.UseVisualStyleBackColor = true;
            this.filePathAddReferenceButton.Click += new System.EventHandler(this.filePathReferenceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ファイルパス";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.folderListView);
            this.tabPage2.Controls.Add(this.folderPathRemoveReferenceButton);
            this.tabPage2.Controls.Add(this.folderPathAddReferenceButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "フォルダ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // folderListView
            // 
            this.folderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.folderListView.HideSelection = false;
            this.folderListView.Location = new System.Drawing.Point(23, 50);
            this.folderListView.Name = "folderListView";
            this.folderListView.Size = new System.Drawing.Size(824, 178);
            this.folderListView.TabIndex = 8;
            this.folderListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ファイル名";
            this.columnHeader2.Width = 824;
            // 
            // folderPathRemoveReferenceButton
            // 
            this.folderPathRemoveReferenceButton.Location = new System.Drawing.Point(156, 15);
            this.folderPathRemoveReferenceButton.Name = "folderPathRemoveReferenceButton";
            this.folderPathRemoveReferenceButton.Size = new System.Drawing.Size(49, 23);
            this.folderPathRemoveReferenceButton.TabIndex = 7;
            this.folderPathRemoveReferenceButton.Text = "削除";
            this.folderPathRemoveReferenceButton.UseVisualStyleBackColor = true;
            this.folderPathRemoveReferenceButton.Click += new System.EventHandler(this.folderPathRemoveReferenceButton_Click);
            // 
            // folderPathAddReferenceButton
            // 
            this.folderPathAddReferenceButton.Location = new System.Drawing.Point(85, 15);
            this.folderPathAddReferenceButton.Name = "folderPathAddReferenceButton";
            this.folderPathAddReferenceButton.Size = new System.Drawing.Size(49, 23);
            this.folderPathAddReferenceButton.TabIndex = 6;
            this.folderPathAddReferenceButton.Text = "追加";
            this.folderPathAddReferenceButton.UseVisualStyleBackColor = true;
            this.folderPathAddReferenceButton.Click += new System.EventHandler(this.folderPathAddReferenceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "フォルダパス";
            // 
            // timeUnitComboBox
            // 
            this.timeUnitComboBox.FormattingEnabled = true;
            this.timeUnitComboBox.Items.AddRange(new object[] {
            "秒",
            "分",
            "時間"});
            this.timeUnitComboBox.Location = new System.Drawing.Point(240, 278);
            this.timeUnitComboBox.Name = "timeUnitComboBox";
            this.timeUnitComboBox.Size = new System.Drawing.Size(121, 20);
            this.timeUnitComboBox.TabIndex = 9;
            // 
            // frequencyNumericUpDown
            // 
            this.frequencyNumericUpDown.Location = new System.Drawing.Point(101, 278);
            this.frequencyNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.frequencyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencyNumericUpDown.Name = "frequencyNumericUpDown";
            this.frequencyNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.frequencyNumericUpDown.TabIndex = 8;
            this.frequencyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "更新頻度";
            // 
            // finishConfigurationButton
            // 
            this.finishConfigurationButton.Location = new System.Drawing.Point(17, 510);
            this.finishConfigurationButton.Name = "finishConfigurationButton";
            this.finishConfigurationButton.Size = new System.Drawing.Size(864, 32);
            this.finishConfigurationButton.TabIndex = 10;
            this.finishConfigurationButton.Text = "設定";
            this.finishConfigurationButton.UseVisualStyleBackColor = true;
            this.finishConfigurationButton.Click += new System.EventHandler(this.finishConfigurationButton_Click);
            // 
            // highLevelConfiguration
            // 
            this.highLevelConfiguration.Location = new System.Drawing.Point(16, 319);
            this.highLevelConfiguration.Name = "highLevelConfiguration";
            this.highLevelConfiguration.Size = new System.Drawing.Size(558, 154);
            this.highLevelConfiguration.TabIndex = 11;
            this.highLevelConfiguration.TabStop = false;
            this.highLevelConfiguration.Text = "高度な設定";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 571);
            this.Controls.Add(this.highLevelConfiguration);
            this.Controls.Add(this.finishConfigurationButton);
            this.Controls.Add(this.timeUnitComboBox);
            this.Controls.Add(this.frequencyNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTrackingForm";
            this.Text = "NewTrackingForm";
            this.Load += new System.EventHandler(this.NewTrackingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button filePathAddReferenceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox timeUnitComboBox;
        private System.Windows.Forms.NumericUpDown frequencyNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button finishConfigurationButton;
        private System.Windows.Forms.GroupBox highLevelConfiguration;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button filePathRemoveReferenceButton;
        private System.Windows.Forms.ListView folderListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button folderPathRemoveReferenceButton;
        private System.Windows.Forms.Button folderPathAddReferenceButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}