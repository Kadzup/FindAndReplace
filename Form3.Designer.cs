namespace FindAndReplace
{
    partial class findAndReplace_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.find_textBox = new System.Windows.Forms.TextBox();
            this.replace_textBox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.replace_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace word";
            // 
            // find_textBox
            // 
            this.find_textBox.Location = new System.Drawing.Point(12, 30);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(272, 20);
            this.find_textBox.TabIndex = 2;
            // 
            // replace_textBox
            // 
            this.replace_textBox.Location = new System.Drawing.Point(12, 80);
            this.replace_textBox.Name = "replace_textBox";
            this.replace_textBox.Size = new System.Drawing.Size(272, 20);
            this.replace_textBox.TabIndex = 3;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(12, 123);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(133, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // replace_btn
            // 
            this.replace_btn.Location = new System.Drawing.Point(151, 123);
            this.replace_btn.Name = "replace_btn";
            this.replace_btn.Size = new System.Drawing.Size(133, 23);
            this.replace_btn.TabIndex = 8;
            this.replace_btn.Text = "Replace";
            this.replace_btn.UseVisualStyleBackColor = true;
            this.replace_btn.Click += new System.EventHandler(this.replace_btn_Click);
            // 
            // findAndReplace_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 162);
            this.Controls.Add(this.replace_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.replace_textBox);
            this.Controls.Add(this.find_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "findAndReplace_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox find_textBox;
        private System.Windows.Forms.TextBox replace_textBox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button replace_btn;
    }
}