using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Відкриття файлу
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FormEditor child = new FormEditor();
                child.MdiParent = this;

                child.richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);

                child.FilePath = openFileDialog1.FileName;
                child.Text = Path.GetFileName(openFileDialog1.FileName);
                child.Show();
            }
        }

        //Створення файлу
        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor childForm = new FormEditor();

            childForm.MdiParent = this;

            childForm.Text = "Документ " + this.MdiChildren.Length;

            childForm.Show();
        }

        //Закриття програми
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Вибір шрифту
        private void вибратиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor activeChild = this.ActiveMdiChild as FormEditor;

            if (activeChild != null)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    activeChild.Controls.OfType<RichTextBox>().First().SelectionFont = fontDialog1.Font;
                }
            }
        }

        // Вирівнювання по лівому краю
        private void leftAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor activeChild = this.ActiveMdiChild as FormEditor;
            if (activeChild != null)
            {
                var rtb = activeChild.Controls.OfType<RichTextBox>().First();
                rtb.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        // Вирівнювання по центру
        private void centerAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor activeChild = this.ActiveMdiChild as FormEditor;
            if (activeChild != null)
            {
                var rtb = activeChild.Controls.OfType<RichTextBox>().First();
                rtb.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        // Вирівнювання по правому краю
        private void rightAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor activeChild = this.ActiveMdiChild as FormEditor;
            if (activeChild != null)
            {
                var rtb = activeChild.Controls.OfType<RichTextBox>().First();
                rtb.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        //Вибір мови
        private void SetLanguage(string lang)
        {
            if (lang == "UA")
            {
                fileMenu.Text = "Файл";
                newFile.Text = "Новий";
                languageMenu.Text = "Мова";
            }
            else if (lang == "EN")
            {
                fileMenu.Text = "File";
                newFile.Text = "New";
                languageMenu.Text = "Language";
            }
        }

        // Виклик методу при натисканні
        private void langUkrItem_Click(object sender, EventArgs e) => ChangeLanguage("UKR");
        private void langEngItem_Click(object sender, EventArgs e) => ChangeLanguage("ENG");

        //Вставка зображення
        private void вставитиЗображенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor activeChild = this.ActiveMdiChild as FormEditor;
            if (activeChild != null)
            {
                OpenFileDialog openImg = new OpenFileDialog();
                openImg.Filter = "Images|*.jpg;*.png;*.bmp";

                if (openImg.ShowDialog() == DialogResult.OK)
                {
                    var rtb = activeChild.Controls.OfType<RichTextBox>().First();
                    Image img = System.Drawing.Image.FromFile(openImg.FileName);
                    Clipboard.SetImage(img);
                    rtb.Paste();
                }
            }
        }

        //Зберігання файлу
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor activeChild = this.ActiveMdiChild as FormEditor;

            if (activeChild != null)
            {
                if (string.IsNullOrEmpty(activeChild.FilePath))
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    var rtb = activeChild.Controls.OfType<RichTextBox>().First();
                    rtb.SaveFile(activeChild.FilePath, RichTextBoxStreamType.RichText);

                }
            }
        }

        //Зберігання файлу як...
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FormEditor activeChild)
            {
                saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf|Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";

                saveFileDialog1.FilterIndex = 1;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    activeChild.richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    activeChild.FilePath = saveFileDialog1.FileName;
                    activeChild.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }
        }

        // Упорядкувати каскадом
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.Cascade);

        // Упорядкувати горизонтально
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileHorizontal);

        // Упорядкувати вертикально
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileVertical);

        //Ствоерння багатомовного інтерфейсу
        private void ChangeLanguage(string lang)
        {
            if (lang == "UKR")
            {
                fileMenu.Text = "Файл";
                openFile.Text = "Відкрити";
                newFile.Text = "Новий";
                saveFile.Text = "Зберегти";
                saveFileAs.Text = "Зберегти як...";
                exit.Text = "Вихід";

                editMenu.Text = "Редагування";
                alignMenu.Text = "Вирівнювання";
                leftAlign.Text = "По лівому краю";
                centerAlign.Text = "По центру";
                rightAlign.Text = "По правому краю";

                insertMenu.Text = "Вставка";
                image.Text = "Зображення";

                fontMenu.Text = "Шрифт";
                chooseFont.Text = "Вибрати...";

                languageMenu.Text = "Мова";
                langUkr.Text = "Українська";
                langEng.Text = "Англійська";

                windowMenu.Text = "Вікно";
                arrangeCascade.Text = "Упорядкувати каскадом";
                arrangeHorizontal.Text = "Упорядкувати горизонтально";
                arrangeVertically.Text = "Упорядкувати вертикально";
            }
            else
            {
                fileMenu.Text = "File";
                openFile.Text = "Open";
                newFile.Text = "New";
                saveFile.Text = "Save";
                saveFileAs.Text = "Save As...";
                exit.Text = "Exit";

                editMenu.Text = "Edit";
                alignMenu.Text = "Alignment";
                leftAlign.Text = "Left Align";
                centerAlign.Text = "Center Align";
                rightAlign.Text = "Right Align";

                insertMenu.Text = "Insert";
                image.Text = "Image";

                fontMenu.Text = "Font";
                chooseFont.Text = "Choose...";

                languageMenu.Text = "Language";
                langUkr.Text = "Ukrainian";
                langEng.Text = "English";

                windowMenu.Text = "Window";
                arrangeCascade.Text = "Arrange cascade";
                arrangeHorizontal.Text = "Arrange horizontal";
                arrangeVertically.Text = "Arrange vertically";
            }
        }
    }
}
