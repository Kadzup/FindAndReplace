using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndReplace
{
    public partial class findAndReplace_form : Form
    {
        public string findWord = "";
        public string replaceWord = "";

        public string Find
        {
            get { return findWord; }
        }

        public string Replace
        {
            get { return replaceWord; }
        }
        
        public findAndReplace_form()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            findWord = "";
            replaceWord = "";

            this.Close();
            this.DestroyHandle();
        }

        private void replace_btn_Click(object sender, EventArgs e)
        {
            replaceWord = replace_textBox.Text;
            findWord = find_textBox.Text;
            
            this.Close();
            this.DestroyHandle();
        }
    }
}
