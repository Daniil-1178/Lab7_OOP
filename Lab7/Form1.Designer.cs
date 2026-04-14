namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.image = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.alignMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.centerAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.langUkr = new System.Windows.Forms.ToolStripMenuItem();
            this.langEng = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeVertically = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.insertMenu,
            this.editMenu,
            this.fontMenu,
            this.languageMenu,
            this.windowMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.newFile,
            this.saveFile,
            this.saveFileAs,
            this.exit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "Файл";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(180, 22);
            this.openFile.Text = "Відкрити";
            this.openFile.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(180, 22);
            this.newFile.Text = "Новий";
            this.newFile.Click += new System.EventHandler(this.новийToolStripMenuItem_Click);
            // 
            // saveFileAs
            // 
            this.saveFileAs.Name = "saveFileAs";
            this.saveFileAs.Size = new System.Drawing.Size(180, 22);
            this.saveFileAs.Text = "Зберегти як...";
            this.saveFileAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 22);
            this.exit.Text = "Вихід";
            this.exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // insertMenu
            // 
            this.insertMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.image});
            this.insertMenu.Name = "insertMenu";
            this.insertMenu.Size = new System.Drawing.Size(61, 20);
            this.insertMenu.Text = "Вставка";
            // 
            // image
            // 
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(143, 22);
            this.image.Text = "Зображення";
            this.image.Click += new System.EventHandler(this.вставитиЗображенняToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alignMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(87, 20);
            this.editMenu.Text = "Редагування";
            // 
            // alignMenu
            // 
            this.alignMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftAlign,
            this.centerAlign,
            this.rightAlign});
            this.alignMenu.Name = "alignMenu";
            this.alignMenu.Size = new System.Drawing.Size(153, 22);
            this.alignMenu.Text = "Вирівнювання";
            // 
            // leftAlign
            // 
            this.leftAlign.Name = "leftAlign";
            this.leftAlign.Size = new System.Drawing.Size(173, 22);
            this.leftAlign.Text = "По лівому краю";
            this.leftAlign.Click += new System.EventHandler(this.leftAlignToolStripMenuItem_Click);
            // 
            // centerAlign
            // 
            this.centerAlign.Name = "centerAlign";
            this.centerAlign.Size = new System.Drawing.Size(173, 22);
            this.centerAlign.Text = "По центру";
            this.centerAlign.Click += new System.EventHandler(this.centerAlignToolStripMenuItem_Click);
            // 
            // rightAlign
            // 
            this.rightAlign.Name = "rightAlign";
            this.rightAlign.Size = new System.Drawing.Size(173, 22);
            this.rightAlign.Text = "По правому краю";
            this.rightAlign.Click += new System.EventHandler(this.rightAlignToolStripMenuItem_Click);
            // 
            // fontMenu
            // 
            this.fontMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFont});
            this.fontMenu.Name = "fontMenu";
            this.fontMenu.Size = new System.Drawing.Size(58, 20);
            this.fontMenu.Text = "Шрифт";
            // 
            // chooseFont
            // 
            this.chooseFont.Name = "chooseFont";
            this.chooseFont.Size = new System.Drawing.Size(120, 22);
            this.chooseFont.Text = "Вибрати";
            this.chooseFont.Click += new System.EventHandler(this.вибратиToolStripMenuItem_Click);
            // 
            // languageMenu
            // 
            this.languageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langUkr,
            this.langEng});
            this.languageMenu.Name = "languageMenu";
            this.languageMenu.Size = new System.Drawing.Size(49, 20);
            this.languageMenu.Text = "Мова";
            // 
            // langUkr
            // 
            this.langUkr.Name = "langUkr";
            this.langUkr.Size = new System.Drawing.Size(134, 22);
            this.langUkr.Text = "Українська";
            this.langUkr.Click += new System.EventHandler(this.langUkrItem_Click);
            // 
            // langEng
            // 
            this.langEng.Name = "langEng";
            this.langEng.Size = new System.Drawing.Size(134, 22);
            this.langEng.Text = "English";
            this.langEng.Click += new System.EventHandler(this.langEngItem_Click);
            // 
            // windowMenu
            // 
            this.windowMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeCascade,
            this.arrangeHorizontal,
            this.arrangeVertically});
            this.windowMenu.Name = "windowMenu";
            this.windowMenu.Size = new System.Drawing.Size(49, 20);
            this.windowMenu.Text = "Вікно";
            // 
            // arrangeCascade
            // 
            this.arrangeCascade.Name = "arrangeCascade";
            this.arrangeCascade.Size = new System.Drawing.Size(236, 22);
            this.arrangeCascade.Text = "Упорядкувати каскадом";
            this.arrangeCascade.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // arrangeHorizontal
            // 
            this.arrangeHorizontal.Name = "arrangeHorizontal";
            this.arrangeHorizontal.Size = new System.Drawing.Size(236, 22);
            this.arrangeHorizontal.Text = "Упорядкувати горизонтально";
            this.arrangeHorizontal.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // arrangeVertically
            // 
            this.arrangeVertically.Name = "arrangeVertically";
            this.arrangeVertically.Size = new System.Drawing.Size(236, 22);
            this.arrangeVertically.Text = "Упорядкувати вертикально";
            this.arrangeVertically.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(180, 22);
            this.saveFile.Text = "Зберегти";
            this.saveFile.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem fontMenu;
        private System.Windows.Forms.ToolStripMenuItem languageMenu;
        private System.Windows.Forms.ToolStripMenuItem windowMenu;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem chooseFont;
        private System.Windows.Forms.ToolStripMenuItem alignMenu;
        private System.Windows.Forms.ToolStripMenuItem leftAlign;
        private System.Windows.Forms.ToolStripMenuItem centerAlign;
        private System.Windows.Forms.ToolStripMenuItem rightAlign;
        private System.Windows.Forms.ToolStripMenuItem langUkr;
        private System.Windows.Forms.ToolStripMenuItem langEng;
        private System.Windows.Forms.ToolStripMenuItem insertMenu;
        private System.Windows.Forms.ToolStripMenuItem image;
        private System.Windows.Forms.ToolStripMenuItem saveFileAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem arrangeCascade;
        private System.Windows.Forms.ToolStripMenuItem arrangeHorizontal;
        private System.Windows.Forms.ToolStripMenuItem arrangeVertically;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
    }
}

