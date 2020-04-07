namespace FindAndReplace
{
    partial class textEditor_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveToFile_btn = new System.Windows.Forms.Button();
            this.clearText_btn = new System.Windows.Forms.Button();
            this.findAndReplace_btn = new System.Windows.Forms.Button();
            this.find_btn = new System.Windows.Forms.Button();
            this.readFile_btn = new System.Windows.Forms.Button();
            this.textBox_richText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveToFile_btn);
            this.groupBox1.Controls.Add(this.clearText_btn);
            this.groupBox1.Controls.Add(this.findAndReplace_btn);
            this.groupBox1.Controls.Add(this.find_btn);
            this.groupBox1.Controls.Add(this.readFile_btn);
            this.groupBox1.Location = new System.Drawing.Point(635, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // saveToFile_btn
            // 
            this.saveToFile_btn.Location = new System.Drawing.Point(6, 45);
            this.saveToFile_btn.Name = "saveToFile_btn";
            this.saveToFile_btn.Size = new System.Drawing.Size(141, 23);
            this.saveToFile_btn.TabIndex = 5;
            this.saveToFile_btn.Text = "Save";
            this.saveToFile_btn.UseVisualStyleBackColor = true;
            this.saveToFile_btn.Click += new System.EventHandler(this.saveToFile_btn_Click);
            // 
            // clearText_btn
            // 
            this.clearText_btn.Location = new System.Drawing.Point(7, 74);
            this.clearText_btn.Name = "clearText_btn";
            this.clearText_btn.Size = new System.Drawing.Size(141, 23);
            this.clearText_btn.TabIndex = 4;
            this.clearText_btn.Text = "Clean";
            this.clearText_btn.UseVisualStyleBackColor = true;
            this.clearText_btn.Click += new System.EventHandler(this.clearText_btn_Click);
            // 
            // findAndReplace_btn
            // 
            this.findAndReplace_btn.Location = new System.Drawing.Point(7, 164);
            this.findAndReplace_btn.Name = "findAndReplace_btn";
            this.findAndReplace_btn.Size = new System.Drawing.Size(140, 23);
            this.findAndReplace_btn.TabIndex = 2;
            this.findAndReplace_btn.Text = "Find and replace";
            this.findAndReplace_btn.UseVisualStyleBackColor = true;
            this.findAndReplace_btn.Click += new System.EventHandler(this.findAndReplace_btn_Click);
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(6, 134);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(141, 23);
            this.find_btn.TabIndex = 1;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // readFile_btn
            // 
            this.readFile_btn.Location = new System.Drawing.Point(6, 19);
            this.readFile_btn.Name = "readFile_btn";
            this.readFile_btn.Size = new System.Drawing.Size(141, 23);
            this.readFile_btn.TabIndex = 0;
            this.readFile_btn.Text = "Read txt file";
            this.readFile_btn.UseVisualStyleBackColor = true;
            this.readFile_btn.Click += new System.EventHandler(this.readFile_btn_Click);
            // 
            // textBox_richText
            // 
            this.textBox_richText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_richText.Location = new System.Drawing.Point(12, 12);
            this.textBox_richText.Name = "textBox_richText";
            this.textBox_richText.Size = new System.Drawing.Size(617, 426);
            this.textBox_richText.TabIndex = 1;
            this.textBox_richText.Text = "";
            this.textBox_richText.TextChanged += new System.EventHandler(this.textBox_richText_TextChanged);
            this.textBox_richText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_richText_MouseDown);
            // 
            // textEditor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_richText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "textEditor_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findAndReplace_btn;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button readFile_btn;
        private System.Windows.Forms.Button clearText_btn;
        private System.Windows.Forms.RichTextBox textBox_richText;
        private System.Windows.Forms.Button saveToFile_btn;
    }
}

