using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanVien2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Modify modify;

        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.GetAllNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message, MessageBoxButtons.OK);
            }

        }
        QuanLyNhanVien nhanVien;
        
        private void buttonthem_Click(object sender, EventArgs e)
        {
      
            string id = textBoxMaNV.Text;
            string name = textBoxTen.Text;
                string gender = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            DateTime DateOfbirh = this.dateTimePicker1.Value;
            string address = textBoxdiachi.Text;
            string phonenumber = textBoxSoDienThoai.Text;
            nhanVien = new QuanLyNhanVien(id, name, gender, DateOfbirh, address, phonenumber);
            if (modify.insert(nhanVien)){
                dataGridView1.DataSource = modify.GetAllNhanVien();

            }
            else
            {
                MessageBox.Show("Không thêm được" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            string id = textBoxMaNV.Text;
            string name = textBoxTen.Text;
            string gender=(radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            DateTime DateOfBrith = this.dateTimePicker1.Value;
            string address = textBoxdiachi.Text;
            string phonenumber = textBoxSoDienThoai.Text;
            nhanVien = new QuanLyNhanVien(id, name, gender, DateOfBrith, address, phonenumber);
            if (modify.update(nhanVien))
            {

                dataGridView1.DataSource = modify.GetAllNhanVien();

            }
            else
            {
                MessageBox.Show("không sửa được","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.Delete(id))
            {
                dataGridView1.DataSource = modify.GetAllNhanVien();
            }
            else
            {
                MessageBox.Show("Không thể xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
