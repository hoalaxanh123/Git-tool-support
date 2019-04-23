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
    public partial class frm_Input : Form
    {
        public frm_Input()
        {
            InitializeComponent();
        }

        public  string title, text,result;
        public  bool isOK;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.result = textBox1.Text;
            this.Close();
            isOK = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            isOK = false;
        }

        private void frm_Input_Load(object sender, EventArgs e)
        {
            this.groupBox1.Text = title;
            this.label1.Text = text;
        }
    }
}
