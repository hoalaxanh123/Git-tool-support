using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Support_Tool
{
    public partial class Form1 : Form
    {
        string FirtRemoteLink, FirtFolderProjectLink;
        MyClass myclass = new MyClass();
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowMessage(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var a = myclass.GetSetting();
            if (a.Count != 0)
            {
                this.txt_RemoteLink.Text = a[0].ToString();
                FirtRemoteLink = this.txt_RemoteLink.Text;
                this.txt_FolderProject.Text = a[1].ToString();
                FirtFolderProjectLink = this.txt_FolderProject.Text;
            }

            this.richTextBox1.Text = "-git init: khai báo 1 thư mục thường thành repo\n" +
                "- git status -s : xem trạng thái các file\n" +
                "Trạng thái file:\n" +
                "\t-?? : chưa làm gì với file\n" +
                "\t-A : file đã tracked\n" +
                     "\t- M: file đã tracked và đã bị sửa\n" +
                     "\t- MM: file đã tracked, commit và sau đó bị sửa\n" +
                "-git commit - a - m 'content' : commit với nội dung content\n" +
                  "- touch 'filename': tạo file\n" +


                "Ngay khi tạo kho chứa, nên tạo tập tin.gitignore để tránh theo dõi những tập tin không cần thiết.\n" +
                "--Up local lên remote\n" +
                "0.git remote rm origin-- > xoá bỏ origin cũ\n" +
                "1.git remote add origin https://github.com/hoalaxanh123/lab05.git  --> add remote mới\n" +
                "2.git pull origin master--allow - unrelated - histories-- > pull xin cấp quyền với remote\n" +
                "3.git push - u origin master --> đẩy local lên remote\n";
        }


        private void btn_ChooseFolderProject_Click(object sender, EventArgs e)
        {
            DialogResult ret = folderBrowserDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                this.txt_FolderProject.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_Clone_Click(object sender, EventArgs e)
        {
            this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": Working, please wait\n";
            this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": ";
            this.rtb_Result.Text += myclass.Do2(" clone " + txt_RemoteLink.Text, this.txt_FolderProject.Text);
            this.rtb_Result.Text += "Done\n------------------------------------------------------------\n";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txt_FolderProject.Text.CompareTo(FirtFolderProjectLink) != 0 || txt_RemoteLink.Text.CompareTo(FirtRemoteLink) != 0)
            {
                DialogResult ret = MessageBox.Show("The setting has changed, do you want to save it ?", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    myclass.SaveSetting(this.txt_RemoteLink.Text, this.txt_FolderProject.Text);
                }
            }

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_AddFiles_Click(object sender, EventArgs e)
        {
            this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": ";
            this.rtb_Result.Text += myclass.Do(" add *", this.txt_FolderProject.Text);
            this.rtb_Result.Text += "Added files "  + "\n------------------------------------------------------------\n";
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": Check status\n\n";
            this.rtb_Result.Text += myclass.Do(" status -s", this.txt_FolderProject.Text);
            this.rtb_Result.Text += "\n------------------------------------------------------------\n";
        }

        private void btn_AddFolder_Click(object sender, EventArgs e)
        {
            DialogResult ret = folderBrowserDialog_AddFolder.ShowDialog();
            if (ret == DialogResult.OK)
            {
                this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": ";
                this.rtb_Result.Text += myclass.Do(" add " + '"' + folderBrowserDialog_AddFolder.SelectedPath + '"', this.txt_FolderProject.Text);
                this.rtb_Result.Text += "Added file " + folderBrowserDialog_AddFolder.SelectedPath + "\n------------------------------------------------------------\n";
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            frm_Input frm = new frm_Input();
            frm.title = "What is version  (ex: Version 1.0) ?";
            frm.text = "Enter version : ";
            frm.ShowDialog();

            if (frm.isOK == false)
            {
                MessageBox.Show("Cannceled !!!");
                return;
            }



            this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": Working.....\n";
            this.rtb_Result.Text += myclass.Do(" commit -a -m " + '"' + frm.result + '"', this.txt_FolderProject.Text);
            this.rtb_Result.Text += "Done " + folderBrowserDialog_AddFolder.SelectedPath + "\n------------------------------------------------------------\n";
        }

        private void btn_commitRemoteRepo_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Are you sure ?", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                string branch, remoteName;

                frm_Input frm = new frm_Input();
                frm.title = "What is remote name (ex: origin) ?";
                frm.text = "Enter remote name: ";
                frm.ShowDialog();

                if (frm.isOK == false)
                {
                    MessageBox.Show("Cannceled !!!");
                    return;
                }
                remoteName = frm.result;


                frm_Input frm2 = new frm_Input();
                frm2.title = "What is branch name (ex: master) ?";
                frm2.text = "Enter branch name: ";
                frm2.ShowDialog();

                if (frm2.isOK == false)
                {
                    MessageBox.Show("Cannceled !!!");
                    return;
                }

                branch = frm2.result;

                //remove old remote repo
                this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": remove old remote repo \n";
                var cmd = " remote rm " + remoteName + "";
                this.rtb_Result.Text += myclass.Do2(cmd, this.txt_FolderProject.Text);
                this.rtb_Result.Text += "Removed !!! " + folderBrowserDialog_AddFolder.SelectedPath + "\n------------------------------------------------------------\n";

                //add new remote repo
                this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": Add new remote repo\n";
                cmd = "remote add " + remoteName + " " + this.txt_RemoteLink.Text;
                this.rtb_Result.Text += myclass.Do2(cmd, this.txt_FolderProject.Text);
                this.rtb_Result.Text += "Added " + folderBrowserDialog_AddFolder.SelectedPath + "\n------------------------------------------------------------\n";

                //pull
                this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": Working.....\n";
                cmd = " pull " + remoteName + " " + branch + " --allow-unrelated-histories";
                this.rtb_Result.Text += myclass.Do2(cmd, this.txt_FolderProject.Text);
                this.rtb_Result.Text += "Pull done " + folderBrowserDialog_AddFolder.SelectedPath + "\n------------------------------------------------------------\n";

                //push
                this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": Working.....\n";
                cmd = "push -u " + remoteName + " " + branch;
                this.rtb_Result.Text += myclass.Do2(cmd, this.txt_FolderProject.Text);
                this.rtb_Result.Text += "Push done " + folderBrowserDialog_AddFolder.SelectedPath + "\n------------------------------------------------------------\n";

            }

        }

        private void rtb_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Init_Click(object sender, EventArgs e)
        {
            this.rtb_Result.Text += DateTime.Now.ToLongTimeString() + ": ";
            this.rtb_Result.Text += myclass.Do(" init", this.txt_FolderProject.Text);
            this.rtb_Result.Text += "Done\n------------------------------------------------------------\n";
        }
    }
}
