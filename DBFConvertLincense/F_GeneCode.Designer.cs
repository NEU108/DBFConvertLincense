namespace DBFConvertLincense
{
    partial class F_GeneCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_machinecode = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_geneCode = new System.Windows.Forms.Button();
            this.txt_registercode = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_notice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_checkcode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "机器码：";
            // 
            // txt_machinecode
            // 
            this.txt_machinecode.Location = new System.Drawing.Point(109, 35);
            this.txt_machinecode.Name = "txt_machinecode";
            this.txt_machinecode.Size = new System.Drawing.Size(404, 118);
            this.txt_machinecode.TabIndex = 1;
            this.txt_machinecode.Text = "";
            this.txt_machinecode.TextChanged += new System.EventHandler(this.txt_machinecode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "激活码：";
            // 
            // btn_geneCode
            // 
            this.btn_geneCode.Location = new System.Drawing.Point(553, 210);
            this.btn_geneCode.Name = "btn_geneCode";
            this.btn_geneCode.Size = new System.Drawing.Size(75, 41);
            this.btn_geneCode.TabIndex = 2;
            this.btn_geneCode.Text = "生成激活码";
            this.btn_geneCode.UseVisualStyleBackColor = true;
            this.btn_geneCode.Click += new System.EventHandler(this.btn_geneCode_Click);
            // 
            // txt_registercode
            // 
            this.txt_registercode.Location = new System.Drawing.Point(109, 175);
            this.txt_registercode.Name = "txt_registercode";
            this.txt_registercode.Size = new System.Drawing.Size(404, 118);
            this.txt_registercode.TabIndex = 1;
            this.txt_registercode.Text = "";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(58, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "注意：";
            // 
            // lab_notice
            // 
            this.lab_notice.AutoSize = true;
            this.lab_notice.ForeColor = System.Drawing.Color.Red;
            this.lab_notice.Location = new System.Drawing.Point(93, 335);
            this.lab_notice.Name = "lab_notice";
            this.lab_notice.Size = new System.Drawing.Size(551, 12);
            this.lab_notice.TabIndex = 4;
            this.lab_notice.Text = "1.请将机器码复制到下面的文本框，多个机器码请采用分隔符[,]，或者换行符，仅支持其中一种方式！";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(93, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "2.激活码是对应机器码的，是一个键值对";
            // 
            // btn_checkcode
            // 
            this.btn_checkcode.Location = new System.Drawing.Point(553, 67);
            this.btn_checkcode.Name = "btn_checkcode";
            this.btn_checkcode.Size = new System.Drawing.Size(75, 41);
            this.btn_checkcode.TabIndex = 2;
            this.btn_checkcode.Text = "校验机器码";
            this.btn_checkcode.UseVisualStyleBackColor = true;
            this.btn_checkcode.Click += new System.EventHandler(this.btn_checkcode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "模拟";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btn_moni);
            // 
            // F_GeneCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_notice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_checkcode);
            this.Controls.Add(this.btn_geneCode);
            this.Controls.Add(this.txt_registercode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_machinecode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "F_GeneCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GeneCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_machinecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_geneCode;
        private System.Windows.Forms.RichTextBox txt_registercode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_notice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_checkcode;
        private System.Windows.Forms.Button button1;
    }
}