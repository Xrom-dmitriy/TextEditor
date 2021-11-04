namespace Text_Editor
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
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяИДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem1
            // 
            this.сохранитьКакToolStripMenuItem1.Name = "сохранитьКакToolStripMenuItem1";
            this.сохранитьКакToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.сохранитьКакToolStripMenuItem1.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выделитьВсёToolStripMenuItem,
            this.времяИДатаToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // выделитьВсёToolStripMenuItem
            // 
            this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выделитьВсёToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсёToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // времяИДатаToolStripMenuItem
            // 
            this.времяИДатаToolStripMenuItem.Name = "времяИДатаToolStripMenuItem";
            this.времяИДатаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.времяИДатаToolStripMenuItem.Text = "Время и дата";
            this.времяИДатаToolStripMenuItem.Click += new System.EventHandler(this.времяИДатаToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.шрифтToolStripMenuItem.Text = "Шрифт...";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(928, 484);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem1,
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 100);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.вырезатьToolStripMenuItem1_Click);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem1_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.вставитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 512);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "NotePad#";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяИДатаToolStripMenuItem;
    }
}

