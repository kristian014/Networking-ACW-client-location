using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace location
{
    public partial class Locationform : Form
    {
        public Locationform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Whois.Servername = tb_servername.Text;
            Whois.Protocol = lb_protocol.Text;
            Whois.PortNumber = Int32.Parse(tb_portnumber.Text);
            Whois.clientInfo.Add(tb_username.Text);
            Whois.clientInfo.Add(tb_location.Text);
            //Whois.timeout = Int32.Parse(timeout.)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
