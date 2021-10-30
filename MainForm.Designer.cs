
namespace AudioCodes_First_Task___Almog_Geva
{
    partial class MainForm
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
            this.label_instructions = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_OpenFolderBrowser = new System.Windows.Forms.Button();
            this.button_FetchFiles = new System.Windows.Forms.Button();
            this.checkedListBox_Files = new System.Windows.Forms.CheckedListBox();
            this.panel_InfoPanel = new System.Windows.Forms.Panel();
            this.panel_InnerInfoPanel = new System.Windows.Forms.Panel();
            this.label_FileValidLabel = new System.Windows.Forms.Label();
            this.label_FileNameLabel = new System.Windows.Forms.Label();
            this.label_FileLengthLabel = new System.Windows.Forms.Label();
            this.label_FileSizeLabel = new System.Windows.Forms.Label();
            this.label_ValidLabel = new System.Windows.Forms.Label();
            this.label_LengthLabel = new System.Windows.Forms.Label();
            this.label_SizeLabel = new System.Windows.Forms.Label();
            this.label_NameLabel = new System.Windows.Forms.Label();
            this.button_DataSync = new System.Windows.Forms.Button();
            this.panel_InfoPanel.SuspendLayout();
            this.panel_InnerInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_instructions
            // 
            this.label_instructions.AutoSize = true;
            this.label_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instructions.Location = new System.Drawing.Point(24, 23);
            this.label_instructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_instructions.Name = "label_instructions";
            this.label_instructions.Size = new System.Drawing.Size(374, 31);
            this.label_instructions.TabIndex = 0;
            this.label_instructions.Text = "Choose a Directory to search:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // button_OpenFolderBrowser
            // 
            this.button_OpenFolderBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_OpenFolderBrowser.Location = new System.Drawing.Point(412, 15);
            this.button_OpenFolderBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.button_OpenFolderBrowser.Name = "button_OpenFolderBrowser";
            this.button_OpenFolderBrowser.Size = new System.Drawing.Size(244, 54);
            this.button_OpenFolderBrowser.TabIndex = 1;
            this.button_OpenFolderBrowser.Text = "Browse Folders";
            this.button_OpenFolderBrowser.UseVisualStyleBackColor = true;
            this.button_OpenFolderBrowser.Click += new System.EventHandler(this.button_OpenFolderBrowser_Click);
            // 
            // button_FetchFiles
            // 
            this.button_FetchFiles.Location = new System.Drawing.Point(412, 77);
            this.button_FetchFiles.Margin = new System.Windows.Forms.Padding(4);
            this.button_FetchFiles.Name = "button_FetchFiles";
            this.button_FetchFiles.Size = new System.Drawing.Size(244, 60);
            this.button_FetchFiles.TabIndex = 2;
            this.button_FetchFiles.Text = "Fetch .mp3 files";
            this.button_FetchFiles.UseVisualStyleBackColor = true;
            this.button_FetchFiles.Click += new System.EventHandler(this.button_FetchFiles_Click);
            // 
            // checkedListBox_Files
            // 
            this.checkedListBox_Files.FormattingEnabled = true;
            this.checkedListBox_Files.Location = new System.Drawing.Point(30, 158);
            this.checkedListBox_Files.Name = "checkedListBox_Files";
            this.checkedListBox_Files.Size = new System.Drawing.Size(605, 200);
            this.checkedListBox_Files.TabIndex = 3;
            this.checkedListBox_Files.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Files_ItemCheck);
            this.checkedListBox_Files.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Files_SelectedIndexChanged);
            // 
            // panel_InfoPanel
            // 
            this.panel_InfoPanel.Controls.Add(this.panel_InnerInfoPanel);
            this.panel_InfoPanel.Controls.Add(this.label_ValidLabel);
            this.panel_InfoPanel.Controls.Add(this.label_LengthLabel);
            this.panel_InfoPanel.Controls.Add(this.label_SizeLabel);
            this.panel_InfoPanel.Controls.Add(this.label_NameLabel);
            this.panel_InfoPanel.Location = new System.Drawing.Point(30, 383);
            this.panel_InfoPanel.Name = "panel_InfoPanel";
            this.panel_InfoPanel.Size = new System.Drawing.Size(605, 193);
            this.panel_InfoPanel.TabIndex = 4;
            // 
            // panel_InnerInfoPanel
            // 
            this.panel_InnerInfoPanel.Controls.Add(this.label_FileValidLabel);
            this.panel_InnerInfoPanel.Controls.Add(this.label_FileNameLabel);
            this.panel_InnerInfoPanel.Controls.Add(this.label_FileLengthLabel);
            this.panel_InnerInfoPanel.Controls.Add(this.label_FileSizeLabel);
            this.panel_InnerInfoPanel.Location = new System.Drawing.Point(131, 3);
            this.panel_InnerInfoPanel.Name = "panel_InnerInfoPanel";
            this.panel_InnerInfoPanel.Size = new System.Drawing.Size(456, 190);
            this.panel_InnerInfoPanel.TabIndex = 4;
            this.panel_InnerInfoPanel.Visible = false;
            // 
            // label_FileValidLabel
            // 
            this.label_FileValidLabel.AutoSize = true;
            this.label_FileValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileValidLabel.Location = new System.Drawing.Point(13, 132);
            this.label_FileValidLabel.Name = "label_FileValidLabel";
            this.label_FileValidLabel.Size = new System.Drawing.Size(82, 31);
            this.label_FileValidLabel.TabIndex = 8;
            this.label_FileValidLabel.Text = "Valid:";
            // 
            // label_FileNameLabel
            // 
            this.label_FileNameLabel.AutoSize = true;
            this.label_FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileNameLabel.Location = new System.Drawing.Point(13, 9);
            this.label_FileNameLabel.Name = "label_FileNameLabel";
            this.label_FileNameLabel.Size = new System.Drawing.Size(94, 31);
            this.label_FileNameLabel.TabIndex = 5;
            this.label_FileNameLabel.Text = "Name:";
            // 
            // label_FileLengthLabel
            // 
            this.label_FileLengthLabel.AutoSize = true;
            this.label_FileLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileLengthLabel.Location = new System.Drawing.Point(13, 89);
            this.label_FileLengthLabel.Name = "label_FileLengthLabel";
            this.label_FileLengthLabel.Size = new System.Drawing.Size(105, 31);
            this.label_FileLengthLabel.TabIndex = 7;
            this.label_FileLengthLabel.Text = "Length:";
            // 
            // label_FileSizeLabel
            // 
            this.label_FileSizeLabel.AutoSize = true;
            this.label_FileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileSizeLabel.Location = new System.Drawing.Point(13, 49);
            this.label_FileSizeLabel.Name = "label_FileSizeLabel";
            this.label_FileSizeLabel.Size = new System.Drawing.Size(75, 31);
            this.label_FileSizeLabel.TabIndex = 6;
            this.label_FileSizeLabel.Text = "Size:";
            // 
            // label_ValidLabel
            // 
            this.label_ValidLabel.AutoSize = true;
            this.label_ValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValidLabel.Location = new System.Drawing.Point(3, 136);
            this.label_ValidLabel.Name = "label_ValidLabel";
            this.label_ValidLabel.Size = new System.Drawing.Size(82, 31);
            this.label_ValidLabel.TabIndex = 3;
            this.label_ValidLabel.Text = "Valid:";
            // 
            // label_LengthLabel
            // 
            this.label_LengthLabel.AutoSize = true;
            this.label_LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LengthLabel.Location = new System.Drawing.Point(3, 93);
            this.label_LengthLabel.Name = "label_LengthLabel";
            this.label_LengthLabel.Size = new System.Drawing.Size(105, 31);
            this.label_LengthLabel.TabIndex = 2;
            this.label_LengthLabel.Text = "Length:";
            // 
            // label_SizeLabel
            // 
            this.label_SizeLabel.AutoSize = true;
            this.label_SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SizeLabel.Location = new System.Drawing.Point(3, 53);
            this.label_SizeLabel.Name = "label_SizeLabel";
            this.label_SizeLabel.Size = new System.Drawing.Size(75, 31);
            this.label_SizeLabel.TabIndex = 1;
            this.label_SizeLabel.Text = "Size:";
            // 
            // label_NameLabel
            // 
            this.label_NameLabel.AutoSize = true;
            this.label_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameLabel.Location = new System.Drawing.Point(3, 13);
            this.label_NameLabel.Name = "label_NameLabel";
            this.label_NameLabel.Size = new System.Drawing.Size(94, 31);
            this.label_NameLabel.TabIndex = 0;
            this.label_NameLabel.Text = "Name:";
            // 
            // button_DataSync
            // 
            this.button_DataSync.Location = new System.Drawing.Point(154, 77);
            this.button_DataSync.Name = "button_DataSync";
            this.button_DataSync.Size = new System.Drawing.Size(244, 60);
            this.button_DataSync.TabIndex = 5;
            this.button_DataSync.Text = "Sync DataBase";
            this.button_DataSync.UseVisualStyleBackColor = true;
            this.button_DataSync.Click += new System.EventHandler(this.button_UpdateMongoDB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 588);
            this.Controls.Add(this.button_DataSync);
            this.Controls.Add(this.panel_InfoPanel);
            this.Controls.Add(this.checkedListBox_Files);
            this.Controls.Add(this.button_FetchFiles);
            this.Controls.Add(this.button_OpenFolderBrowser);
            this.Controls.Add(this.label_instructions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Almog Geva";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_InfoPanel.ResumeLayout(false);
            this.panel_InfoPanel.PerformLayout();
            this.panel_InnerInfoPanel.ResumeLayout(false);
            this.panel_InnerInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_instructions;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button_OpenFolderBrowser;
        private System.Windows.Forms.Button button_FetchFiles;
        private System.Windows.Forms.CheckedListBox checkedListBox_Files;
        private System.Windows.Forms.Panel panel_InfoPanel;
        private System.Windows.Forms.Label label_ValidLabel;
        private System.Windows.Forms.Label label_LengthLabel;
        private System.Windows.Forms.Label label_SizeLabel;
        private System.Windows.Forms.Label label_NameLabel;
        private System.Windows.Forms.Panel panel_InnerInfoPanel;
        private System.Windows.Forms.Label label_FileValidLabel;
        private System.Windows.Forms.Label label_FileNameLabel;
        private System.Windows.Forms.Label label_FileLengthLabel;
        private System.Windows.Forms.Label label_FileSizeLabel;
        private System.Windows.Forms.Button button_DataSync;
    }
}