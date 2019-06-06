using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public String Enkripto(String fjala, String celesi)
        {
            String enkriptuar = "";
            fjala = fjala.ToUpper();
            celesi = celesi.ToUpper();
            int z = 0;
            while (celesi.Length < fjala.Length)
            {
                celesi += celesi.ToCharArray()[z];
                z++;
            }
            for (int i = 0; i < fjala.Length; i++)
            {
                char c = fjala.ToCharArray()[i];
                if (c + (celesi.ToCharArray()[i] - 65) > 90)
                {
                    c -= (char)26;
                }
                c += (char)(celesi.ToCharArray()[i] - 65);
                enkriptuar += c;
            }
            return enkriptuar;
        }
        public String Dekripto(String fjala, String celesi)
        {
            String dekriptuar = "";
            fjala = fjala.ToUpper();
            celesi = celesi.ToUpper();
            int z = 0;
            while (celesi.Length < fjala.Length)
            {
                celesi += celesi.ToCharArray()[z];
                z++;
            }
            for (int i = 0; i < fjala.Length; i++)
            {
                char c = fjala.ToCharArray()[i];
                if (c - (celesi.ToCharArray()[i] - 65) < 65)
                {
                    c += (char)26;
                }
                c -= (char)(celesi.ToCharArray()[i] - 65);
                dekriptuar += c;
            }
            return dekriptuar;
        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            txtRezultati.Text = Enkripto(txtPlaintext.Text, txtCelesi.Text);
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            txtDekripto.Text = Dekripto(txtRezultati.Text, txtCelesi.Text);
        }

        private void btnGjenero_Click(object sender, EventArgs e)
        {
            txtCelesi.Text = Keystream.GetRandomString(txtPlaintext.TextLength);
        }

        private void txtPlaintext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
