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

namespace PHANMEMTHI
{
    public partial class Class_Exam_Info : Form
    {
        public Class_Exam_Info()
        {
            InitializeComponent();
        }
        function fn = new function();
        DataTable dt3 = new DataTable();
        DataTable temp = new DataTable();
        string resultid, classname, examtype, examid, classid1;
        int numberquestion;
        public Class_Exam_Info(string classid, string stuid, string name, string birthday)
        {
            InitializeComponent();
            studentid.Text = stuid;
            studentname.Text = name;
            studentbirthday.Text = birthday;
            classid1 = classid;
            string query = "select Exams.Exam_id as N'Mã đề thi', Classes.Class_name as N'Lớp', Exams.Exam_order as N'Loại bài thi' , number_question as N'Số câu hỏi', Round(Score, 2) as N'Điểm',  times as N'Lần', Student_Exam_Result.Result_id as N'Mã kết quả'  from Exams, Student_Exam_Result, classes where exams.Exam_id = Student_Exam_Result.Exam_id  and Exams.Class_id = Classes.Class_id and Classes.class_id = '" + classid + "' and Student_Exam_Result.Student_id = '"+stuid+"'";
            dt3 = fn.getdt(query);            
            classinfo.DataSource = dt3;
            classinfo.Columns[6].Visible = false;
            classinfo.Columns[1].Visible = false;
            Chitiet.Visible = false;
            if (classinfo.Rows.Count > 0)
            {
                napdl(0);
                Chitiet.Visible = true;
                classname = dt3.Rows[0][1].ToString();
            }
            
            this.Text = classname;
            
        }

        private void hombut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login stlogin = new Student_Login(studentid.Text);
            stlogin.Show();
        }
        private void Chitiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowExamResult se = new ShowExamResult(resultid, studentname.Text, classname, examtype, numberquestion, studentid.Text, examid, "examinfo");
            se.Show();
        }

        private void Class_Exam_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string sql = "Select Subject_name, Class_name from Classes, Subject where Class_id = '" + classid1+"' and Classes.Subject_id = Subject.Subject_id";
            DataTable tem = new DataTable();
            tem = fn.getdt(sql);
            string sub = tem.Rows[0][0].ToString();
            string cla = tem.Rows[0][1].ToString();            
            sql = "Select Times, Date, Score, Exam_order from Exams, Student_Exam_Result, classes where exams.Exam_id = Student_Exam_Result.Exam_id  and Exams.Class_id = Classes.Class_id and Classes.class_id = '" + classid1+"' and Student_Exam_Result.Student_id = '"+studentid.Text+"'";
            DataTable rpttable = new DataTable();
            rpttable = fn.getdt(sql);
            KQthi rpt = new KQthi();
            rpt.SetDataSource(rpttable);
            rpt.DataDefinition.FormulaFields["Subjectname"].Text = "'" + sub + "'";
            rpt.DataDefinition.FormulaFields["Name"].Text = "'" + studentname.Text + "'";
            rpt.DataDefinition.FormulaFields["Id"].Text = "'" + studentid.Text + "'";
            rpt.DataDefinition.FormulaFields["Class"].Text = "'" + cla + "'";
            FrmRptResult frm = new FrmRptResult(rpt);
            frm.Show();
        }

        private void napdl(int i)
        {
            resultid = dt3.Rows[i][6].ToString();
            examtype = classinfo[1, i].Value.ToString();
            numberquestion = Convert.ToInt32(classinfo[3, i].Value.ToString());
            examid = classinfo[0, i].Value.ToString();
           // classname = classinfo[1, i].Value.ToString();
        }
        private void classinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = classinfo.CurrentRow.Index;
            napdl(i);
            Chitiet.Visible = true; 
        }

        private void backbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test_Result tr = new Test_Result(studentid.Text, studentname.Text, studentbirthday.Text);
            tr.Show();
        }
    }
}
