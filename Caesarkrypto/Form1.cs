using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesarkrypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Encryptbtn_Click(object sender, EventArgs e)
        {
            string abcstring = "abcdefghijklmnopqrstuvwxyz";
            string outputstring = null;
            int förskjutning = Convert.ToInt32(nummersak.Value);
            List<char> charlist = abcstring.ToList();


            string encrypt = InputBox.Text; //Input
            encrypt = encrypt.Replace(" ", string.Empty); // Ta bort whitespaces

            for (int i = 0; i < encrypt.Length; i++) 
            {
         
                int z = 0;
                z = charlist.IndexOf(encrypt[i]);
                if(z+ förskjutning > abcstring.Length)
                {
                    outputstring += abcstring[(z + förskjutning) - abcstring.Length];
                }
                else if (z + förskjutning < 0)
                {
                    outputstring += abcstring[(z + förskjutning) + abcstring.Length];
                }
                else
                {
                outputstring += abcstring[z + förskjutning];
                }
            }
            OutputLabel.Text = outputstring;
        }
    }
}
