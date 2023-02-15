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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("grupa 1");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("grupa 2");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("rok I", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("grupa 1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("grupa 2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("rok II", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.strona1_tabPage = new System.Windows.Forms.TabPage();
            this.tekstIn_richTextBox = new System.Windows.Forms.RichTextBox();
            this.strona2_tabPage = new System.Windows.Forms.TabPage();
            this.studia_treeView = new System.Windows.Forms.TreeView();
            this.datarezerwacji_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.student_comboBox = new System.Windows.Forms.ComboBox();
            this.strona3_tabPage = new System.Windows.Forms.TabPage();
            this.tekstOut_richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.strona1_tabPage.SuspendLayout();
            this.strona2_tabPage.SuspendLayout();
            this.strona3_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // liczba1_label
            // 
            this.liczba1_label.AutoSize = true;
            this.liczba1_label.Location = new System.Drawing.Point(12, 62);
            this.liczba1_label.Name = "liczba1_label";
            this.liczba1_label.Size = new System.Drawing.Size(43, 15);
            this.liczba1_label.TabIndex = 0;
            this.liczba1_label.Text = "liczba1";
            this.liczba1_label.Click += new System.EventHandler(this.Label1_Click);
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
            this.liczba1_textBox.Location = new System.Drawing.Point(86, 54);
            this.liczba1_textBox.Name = "liczba1_textBox";
            this.liczba1_textBox.Size = new System.Drawing.Size(100, 23);
            this.liczba1_textBox.TabIndex = 2;
            this.liczba1_textBox.Enter += new System.EventHandler(this.Oblicz_button_Click);
            this.liczba1_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Liczba1_textBox_KeyDown);
            // 
            // liczba2_textBox
            // 
            this.liczba2_textBox.Location = new System.Drawing.Point(86, 92);
            this.liczba2_textBox.Name = "liczba2_textBox";
            this.liczba2_textBox.Size = new System.Drawing.Size(100, 23);
            this.liczba2_textBox.TabIndex = 3;
            this.liczba2_textBox.TextChanged += new System.EventHandler(this.Liczba2_textBox_TextChanged);
            this.liczba2_textBox.Enter += new System.EventHandler(this.Oblicz_button_Click);
            this.liczba2_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Liczba2_textBox_KeyDown);
            // 
            // wynik1_label
            // 
            this.wynik1_label.AutoSize = true;
            this.wynik1_label.Location = new System.Drawing.Point(20, 133);
            this.wynik1_label.Name = "wynik1_label";
            this.wynik1_label.Size = new System.Drawing.Size(38, 15);
            this.wynik1_label.TabIndex = 4;
            this.wynik1_label.Text = "wynik";
            this.wynik1_label.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // wynik_textBox
            // 
            this.wynik_textBox.Location = new System.Drawing.Point(86, 130);
            this.wynik_textBox.Name = "wynik_textBox";
            this.wynik_textBox.Size = new System.Drawing.Size(100, 23);
            this.wynik_textBox.TabIndex = 5;
            this.wynik_textBox.Enter += new System.EventHandler(this.Oblicz_button_Click);
            // 
            // wynik2_label
            // 
            this.wynik2_label.AutoSize = true;
            this.wynik2_label.Location = new System.Drawing.Point(192, 95);
            this.wynik2_label.Name = "wynik2_label";
            this.wynik2_label.Size = new System.Drawing.Size(44, 15);
            this.wynik2_label.TabIndex = 6;
            this.wynik2_label.Text = "wynik2";
            this.wynik2_label.Visible = false;
            this.wynik2_label.Click += new System.EventHandler(this.Wynik2_label_Click);
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
            this.oblicz_button.Click += new System.EventHandler(this.Oblicz_button_Click);
            this.oblicz_button.Enter += new System.EventHandler(this.Oblicz_button_Click);
            this.oblicz_button.MouseLeave += new System.EventHandler(this.Oblicz_button_MouseLeave);
            this.oblicz_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Oblicz_button_MouseMove);
            // 
            // wyczyść_button
            // 
            this.wyczyść_button.Location = new System.Drawing.Point(203, 270);
            this.wyczyść_button.Name = "wyczyść_button";
            this.wyczyść_button.Size = new System.Drawing.Size(75, 23);
            this.wyczyść_button.TabIndex = 9;
            this.wyczyść_button.Text = "Wyczyść";
            this.wyczyść_button.UseVisualStyleBackColor = true;
            this.wyczyść_button.Click += new System.EventHandler(this.Wyczyść_button_Click);
            // 
            // zakoncz_button
            // 
            this.zakoncz_button.Location = new System.Drawing.Point(357, 337);
            this.zakoncz_button.Name = "zakoncz_button";
            this.zakoncz_button.Size = new System.Drawing.Size(75, 23);
            this.zakoncz_button.TabIndex = 10;
            this.zakoncz_button.Text = "zamknij";
            this.zakoncz_button.UseVisualStyleBackColor = true;
            this.zakoncz_button.Click += new System.EventHandler(this.Zakoncz_button_Click);
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
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
            this.wyczysc_ToolStripMenuItem.Click += new System.EventHandler(this.Wyczysc_ToolStripMenuItem_Click);
            // 
            // oblicz_ToolStripMenuItem
            // 
            this.oblicz_ToolStripMenuItem.Name = "oblicz_ToolStripMenuItem";
            this.oblicz_ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.oblicz_ToolStripMenuItem.Text = "Oblicz";
            this.oblicz_ToolStripMenuItem.Click += new System.EventHandler(this.Oblicz_ToolStripMenuItem_Click);
            // 
            // zakończ_ToolStripMenuItem
            // 
            this.zakończ_ToolStripMenuItem.Name = "zakończ_ToolStripMenuItem";
            this.zakończ_ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.zakończ_ToolStripMenuItem.Text = "Zakończ";
            this.zakończ_ToolStripMenuItem.Click += new System.EventHandler(this.Zakończ_ToolStripMenuItem_Click);
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
            this.suma_ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.suma_ToolStripMenuItem.Text = "Suma";
            this.suma_ToolStripMenuItem.Click += new System.EventHandler(this.Suma_ToolStripMenuItem_Click);
            // 
            // roznica_ToolStripMenuItem
            // 
            this.roznica_ToolStripMenuItem.Name = "roznica_ToolStripMenuItem";
            this.roznica_ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.roznica_ToolStripMenuItem.Text = "Różnica";
            this.roznica_ToolStripMenuItem.Click += new System.EventHandler(this.Roznica_ToolStripMenuItem_Click);
            // 
            // iloczyn_ToolStripMenuItem
            // 
            this.iloczyn_ToolStripMenuItem.Name = "iloczyn_ToolStripMenuItem";
            this.iloczyn_ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.iloczyn_ToolStripMenuItem.Text = "Iloczyn";
            this.iloczyn_ToolStripMenuItem.Click += new System.EventHandler(this.Iloczyn_ToolStripMenuItem_Click);
            // 
            // iloraz_ToolStripMenuItem
            // 
            this.iloraz_ToolStripMenuItem.Name = "iloraz_ToolStripMenuItem";
            this.iloraz_ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.iloraz_ToolStripMenuItem.Text = "Iloraz";
            this.iloraz_ToolStripMenuItem.Click += new System.EventHandler(this.Iloraz_ToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.strona1_tabPage);
            this.TabControl.Controls.Add(this.strona2_tabPage);
            this.TabControl.Controls.Add(this.strona3_tabPage);
            this.TabControl.Location = new System.Drawing.Point(245, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(200, 206);
            this.TabControl.TabIndex = 12;
            // 
            // strona1_tabPage
            // 
            this.strona1_tabPage.Controls.Add(this.tekstIn_richTextBox);
            this.strona1_tabPage.Location = new System.Drawing.Point(4, 24);
            this.strona1_tabPage.Name = "strona1_tabPage";
            this.strona1_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.strona1_tabPage.Size = new System.Drawing.Size(192, 178);
            this.strona1_tabPage.TabIndex = 0;
            this.strona1_tabPage.Text = "Strona 1";
            this.strona1_tabPage.UseVisualStyleBackColor = true;
            // 
            // tekstIn_richTextBox
            // 
            this.tekstIn_richTextBox.Location = new System.Drawing.Point(6, 7);
            this.tekstIn_richTextBox.Name = "tekstIn_richTextBox";
            this.tekstIn_richTextBox.Size = new System.Drawing.Size(180, 165);
            this.tekstIn_richTextBox.TabIndex = 0;
            this.tekstIn_richTextBox.Text = "";
            // 
            // strona2_tabPage
            // 
            this.strona2_tabPage.Controls.Add(this.studia_treeView);
            this.strona2_tabPage.Controls.Add(this.datarezerwacji_dateTimePicker);
            this.strona2_tabPage.Controls.Add(this.student_comboBox);
            this.strona2_tabPage.Location = new System.Drawing.Point(4, 24);
            this.strona2_tabPage.Name = "strona2_tabPage";
            this.strona2_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.strona2_tabPage.Size = new System.Drawing.Size(192, 178);
            this.strona2_tabPage.TabIndex = 1;
            this.strona2_tabPage.Text = "Strona 2";
            this.strona2_tabPage.UseVisualStyleBackColor = true;
            // 
            // studia_treeView
            // 
            this.studia_treeView.Location = new System.Drawing.Point(10, 69);
            this.studia_treeView.Name = "studia_treeView";
            treeNode7.Name = "grupa_1_1";
            treeNode7.Text = "grupa 1";
            treeNode8.Name = "grupa_1_2";
            treeNode8.Text = "grupa 2";
            treeNode9.Name = "rok_1";
            treeNode9.Text = "rok I";
            treeNode10.Name = "grupa_2_1";
            treeNode10.Text = "grupa 1";
            treeNode11.Name = "grupa_2_2";
            treeNode11.Text = "grupa 2";
            treeNode12.Name = "rok_2";
            treeNode12.Text = "rok II";
            this.studia_treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.studia_treeView.Size = new System.Drawing.Size(173, 97);
            this.studia_treeView.TabIndex = 2;
            // 
            // datarezerwacji_dateTimePicker
            // 
            this.datarezerwacji_dateTimePicker.Location = new System.Drawing.Point(8, 38);
            this.datarezerwacji_dateTimePicker.MinDate = new System.DateTime(2023, 2, 6, 0, 0, 0, 0);
            this.datarezerwacji_dateTimePicker.Name = "datarezerwacji_dateTimePicker";
            this.datarezerwacji_dateTimePicker.Size = new System.Drawing.Size(144, 23);
            this.datarezerwacji_dateTimePicker.TabIndex = 1;
            this.datarezerwacji_dateTimePicker.ValueChanged += new System.EventHandler(this.Datarezerwacji_dateTimePicker_ValueChanged);
            // 
            // student_comboBox
            // 
            this.student_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.student_comboBox.FormattingEnabled = true;
            this.student_comboBox.Items.AddRange(new object[] {
            "student 1",
            "student 2",
            "student 3"});
            this.student_comboBox.Location = new System.Drawing.Point(8, 9);
            this.student_comboBox.Name = "student_comboBox";
            this.student_comboBox.Size = new System.Drawing.Size(121, 23);
            this.student_comboBox.TabIndex = 0;
            // 
            // strona3_tabPage
            // 
            this.strona3_tabPage.Controls.Add(this.tekstOut_richTextBox);
            this.strona3_tabPage.Location = new System.Drawing.Point(4, 24);
            this.strona3_tabPage.Name = "strona3_tabPage";
            this.strona3_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.strona3_tabPage.Size = new System.Drawing.Size(192, 178);
            this.strona3_tabPage.TabIndex = 2;
            this.strona3_tabPage.Text = "Strona 3";
            this.strona3_tabPage.UseVisualStyleBackColor = true;
            this.strona3_tabPage.Click += new System.EventHandler(this.Strona3_tabPage_Click);
            // 
            // tekstOut_richTextBox
            // 
            this.tekstOut_richTextBox.Location = new System.Drawing.Point(6, 7);
            this.tekstOut_richTextBox.Name = "tekstOut_richTextBox";
            this.tekstOut_richTextBox.Size = new System.Drawing.Size(180, 165);
            this.tekstOut_richTextBox.TabIndex = 0;
            this.tekstOut_richTextBox.Text = "";
            // 
            // Form_MojFormularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(445, 364);
            this.ControlBox = false;
            this.Controls.Add(this.TabControl);
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
            this.Enter += new System.EventHandler(this.Oblicz_button_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_MojFormularz_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.strona1_tabPage.ResumeLayout(false);
            this.strona2_tabPage.ResumeLayout(false);
            this.strona3_tabPage.ResumeLayout(false);
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
        private TabControl TabControl;
        private TabPage strona1_tabPage;
        private TabPage strona2_tabPage;
        private TabPage strona3_tabPage;
        private RichTextBox tekstIn_richTextBox;
        private DateTimePicker datarezerwacji_dateTimePicker;
        private ComboBox student_comboBox;
        private RichTextBox tekstOut_richTextBox;
        private TreeView studia_treeView;
    }
}