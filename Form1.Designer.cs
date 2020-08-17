namespace filencry
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AESE = new System.Windows.Forms.Button();
            this.AESD = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RSAGENERAL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AESE
            // 
            this.AESE.Location = new System.Drawing.Point(146, 44);
            this.AESE.Name = "AESE";
            this.AESE.Size = new System.Drawing.Size(75, 23);
            this.AESE.TabIndex = 0;
            this.AESE.Text = "AES加密";
            this.AESE.UseVisualStyleBackColor = true;
            this.AESE.Click += new System.EventHandler(this.AESE_Click);
            // 
            // AESD
            // 
            this.AESD.Location = new System.Drawing.Point(346, 44);
            this.AESD.Name = "AESD";
            this.AESD.Size = new System.Drawing.Size(75, 23);
            this.AESD.TabIndex = 1;
            this.AESD.Text = "AES解密";
            this.AESD.UseVisualStyleBackColor = true;
            this.AESD.Click += new System.EventHandler(this.AESD_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(146, 121);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 21);
            this.text1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // RSAGENERAL
            // 
            this.RSAGENERAL.Location = new System.Drawing.Point(281, 250);
            this.RSAGENERAL.Name = "RSAGENERAL";
            this.RSAGENERAL.Size = new System.Drawing.Size(75, 23);
            this.RSAGENERAL.TabIndex = 5;
            this.RSAGENERAL.Text = "RSA信息生成";
            this.RSAGENERAL.UseVisualStyleBackColor = true;
            this.RSAGENERAL.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.RSAGENERAL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.AESD);
            this.Controls.Add(this.AESE);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AESE;
        private System.Windows.Forms.Button AESD;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button RSAGENERAL;
    }
}

