using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGrid
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("DTColumn1");
            dt.Columns.Add("DTColumn2");
            dt.Columns.Add("DTColumn3");
            var row = dt.NewRow();
            row[0] = "ZZZZ";
            row[1] = "ssss";
            row[2] = "xxxx";
            dt.Rows.Add(row);

            dt2.Columns.Add("DTColumn121");
            dt2.Columns.Add("DTColumn222");
            dt2.Columns.Add("DTColumn322");
            var row2 = dt2.NewRow();
            row2[0] = "ZZZZ2";
            row2[1] = "ssss22";
            row2[2] = "xxxx22";
            dt2.Rows.Add(row2);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Test1", "Test1");
            foreach (var item in dt.Columns)
            {
                dataGridView1.Columns.Add(item.ToString(), item.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataRow row = dt.Rows[0];
            //DataGridViewRow dataGridViewRow = new DataGridViewRow();

            dataGridView1.DataSource = dt;


            foreach (var item in dt.Columns)
            {
                //MessageBox.Show(item.ToString());
                //dataGridViewRow[item.ToString()] = row[item.ToString()];
                //dataGridViewRow[0] = item;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt2;

        }
    }
}
