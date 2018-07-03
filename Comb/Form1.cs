using Snowflake.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = MainID.GetID().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = MainID.GetID().ToString();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text!="")
            {
                Clipboard.SetDataObject(textBox1.Text);
                textBox1.SelectAll();
            }       
        }
    }
}
