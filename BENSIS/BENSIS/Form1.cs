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
using System.Security.Cryptography;

namespace BENSIS
{
    public partial class Form1 : Form
    {
        Form2 main = new Form2();
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            button2.Click += kayttaja;
        }

        private void kayttaja(object arg1, EventArgs arg2)
        {
            bool tunnuksetoikein = false;
            string path = @"D:\Graafisen käyttöliittymän ohjelmointi\Bensa-asema\kayttajatunnukset.txt";
            string suola = "dsmDQIrjh89masio";
            MD5CryptoServiceProvider md5kryptaaja = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(suola + textBox2.Text + suola);
            data = md5kryptaaja.ComputeHash(data);
            string md5tiiviste = "";
            for (int i = 0; i < data.Length; i++)
            {
                md5tiiviste += data[i].ToString("x2").ToLower();
            }

            List<Tunnukset> Tunnuslista = new List<Tunnukset>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();
                    strArray = str.Split(';');
                    Tunnukset nykyinenkayttaja = new Tunnukset();
                    nykyinenkayttaja.kayttajanimi = strArray[0];
                    nykyinenkayttaja.salasana = strArray[1];
                    Tunnuslista.Add(nykyinenkayttaja);
                }
            }
            for (int i = 0; i < Tunnuslista.Count(); i++)
            {
                if (textBox1.Text == Tunnuslista[i].kayttajanimi && md5tiiviste == Tunnuslista[i].salasana)
                {
                    tunnuksetoikein = true;
                }
            }
            if (tunnuksetoikein == true)
            {
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Väärä käyttäjänimi tai salasana");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public class Tunnukset
        {
            public string kayttajanimi;
            public string salasana;
        }
    }
}
