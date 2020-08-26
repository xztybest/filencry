using System;
using System.Runtime.CompilerServices;

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
            this.RSAE = new System.Windows.Forms.Button();
            this.RSAD = new System.Windows.Forms.Button();
            this.exchatest = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.methodget = new System.Windows.Forms.Button();
            this.timebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeget = new System.Windows.Forms.Button();
            this.sigtxt = new System.Windows.Forms.TextBox();
            this.signmenu = new System.Windows.Forms.Button();
            this.signcheck = new System.Windows.Forms.Button();
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
            this.AESD.Location = new System.Drawing.Point(242, 44);
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
            // RSAE
            // 
            this.RSAE.Location = new System.Drawing.Point(389, 44);
            this.RSAE.Name = "RSAE";
            this.RSAE.Size = new System.Drawing.Size(75, 23);
            this.RSAE.TabIndex = 6;
            this.RSAE.Text = "RSA加密";
            this.RSAE.UseVisualStyleBackColor = true;
            this.RSAE.Click += new System.EventHandler(this.RSAE_Click);
            // 
            // RSAD
            // 
            this.RSAD.Location = new System.Drawing.Point(515, 44);
            this.RSAD.Name = "RSAD";
            this.RSAD.Size = new System.Drawing.Size(75, 23);
            this.RSAD.TabIndex = 7;
            this.RSAD.Text = "RSA解密";
            this.RSAD.UseVisualStyleBackColor = true;
            this.RSAD.Click += new System.EventHandler(this.RSAD_Click);
            // 
            // exchatest
            // 
            this.exchatest.Location = new System.Drawing.Point(515, 184);
            this.exchatest.Name = "exchatest";
            this.exchatest.Size = new System.Drawing.Size(75, 23);
            this.exchatest.TabIndex = 8;
            this.exchatest.Text = "密钥交换";
            this.exchatest.UseVisualStyleBackColor = true;
            this.exchatest.Click += new System.EventHandler(this.exchatest_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(345, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 9;
            // 
            // methodget
            // 
            this.methodget.Location = new System.Drawing.Point(515, 118);
            this.methodget.Name = "methodget";
            this.methodget.Size = new System.Drawing.Size(75, 23);
            this.methodget.TabIndex = 10;
            this.methodget.Text = "事件绑定";
            this.methodget.UseVisualStyleBackColor = true;
            this.methodget.Click += new System.EventHandler(this.AESEncry2);
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(217, 244);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(100, 21);
            this.timebox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "当前系统时间";
            // 
            // timeget
            // 
            this.timeget.Location = new System.Drawing.Point(355, 241);
            this.timeget.Name = "timeget";
            this.timeget.Size = new System.Drawing.Size(75, 23);
            this.timeget.TabIndex = 13;
            this.timeget.Text = "获取";
            this.timeget.UseVisualStyleBackColor = true;
            this.timeget.Click += new System.EventHandler(this.timeget_Click);
            // 
            // sigtxt
            // 
            this.sigtxt.Location = new System.Drawing.Point(136, 295);
            this.sigtxt.Name = "sigtxt";
            this.sigtxt.Size = new System.Drawing.Size(100, 21);
            this.sigtxt.TabIndex = 14;
            this.sigtxt.UseWaitCursor = true;
            // 
            // signmenu
            // 
            this.signmenu.Location = new System.Drawing.Point(254, 295);
            this.signmenu.Name = "signmenu";
            this.signmenu.Size = new System.Drawing.Size(75, 23);
            this.signmenu.TabIndex = 15;
            this.signmenu.Text = "RSA签名";
            this.signmenu.UseVisualStyleBackColor = true;
            this.signmenu.Click += new System.EventHandler(this.signmenu_Click);
            // 
            // signcheck
            // 
            this.signcheck.Location = new System.Drawing.Point(254, 336);
            this.signcheck.Name = "signcheck";
            this.signcheck.Size = new System.Drawing.Size(75, 23);
            this.signcheck.TabIndex = 16;
            this.signcheck.Text = "RSA签名验证";
            this.signcheck.UseVisualStyleBackColor = true;
            this.signcheck.Click += new System.EventHandler(this.signcheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.signcheck);
            this.Controls.Add(this.signmenu);
            this.Controls.Add(this.sigtxt);
            this.Controls.Add(this.timeget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.methodget);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.exchatest);
            this.Controls.Add(this.RSAD);
            this.Controls.Add(this.RSAE);
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
        private System.Windows.Forms.Button RSAE;
        private System.Windows.Forms.Button RSAD;
        private System.Windows.Forms.Button exchatest;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button methodget;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button timeget;
        private System.Windows.Forms.TextBox sigtxt;
        private System.Windows.Forms.Button signmenu;
        private System.Windows.Forms.Button signcheck;
    }
    
}

