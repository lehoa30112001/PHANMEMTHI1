using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANMEMTHI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void formlogin_Click(object sender, EventArgs e)
        {
            formlogin.FillColor = Color.White;
            formlogin.ForeColor = Color.Teal;
            formintro.FillColor = Color.Teal;
            formintro.ForeColor = Color.White;
            login_formpanel1.Visible = true;
            login_formpanel1.BringToFront();
        }

        private void formintro_Click(object sender, EventArgs e)
        {
            formintro.FillColor = Color.White;
            formintro.ForeColor = Color.Teal;
            formlogin.FillColor = Color.Teal;
            formlogin.ForeColor = Color.White;
            form_gioithieu1.Visible = true; 
            form_gioithieu1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
