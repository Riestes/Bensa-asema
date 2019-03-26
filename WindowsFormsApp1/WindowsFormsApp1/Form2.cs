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

namespace WindowsFormsApp1
{
    public partial class TilausLomake : Form
    {
        Form1 bensaLomake;
        string tilaukset = "D:/Graafisen käyttöliittymän ohjelmointi/Bensa-asema/tilaukset.txt";
        string maara;
        string maara2;
        string maara3;
        public TilausLomake(Form1 f1)
        {
            InitializeComponent();
            bensaLomake = f1;
            tilaa95.Click += TeeTilaus1;
            tilaa98.Click += TeeTilaus2;
            tilaadiesel.Click += TeeTilaus3;

        }



        private void TeeTilaus3(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tilausmaaradiesel.Text, "[^0-9]"))
            {
                MessageBox.Show("Ole hyvä ja syötä vain numeroita.");
                tilausmaaradiesel.Text = tilausmaaradiesel.Text.Remove(tilausmaaradiesel.Text.Length - 1);
                tilausmaaradiesel.Clear();
            }
            else
            {
                DateTime dt = DateTime.Now;
                string aika = "dd/MM/yyyy";
                DateTime.Now.ToString("h:mm:ss tt");

                // form1 tankeihin lisäys
                double n = double.Parse(tilausmaaradiesel.Text);
                double s3 = double.Parse(maara3);
                s3 = s3 + n;

                if (s3 > 5000)
                {
                    MessageBox.Show("Tilaus menee rajan yli");
                    tilausmaaradiesel.Clear();
                }
                else
                {
                    bensaLomake.paivita3("" + s3);
                    maara3 = (double.Parse(maara3) + double.Parse(tilausmaaradiesel.Text)).ToString();
                }

                // Tekstitiedostoon kirjoitus
                TextWriter tw = new StreamWriter(tilaukset, true);
                tw.Write("Diesel ");
                tw.Write(tilausmaaradiesel.Text + "l");
                tw.WriteLine(" " + dt.ToString(aika));
                tw.WriteLine(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo));
                tw.Close();
            }

        }

        private void TeeTilaus2(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tilausmaara98.Text, "[^0-9]"))
            {
                MessageBox.Show("Ole hyvä ja syötä vain numeroita.");
                tilausmaara98.Text = tilausmaara98.Text.Remove(tilausmaara98.Text.Length - 1);
                tilausmaara98.Clear();
            }
            else
            {
                DateTime dt = DateTime.Now;
                string aika = "dd/MM/yyyy";
                DateTime.Now.ToString("h:mm:ss tt");

                // form1 tankeihin lisäys
                double n = double.Parse(tilausmaara98.Text);
                double s2 = double.Parse(maara2);
                s2 = s2 + n;

                if (s2 > 5000)
                {
                    MessageBox.Show("Tilaus menee rajan yli");
                    tilausmaara98.Clear();
                }
                else
                {
                    bensaLomake.paivita2("" + s2);
                    maara2 = (double.Parse(maara2) + double.Parse(tilausmaara98.Text)).ToString();
                }

                // Tekstitiedostoon kirjoitus
                TextWriter tw = new StreamWriter(tilaukset, true);
                tw.Write("E98 ");
                tw.Write(tilausmaara98.Text + "l");
                tw.WriteLine(" " + dt.ToString(aika));
                tw.WriteLine(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo));
                tw.Close();
            }


        }

        private void TeeTilaus1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tilausmaara95.Text, "[^0-9]"))
            {
                MessageBox.Show("Ole hyvä ja syötä vain numeroita.");
                tilausmaara95.Text = tilausmaara95.Text.Remove(tilausmaara95.Text.Length - 1);
                tilausmaara95.Clear();
            }

            else
            {
                    DateTime dt = DateTime.Now;
                    string aika = "dd/MM/yyyy";
                    DateTime.Now.ToString("h:mm:ss tt");

                // form1 tankeihin lisäys
                double n = double.Parse(tilausmaara95.Text);
                double s = double.Parse(maara);
                    s = s + n;
                if (s > 5000)
                {
                    MessageBox.Show("Tilaus menee rajan yli");
                    tilausmaara95.Clear();
                }
                else
                {
                    bensaLomake.paivita("" + s);
                    maara = (double.Parse(maara) + double.Parse(tilausmaara95.Text)).ToString();
                }
                

                    // Tekstitiedostoon kirjoitus
                    TextWriter tw = new StreamWriter(tilaukset, true);
                    tw.Write("E95 ");
                    tw.Write(tilausmaara95.Text + "l");
                    tw.WriteLine(" " + dt.ToString(aika));
                    tw.WriteLine(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo));
                    tw.WriteLine(maara);
                    tw.Close();
                }

            }
            public void setmaara(string maara)
            {
                this.maara = maara;
            }
            public void setmaara2(string maara2)
            {
                this.maara2 = maara2;
            }
            public void setmaara3(string maara3)
            {
                this.maara3 = maara3;
            }

        }
    }

