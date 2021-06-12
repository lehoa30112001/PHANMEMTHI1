
namespace PHANMEMTHI.Forms {
    partial class ExamQuestionsSelectForm {
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.Exam_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Questions_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(190)))), ((int)(((byte)(194)))));
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(448, 125);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(158, 42);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Chọn kỳ thi";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.OnButtonSelectClick);
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvExams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exam_id,
            this.Class_id,
            this.Exam_order,
            this.Questions_amount});
            this.dgvExams.Location = new System.Drawing.Point(12, 57);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(418, 235);
            this.dgvExams.TabIndex = 5;
            this.dgvExams.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            // 
            // Exam_id
            // 
            this.Exam_id.HeaderText = "Mã kỳ thi";
            this.Exam_id.Name = "Exam_id";
            this.Exam_id.ReadOnly = true;
            // 
            // Class_id
            // 
            this.Class_id.HeaderText = "Mã lớp";
            this.Class_id.Name = "Class_id";
            this.Class_id.ReadOnly = true;
            // 
            // Exam_order
            // 
            this.Exam_order.HeaderText = "Loại kỳ thi";
            this.Exam_order.Name = "Exam_order";
            this.Exam_order.ReadOnly = true;
            // 
            // Questions_amount
            // 
            this.Questions_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Questions_amount.HeaderText = "Số câu";
            this.Questions_amount.Name = "Questions_amount";
            this.Questions_amount.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách các kỳ thi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(190)))), ((int)(((byte)(194)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(448, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OnBackButtonClick);
            // 
            // ExamQuestionsSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(633, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvExams);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamQuestionsSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn câu hỏi từ kỳ thi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Questions_amount;
    }
}