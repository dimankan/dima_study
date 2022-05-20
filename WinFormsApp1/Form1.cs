using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process? process = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            var item = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c chcp 1251",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            };
            process = Process.Start(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbOutput.Text = process.StandardOutput.ReadToEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c {tbInput}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            };
            process = Process.Start(item);
        }
    }
}
