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
        public string m_username;
        public string m_location;
        public string m_protocol ;
        public string m_portnumber ;
        public string m_servername  ;
        public string m_response;
        public string m_timeout = "1000";

        public Locationform()
        {
            InitializeComponent();

            if (lacationform2.UpdateButton == true)
            {
                tb_location.Visible = true;
                label3.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            if (lacationform2.UpdateButton == true)
            {

                Whois.clientInfo.Add(tb_username.Text);
                Whois.clientInfo.Add(tb_location.Text);
                string[] argsfromwindowsform = { "-h", m_servername, "-p", m_portnumber, "-t", m_timeout , m_protocol};
                Whois.Main(argsfromwindowsform);
                m_response = Response.Text;



            }
            else
            {
                Whois.clientInfo.Add(tb_username.Text);
                string[] argsfromwindowsform = { "-h", m_servername, "-p", m_portnumber, "-t", m_timeout, m_protocol };
                Whois.Main(argsfromwindowsform);
               m_response = Response.Text;
               


            }

           //Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            m_username = tb_username.Text;
           // Whois.clientInfo.Add(tb_username.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            m_location = tb_location.Text;
           // Whois.clientInfo.Add(tb_location.Text);
        }

        private void lb_protocol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Locationform_Load(object sender, EventArgs e)
        {

        }

        private void timeout_ValueChanged(object sender, EventArgs e)
        {
            

            m_timeout = timeout.Value.ToString();
        }

        private void tb_portnumber_TextChanged(object sender, EventArgs e)
        {
            m_portnumber = tb_portnumber.Text;
        }

        private void tb_servername_TextChanged(object sender, EventArgs e)
        {
            m_servername = tb_servername.Text;
        }

        private void cb_protocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_protocol = cb_protocol.Text;

            switch (m_protocol)
            {
                case ("whois"):
                    m_protocol = "whois";
                    break;
                case ("-h0"):
                    m_protocol = "-h0";
                    break;
                case ("-h1"):
                    m_protocol = "-h1";
                    break;

                case ("-h9"):
                    m_protocol = "-h9";
                    break;

                   

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            m_response = Response.Text;
        }

        private void Response_Click(object sender, EventArgs e)
        {

        }
    }
}