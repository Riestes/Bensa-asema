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

namespace Maksuautomaatti___bensamittari
{
    public partial class Form1 : Form
    {
        formPIN pinformi  = new formPIN();

        public Form1()
        {
            InitializeComponent();

            // LUETAAN HINNAT TEKSTITIEDOSTOSTA (READLINESILLA VALITAAN OIKEAT RIVIT).
            string hinta95 = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/hinnat.txt";
            string hinta98 = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/hinnat.txt";
            string hintadiesel = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/hinnat.txt";

            hinta95 = File.ReadLines(hinta95).Skip(1).Take(2).First();
            labelysiviis.Text = hinta95;

            hinta98 = File.ReadLines(hinta98).Skip(4).Take(5).First();
            labelysikasi.Text = hinta98;

            hintadiesel = File.ReadLines(hintadiesel).Skip(7).Take(8).First();
            labeldiesel.Text = hintadiesel;

            // button osta alustus
            buttonOsta.Click += avaaPinForm;
        }

        // PAINETAAN OSTOBUTTONIA JA SIITÄ AUKEAA SEURAAVA FORMI
        private void avaaPinForm(object sender, EventArgs e)
        {
            if (pinformi.IsDisposed)
            {
                pinformi = new formPIN();
            }
            pinformi.Show();
        }
    }
}
