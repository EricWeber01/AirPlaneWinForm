using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPlaneWinForm
{
    public partial class Form1 : Form
    {
        List<User> us = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }
        public void obnov() { listBox1.Items.Clear(); listBox1.Items.AddRange(us.ToArray()); }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            Form2 form2 = new Form2();
            if (form2.ShowDialog(us, u) == DialogResult.OK)
            {
                us.Add(u);
                obnov();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            using (Stream fs = File.Create(@"..\test1.bin"))
            {
                bin.Serialize(fs, us);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            using (Stream fs = File.OpenRead(@"..\test1.bin"))
            {
                us = bin.Deserialize(fs) as List<User>;
            }
            obnov();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.us = us;
            form3.Show();
        }
    }
}
