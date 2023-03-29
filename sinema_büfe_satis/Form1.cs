using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
    

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            su = Convert.ToInt16(txtsu.Text);
            cay = Convert.ToInt16(txtcay.Text);


            toplam = misir * 4 + bilet * 8 + su * 1 + cay * 2;
            lbltoplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + " TL";
             
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtcay.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtmisir.Focus();
        }
    }
}
