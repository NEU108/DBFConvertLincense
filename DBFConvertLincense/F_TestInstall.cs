using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFConvertLincense
{
    public partial class F_TestInstall : Form
    {
        public F_TestInstall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //向注册表写入【安装时间，当前读取的 硬件信息】
            string code= Lincense.getInstance().CreateCode();

            if (!RegHelper.WriteToRegInstall(code)) {
                MessageBox.Show("注册表没有访问权限！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((new F_RegisterForm()).ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new F_GeneCode()).ShowDialog();
        }
    }
}
