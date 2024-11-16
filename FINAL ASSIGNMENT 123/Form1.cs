using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_ASSIGNMENT_123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            ADMIN_LOGIN frm = new ADMIN_LOGIN();
            frm.Show();
        }
    }
}
