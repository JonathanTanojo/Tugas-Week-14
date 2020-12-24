using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Panda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonkonversi_Click(object sender, EventArgs e)
        {
            string kalimat = textBoxkalimat.Text;
            int n = kalimat.Length;
            int asc = 0 ;
            string huruf = textBoxhuruf.Text;
            int aschuruf;
            aschuruf = (int)huruf[0];
            string menjadi = textBoxmenjadi.Text;
            int ascmenjadi;
            ascmenjadi = (int)menjadi[0];
            
            int c = 0;
            while (aschuruf != ascmenjadi)
            {
                if (aschuruf < ascmenjadi)
                {
                    aschuruf++;
                    c++;
                }
                else if (aschuruf > ascmenjadi)
                {
                    aschuruf++;
                    c--;
                }
            }
            byte hasil;
            for (int i = 0; i < n; i++)
            {
                asc = (int)kalimat[i] + c;
                hasil = Convert.ToByte(asc);
                labelperubahan.Text += Char.ConvertFromUtf32(hasil).ToUpper();
                
            }
        }
    }
}
