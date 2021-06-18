using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANMEMTHI.Login_Panel
{
    public partial class form_gioithieu : UserControl
    {
        public form_gioithieu()
        {
            InitializeComponent();
        }
                
        private void introbutton_Click(object sender, EventArgs e)
        {
            gioithieu.BringToFront();
        }

        private void Chucnang_Click(object sender, EventArgs e)
        {
            chucnangg.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            giangvien.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            sinhvien.BringToFront();
        }
    }
}
