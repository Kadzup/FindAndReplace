using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndReplace
{ 
    public partial class textEditor_form : Form
    {
        private const string formPattern = "Text Editor";

        private OpenFileDialog openFileDialog = null;
        private SaveFileDialog saveFileDialog = null;

        public bool isTextChanged = false;
        public string searchWord;

        private string fileName;

        public string textBoxText;

        public string FieldText
        {
            get { return textBoxText; }
        }

        public textEditor_form()

        {
            InitializeComponent();

            saveToFile_btn.Enabled = false;
            clearText_btn.Enabled = false;

            find_btn.Enabled = false;
            findAndReplace_btn.Enabled = false;
        }

        private void clearText_btn_Click(object sender, EventArgs e)
        {
            textBox_richText.Text = "";
            clearText_btn.Enabled = false;
        }

        private void textBox_richText_TextChanged(object sender, EventArgs e)
        {
            saveToFile_btn.Enabled = true;
            textBoxText = textBox_richText.Text;

            if (textBox_richText.Text == "")
            {
                readFile_btn.Enabled = true;

                find_btn.Enabled = false;
                findAndReplace_btn.Enabled = false;
            }
            else
            {
                readFile_btn.Enabled = false;

                find_btn.Enabled = true;
                findAndReplace_btn.Enabled = true;

                clearText_btn.Enabled = true;
            }

            this.Text = formPattern + " : " + fileName + "*";
        }

        private void textBox_richText_MouseDown(object sender, MouseEventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;

            rtb.SelectionStart = 0;
            rtb.SelectionLength = textBox_richText.TextLength;
            rtb.SelectionBackColor = Color.White;

            rtb.SelectionStart = rtb.GetCharIndexFromPosition(e.Location);
            rtb.SelectionLength = 0;
        }

        private void readFile_btn_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            fileName = openFileDialog.FileName;

            string fileText = System.IO.File.ReadAllText(fileName);
            textBox_richText.Text = fileText;

            this.Text = formPattern + " : " + fileName;
        }

        private void saveToFile_btn_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            fileName = saveFileDialog.FileName;

            System.IO.File.WriteAllText(fileName, textBox_richText.Text);

            saveToFile_btn.Enabled = false;

            this.Text = formPattern + " : " + fileName;
        }
        private int FindCount(string input)
        {
            if (input.Length <= 0)
                return -1;

            string number = "";
	
            for(int i = input.IndexOf("{") + 1; i < input.IndexOf("}"); i++)
            {
                number += input[i];
            }

            return Convert.ToInt16(number);
        }
        private string FindChars(string input)
        {
            if (input.Length <= 0)
                return "";

            string chars = "";
	
            for(int i = input.IndexOf("[")+1; i<input.IndexOf("]"); i++)
            {
                chars += input[i];
            }

            return chars;
        }

        private bool IsRegularExpresion(string word)
        {
            if(word.IndexOf("[") > -1 && word.IndexOf("]") > -1 && word.IndexOf("{") > -1 && word.IndexOf("}") > -1)
                return true;

            return false;
        }

        private string[] GetStringFromRegularExpresion(string word)
        {
            if (word.Length <= 0)
                return null;

            int count = FindCount(word);
            string chars = FindChars(word);

            string [] result = new string[chars.Length];

            string transform = "";
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == '{')
                    {
                        int k = 0;
                        while (k < count)
                        {
                            transform += chars[i];
                            k++;
                        }
                        j = word.IndexOf("}");
                    }
                    else if (word[j] == '[')
                    {
                        j = word.IndexOf("]");
                    }
                    else
                    {
                        transform += word[j];
                    }
                }

                if (transform.Length > 0)
                {
                    result[i] = transform;
                }

                transform = "";
            }

            return result;
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            textBox_richText.SelectionStart = 0;
            textBox_richText.SelectionLength = textBox_richText.TextLength;
            textBox_richText.SelectionBackColor = Color.White;

            textBoxText = textBox_richText.Text;
            findForm findWindow = new findForm();
            findWindow.ShowDialog();

            string word = "";
            word = findWindow.Search;

            if (word.Length > 0)
            {
                if (IsRegularExpresion(word))
                {
                    string [] words = GetStringFromRegularExpresion(word);
                    int i = 0;
                    while (i < words.Length)
                    {
                        FindStringInText(words[i]);
                        i++;
                    }
                }
                else
                    FindStringInText(word);
            }

            findWindow.Close();
        }

        private void FindStringInText(string search)
        {
            string textBoxText = textBox_richText.Text;
            int wordPosition = textBoxText.ToString().IndexOf(search);
            while (wordPosition >= 0)
            {
                if (wordPosition != -1)
                {
                    textBox_richText.SelectionStart = wordPosition;
                    textBox_richText.SelectionLength = search.Length;

                    textBox_richText.SelectionBackColor = Color.Yellow;
                }
                else
                    MessageBox.Show("Word not found", "Find dialog result");

                wordPosition = textBoxText.ToString().IndexOf(search, wordPosition+1);
            }
        }

        private void findAndReplace_btn_Click(object sender, EventArgs e)
        {
            textBoxText = textBox_richText.Text;

            findAndReplace_form findAndReplaceWindow = new findAndReplace_form();
            findAndReplaceWindow.ShowDialog();

            string find = "";
            string replace = "";

            find = findAndReplaceWindow.Find;
            replace = findAndReplaceWindow.Replace;

            if (find.Length > 0 && replace.Length > 0)
            {
                if (find.Length > 0)
                {
                    if (IsRegularExpresion(find))
                    {
                        string[] words = GetStringFromRegularExpresion(find);
                        int i = 0;
                        while (i < words.Length)
                        {
                            FindAndReplace(find, replace);
                            i++;
                        }
                    }
                    else
                        FindAndReplace(find, replace);
                }
            }
            
            findAndReplaceWindow.Close();
        }

        private void FindAndReplace(string find, string replace)
        {
            string pattern = @"\b" + find + @"\b";
            string result = Regex.Replace(textBox_richText.Text, pattern, replace);

            textBox_richText.Text = result;

            FindStringInText(replace);
        }
    }
}
