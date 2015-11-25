using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFConvertLincense
{
    public partial class F_GeneCode : Form
    {
        public F_GeneCode()
        {
            InitializeComponent();

            this.btn_geneCode.Enabled = false;
        }

        private bool isCheck = false;

        private void btn_geneCode_Click(object sender, EventArgs e)
        { 
            // string machineCode = txt_machinecode.Text;
            //string regcode= Lincense.getInstance().GetCode2(machineCode); 
            //txt_registercode.Text = regcode; 
            geneCode();
        }

        private void geneCode() 
        {
            string str = "";
            if (isCheck) 
            {
                Lincense lincese = Lincense.getInstance();
                string[] codes = txt_machinecode.Text.Split('\n');
                for (int i = 0; i < codes.Length; i++)
                {
                    if (codes[i].Length == 32)
                    {
                        codes[i] = "机器码：[" + codes[i] + "]-激活码：[" + lincese.GetCode2(codes[i]) + "]";
                        str += codes[i] + "\n";
                    }
                }
                txt_registercode.Text = str; 
            } 
        }

        private void btn_checkcode_Click(object sender, EventArgs e)
        {
            //检查code

            string str = txt_machinecode.Text;
            if(str.Contains(","))
            {
                str= str.Replace(',','\n');
            }

            string[] codes = str.Split('\n');
            str = "";
            isCheck = true;
            for (int i = 0; i < codes.Length; i++)
            {
                if(codes[i].Trim() != ""){
                    str += codes[i] + "\n";

                    if (codes[i].Trim().Length != 32) 
                    {
                        isCheck = false;
                    }
                }
               
            }
            txt_machinecode.Text = str;
            if (str.Trim() == "") {
                MessageBox.Show("请您输入机器码！");
                }
            else if (isCheck )
            {
                this.btn_geneCode.Enabled = true;
            }
            else {
                MessageBox.Show("机器码校验失败，请确保分隔符正确，且机器码均为32位！");
            }
        }

        private void txt_machinecode_TextChanged(object sender, EventArgs e)
        {
            this.btn_geneCode.Enabled = false;
        }

        private void btn_moni(object sender, EventArgs e)
        {
            (new F_TestInstall()).Show();
        } 
    }
}
