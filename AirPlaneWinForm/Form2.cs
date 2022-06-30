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

namespace AirPlaneWinForm
{
    public partial class Form2 : Form
    {
        List<User> us = new List<User>();
        User uso = new User();
        int pam = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(List<User> us, User uso)
        {
            this.us = us;
            this.uso = uso;
            return ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && maskedTextBox4.TextLength == 5 && maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && maskedTextBox3.Text != "")
            {
                uso.Name = textBox1.Text;
                uso.Fami = textBox2.Text;
                uso.Och = textBox3.Text;
                uso.Ves = int.Parse(maskedTextBox1.Text);
                uso.Nomer = int.Parse(maskedTextBox2.Text);
                uso.Pol = int.Parse(maskedTextBox3.Text);
                uso.Time = maskedTextBox4.Text;
                uso.Dt = dateTimePicker1.Value;
                uso.Punct = textBox4.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text != "")
            {
                int nomer = int.Parse(maskedTextBox2.Text);
                for (int i = 0; i < us.Count; i++)
                {
                    if (us[i].Nomer == nomer)
                    {
                        pam = 1;
                        dateTimePicker1.Value = us[i].Dt; dateTimePicker1.Enabled = false;
                        maskedTextBox3.Text = us[i].Pol.ToString(); maskedTextBox3.Enabled = false;
                        maskedTextBox4.Text = us[i].Time; maskedTextBox4.Enabled = false;
                        textBox4.Text = us[i].Punct; textBox4.Enabled = false;
                        break;
                    }
                    else if (pam == 1)
                    {
                        pam = 0;
                        dateTimePicker1.Value = DateTime.Now; dateTimePicker1.Enabled = true;
                        maskedTextBox3.Text = ""; maskedTextBox3.Enabled = true;
                        maskedTextBox4.Text = ""; maskedTextBox4.Enabled = true;
                        textBox4.Text = ""; textBox4.Enabled = true;
                    }
                }
            }
        }
    }
}
