namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Delta_przycisk = new System.Windows.Forms.Button();
            this.Silnia_przycisk = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zielonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niebieskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BiałyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niebieskiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrukcjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ankietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WyłączenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delta_przycisk
            // 
            this.Delta_przycisk.Location = new System.Drawing.Point(98, 192);
            this.Delta_przycisk.Name = "Delta_przycisk";
            this.Delta_przycisk.Size = new System.Drawing.Size(126, 64);
            this.Delta_przycisk.TabIndex = 0;
            this.Delta_przycisk.Text = "Delta";
            this.Delta_przycisk.UseVisualStyleBackColor = true;
            this.Delta_przycisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // Silnia_przycisk
            // 
            this.Silnia_przycisk.Location = new System.Drawing.Point(293, 192);
            this.Silnia_przycisk.Name = "Silnia_przycisk";
            this.Silnia_przycisk.Size = new System.Drawing.Size(126, 64);
            this.Silnia_przycisk.TabIndex = 8;
            this.Silnia_przycisk.Text = "Silnia";
            this.Silnia_przycisk.UseVisualStyleBackColor = true;
            this.Silnia_przycisk.Click += new System.EventHandler(this.Silnia_przycisk_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(535, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.ankietaToolStripMenuItem,
            this.WyłączenieToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorToolStripMenuItem,
            this.niebieskiToolStripMenuItem1});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zielonyToolStripMenuItem,
            this.niebieskiToolStripMenuItem,
            this.BiałyToolStripMenuItem});
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.kolorToolStripMenuItem.Text = "Kolor";
            // 
            // zielonyToolStripMenuItem
            // 
            this.zielonyToolStripMenuItem.Name = "zielonyToolStripMenuItem";
            this.zielonyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.zielonyToolStripMenuItem.Text = "Zielony";
            this.zielonyToolStripMenuItem.Click += new System.EventHandler(this.zielonyToolStripMenuItem_Click);
            // 
            // niebieskiToolStripMenuItem
            // 
            this.niebieskiToolStripMenuItem.Name = "niebieskiToolStripMenuItem";
            this.niebieskiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niebieskiToolStripMenuItem.Text = "Niebieski";
            this.niebieskiToolStripMenuItem.Click += new System.EventHandler(this.niebieskiToolStripMenuItem_Click);
            // 
            // BiałyToolStripMenuItem
            // 
            this.BiałyToolStripMenuItem.Name = "BiałyToolStripMenuItem";
            this.BiałyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.BiałyToolStripMenuItem.Text = "Biały";
            this.BiałyToolStripMenuItem.Click += new System.EventHandler(this.BiałyToolStripMenuItem_Click);
            // 
            // niebieskiToolStripMenuItem1
            // 
            this.niebieskiToolStripMenuItem1.Name = "niebieskiToolStripMenuItem1";
            this.niebieskiToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.niebieskiToolStripMenuItem1.Text = "niebieski";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrukcjaToolStripMenuItem,
            this.oAutorzeToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // instrukcjaToolStripMenuItem
            // 
            this.instrukcjaToolStripMenuItem.Name = "instrukcjaToolStripMenuItem";
            this.instrukcjaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.instrukcjaToolStripMenuItem.Text = "Instrukcja";
            this.instrukcjaToolStripMenuItem.Click += new System.EventHandler(this.instrukcjaToolStripMenuItem_Click);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.oAutorzeToolStripMenuItem.Text = "O Autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // ankietaToolStripMenuItem
            // 
            this.ankietaToolStripMenuItem.Name = "ankietaToolStripMenuItem";
            this.ankietaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ankietaToolStripMenuItem.Text = "Ankieta";
            this.ankietaToolStripMenuItem.Click += new System.EventHandler(this.AnkietaToolStripMenuItem_Click);
            // 
            // WyłączenieToolStripMenuItem
            // 
            this.WyłączenieToolStripMenuItem.Name = "WyłączenieToolStripMenuItem";
            this.WyłączenieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WyłączenieToolStripMenuItem.Text = "Wyjście";
            this.WyłączenieToolStripMenuItem.Click += new System.EventHandler(this.WyłączenieToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(419, 386);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Muzyka";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(146, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Witaj użytkowniku";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tutaj możesz wstawić własną grafikę";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Silnia_przycisk);
            this.Controls.Add(this.Delta_przycisk);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Kalkulator Wzorów";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delta_przycisk;
        private System.Windows.Forms.Button Silnia_przycisk;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WyłączenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrukcjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem zielonyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niebieskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BiałyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ankietaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem niebieskiToolStripMenuItem1;
    }
}

