using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peoples
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "admin";
            string login = "admin";
            if (textBox2.Text == "admin" && textBox1.Text == "admin")
            { Form1 newform = new Form1();
                newform.Show();
                Hide();
            }
            if (pass == "" | login == "")
            {
                MessageBox.Show("неправильно введены данные");
            }
        }
    }
}
