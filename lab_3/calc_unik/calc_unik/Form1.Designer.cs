namespace calc_unik
{
    partial class Form_MojFormularz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.liczba1_label = new System.Windows.Forms.Label();
            this.liczba2_label = new System.Windows.Forms.Label();
            this.liczba1_textBox = new System.Windows.Forms.TextBox();
            this.liczba2_textBox = new System.Windows.Forms.TextBox();
            this.wynik1_label = new System.Windows.Forms.Label();
            this.wynik_textBox = new System.Windows.Forms.TextBox();
            this.wynik2_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oblicz_button = new System.Windows.Forms.Button();
            this.wyczyść_button = new System.Windows.Forms.Button();
            this.zakoncz_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projekt_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczysc_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oblicz_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończ_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.działanie_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suma_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roznica_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iloczyn_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iloraz_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liczba1_label
            // 
            this.liczba1_label.AutoSize = true;
            this.liczba1_label.Location = new System.Drawing.Point(21, 26);
            this.liczba1_label.Name = "liczba1_label";
            this.liczba1_label.Size = new System.Drawing.Size(43, 15);
            this.liczba1_label.TabIndex = 0;
            this.liczba1_label.Text = "liczba1";
            this.liczba1_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // liczba2_label
            // 
            this.liczba2_label.AutoSize = true;
            this.liczba2_label.Location = new System.Drawing.Point(15, 95);
            this.liczba2_label.Name = "liczba2_label";
            this.liczba2_label.Size = new System.Drawing.Size(43, 15);
            this.liczba2_label.TabIndex = 1;
            this.liczba2_label.Text = "liczba2";
            // 
            // liczba1_textBox
            // 
            this.liczba1_textBox.Location = new System.Drawing.Point(86, 25);
            this.liczba1_textBox.Name = "liczba1_textBox";
            this.liczba1_textBox.Size = new System.Drawing.Size(100, 23);
            this.liczba1_textBox.TabIndex = 2;
            this.liczba1_textBox.Enter += new System.EventHandler(this.oblicz_button_Click);
            this.liczba1_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.liczba1_textBox_KeyDown);
            // 
            // liczba2_textBox
            // 
            this.liczba2_textBox.Location = new System.Drawing.Point(86, 92);
            this.liczba2_textBox.Name = "liczba2_textBox";
            this.liczba2_textBox.Size = new System.Drawing.Size(100, 23);
            this.liczba2_textBox.TabIndex = 3;
            this.liczba2_textBox.TextChanged += new System.EventHandler(this.liczba2_textBox_TextChanged);
            this.liczba2_textBox.Enter += new System.EventHandler(this.oblicz_button_Click);
            this.liczba2_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.liczba2_textBox_KeyDown);
            // 
            // wynik1_label
            // 
            this.wynik1_label.AutoSize = true;
            this.wynik1_label.Location = new System.Drawing.Point(20, 133);
            this.wynik1_label.Name = "wynik1_label";
            this.wynik1_label.Size = new System.Drawing.Size(38, 15);
            this.wynik1_label.TabIndex = 4;
            this.wynik1_label.Text = "wynik";
            this.wynik1_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // wynik_textBox
            // 
            this.wynik_textBox.Location = new System.Drawing.Point(86, 130);
            this.wynik_textBox.Name = "wynik_textBox";
            this.wynik_textBox.Size = new System.Drawing.Size(100, 23);
            this.wynik_textBox.TabIndex = 5;
            this.wynik_textBox.Enter += new System.EventHandler(this.oblicz_button_Click);
            // 
            // wynik2_label
            // 
            this.wynik2_label.AutoSize = true;
            this.wynik2_label.Location = new System.Drawing.Point(209, 133);
            this.wynik2_label.Name = "wynik2_label";
            this.wynik2_label.Size = new System.Drawing.Size(44, 15);
            this.wynik2_label.TabIndex = 6;
            this.wynik2_label.Text = "wynik2";
            this.wynik2_label.Visible = false;
            this.wynik2_label.Click += new System.EventHandler(this.wynik2_label_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Suma",
            "Różnica",
            "Iloraz",
            "Iloczyn"});
            this.comboBox1.Location = new System.Drawing.Point(83, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "Suma";
            // 
            // oblicz_button
            // 
            this.oblicz_button.Location = new System.Drawing.Point(92, 267);
            this.oblicz_button.Name = "oblicz_button";
            this.oblicz_button.Size = new System.Drawing.Size(75, 23);
            this.oblicz_button.TabIndex = 8;
            this.oblicz_button.Text = "oblicz";
            this.oblicz_button.UseVisualStyleBackColor = true;
            this.oblicz_button.Click += new System.EventHandler(this.oblicz_button_Click);
            this.oblicz_button.Enter += new System.EventHandler(this.oblicz_button_Click);
            this.oblicz_button.MouseLeave += new System.EventHandler(this.oblicz_button_MouseLeave);
            this.oblicz_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oblicz_button_MouseMove);
            // 
            // wyczyść_button
            // 
            this.wyczyść_button.Location = new System.Drawing.Point(203, 270);
            this.wyczyść_button.Name = "wyczyść_button";
            this.wyczyść_button.Size = new System.Drawing.Size(75, 23);
            this.wyczyść_button.TabIndex = 9;
            this.wyczyść_button.Text = "Wyczyść";
            this.wyczyść_button.UseVisualStyleBackColor = true;
            this.wyczyść_button.Click += new System.EventHandler(this.wyczyść_button_Click);
            // 
            // zakoncz_button
            // 
            this.zakoncz_button.Location = new System.Drawing.Point(357, 337);
            this.zakoncz_button.Name = "zakoncz_button";
            this.zakoncz_button.Size = new System.Drawing.Size(75, 23);
            this.zakoncz_button.TabIndex = 10;
            this.zakoncz_button.Text = "zamknij";
            this.zakoncz_button.UseVisualStyleBackColor = true;
            this.zakoncz_button.Click += new System.EventHandler(this.zakoncz_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projekt_ToolStripMenuItem,
            this.działanie_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // projekt_ToolStripMenuItem
            // 
            this.projekt_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyczysc_ToolStripMenuItem,
            this.oblicz_ToolStripMenuItem,
            this.zakończ_ToolStripMenuItem});
            this.projekt_ToolStripMenuItem.Name = "projekt_ToolStripMenuItem";
            this.projekt_ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projekt_ToolStripMenuItem.Text = "Projekt";
            // 
            // wyczysc_ToolStripMenuItem
            // 
            this.wyczysc_ToolStripMenuItem.Name = "wyczysc_ToolStripMenuItem";
            this.wyczysc_ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.wyczysc_ToolStripMenuItem.Text = "Wyczyść";
            this.wyczysc_ToolStripMenuItem.Click += new System.EventHandler(this.wyczysc_ToolStripMenuItem_Click);
            // 
            // oblicz_ToolStripMenuItem
            // 
            this.oblicz_ToolStripMenuItem.Name = "oblicz_ToolStripMenuItem";
            this.oblicz_ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.oblicz_ToolStripMenuItem.Text = "Oblicz";
            this.oblicz_ToolStripMenuItem.Click += new System.EventHandler(this.oblicz_ToolStripMenuItem_Click);
            // 
            // zakończ_ToolStripMenuItem
            // 
            this.zakończ_ToolStripMenuItem.Name = "zakończ_ToolStripMenuItem";
            this.zakończ_ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.zakończ_ToolStripMenuItem.Text = "Zakończ";
            this.zakończ_ToolStripMenuItem.Click += new System.EventHandler(this.zakończ_ToolStripMenuItem_Click);
            // 
            // działanie_ToolStripMenuItem
            // 
            this.działanie_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suma_ToolStripMenuItem,
            this.roznica_ToolStripMenuItem,
            this.iloczyn_ToolStripMenuItem,
            this.iloraz_ToolStripMenuItem});
            this.działanie_ToolStripMenuItem.Name = "działanie_ToolStripMenuItem";
            this.działanie_ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.działanie_ToolStripMenuItem.Text = "Działanie";
            // 
            // suma_ToolStripMenuItem
            // 
            this.suma_ToolStripMenuItem.Name = "suma_ToolStripMenuItem";
            this.suma_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suma_ToolStripMenuItem.Text = "Suma";
            this.suma_ToolStripMenuItem.Click += new System.EventHandler(this.suma_ToolStripMenuItem_Click);
            // 
            // roznica_ToolStripMenuItem
            // 
            this.roznica_ToolStripMenuItem.Name = "roznica_ToolStripMenuItem";
            this.roznica_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roznica_ToolStripMenuItem.Text = "Różnica";
            this.roznica_ToolStripMenuItem.Click += new System.EventHandler(this.roznica_ToolStripMenuItem_Click);
            // 
            // iloczyn_ToolStripMenuItem
            // 
            this.iloczyn_ToolStripMenuItem.Name = "iloczyn_ToolStripMenuItem";
            this.iloczyn_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iloczyn_ToolStripMenuItem.Text = "Iloczyn";
            this.iloczyn_ToolStripMenuItem.Click += new System.EventHandler(this.iloczyn_ToolStripMenuItem_Click);
            // 
            // iloraz_ToolStripMenuItem
            // 
            this.iloraz_ToolStripMenuItem.Name = "iloraz_ToolStripMenuItem";
            this.iloraz_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iloraz_ToolStripMenuItem.Text = "Iloraz";
            this.iloraz_ToolStripMenuItem.Click += new System.EventHandler(this.iloraz_ToolStripMenuItem_Click);
            // 
            // Form_MojFormularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(445, 364);
            this.ControlBox = false;
            this.Controls.Add(this.zakoncz_button);
            this.Controls.Add(this.wyczyść_button);
            this.Controls.Add(this.oblicz_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.wynik2_label);
            this.Controls.Add(this.wynik_textBox);
            this.Controls.Add(this.wynik1_label);
            this.Controls.Add(this.liczba2_textBox);
            this.Controls.Add(this.liczba1_textBox);
            this.Controls.Add(this.liczba2_label);
            this.Controls.Add(this.liczba1_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "Form_MojFormularz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zajęcia nr 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.oblicz_button_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label liczba1_label;
        private Label liczba2_label;
        private TextBox liczba1_textBox;
        private TextBox liczba2_textBox;
        private Label wynik1_label;
        private TextBox wynik_textBox;
        private Label wynik2_label;
        private ComboBox comboBox1;
        private Button oblicz_button;
        private Button wyczyść_button;
        private Button zakoncz_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem projekt_ToolStripMenuItem;
        private ToolStripMenuItem wyczysc_ToolStripMenuItem;
        private ToolStripMenuItem oblicz_ToolStripMenuItem;
        private ToolStripMenuItem zakończ_ToolStripMenuItem;
        private ToolStripMenuItem działanie_ToolStripMenuItem;
        private ToolStripMenuItem suma_ToolStripMenuItem;
        private ToolStripMenuItem roznica_ToolStripMenuItem;
        private ToolStripMenuItem iloczyn_ToolStripMenuItem;
        private ToolStripMenuItem iloraz_ToolStripMenuItem;
    }
}