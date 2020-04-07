namespace FindAndReplace
{
    partial class findForm
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
            this.findCancel_btn = new System.Windows.Forms.Button();
            this.findSearch_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.find_TextBox = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // findCancel_btn
            // 
            this.findCancel_btn.Location = new System.Drawing.Point(12, 74);
            this.findCancel_btn.Name = "findCancel_btn";
            this.findCancel_btn.Size = new System.Drawing.Size(96, 23);
            this.findCancel_btn.TabIndex = 1;
            this.findCancel_btn.Text = "Cancel";
            this.findCancel_btn.UseVisualStyleBackColor = true;
            this.findCancel_btn.Click += new System.EventHandler(this.findCancel_btn_Click);
            // 
            // findSearch_btn
            // 
            this.findSearch_btn.Location = new System.Drawing.Point(189, 74);
            this.findSearch_btn.Name = "findSearch_btn";
            this.findSearch_btn.Size = new System.Drawing.Size(98, 23);
            this.findSearch_btn.TabIndex = 2;
            this.findSearch_btn.Text = "Search";
            this.findSearch_btn.UseVisualStyleBackColor = true;
            this.findSearch_btn.Click += new System.EventHandler(this.findSearch_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter word to search";
            // 
            // find_TextBox
            // 
            this.find_TextBox.Location = new System.Drawing.Point(12, 37);
            this.find_TextBox.Name = "find_TextBox";
            this.find_TextBox.Size = new System.Drawing.Size(275, 20);
            this.find_TextBox.TabIndex = 0;
            this.find_TextBox.MouseHover += new System.EventHandler(this.find_TextBox_MouseHover);
            // 
            // findForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 122);
            this.Controls.Add(this.find_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findSearch_btn);
            this.Controls.Add(this.findCancel_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "findForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find in text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findCancel_btn;
        private System.Windows.Forms.Button findSearch_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox find_TextBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}