
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.classUC = new PHANMEMTHI.Forms.Panels.ClassUserControl();
            this.reportUC = new PHANMEMTHI.Forms.Panels.ReportUserControl();
            this.examUC = new PHANMEMTHI.Forms.Panels.ExaminationUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExam);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnExam
            // 
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Location = new System.Drawing.Point(181, 5);
            this.btnExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(215, 62);
            this.btnExam.TabIndex = 0;
            this.btnExam.Text = "Kỳ thi";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.OnExaminationButtonClick);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(627, 5);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(215, 62);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.OnReportButtonClick);
            // 
            // btnClass
            // 
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Location = new System.Drawing.Point(404, 5);
            this.btnClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(215, 62);
            this.btnClass.TabIndex = 0;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.OnClassButtonClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.examUC);
            this.panel2.Controls.Add(this.classUC);
            this.panel2.Controls.Add(this.reportUC);
            this.panel2.Location = new System.Drawing.Point(17, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 545);
            this.panel2.TabIndex = 2;
            // 
            // classUC
            // 
            this.classUC.Location = new System.Drawing.Point(-4, 4);
            this.classUC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.classUC.Name = "classUC";
            this.classUC.Size = new System.Drawing.Size(1041, 538);
            this.classUC.TabIndex = 1;
            this.classUC.Click += new System.EventHandler(this.OnClassButtonClick);
            // 
            // reportUC
            // 
            this.reportUC.Location = new System.Drawing.Point(-1, 0);
            this.reportUC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reportUC.Name = "reportUC";
            this.reportUC.Size = new System.Drawing.Size(1035, 545);
            this.reportUC.TabIndex = 3;
            // 
            // examUC
            // 
            this.examUC.Location = new System.Drawing.Point(0, 4);
            this.examUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.examUC.Name = "examUC";
            this.examUC.Size = new System.Drawing.Size(1034, 549);
            this.examUC.TabIndex = 4;
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "11192033 - GV Trần Chí Đức";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Panel panel2;
        private Panels.ClassUserControl classUC;
        private System.Windows.Forms.Button btnReport;
        private Panels.ReportUserControl reportUC;
        private Panels.ExaminationUserControl examUC;
    }
}