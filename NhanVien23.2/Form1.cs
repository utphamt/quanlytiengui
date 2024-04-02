using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanVien23._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public  void btnnhap_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["vdnhanvien"].ConnectionString;
            using( SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("insertNV", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
                 
                    Cmd.Parameters.AddWithValue("@Hoten", txthoten.Text);
                    Cmd.Parameters.AddWithValue("@Gioitinh", rdbnam.Checked);
                    Cmd.Parameters.AddWithValue("@Ngaysinh", Convert.ToDateTime(mtbngaysinh.Text));
                    Cmd.Parameters.AddWithValue("@Hesoluong", txtluong.Text);
                    Cmd.Parameters.AddWithValue("@Maphong", txtmaphong.Text);
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    btnboqua_Click(sender, e);
                    hienNV();

                }
            }
            
        }
        public DataTable getNV()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["vdnhanvien"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("getNV", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(Cmd))
                    {
                        DataTable tbl = new DataTable("tblNhanVien");
                        da.Fill(tbl);
                        return tbl;
                    }
                       
                }
            }
        }
        private void hienNV( string dieukienloc = "")
        {
            using (var tblNhanVien = getNV())
            {
                DataView dvnhanvien = new DataView(tblNhanVien);
                if (!string.IsNullOrEmpty(dieukienloc))
                    dvnhanvien.RowFilter = dieukienloc;
                dgrnhanvien.AutoGenerateColumns = false;
                dgrnhanvien.DataSource = dvnhanvien;


                
                }

            }
        
        
        private void btnboqua_Click(object sender, EventArgs e)
        {
            txtmanv.Text =
                txthoten.Text
                = txtluong.Text
                = txtmaphong.Text
                = string.Empty;
            mtbngaysinh.ResetText();
            txthoten.Focus();
            hienNV();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không?"
                , "Khẳng đinh "
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (re == DialogResult.No)
                return;
            DataView dvnhanvien = (DataView)dgrnhanvien.DataSource;
            DataRowView drvnhanvien = dvnhanvien[dgrnhanvien.CurrentRow.Index];

            string connectionString = ConfigurationManager.ConnectionStrings["vdnhanvien"].ConnectionString;

            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("deleteNV", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@MaNV", drvnhanvien["MaNV"]);
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    
                    hienNV();
                }
            }
        }

        

        private void dgrnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgrnhanvien.Rows[e.RowIndex];
                txtmanv.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                mtbngaysinh.Text = row.Cells[2].Value.ToString();
                txtluong.Text = row.Cells[4].Value.ToString();
                txtmaphong.Text = row.Cells[5].Value.ToString();

                if(dgrnhanvien.CurrentRow.Cells[3].Value.ToString() == " Nam")
                {
                    rdbnam.Checked = true;
                }
                else
                {
                    rdbnu.Checked = true;
                }
            }
            
        }

        private  void btntim_Click(object sender, EventArgs e)
        {
            string filter = "MaNV >0";
            if (!string.IsNullOrEmpty(txthoten.Text.Trim()))                
                filter += string.Format(" AND Hoten LIKE '%{0}%'", txthoten.Text);
            if (!string.IsNullOrEmpty(txtmanv.Text.Trim()))
                filter += string.Format(" AND MaNV LIKE '%{0}%'", txtmanv.Text);
            hienNV(filter);
            
                

            
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            string filter = "tblnhanVien.MaNV >0";
            if (!string.IsNullOrEmpty(txthoten.Text.Trim()))
                filter += string.Format(" AND tblnhanVien.Hoten LIKE '*{0}*'", txthoten.Text);
            if (!string.IsNullOrEmpty(txtmanv.Text.Trim()))
                filter += string.Format(" AND tblNhanVien.MaNV LIKE '*{0}*'", txtmanv.Text);

            Frmreportnv reportviewer = new Frmreportnv();
            reportviewer.Show();
            reportviewer.showReport("nhanvien.rpt"
                , filter
                ,"danh sách nhân viên");
            reportviewer.Activate();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienNV();
        }
    }
    }

