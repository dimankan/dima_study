using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hap = HtmlAgilityPack;

namespace HttpButtonClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string htmlLink = textBox1.Text;
            //string htmlButtonName = textBox2.Text;
            //ButtonClicker buttonClicker = new ButtonClicker();
            //string responseHtml = buttonClicker.ButtonClick(htmlLink, htmlButtonName);
            //textBox3.Text = responseHtml;

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://metamask.github.io/vault-decryptor/");

            //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //{
            //    Stream stream = response.GetResponseStream();
            //    StreamReader sr = new StreamReader(stream);

            //    string sReadData = sr.ReadToEnd();

            //    MessageBox.Show(sReadData);
            //    //dynamic d = JsonConvert.DeserializeObject(sReadData);
            //    //MessageBox.Show( ((double)d.result / 1000000000000000000).ToString());
            //}

            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Url = new Uri("http://google.com");
            webBrowser.Navigate(textBox3.Text);
        }
    }
}
