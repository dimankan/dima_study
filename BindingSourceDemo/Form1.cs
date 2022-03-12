using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSourceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usersBindingSource.Add(new Users() { Username = "admin", Password = "admin" });
            usersBindingSource.Add(new Users() { Username = "admin1", Password = "21wwwa" });
            usersBindingSource.Add(new Users() { Username = "admin2", Password = "wwaaa" });
            usersBindingSource.Add(new Users() { Username = "admin3", Password = "331asd" });
        }
    }
}
