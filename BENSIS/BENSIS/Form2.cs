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

namespace BENSIS
{
    public partial class Form2 : Form
    {
        string hinta = @"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt";
        string hinta1 = @"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt";
        string hinta2 = @"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt";
        string mainos = @"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\Mainosteksti.txt";

        Form3 muokkaa;
        public Form2()
        {
            InitializeComponent();

           
            //alustetaan miltä riviltä hintatiedostosta minkäkin bensalaadun hinta luetaan
            hinta = File.ReadLines(hinta).Skip(1).Take(2).First();
            hinta1 = File.ReadLines(hinta1).Skip(4).Take(5).First();
            hinta2 = File.ReadLines(hinta2).Skip(7).Take(8).First();
            mainos = File.ReadAllText(mainos);

            E95label.Text = hinta;
            E98label.Text = hinta1;
            Diesellabel.Text = hinta2;
            Mainoslabel.Text = mainos;

        }

        private void Muokkaa_Click(object sender, EventArgs e)
        {

            muokkaa = new Form3(this);
            muokkaa.SetMainos(mainos);
            muokkaa.SetHinta(hinta);
            muokkaa.SetHinta1(hinta1);
            muokkaa.SetHinta2(hinta2);
            muokkaa.Show();




        }

        private void sulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Päivitetään tekstitiedostoon uusi annettu hinta
        public void paivita(string p4)
        {
            mainos = p4;
            Mainoslabel.Text = mainos;
            var lines = File.ReadAllLines(@"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\Mainosteksti.txt");
            lines[0] = Mainoslabel.Text;
            File.WriteAllLines(@"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\Mainosteksti.txt", lines);

        }

        public void paivitahinta(string h)
        {
            hinta = h;
            E95label.Text = hinta;
            var lines = File.ReadAllLines(@"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt");
            lines[1] = hinta;
            File.WriteAllLines(@"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt", lines);
        }

        public void paivitahinta1(string h1)
        {
            hinta1 = h1;
            E98label.Text = hinta1;
            var lines = File.ReadAllLines(@"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt");
            lines[4] = hinta1;
            File.WriteAllLines(@"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt", lines);
        }

        public void paivitahinta2(string h2)
        {
            hinta2 = h2;
            Diesellabel.Text = hinta2;
            var lines = File.ReadAllLines(@"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt");
            lines[7] = hinta2;
            File.WriteAllLines(@"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\hinnat.txt", lines);
        }
    }
}
