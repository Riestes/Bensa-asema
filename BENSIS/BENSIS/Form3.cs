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
    public partial class Form3 : Form
    {
        Form2 Mainostaulu;
        string mainos;
        string hinta;
        string hinta1;
        string hinta2;
        public Form3()
        {
        }

        public Form3(Form2 f2)
        {
            InitializeComponent();

            button4.Click += muutamainos;
            button1.Click += muutahinta;
            button2.Click += muutahinta1;
            button3.Click += muutahinta2;

            Mainostaulu = f2;
            
        }
        //Päivitetään tiedot uudet syötetyt tiedot tekstitiedostoon
        //Päivitetään uudet tiedot myös tekstiboksiin mainostauluun
        private void muutahinta2(object sender, EventArgs e)
        {
            double h2 = double.Parse(textBox3.Text);
            Mainostaulu.paivitahinta2("" + h2);
        }

        private void muutahinta1(object sender, EventArgs e)
        {

            double h1 = double.Parse(textBox2.Text);
            Mainostaulu.paivitahinta1("" + h1);
        }

        private void muutahinta(object sender, EventArgs e)
        {
            double h = double.Parse(textBox1.Text);
            Mainostaulu.paivitahinta("" + h);
        }

        private void muutamainos(object sender, EventArgs e)
        {
            string p4 = textBox4.Text;
            Mainostaulu.paivita("" + p4);
        }

        

        public void SetHinta2(string hinta2)
        {
            this.hinta2 = hinta2;
        }

        public void SetMainos(string mainos)
        {
            this.mainos = mainos;
        }

        public void SetHinta(string hinta)
        {
            this.hinta = hinta;

        }
        public void SetHinta1(string hinta1)
        {
            this.hinta1 = hinta1;
        }

        //Sulkee ohjelman
        private void Sulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
