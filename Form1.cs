using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfinTransformationEncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            Encrypt e1 = new Encrypt(Convert.ToInt32(txtKeyA.Text),Convert.ToInt32(txtKeyB.Text),txtWord.Text.ToUpper());
            lblResult.Text = e1.AfinOutput();

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt d1 = new Decrypt(Convert.ToInt32(txtKeyA.Text), Convert.ToInt32(txtKeyB.Text), txtWord.Text.ToUpper());
            lblResult.Text = d1.AfinOutput();
            
        }
    }
}
