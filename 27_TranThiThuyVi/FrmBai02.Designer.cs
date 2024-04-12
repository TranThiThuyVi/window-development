namespace _27_TranThiThuyVi
{
    partial class FrmBai02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNhapChuoiSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboChonXem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhapChuoiSo
            // 
            this.txtNhapChuoiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapChuoiSo.Location = new System.Drawing.Point(15, 78);
            this.txtNhapChuoiSo.Name = "txtNhapChuoiSo";
            this.txtNhapChuoiSo.Size = new System.Drawing.Size(514, 20);
            this.txtNhapChuoiSo.TabIndex = 6;
            this.txtNhapChuoiSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapChuoiSo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập dãy số nguyên, các số phân cách nhau bởi khoảng trắng";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(539, 33);
            this.label6.TabIndex = 27;
            this.label6.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(539, 33);
            this.label7.TabIndex = 28;
            this.label7.Text = "LẬP TRÌNH WINDOWS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboChonXem
            // 
            this.cboChonXem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonXem.FormattingEnabled = true;
            this.cboChonXem.Location = new System.Drawing.Point(15, 153);
            this.cboChonXem.Name = "cboChonXem";
            this.cboChonXem.Size = new System.Drawing.Size(121, 24);
            this.cboChonXem.TabIndex = 29;
            this.cboChonXem.SelectedIndexChanged += new System.EventHandler(this.cboChonXem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Chọn xem";
            // 
            // lbKQ
            // 
            this.lbKQ.Location = new System.Drawing.Point(201, 153);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(328, 97);
            this.lbKQ.TabIndex = 31;
            // 
            // FrmBai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 298);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboChonXem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNhapChuoiSo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Câu 2";
            this.Load += new System.EventHandler(this.FrmBai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapChuoiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboChonXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKQ;
    }
}