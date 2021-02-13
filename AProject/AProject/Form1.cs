using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            this.BackColor = Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text file|*.txt|All files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(dlg.FileName);
            }
        }
    }
}
