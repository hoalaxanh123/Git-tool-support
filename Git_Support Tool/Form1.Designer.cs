namespace Git_Support_Tool
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtb_Result = new System.Windows.Forms.RichTextBox();
            this.btn_commitRemoteRepo = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_Init = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_AddFolder = new System.Windows.Forms.Button();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.btn_Clone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ChooseFolderProject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FolderProject = new System.Windows.Forms.TextBox();
            this.txt_RemoteLink = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_AddFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(485, 456);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtb_Result);
            this.groupBox2.Controls.Add(this.btn_commitRemoteRepo);
            this.groupBox2.Controls.Add(this.btn_Status);
            this.groupBox2.Controls.Add(this.btn_Init);
            this.groupBox2.Controls.Add(this.btn_Submit);
            this.groupBox2.Controls.Add(this.btn_AddFolder);
            this.groupBox2.Controls.Add(this.btn_AddFiles);
            this.groupBox2.Controls.Add(this.btn_Clone);
            this.groupBox2.Location = new System.Drawing.Point(9, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 283);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // rtb_Result
            // 
            this.rtb_Result.Location = new System.Drawing.Point(7, 77);
            this.rtb_Result.Name = "rtb_Result";
            this.rtb_Result.Size = new System.Drawing.Size(445, 200);
            this.rtb_Result.TabIndex = 1;
            this.rtb_Result.Text = "";
            this.rtb_Result.TextChanged += new System.EventHandler(this.rtb_Result_TextChanged);
            // 
            // btn_commitRemoteRepo
            // 
            this.btn_commitRemoteRepo.Location = new System.Drawing.Point(6, 48);
            this.btn_commitRemoteRepo.Name = "btn_commitRemoteRepo";
            this.btn_commitRemoteRepo.Size = new System.Drawing.Size(446, 23);
            this.btn_commitRemoteRepo.TabIndex = 0;
            this.btn_commitRemoteRepo.Text = "Commit to remote repo";
            this.btn_commitRemoteRepo.UseVisualStyleBackColor = true;
            this.btn_commitRemoteRepo.Click += new System.EventHandler(this.btn_commitRemoteRepo_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(370, 19);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(82, 23);
            this.btn_Status.TabIndex = 0;
            this.btn_Status.Text = "Status";
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Init
            // 
            this.btn_Init.Location = new System.Drawing.Point(331, 19);
            this.btn_Init.Name = "btn_Init";
            this.btn_Init.Size = new System.Drawing.Size(33, 23);
            this.btn_Init.TabIndex = 0;
            this.btn_Init.Text = "Init";
            this.btn_Init.UseVisualStyleBackColor = true;
            this.btn_Init.Click += new System.EventHandler(this.btn_Init_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(250, 19);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_AddFolder
            // 
            this.btn_AddFolder.Location = new System.Drawing.Point(169, 19);
            this.btn_AddFolder.Name = "btn_AddFolder";
            this.btn_AddFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFolder.TabIndex = 0;
            this.btn_AddFolder.Text = "Add Folders";
            this.btn_AddFolder.UseVisualStyleBackColor = true;
            this.btn_AddFolder.Click += new System.EventHandler(this.btn_AddFolder_Click);
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.Location = new System.Drawing.Point(88, 19);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFiles.TabIndex = 0;
            this.btn_AddFiles.Text = "Add files";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.btn_AddFiles_Click);
            // 
            // btn_Clone
            // 
            this.btn_Clone.Location = new System.Drawing.Point(7, 19);
            this.btn_Clone.Name = "btn_Clone";
            this.btn_Clone.Size = new System.Drawing.Size(75, 23);
            this.btn_Clone.TabIndex = 0;
            this.btn_Clone.Text = "Clone";
            this.btn_Clone.UseVisualStyleBackColor = true;
            this.btn_Clone.Click += new System.EventHandler(this.btn_Clone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ChooseFolderProject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_FolderProject);
            this.groupBox1.Controls.Add(this.txt_RemoteLink);
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // btn_ChooseFolderProject
            // 
            this.btn_ChooseFolderProject.Location = new System.Drawing.Point(400, 57);
            this.btn_ChooseFolderProject.Name = "btn_ChooseFolderProject";
            this.btn_ChooseFolderProject.Size = new System.Drawing.Size(53, 23);
            this.btn_ChooseFolderProject.TabIndex = 2;
            this.btn_ChooseFolderProject.Text = "...";
            this.btn_ChooseFolderProject.UseVisualStyleBackColor = true;
            this.btn_ChooseFolderProject.Click += new System.EventHandler(this.btn_ChooseFolderProject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folder project:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote link:";
            // 
            // txt_FolderProject
            // 
            this.txt_FolderProject.Location = new System.Drawing.Point(97, 59);
            this.txt_FolderProject.Name = "txt_FolderProject";
            this.txt_FolderProject.Size = new System.Drawing.Size(297, 20);
            this.txt_FolderProject.TabIndex = 1;
            this.txt_FolderProject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_RemoteLink
            // 
            this.txt_RemoteLink.Location = new System.Drawing.Point(97, 24);
            this.txt_RemoteLink.Name = "txt_RemoteLink";
            this.txt_RemoteLink.Size = new System.Drawing.Size(356, 20);
            this.txt_RemoteLink.TabIndex = 1;
            this.txt_RemoteLink.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Support";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 416);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 238);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Một số lệnh cơ bản git:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Class: CTK39";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Author: Nguyen Van Vuong 1510289 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vesion: 1.0 Beta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(24, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Git support tool Beta version";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // folderBrowserDialog_AddFolder
            // 
            this.folderBrowserDialog_AddFolder.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 456);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Git Support Tool - Code by 1510289";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_RemoteLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb_Result;
        private System.Windows.Forms.Button btn_Init;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_AddFolder;
        private System.Windows.Forms.Button btn_AddFiles;
        private System.Windows.Forms.Button btn_Clone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ChooseFolderProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FolderProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_AddFolder;
        private System.Windows.Forms.Button btn_commitRemoteRepo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

