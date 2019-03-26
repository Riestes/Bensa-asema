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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        Form1 main = new Form1();
        public Form3()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            //kayttajatunnus= File.ReadLines(tiedosto).Skip(0).Take(1).First();
            //salasana= File.ReadLines(tiedosto).Skip(1).Take(2).First();
            button1.Click += kayttaja;
        }

        private void kayttaja(object sender, EventArgs e)
        {
            bool tunnuksetoikein = false;
            string path = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/kayttajatunnukset.txt";

            string suola = "dsmDQIrjh89masio";
            MD5CryptoServiceProvider md5Kryptaaja = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(suola + textBox2.Text + suola);
            data = md5Kryptaaja.ComputeHash(data);
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
            }
            else
            {
                MessageBox.Show("Väärä salasana tai käyttäjätunnus");
            }
        }

        public class Tunnukset
        {
            public string kayttajanimi;
            public string salasana;
        }
    }
}
