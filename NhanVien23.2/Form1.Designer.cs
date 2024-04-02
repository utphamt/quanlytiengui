
namespace NhanVien23._2
{
    partial class Form1
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
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblluong = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblmaphong = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.mtbngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.dgrnhanvien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnbaocao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(140, 13);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(170, 22);
            this.txtmanv.TabIndex = 0;
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(140, 165);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(75, 33);
            this.btnnhap.TabIndex = 1;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(243, 165);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 33);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(50, 16);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(50, 17);
            this.lblmanv.TabIndex = 5;
            this.lblmanv.Text = "Mã NV";
            this.lblmanv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(50, 110);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(65, 17);
            this.lblgioitinh.TabIndex = 6;
            this.lblgioitinh.Text = "Giới Tính";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(50, 60);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(50, 17);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "Họ tên";
            this.lblhoten.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblluong
            // 
            this.lblluong.AutoSize = true;
            this.lblluong.Location = new System.Drawing.Point(384, 110);
            this.lblluong.Name = "lblluong";
            this.lblluong.Size = new System.Drawing.Size(84, 17);
            this.lblluong.TabIndex = 8;
            this.lblluong.Text = "Hệ số lương";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(140, 57);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(170, 22);
            this.txthoten.TabIndex = 9;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(498, 110);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(170, 22);
            this.txtluong.TabIndex = 10;
            this.txtluong.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // rdbnam
            // 
            this.rdbnam.AutoSize = true;
            this.rdbnam.Location = new System.Drawing.Point(140, 108);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(56, 21);
            this.rdbnam.TabIndex = 13;
            this.rdbnam.Text = "nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(243, 108);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(45, 21);
            this.rdbnu.TabIndex = 14;
            this.rdbnu.Text = "nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(384, 20);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(71, 17);
            this.lblngaysinh.TabIndex = 15;
            this.lblngaysinh.Text = "Ngày sinh";
            // 
            // lblmaphong
            // 
            this.lblmaphong.AutoSize = true;
            this.lblmaphong.Location = new System.Drawing.Point(384, 60);
            this.lblmaphong.Name = "lblmaphong";
            this.lblmaphong.Size = new System.Drawing.Size(71, 17);
            this.lblmaphong.TabIndex = 16;
            this.lblmaphong.Text = "Mã phòng";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(499, 57);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(169, 22);
            this.txtmaphong.TabIndex = 17;
            // 
            // mtbngaysinh
            // 
            this.mtbngaysinh.Location = new System.Drawing.Point(499, 17);
            this.mtbngaysinh.Mask = "00/00/0000";
            this.mtbngaysinh.Name = "mtbngaysinh";
            this.mtbngaysinh.Size = new System.Drawing.Size(169, 22);
            this.mtbngaysinh.TabIndex = 18;
            this.mtbngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // dgrnhanvien
            // 
            this.dgrnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Hoten,
            this.Ngaysinh,
            this.Gioitinh,
            this.Hesoluong,
            this.MaPhong});
            this.dgrnhanvien.Location = new System.Drawing.Point(12, 234);
            this.dgrnhanvien.Name = "dgrnhanvien";
            this.dgrnhanvien.RowHeadersWidth = 51;
            this.dgrnhanvien.RowTemplate.Height = 24;
            this.dgrnhanvien.Size = new System.Drawing.Size(842, 204);
            this.dgrnhanvien.TabIndex = 19;
            this.dgrnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrnhanvien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.MinimumWidth = 6;
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 125;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "ngày sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Width = 125;
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 6;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Width = 125;
            // 
            // Hesoluong
            // 
            this.Hesoluong.DataPropertyName = "Hesoluong";
            this.Hesoluong.HeaderText = "hệ số lương";
            this.Hesoluong.MinimumWidth = 6;
            this.Hesoluong.Name = "Hesoluong";
            this.Hesoluong.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(387, 165);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 33);
            this.btnboqua.TabIndex = 20;
            this.btnboqua.Text = "bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(516, 165);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 33);
            this.btntim.TabIndex = 21;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnbaocao
            // 
            this.btnbaocao.Location = new System.Drawing.Point(632, 165);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(75, 33);
            this.btnbaocao.TabIndex = 22;
            this.btnbaocao.Text = "báo cáo";
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.dgrnhanvien);
            this.Controls.Add(this.mtbngaysinh);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.lblmaphong);
            this.Controls.Add(this.lblngaysinh);
            this.Controls.Add(this.rdbnu);
            this.Controls.Add(this.rdbnam);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.lblluong);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.lblgioitinh);
            this.Controls.Add(this.lblmanv);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.txtmanv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblluong;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblmaphong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.MaskedTextBox mtbngaysinh;
        private System.Windows.Forms.DataGridView dgrnhanvien;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hesoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnbaocao;
    }
}

