using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LicenseGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = Program.GenerateRandom();
            string test2 = Program.GenerateUnix();

            textBox1.Text = test +"-"+test2;
            toolStripStatusLabel1.Text = "Key Generated";
            statusStrip1.BackColor = Color.Green;
            statusStrip1.ForeColor = Color.White;
        }

       private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int NrOfKeys = 0;
            if (Int32.TryParse(textBox2.Text, out NrOfKeys))
            {
                toolStripStatusLabel1.Text = NrOfKeys.ToString() + " keys have been generated";
                statusStrip1.BackColor = Color.Green;
                statusStrip1.ForeColor = Color.White;

                for (int i = 0; i <= NrOfKeys; i++)
                {
                    string test3 = Program.GenerateRandom();
                    string test4 = Program.GenerateUnix();
                    Console.WriteLine(test3 + "-" + test4);
                    using (StreamWriter w = File.AppendText("cdkeys.txt"))
                    {
                        w.WriteLine(test3 + "-" + test4);
                    }
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Please input a number";
                statusStrip1.BackColor = Color.Red;
                statusStrip1.ForeColor = Color.White;
            }

            

        }
    }
}
