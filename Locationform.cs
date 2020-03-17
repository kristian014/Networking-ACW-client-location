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
        public string m_location ;
        public string m_protocol;
        public string m_portnumber;
        public string m_servername;
        public string m_response;
        public string m_timeout = "1000";
        public string m_debug;

        public Locationform()
        {
            InitializeComponent();
            // this select 
            if (lacationform2.UpdateButton == true)
            {
                tb_location.Visible = true;
                label3.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This part sends the argument to the server and also gives you the option to select 
        /// what you want to do. If it's update or lookup. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {




            if (lacationform2.UpdateButton == true)
            {
                // the if statement below checks if the debugging features is ticked
                // if that is tick i want to send the arguement to the main program and making debug true
                

                // if the debug isn't ticked, the debug becomes the default which is false 
              
                    string[] argsfromwindowsform = { "-h", m_servername, "-p", m_portnumber, "-t", m_timeout, m_protocol , m_username ,m_location };
                    Whois.Main(argsfromwindowsform);
                    textBox1.Text = Whois.response;
                if (checkBox1.Checked)
                {
                    textBox1.Text = textBox1.Text + "\r\n" + "Debug Feature enabled" + "\r\n" + Whois.debuggingresponse;
                }

            }

            // this method is to send the arguements to the main program if the it's a lookup
            // Also when the debug features is ticked, the debug becomes true and false by default when the server is not tick
            else
            {
                
                    //Whois.clientInfo.Add(tb_username.Text);
                    string[] argsfromwindowsform = { "-h", m_servername, "-p", m_portnumber, "-t", m_timeout, m_protocol , m_username };
                    Whois.Main(argsfromwindowsform);
                    textBox1.Text = Whois.response;
                
                // if the check box is clicked, enable the debug response.
            if (checkBox1.Checked)
                {
                    textBox1.Text =  textBox1.Text + "\r\n" + "Debug Feature enabled" + "\r\n" + Whois.debuggingresponse;
                }


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                // do nothing
            }
            else
            {
                m_username = tb_username.Text;
            }
           
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tb_location.Text == "")
            {
                m_location = null;
            }
            else
            {
                m_location = tb_location.Text;
            }
            
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

        /// <summary>
        /// This cb_protocol gets the selected protocol from the windows form and sends 
        /// to the "argsfromwindowsform" which sends to the main program.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
            //textBox1.Text = Whois.response;
        }

        private void Response_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // this sets the debug to be when checked.
            Whois.debugging = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                m_debug = "-d";
            }
            else
            {
                // do nothing and take the default which is false
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (lacationform2.UpdateButton == true)
            {


            }
                Hide();
            Form form = new lacationform2();
            form.Show();
        }
    }
}