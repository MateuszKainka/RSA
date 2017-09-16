namespace KomunikatorKlient_Klient
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.połączenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.połączToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szyfrowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(431, 282);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 367);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(383, 52);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(394, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.połączenieToolStripMenuItem,
            this.narzędziaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // połączenieToolStripMenuItem
            // 
            this.połączenieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.połączToolStripMenuItem,
            this.szyfrowanieToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.połączenieToolStripMenuItem.Name = "połączenieToolStripMenuItem";
            this.połączenieToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.połączenieToolStripMenuItem.Text = "Połączenie";
            // 
            // połączToolStripMenuItem
            // 
            this.połączToolStripMenuItem.Name = "połączToolStripMenuItem";
            this.połączToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.połączToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.połączToolStripMenuItem.Text = "Połącz";
            this.połączToolStripMenuItem.Click += new System.EventHandler(this.połączToolStripMenuItem_Click);
            // 
            // szyfrowanieToolStripMenuItem
            // 
            this.szyfrowanieToolStripMenuItem.Enabled = false;
            this.szyfrowanieToolStripMenuItem.Name = "szyfrowanieToolStripMenuItem";
            this.szyfrowanieToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.szyfrowanieToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.szyfrowanieToolStripMenuItem.Text = "Szyfrowanie";
            this.szyfrowanieToolStripMenuItem.Click += new System.EventHandler(this.szyfrowanieToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // narzędziaToolStripMenuItem
            // 
            this.narzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Połącz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(455, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komunikator Klient - Klient";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem połączenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem połączToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szyfrowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narzędziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
    }
}

