using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUserControl
{
    public partial class ucPeople : UserControl
    {
        public ucPeople()
        {
            InitializeComponent();
        }

        public People SelectedPeople
        {
            get
            {
                return (People)comboBox1.SelectedItem;
            }
        }

        private void ucPeople_Load(object sender, EventArgs e)
        {
            List<People> list = new List<People>(); 
            list.Add(new People() { ID = 1, Name = "Dima"});
            list.Add(new People() { ID = 2, Name = "Oleg"});
            list.Add(new People() { ID = 3, Name = "Vanya"});
            list.Add(new People() { ID = 4, Name = "Misha"});
            comboBox1.DataSource = list;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";

        }
    }
}
