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

            if(lacationform2.UpdateButton == true)
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
                // Createlocation_information info = new Createlocation_information();
                // info.get_details_ofLocation();



                Whois.Servername = tb_servername.Text;
                Whois.Protocol = cb_protocol.Text;
                Whois.PortNumber = int.Parse(tb_portnumber.Text);
                Whois.clientInfo.Add(tb_username.Text);
                Whois.clientInfo.Add(tb_location.Text);
                
            }
            else {
                Whois.Servername = tb_servername.Text;
                Whois.Protocol = cb_protocol.Text;
                Whois.PortNumber = int.Parse(tb_portnumber.Text);
                Whois.clientInfo.Add(tb_username.Text);
                //Whois.clientInfo.Add(tb_location.Text);
                //Whois.timeout = Int32.Parse(timeout.);
            }

            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_protocol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Locationform_Load(object sender, EventArgs e)
        {

        }
    }
}
