using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void goForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString().Contains("https://www.") &&
               comboBox1.Text.ToString().Contains("."))
                webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString()));

            else if (comboBox1.Text.ToString().Contains(".") == false)
                webBrowser1.Navigate(new Uri("https://www.bing.com/search?q=" + comboBox1.Text.ToString()));

            else if (comboBox1.Text.ToString().Contains("www") &&
                    comboBox1.Text.ToString().Contains("."))
                webBrowser1.Navigate(new Uri("http://" + comboBox1.Text.ToString()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
        }
    }
}
