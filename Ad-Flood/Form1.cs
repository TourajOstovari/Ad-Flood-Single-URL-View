using System;
using System.Windows.Forms;

namespace Ad_Flood
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for(int z = 0; z< 2000; z++){
                    Form2 f = new Form2();
                    f.Urls = textBox1.Text;
                    f.Show();
                }
            }
            catch (Exception)
            {
                System.Threading.Thread.Sleep(10000);
                Environment.Exit(0);
            }

        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
