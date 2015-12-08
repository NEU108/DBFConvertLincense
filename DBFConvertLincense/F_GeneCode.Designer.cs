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
            this.btn_checkcode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MachineCode:";
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
            this.label2.Location = new System.Drawing.Point(77, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key:";
            // 
            // btn_geneCode
            // 
            this.btn_geneCode.Location = new System.Drawing.Point(553, 210);
            this.btn_geneCode.Name = "btn_geneCode";
            this.btn_geneCode.Size = new System.Drawing.Size(91, 41);
            this.btn_geneCode.TabIndex = 2;
            this.btn_geneCode.Text = "GenerateKey";
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
            this.label3.Text = "Note:";
            // 
            // lab_notice
            // 
            this.lab_notice.AutoSize = true;
            this.lab_notice.ForeColor = System.Drawing.Color.Red;
            this.lab_notice.Location = new System.Drawing.Point(93, 335);
            this.lab_notice.Name = "lab_notice";
            this.lab_notice.Size = new System.Drawing.Size(515, 12);
            this.lab_notice.TabIndex = 4;
            this.lab_notice.Text = "1.Please copied machine code to the following text box, the split is [,], or newl" +
    "ine!";
            // 
            // btn_checkcode
            // 
            this.btn_checkcode.Location = new System.Drawing.Point(553, 67);
            this.btn_checkcode.Name = "btn_checkcode";
            this.btn_checkcode.Size = new System.Drawing.Size(91, 41);
            this.btn_checkcode.TabIndex = 2;
            this.btn_checkcode.Text = "Check MachineCode";
            this.btn_checkcode.UseVisualStyleBackColor = true;
            this.btn_checkcode.Click += new System.EventHandler(this.btn_checkcode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "moni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btn_moni);
            // 
            // F_GeneCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 403);
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
            this.Text = "Generate Key";
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
        private System.Windows.Forms.Button btn_checkcode;
        private System.Windows.Forms.Button button1;
    }
}