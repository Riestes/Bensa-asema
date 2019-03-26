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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string tekstitiedosto = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt";
        string maara;
        string maara2;
        string maara3;
        
        TilausLomake tl;
        public Form1()
        {
            InitializeComponent();
            maara = File.ReadLines(tekstitiedosto).Skip(1).Take(2).First();
            E95.Text = maara;
            maara2 = File.ReadLines(tekstitiedosto).Skip(4).Take(5).First();
            E98.Text = maara2;
            maara3 = File.ReadLines(tekstitiedosto).Skip(7).Take(8).First();
            Diesel.Text = maara3;
            Progress();
            Varoitus();
            
        }

        private void Progress()
        {
                progressBar1.Maximum = 5000;
                progressBar1.Step = 1;
                progressBar1.Value = Convert.ToInt32(Math.Round(double.Parse(E95.Text)));
                progressBar2.Maximum = 5000;
                progressBar2.Step = 1;
                progressBar2.Value = Convert.ToInt32(Math.Round(double.Parse(E98.Text)));
                progressBar3.Maximum = 5000;
                progressBar3.Step = 1;
                progressBar3.Value = Convert.ToInt32(Math.Round(double.Parse(Diesel.Text)));

        }

        //private void Varoitus2()
        //{
        //    if (int.Parse(E95.Text)> 5000)
        //    {
        //        MessageBox.Show("Tilaus ylittää maksimi rajan");
        //    }
        //}

        private void Varoitus()
        {
            if (double.Parse(E95.Text) <= 200)
            {
                label6.ForeColor = System.Drawing.Color.Red;
                label6.Text = "Vähissä";
            }
            else
            {
                label6.Text = " ";
            }
            if (double.Parse(E98.Text) <= 200)
            {
                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Vähissä";
            }
            else
            {
                label7.Text = " ";
            }
            if (double.Parse(Diesel.Text) <= 200)
            {
                label8.ForeColor = System.Drawing.Color.Red;
                label8.Text = "Vähissä";
            }
            else
            {
                label8.Text = " ";
            }
            
        }

        public void paivita(string s)
        {
                maara = s;
                E95.Text = maara;
                var lines = File.ReadAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt");
                lines[1] = maara;
                File.WriteAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt", lines);
                Progress();
                Varoitus();
        
        }
        public void paivita2(string s2)
        {
            maara2 = s2;
            E98.Text = maara2;
            var lines = File.ReadAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt");
            lines[4] = maara2;
            File.WriteAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt", lines);
            Progress();
            Varoitus();

        }
        public void paivita3(string s3)
        {
            maara3 = s3;
            Diesel.Text = maara3;
            var lines = File.ReadAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt");
            lines[7] = maara3;
            File.WriteAllLines("D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/bensa.txt", lines);
            Progress();
            Varoitus();

        }
        
        public void tilaa_Click(object sender, EventArgs e)
        {
            tl = new TilausLomake(this);
            tl.setmaara(maara);
            tl.setmaara2(maara2);
            tl.setmaara3(maara3);
            tl.Show();
        }

        private void suljebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
    }
}
