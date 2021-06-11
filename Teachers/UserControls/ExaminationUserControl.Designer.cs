
namespace PHANMEMTHI.Forms.Panels {
    partial class ExaminationUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelCurrentExams = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonExams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrentExams
            // 
            this.labelCurrentExams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentExams.AutoSize = true;
            this.labelCurrentExams.Font = new System.Drawing.Font("UTM Avo", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentExams.Location = new System.Drawing.Point(240, 96);
            this.labelCurrentExams.Name = "labelCurrentExams";
            this.labelCurrentExams.Size = new System.Drawing.Size(72, 87);
            this.labelCurrentExams.TabIndex = 1;
            this.labelCurrentExams.Text = "2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "kỳ thi đang diễn ra";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(106, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tạo kỳ thi mới";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OnNewExamButtonClick);
            // 
            // buttonExams
            // 
            this.buttonExams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExams.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonExams.FlatAppearance.BorderSize = 0;
            this.buttonExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExams.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExams.Location = new System.Drawing.Point(106, 306);
            this.buttonExams.Name = "buttonExams";
            this.buttonExams.Size = new System.Drawing.Size(340, 63);
            this.buttonExams.TabIndex = 3;
            this.buttonExams.Text = "Xem hoặc sửa kỳ thi";
            this.buttonExams.UseVisualStyleBackColor = false;
            this.buttonExams.Click += new System.EventHandler(this.OnButtonEditClick);
            // 
            // ExaminationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonExams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCurrentExams);
            this.Name = "ExaminationUserControl";
            this.Size = new System.Drawing.Size(563, 473);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonExams;
        public System.Windows.Forms.Label labelCurrentExams;
    }
}
