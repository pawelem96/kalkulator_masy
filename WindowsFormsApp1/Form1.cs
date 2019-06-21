using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double g = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Okno1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // jeśli chcemy obsługiwać przecinek (Europa) i kropkę (USA)
            // możemy odwrócić znaki, by wyświetlało kropkę lub usunąć
            // te dwie linijki by usunąć kompatybilność tych liczb
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            // pozwala na tylko jeden przecinek w słowie
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
                e.Handled = true;

            // nie pozwala na przecinek na początku
            if (e.KeyChar == ',' && okno1.SelectionStart == 0)
                e.Handled = true;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }
        private void Okno2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
                e.Handled = true;

            if (e.KeyChar == ',' && okno2.SelectionStart == 0)
                e.Handled = true;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (okrag.Checked)
            {
                srednica.Text = "Średnica";
            }
            else
            {
                srednica.Text = "Bok";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (kwadrat.Checked)
            {
                double a = Convert.ToDouble(okno1.Text);
                double h = Convert.ToDouble(okno2.Text);
                double obj = a * a * h;
                double masa = obj * g;
                wynik.Text = "Obliczona masa preta to" + " " + masa;
            }
            else if (okrag.Checked)
            {
                double r = Convert.ToDouble(okno1.Text);
                double h = Convert.ToDouble(okno2.Text);
                double pi = 3.14;
                double obj = pi * r * r * h;
                double masa = obj * g;
                wynik.Text = "Obliczona masa preta to" + " " + masa;
            }
            else if (szesc.Checked)
            {
                double a = Convert.ToDouble(okno1.Text);
                double h = Convert.ToDouble(okno2.Text);
                double pierw = Math.Sqrt(3);
                double pole = (3 * a * a * pierw) / 2;
                double obj = pole * h;
                double masa = obj * g;
                wynik.Text = "Obliczona masa preta to" + " " + masa;

            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            wartosc.Text = lista.Text;
        }

    }
    }