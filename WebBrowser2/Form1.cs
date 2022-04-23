using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string da = "11.02.2022 20:13:59";

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = da;
            dateTimePicker1.Text = da;
            //DateTime dateTime = DateTime.Parse(da);
            textBox2.Text = DateTime.Parse(da).ToString("d");

            string s = "1";
            if(s == "1")
            {
                checkBox1.Checked = true;
            }
        }
    }
}
