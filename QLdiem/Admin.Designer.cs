namespace QLdiem
{
    partial class Admin
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
            this.btnCreateSinhVien = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.tbTenSV = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDiem = new System.Windows.Forms.TextBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnDeleteSinhVien = new System.Windows.Forms.Button();
            this.btnUpdateSinhVien = new System.Windows.Forms.Button();
            this.tbDeleteUpdateSinhVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbXepLoai = new System.Windows.Forms.ComboBox();
            this.tbMaSV1 = new System.Windows.Forms.TextBox();
            this.tbNamHoc = new System.Windows.Forms.TextBox();
            this.tbDiem1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnDiemHP = new System.Windows.Forms.Button();
            this.btnDeleteDiemHP = new System.Windows.Forms.Button();
            this.btnUpdateDiemHP = new System.Windows.Forms.Button();
            this.tbDeleteUpdateDiemHP = new System.Windows.Forms.TextBox();
            this.cbbHocKy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateSinhVien
            // 
            this.btnCreateSinhVien.Location = new System.Drawing.Point(611, 24);
            this.btnCreateSinhVien.Name = "btnCreateSinhVien";
            this.btnCreateSinhVien.Size = new System.Drawing.Size(93, 32);
            this.btnCreateSinhVien.TabIndex = 0;
            this.btnCreateSinhVien.Text = "Create";
            this.btnCreateSinhVien.UseVisualStyleBackColor = true;
            this.btnCreateSinhVien.Click += new System.EventHandler(this.btnCreateSinhVien_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(3, 314);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(860, 304);
            this.dgv.TabIndex = 1;
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(138, 24);
            this.tbMaSV.Multiline = true;
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(308, 32);
            this.tbMaSV.TabIndex = 2;
            // 
            // tbTenSV
            // 
            this.tbTenSV.Location = new System.Drawing.Point(138, 83);
            this.tbTenSV.Multiline = true;
            this.tbTenSV.Name = "tbTenSV";
            this.tbTenSV.Size = new System.Drawing.Size(308, 32);
            this.tbTenSV.TabIndex = 2;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(138, 199);
            this.tbSDT.Multiline = true;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(308, 32);
            this.tbSDT.TabIndex = 2;
            // 
            // tbDiem
            // 
            this.tbDiem.AcceptsReturn = true;
            this.tbDiem.Location = new System.Drawing.Point(138, 257);
            this.tbDiem.Multiline = true;
            this.tbDiem.Name = "tbDiem";
            this.tbDiem.Size = new System.Drawing.Size(308, 32);
            this.tbDiem.TabIndex = 2;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu",
            "LGPT"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(138, 146);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(308, 28);
            this.cbbGioiTinh.TabIndex = 3;
            // 
            // btnDeleteSinhVien
            // 
            this.btnDeleteSinhVien.Location = new System.Drawing.Point(630, 142);
            this.btnDeleteSinhVien.Name = "btnDeleteSinhVien";
            this.btnDeleteSinhVien.Size = new System.Drawing.Size(84, 32);
            this.btnDeleteSinhVien.TabIndex = 0;
            this.btnDeleteSinhVien.Text = "Delete";
            this.btnDeleteSinhVien.UseVisualStyleBackColor = true;
            this.btnDeleteSinhVien.Click += new System.EventHandler(this.btnDeleteSinhVien_Click);
            // 
            // btnUpdateSinhVien
            // 
            this.btnUpdateSinhVien.Location = new System.Drawing.Point(731, 142);
            this.btnUpdateSinhVien.Name = "btnUpdateSinhVien";
            this.btnUpdateSinhVien.Size = new System.Drawing.Size(73, 32);
            this.btnUpdateSinhVien.TabIndex = 0;
            this.btnUpdateSinhVien.Text = "Update";
            this.btnUpdateSinhVien.UseVisualStyleBackColor = true;
            this.btnUpdateSinhVien.Click += new System.EventHandler(this.btnUpdateSinhVien_Click);
            // 
            // tbDeleteUpdateSinhVien
            // 
            this.tbDeleteUpdateSinhVien.Location = new System.Drawing.Point(611, 83);
            this.tbDeleteUpdateSinhVien.Multiline = true;
            this.tbDeleteUpdateSinhVien.Name = "tbDeleteUpdateSinhVien";
            this.tbDeleteUpdateSinhVien.Size = new System.Drawing.Size(193, 32);
            this.tbDeleteUpdateSinhVien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ma SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ten SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gioi Tinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sdt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diem";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 657);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage1.Controls.Add(this.tbMaSV);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.tbDeleteUpdateSinhVien);
            this.tabPage1.Controls.Add(this.btnCreateSinhVien);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbTenSV);
            this.tabPage1.Controls.Add(this.btnDeleteSinhVien);
            this.tabPage1.Controls.Add(this.btnUpdateSinhVien);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbbGioiTinh);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbSDT);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbDiem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinh Vien";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage2.Controls.Add(this.btnUpdateDiemHP);
            this.tabPage2.Controls.Add(this.btnDeleteDiemHP);
            this.tabPage2.Controls.Add(this.btnDiemHP);
            this.tabPage2.Controls.Add(this.dgv1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbDiem1);
            this.tabPage2.Controls.Add(this.tbNamHoc);
            this.tabPage2.Controls.Add(this.tbDeleteUpdateDiemHP);
            this.tabPage2.Controls.Add(this.tbMaSV1);
            this.tabPage2.Controls.Add(this.cbbHocKy);
            this.tabPage2.Controls.Add(this.cbbXepLoai);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diem HP";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbbXepLoai
            // 
            this.cbbXepLoai.FormattingEnabled = true;
            this.cbbXepLoai.Items.AddRange(new object[] {
            "Tot",
            "Kha",
            "Trung Binh",
            "Yeu"});
            this.cbbXepLoai.Location = new System.Drawing.Point(144, 248);
            this.cbbXepLoai.Name = "cbbXepLoai";
            this.cbbXepLoai.Size = new System.Drawing.Size(340, 28);
            this.cbbXepLoai.TabIndex = 0;
            // 
            // tbMaSV1
            // 
            this.tbMaSV1.Location = new System.Drawing.Point(144, 27);
            this.tbMaSV1.Multiline = true;
            this.tbMaSV1.Name = "tbMaSV1";
            this.tbMaSV1.Size = new System.Drawing.Size(340, 32);
            this.tbMaSV1.TabIndex = 1;
            // 
            // tbNamHoc
            // 
            this.tbNamHoc.Location = new System.Drawing.Point(144, 132);
            this.tbNamHoc.Multiline = true;
            this.tbNamHoc.Name = "tbNamHoc";
            this.tbNamHoc.Size = new System.Drawing.Size(340, 32);
            this.tbNamHoc.TabIndex = 1;
            // 
            // tbDiem1
            // 
            this.tbDiem1.Location = new System.Drawing.Point(144, 187);
            this.tbDiem1.Multiline = true;
            this.tbDiem1.Name = "tbDiem1";
            this.tbDiem1.Size = new System.Drawing.Size(340, 32);
            this.tbDiem1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ma SV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hoc Ky";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nam Hoc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Diem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Xep Loai";
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(5, 317);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(965, 304);
            this.dgv1.TabIndex = 3;
            // 
            // btnDiemHP
            // 
            this.btnDiemHP.Location = new System.Drawing.Point(576, 27);
            this.btnDiemHP.Name = "btnDiemHP";
            this.btnDiemHP.Size = new System.Drawing.Size(86, 32);
            this.btnDiemHP.TabIndex = 4;
            this.btnDiemHP.Text = "Create";
            this.btnDiemHP.UseVisualStyleBackColor = true;
            this.btnDiemHP.Click += new System.EventHandler(this.btnDiemHP_Click);
            // 
            // btnDeleteDiemHP
            // 
            this.btnDeleteDiemHP.Location = new System.Drawing.Point(636, 129);
            this.btnDeleteDiemHP.Name = "btnDeleteDiemHP";
            this.btnDeleteDiemHP.Size = new System.Drawing.Size(68, 32);
            this.btnDeleteDiemHP.TabIndex = 4;
            this.btnDeleteDiemHP.Text = "Delete";
            this.btnDeleteDiemHP.UseVisualStyleBackColor = true;
            this.btnDeleteDiemHP.Click += new System.EventHandler(this.btnDeleteDiemHP_Click);
            // 
            // btnUpdateDiemHP
            // 
            this.btnUpdateDiemHP.Location = new System.Drawing.Point(727, 129);
            this.btnUpdateDiemHP.Name = "btnUpdateDiemHP";
            this.btnUpdateDiemHP.Size = new System.Drawing.Size(76, 32);
            this.btnUpdateDiemHP.TabIndex = 4;
            this.btnUpdateDiemHP.Text = "Update";
            this.btnUpdateDiemHP.UseVisualStyleBackColor = true;
            this.btnUpdateDiemHP.Click += new System.EventHandler(this.btnUpdateDiemHP_Click);
            // 
            // tbDeleteUpdateDiemHP
            // 
            this.tbDeleteUpdateDiemHP.Location = new System.Drawing.Point(576, 77);
            this.tbDeleteUpdateDiemHP.Multiline = true;
            this.tbDeleteUpdateDiemHP.Name = "tbDeleteUpdateDiemHP";
            this.tbDeleteUpdateDiemHP.Size = new System.Drawing.Size(227, 32);
            this.tbDeleteUpdateDiemHP.TabIndex = 1;
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cbbHocKy.Location = new System.Drawing.Point(144, 81);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(340, 28);
            this.cbbHocKy.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 671);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSinhVien;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.TextBox tbTenSV;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbDiem;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Button btnDeleteSinhVien;
        private System.Windows.Forms.Button btnUpdateSinhVien;
        private System.Windows.Forms.TextBox tbDeleteUpdateSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbDiem1;
        private System.Windows.Forms.TextBox tbNamHoc;
        private System.Windows.Forms.TextBox tbMaSV1;
        private System.Windows.Forms.ComboBox cbbXepLoai;
        private System.Windows.Forms.Button btnUpdateDiemHP;
        private System.Windows.Forms.Button btnDeleteDiemHP;
        private System.Windows.Forms.Button btnDiemHP;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDeleteUpdateDiemHP;
        private System.Windows.Forms.ComboBox cbbHocKy;
    }
}