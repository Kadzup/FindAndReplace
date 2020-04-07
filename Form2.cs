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
    public partial class findForm : Form
    {
        private string findString = "";
        public string Search { get { return findString; } }
        public findForm()
        {
            InitializeComponent();
        }
        
        private void findCancel_btn_Click(object sender, EventArgs e)
        {
            findString = "";
            this.Close();
            this.DestroyHandle();
        }

        private void findSearch_btn_Click(object sender, EventArgs e)
        {
            findString = find_TextBox.Text;

            this.Close();
            this.DestroyHandle();
        }

        private void find_TextBox_MouseHover(object sender, EventArgs e)
        {
           ToolTip toolTip = new ToolTip();

           toolTip.ToolTipTitle = "You can use regular expresion";
           Point p = find_TextBox.Location;
           toolTip.Show("text[symbols]text{count of symbols}text", this, p.X + 100,
               p.Y-10, 3000);
        }
    }
}
