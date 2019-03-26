using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;


namespace Maksuautomaatti___bensamittari
{
    public partial class FormTankkaus : Form
    {
        double maara;
        string tankkisijainti = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt";
        string tankki95;
        string tankki98;
        string tankkiDiesel;

        public FormTankkaus()
        {
            InitializeComponent();
            tankki95 = File.ReadLines(tankkisijainti).Skip(1).Take(2).First();
            tankki98 = File.ReadLines(tankkisijainti).Skip(4).Take(5).First();
            tankkiDiesel = File.ReadLines(tankkisijainti).Skip(7).Take(8).First();
        }
        
        private void button95_Click(object sender, EventArgs e)
        {
            string hinta95 = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/hinnat.txt";
            hinta95 = File.ReadLines(hinta95).Skip(1).Take(1).First();
            if (System.Text.RegularExpressions.Regex.IsMatch(tankkausBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Ole hyvä ja syötä vain numeroita.");
                tankkausBox.Text = tankkausBox.Text.Remove(tankkausBox.Text.Length - 1);
                tankkausBox.Clear();
            }
            else
            {
                tankkaa(double.Parse(tankkausBox.Text), double.Parse(hinta95), "95E", double.Parse(tankki95));
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            string hinta98 = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/hinnat.txt";
            hinta98 = File.ReadLines(hinta98).Skip(4).Take(5).First();
            if (System.Text.RegularExpressions.Regex.IsMatch(tankkausBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Ole hyvä ja syötä vain numeroita.");
                tankkausBox.Text = tankkausBox.Text.Remove(tankkausBox.Text.Length - 1);
                tankkausBox.Clear();
            }
            else
            {
                tankkaa(double.Parse(tankkausBox.Text), double.Parse(hinta98), "98E", double.Parse(tankki98));
            }
        }

        private void buttonDiesel_Click(object sender, EventArgs e)
        {
            string hintadiesel = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/hinnat.txt";
            hintadiesel = File.ReadLines(hintadiesel).Skip(7).Take(8).First();
            if (System.Text.RegularExpressions.Regex.IsMatch(tankkausBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Ole hyvä ja syötä vain numeroita.");
                tankkausBox.Text = tankkausBox.Text.Remove(tankkausBox.Text.Length - 1);
                tankkausBox.Clear();
            }
            else
            {
                tankkaa(double.Parse(tankkausBox.Text), double.Parse(hintadiesel), "Diesel", double.Parse(tankkiDiesel));
            }
        }

        // TÄSSÄ ON "TANKKAA" ALIOHJELMA.
        public void tankkaa(double summa, double hinta, string bensa, double tankki)
        {
            
            maara = summa / hinta;
            if (maara > tankki)
            {
                MessageBox.Show("Tankkissa ei ollut tarpeeksi polttoainetta");
            }
            else
            {
                string litrat = maara.ToString();
                this.Dispose();
                MessageBox.Show("Tankkasit " + string.Format("{0:0.0}", maara) + " litraa.");
                tallennaKuitit(summa, litrat, bensa);
                if (bensa == "Diesel")
                {
                    double tankinBensa = double.Parse(tankkiDiesel) - maara;
                    var lines = File.ReadAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt");
                    lines[7] = string.Format("{0:0.0}", double.Parse(tankinBensa.ToString()));
                    File.WriteAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt", lines);
                }
                else if (bensa == "98E")
                {
                    double tankinBensa = double.Parse(tankki98) - maara;
                    var lines = File.ReadAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt");
                    lines[4] = string.Format("{0:0.0}", double.Parse(tankinBensa.ToString()));
                    File.WriteAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt", lines);
                }
                else
                {
                    double tankinBensa = double.Parse(tankki95) - maara;
                    var lines = File.ReadAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt");
                    lines[1] = string.Format("{0:0.0}", double.Parse(tankinBensa.ToString()));
                    File.WriteAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt", lines);
                }
            }
        }

        // TÄSSÄ FUNKTIO JOLLA TALLENNETAAN OSTO TEKSTITIEDOSTOON.
        public void tallennaKuitit(double summa, string maara, string tyyppi)
        {
            DateTime paivamaara = DateTime.Now;
            string aika = "dd/MM/yyyy";
            
            DateTime.Now.ToString("h:mm:ss tt");

            string kuitit = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/kuitit.txt";
            TextWriter tw = new StreamWriter(kuitit, true);
            tw.WriteLine("----------------");
            tw.WriteLine("Päivämäärä: " + paivamaara.ToString(aika));
            tw.WriteLine("Kellonaika: " + DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo));
            tw.WriteLine();
            tw.WriteLine("Summa: " + summa + " €");
            tw.WriteLine("Litrat: " + string.Format("{0:0.0}", double.Parse(maara)) + " l");
            tw.WriteLine("Tyyppi: " + tyyppi);
            tw.WriteLine("----------------");
            tw.Close();
            Application.Exit();
        }
    }
}
