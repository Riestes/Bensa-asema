using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Maksuautomaatti___bensamittari
{
    public partial class formPIN : Form
    {
        FormTankkaus tankkausformi = new FormTankkaus();

        public formPIN()
        {
            InitializeComponent();
            textBoxPin.UseSystemPasswordChar = true;
        }

        // TÄSSÄ ON ASETETTU OIKEA PIN-KOODI 1234, MUUT KOODIT EI KÄY
        bool tarkistaPin(string PIN)
        {
            if (PIN == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // OK BUTTONILLA JATKETAAN SEURAAVAAN FORMIIN JOS PIN ON OIKEIN.
        // JOS PIN ON VÄÄRIN, AVATAAN MESSAGEBOX JOKA ILMOITTAA "PIN VÄÄRIN".
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (tarkistaPin(textBoxPin.Text))
            {
                avaaTankkausForm("", e);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("PIN väärin!");
            }
        }

        // JOS PIN OIKEIN SE AVAA SUORAAN UUDEN FORMIN, JA SULKEE PIN-KOODI FORMIN.
        private void avaaTankkausForm(object sender, EventArgs e)
        {
            if (tankkausformi.IsDisposed)
            {
                tankkausformi = new FormTankkaus();
            }
            tankkausformi.Show();
        }
        
    }
}
