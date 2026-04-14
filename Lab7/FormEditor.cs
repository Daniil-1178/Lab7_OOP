using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class FormEditor : Form
    {
        public string FilePath { get; set; } = null;
        public FormEditor()
        {
            InitializeComponent();
        }

        //Підсвічування синтаксису С подібних мов
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] keywords = { "int", "void", "if", "else", "for", "while", "return", "string", "class" };

            int originalIndex = richTextBox1.SelectionStart;
            int originalLength = richTextBox1.SelectionLength;
            Color originalColor = Color.Black;

            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = originalColor;

            foreach (string word in keywords)
            {
                int startIndex = 0;
                while ((startIndex = richTextBox1.Find(word, startIndex, RichTextBoxFinds.WholeWord)) != -1)
                {
                    richTextBox1.SelectionStart = startIndex;
                    richTextBox1.SelectionLength = word.Length;
                    richTextBox1.SelectionColor = Color.Blue;

                    startIndex += word.Length;
                }
            }

            richTextBox1.SelectionStart = originalIndex;
            richTextBox1.SelectionLength = originalLength;
            richTextBox1.SelectionColor = originalColor;
        }
    }
}
