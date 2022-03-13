using MVPDemo.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPDemo
{
    public partial class DemoView : Form
    {
        public DemoPresenter Presenter { get; set; }
        public DemoView()
        {
            InitializeComponent();
        }

        private void tbOperand1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Presenter.OnOperand1Changed(Convert.ToInt32(tbOperand1.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибочка: " + ex.Message);
            }
        }

        private void tbOperand2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Presenter.OnOperand2Changed(Convert.ToInt32(tbOperand2.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибочка: " + ex.Message);
            }
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            Presenter.OnSumClicked();

        }

        public void UpdateView(int operand1, int operand2, int result)
        {
            tbOperand1.Text = Convert.ToString(operand1);
            tbOperand2.Text = Convert.ToString(operand2);

            tbResult.Text = Convert.ToString(result);

        }
    }
}
