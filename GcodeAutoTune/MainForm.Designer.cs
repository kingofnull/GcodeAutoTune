namespace GcodeAutoTune
{
    partial class frmMain
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
            this.chkAutoReplace = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtInPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOutBrows = new System.Windows.Forms.Button();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAutoReplace
            // 
            this.chkAutoReplace.AutoSize = true;
            this.chkAutoReplace.Location = new System.Drawing.Point(12, 120);
            this.chkAutoReplace.Name = "chkAutoReplace";
            this.chkAutoReplace.Size = new System.Drawing.Size(91, 17);
            this.chkAutoReplace.TabIndex = 0;
            this.chkAutoReplace.Text = "Auto Replace";
            this.chkAutoReplace.UseVisualStyleBackColor = true;
            this.chkAutoReplace.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(12, 190);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(339, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtInPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 45);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(270, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtInPath
            // 
            this.txtInPath.Location = new System.Drawing.Point(6, 13);
            this.txtInPath.Name = "txtInPath";
            this.txtInPath.Size = new System.Drawing.Size(258, 20);
            this.txtInPath.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOutBrows);
            this.groupBox2.Controls.Add(this.txtOutPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 45);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // btnOutBrows
            // 
            this.btnOutBrows.Location = new System.Drawing.Point(270, 13);
            this.btnOutBrows.Name = "btnOutBrows";
            this.btnOutBrows.Size = new System.Drawing.Size(75, 20);
            this.btnOutBrows.TabIndex = 4;
            this.btnOutBrows.Text = "browse";
            this.btnOutBrows.UseVisualStyleBackColor = true;
            this.btnOutBrows.Click += new System.EventHandler(this.btnOutBrows_Click);
            // 
            // txtOutPath
            // 
            this.txtOutPath.Location = new System.Drawing.Point(6, 13);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.Size = new System.Drawing.Size(258, 20);
            this.txtOutPath.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 225);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.chkAutoReplace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSS & SMM GCode AutoTune";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAutoReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtInPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOutBrows;
        private System.Windows.Forms.TextBox txtOutPath;
    }
}

