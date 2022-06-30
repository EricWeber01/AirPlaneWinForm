using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPlaneWinForm
{
    public partial class Form3 : Form
    {
        public List<User> us = new List<User>();
        public Form3()
        {
            InitializeComponent();
        }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                int nomer = int.Parse(maskedTextBox1.Text);
                if (us.Where(i => i.Nomer == nomer).ToList().Any())
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < us.Where(j => j.Nomer == nomer).ToList().Count; i++) { listBox1.Items.Add(us.Where(j => j.Nomer == nomer).ToList()[i].print_name()); }
                    textBox1.Text = $"{us.Where(i => i.Nomer == nomer).ToList()[0].Dt.ToShortDateString()} | {us.Where(i => i.Nomer == nomer).ToList()[0].Time}";
                    textBox2.Text = us.Where(i => i.Nomer == nomer).ToList()[0].Pol.ToString();
                    textBox3.Text = us.Where(i => i.Nomer == nomer).ToList()[0].Punct;
                    textBox4.Text = us.Where(i => i.Nomer == nomer).ToList().Sum(j => j.Ves).ToString();
                }
                else
                {
                    listBox1.Items.Clear();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
        }
    }
}
