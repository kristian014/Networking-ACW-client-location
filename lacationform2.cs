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
    public partial class lacationform2 : Form
    {
        public static bool UpdateButton = false;
        public lacationform2()
        {
            InitializeComponent();
        }

        private void BtnLookUp_Click(object sender, EventArgs e)
        {
            Hide();
            Form form = new Locationform();
            form.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateButton = true;
            Hide();
            Form form = new Locationform();
            form.Show();
        }
    }
}
