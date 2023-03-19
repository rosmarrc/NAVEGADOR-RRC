using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegador_rrc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void btn_retroceder_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_adelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            textBox1.Clear();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            { btn_ir_Click(sender, e); }
        }
    }
}
