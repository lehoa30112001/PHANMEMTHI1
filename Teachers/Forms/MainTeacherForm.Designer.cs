
namespace PHANMEMTHI.Forms {
    partial class MainTeacherForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel2 = new System.Windows.Forms.Panel();
            this.examUC = new PHANMEMTHI.Forms.Panels.ExaminationUserControl();
            this.classUC = new PHANMEMTHI.Forms.Panels.ClassUserControl();
            this.reportUC = new PHANMEMTHI.Forms.Panels.ReportUserControl();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.examUC);
            this.panel2.Controls.Add(this.classUC);
            this.panel2.Controls.Add(this.reportUC);
            this.panel2.Location = new System.Drawing.Point(13, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 443);
            this.panel2.TabIndex = 2;
            // 
            // examUC
            // 
            this.examUC.Location = new System.Drawing.Point(-1, 3);
            this.examUC.Name = "examUC";
            this.examUC.Size = new System.Drawing.Size(776, 446);
            this.examUC.TabIndex = 4;
            // 
            // classUC
            // 
            this.classUC.Location = new System.Drawing.Point(-3, 3);
            this.classUC.Margin = new System.Windows.Forms.Padding(4);
            this.classUC.Name = "classUC";
            this.classUC.Size = new System.Drawing.Size(781, 437);
            this.classUC.TabIndex = 1;
            this.classUC.Click += new System.EventHandler(this.OnClassButtonClick);
            // 
            // reportUC
            // 
            this.reportUC.Location = new System.Drawing.Point(-1, 0);
            this.reportUC.Margin = new System.Windows.Forms.Padding(4);
            this.reportUC.Name = "reportUC";
            this.reportUC.Size = new System.Drawing.Size(776, 443);
            this.reportUC.TabIndex = 3;
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Location = new System.Drawing.Point(303, 4);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(161, 67);
            this.btnClass.TabIndex = 0;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.OnClassButtonClick);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.PowderBlue;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(470, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(161, 67);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.OnReportButtonClick);
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Location = new System.Drawing.Point(136, 4);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(161, 67);
            this.btnExam.TabIndex = 0;
            this.btnExam.Text = "Kỳ thi";
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.OnExaminationButtonClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnExam);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 1;
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "11192033 - GV Trần Chí Đức";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Panels.ClassUserControl classUC;
        private Panels.ReportUserControl reportUC;
        private Panels.ExaminationUserControl examUC;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Panel panel1;
    }
}