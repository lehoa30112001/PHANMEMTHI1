using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PHANMEMTHI.Login_Panel
{
    public partial class Login_formpanel : UserControl
    {
        public Login_formpanel()
        {
            InitializeComponent();
        }
        function fn = new function();
        string query;         
        bool teacher = false;
        bool student = false;
        private void gvbutton_Click(object sender, EventArgs e)
        {
            svbutton.FillColor = Color.White;
            svbutton.ForeColor = Color.Teal;
            gvbutton.FillColor = Color.Teal;
            gvbutton.ForeColor = Color.White;
            teacher = true;
            student = false;
        }

        private void svbutton_Click(object sender, EventArgs e)
        {
            gvbutton.FillColor = Color.White;
            gvbutton.ForeColor = Color.Teal;
            svbutton.FillColor = Color.Teal;
            svbutton.ForeColor = Color.White;
            teacher = false;
            student = true;
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
            {
                passbox.UseSystemPasswordChar = false;
            }
            else
            {
                passbox.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            userbox.Text = "";
            passbox.Text = "";
        }  // xóa hai ô nhập tên, mật khẩu
        int count = 0; 

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (teacher)
            {
                query = "select * from teachers where teacher_id = '"+userbox.Text+"' and Teacher_password = '"+ passbox.Text +"'";
                DataTable dt = fn.getdt(query);
                if (dt.Rows.Count == 1)
                {
                    Login.ActiveForm.Hide();
                    Forms.MainTeacherForm frm = new Forms.MainTeacherForm(userbox.Text, function.ConnectionString);
                    frm.Show();
                }  
                else
                {
                    count++;
                    if (count > 5)
                        Application.Exit();
                    MessageBox.Show("Nhập sai tên người dùng hoặc mật khẩu. \n Chỉ còn "+ (5 - count) +" lần nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }    
            }   
            else if (student)
            {
                query = "select * from students where student_id = '" + userbox.Text + "' and student_password = '" + passbox.Text + "'";
                DataTable dt = fn.getdt(query);
                if (dt.Rows.Count == 1)
                {
                    Login.ActiveForm.Hide();
                    Student_Login stlogin = new Student_Login(userbox.Text);                    
                    stlogin.Show();
                }
                else
                {
                    count++;
                    if (count > 4)
                        Application.Exit();
                    MessageBox.Show("Nhập sai tên người dùng hoặc mật khẩu. \nChỉ còn " + (5 - count) + " lần nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            else
            {
                MessageBox.Show("Chon dang nhap sinh vien hoac giao vien");
            } 
                
            
        } //Đăng nhập

        private void Login_formpanel_Load(object sender, EventArgs e)
        {
            svbutton.PerformClick();            
        }
             

        private void Login_formpanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
    } 
}
