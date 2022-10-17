namespace calc_unik
{
    public partial class Form_MojFormularz : Form
    {
        public Form_MojFormularz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            MessageBox.Show("Startujemy", "Komunikat");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void liczba2_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wynik2_label_Click(object sender, EventArgs e)
        {
           
        }

        private void oblicz_button_Click(object sender, EventArgs e)
        {
            

            if (comboBox1.Text == "Suma")
            {
                if (liczba1_textBox.Text != "" && liczba2_textBox.Text != "")
                    if (Int32.TryParse(liczba1_textBox.Text, out int value) && Int32.TryParse(liczba1_textBox.Text, out int value2))
                    {
                        wynik_textBox.Text = Convert.ToString(value + value2);
                    }
                    else
                    {
                        MessageBox.Show("w textboxach nie so same liczby", "error");
                    }
            }
            else if(comboBox1.Text == "Różnica")
            {
                if (liczba1_textBox.Text != "" && liczba2_textBox.Text != "")
                    if (Int32.TryParse(liczba1_textBox.Text, out int value) && Int32.TryParse(liczba1_textBox.Text, out int value2))
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
                    if (Int32.TryParse(liczba1_textBox.Text, out int value) && Int32.TryParse(liczba1_textBox.Text, out int value2))
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
                    if (Int32.TryParse(liczba1_textBox.Text, out int value) && Int32.TryParse(liczba1_textBox.Text, out int value2))
                    {
                        wynik_textBox.Text = Convert.ToString(value / value2);
                    }
                    else
                    {
                        MessageBox.Show("w textboxach nie so same liczby", "error");
                    }
            }
        }

        private void wyczyść_button_Click(object sender, EventArgs e)
        {
            wynik_textBox.Clear();
            liczba1_textBox.Clear();
            liczba2_textBox.Clear();
        }

        private void zakoncz_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oblicz_button_MouseMove(object sender, MouseEventArgs e)
        {
            oblicz_button.Size = new Size(80, 28);
            oblicz_button.Text = "naciśnij";
        }

        private void oblicz_button_MouseLeave(object sender, EventArgs e)
        {
            oblicz_button.Size = new Size(75, 23);
            oblicz_button.Text = "oblicz";
        }

        private void liczba2_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                oblicz_button_Click(this, new EventArgs());
        }

        private void liczba1_textBox_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                    oblicz_button_Click(this, new EventArgs());
        }
    }
}