namespace calc_unik
{
    public partial class Form_MojFormularz : Form
    {
        public static Keys KeyCode { get; private set; }

        private string ImgPath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\resources\cross.jpg");

        public Form_MojFormularz()
        {
            InitializeComponent();
            zakończ_ToolStripMenuItem.Image = Image.FromFile(ImgPath);
            datarezerwacji_dateTimePicker.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            MessageBox.Show("Startujemy", "Komunikat");
            Check_checked();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Liczba2_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wynik2_label_Click(object sender, EventArgs e)
        {
           
        }

        private void Oblicz_button_Click(object sender, EventArgs e)
        {
            Oblicz();
        }

        private void Wyczyść_button_Click(object sender, EventArgs e)
        {
            Wyczysc();
        }

        private void Zakoncz_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Oblicz_button_MouseMove(object sender, MouseEventArgs e)
        {
            oblicz_button.Size = new Size(80, 28);
            oblicz_button.Text = "naciśnij";
        }

        private void Oblicz_button_MouseLeave(object sender, EventArgs e)
        {
            oblicz_button.Size = new Size(75, 23);
            oblicz_button.Text = "oblicz";
        }

        private void Liczba2_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Oblicz();
                //oblicz_button_Click(this, new EventArgs());
        }

        private void Liczba1_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Oblicz();
                //oblicz_button_Click(this, new EventArgs());
        }
        //
        // ToolStripMenu
        //
        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Wyczysc_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wyczysc();
        }

        private void Oblicz_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oblicz();
        }

        private void Zakończ_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Suma_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Suma";
            Check_checked();
        }

        private void Roznica_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Różnica";
            Check_checked();
        }

        private void Iloczyn_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Iloczyn";
            Check_checked();
        }

        private void Iloraz_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Iloraz";
            Check_checked();
        }

        //
        // funkcji
        //
        private void Oblicz()
        {
            wynik_textBox.Clear();
            if (comboBox1.Text == "Suma")
            {
                if (liczba1_textBox.Text != "" && liczba2_textBox.Text != "")
                    if (Int32.TryParse(liczba1_textBox.Text, out int value) && Int32.TryParse(liczba2_textBox.Text, out int value2))
                    {
                        wynik_textBox.Text = Convert.ToString(value + value2);
                    }
                    else
                    {
                        MessageBox.Show("w textboxach nie so same liczby", "error");
                    }
            }
            else if (comboBox1.Text == "Różnica")
            {
                if (liczba1_textBox.Text != "" && liczba2_textBox.Text != "")
                    if (Int32.TryParse(liczba1_textBox.Text, out int value) && Int32.TryParse(liczba2_textBox.Text, out int value2))
                    {
                        wynik_textBox.Text = Convert.ToString(value - value2);
                    }
                    else
                    {
                        MessageBox.Show("w textboxach nie so same liczby", "error");
                    }
            }
            else if (comboBox1.Text == "Iloraz")
            {
                if (liczba1_textBox.Text != "" && liczba2_textBox.Text != "")
                    if (Int32.TryParse(liczba1_textBox.Text, out int value) && Int32.TryParse(liczba2_textBox.Text, out int value2))
                    {
                        wynik_textBox.Text = Convert.ToString(value * value2);
                    }
                    else
                    {
                        MessageBox.Show("w textboxach nie so same liczby", "error");
                    }
            }
            else if (comboBox1.Text == "Iloczyn")
            {
                if (liczba1_textBox.Text != "" && liczba2_textBox.Text != "")
                    if (Int32.TryParse(liczba1_textBox.Text, out int value) && Int32.TryParse(liczba2_textBox.Text, out int value2))
                    {
                        wynik_textBox.Text = Convert.ToString(value / value2);
                    }
                    else
                    {
                        MessageBox.Show("w textboxach nie so same liczby", "error");
                    }
            }
        }

        private void Wyczysc()
        {
            wynik_textBox.Clear();
            liczba1_textBox.Clear();
            liczba2_textBox.Clear();
        }
        private void Skrut_dla_oblicz(object sender, EventArgs e)
        {
            if (Form_MojFormularz.KeyCode == Keys.Enter)
                Oblicz();
            if ((Form_MojFormularz.KeyCode == Keys.Control)&&(Form_MojFormularz.KeyCode == Keys.O))
                Oblicz();
        }

        private void Check_checked()
        {
            suma_ToolStripMenuItem.Checked = false;
            roznica_ToolStripMenuItem.Checked = false;
            iloraz_ToolStripMenuItem.Checked = false;
            iloczyn_ToolStripMenuItem.Checked = false;

            if (comboBox1.Text == "Suma")
                suma_ToolStripMenuItem.Checked = true;
            else if (comboBox1.Text == "Różnica")
                roznica_ToolStripMenuItem.Checked = true;
            else if (comboBox1.Text == "Iloraz")
                iloraz_ToolStripMenuItem.Checked = true;
            else if (comboBox1.Text == "Iloczyn")
                iloczyn_ToolStripMenuItem.Checked = true;
        }

        private void Form_MojFormularz_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Control )||(e.KeyCode == Keys.O))
            {
                Oblicz();
            }
        }

        private void Datarezerwacji_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(datarezerwacji_dateTimePicker.Value > datarezerwacji_dateTimePicker.MinDate.AddDays(30))
            {
                MessageBox.Show("data jest zbyt daleko", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Strona3_tabPage_Click(object sender, EventArgs e)
        {
            string tmp_txt;
            tmp_txt = student_comboBox.Text + "\n";
            if (studia_treeView.SelectedNode.Level == 0)
            {
                tmp_txt += studia_treeView.SelectedNode.Text + "\n";
            }
            else
            {
                tmp_txt += studia_treeView.SelectedNode.Nodes + studia_treeView.SelectedNode.Text + "\n";
            }
            tmp_txt += datarezerwacji_dateTimePicker.Value + "\n" + tekstIn_richTextBox;

            tekstOut_richTextBox.Text = tmp_txt;
        }

        private void Abnawlenij_tekstOut_richTextBox()
        {
            tekstOut_richTextBox.Text = string.Empty;
            if(tekstIn_richTextBox.Text != string.Empty)
            {
                tekstOut_richTextBox.Text += tekstIn_richTextBox.Text+"\n";
            }

            if (student_comboBox.Text != string.Empty)
            {
                tekstOut_richTextBox.Text += student_comboBox.Text + "\n";
            }

            if (datarezerwacji_dateTimePicker.Text != string.Empty)
            {
                tekstOut_richTextBox.Text += datarezerwacji_dateTimePicker.Text + "\n";
            }

            if (studia_treeView.SelectedNode != null)
            {
                tekstOut_richTextBox.Text += studia_treeView.TopNode.Text +": "+ studia_treeView.SelectedNode.Text + "\n";
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Abnawlenij_tekstOut_richTextBox();
        }
    }
}