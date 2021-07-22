namespace pagibig_pms_encdec
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
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkEncrypt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(12, 111);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(658, 96);
            this.rtb1.TabIndex = 0;
            this.rtb1.Text = "";
            // 
            // rtb2
            // 
            this.rtb2.Location = new System.Drawing.Point(12, 213);
            this.rtb2.Name = "rtb2";
            this.rtb2.Size = new System.Drawing.Size(658, 96);
            this.rtb2.TabIndex = 1;
            this.rtb2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkEncrypt
            // 
            this.chkEncrypt.AutoSize = true;
            this.chkEncrypt.Checked = true;
            this.chkEncrypt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEncrypt.Location = new System.Drawing.Point(12, 23);
            this.chkEncrypt.Name = "chkEncrypt";
            this.chkEncrypt.Size = new System.Drawing.Size(78, 21);
            this.chkEncrypt.TabIndex = 3;
            this.chkEncrypt.Text = "Encrypt";
            this.chkEncrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 325);
            this.Controls.Add(this.chkEncrypt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.rtb1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkEncrypt;
    }
}

