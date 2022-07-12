namespace QuanLyNhanVien2
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
            this.labelMaNV = new System.Windows.Forms.Label();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.labelGioitinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.buttonBaocao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(38, 27);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(40, 13);
            this.labelMaNV.TabIndex = 0;
            this.labelMaNV.Text = "Mã NV";
            // 
            // labelTenNV
            // 
            this.labelTenNV.AutoSize = true;
            this.labelTenNV.Location = new System.Drawing.Point(38, 71);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(39, 13);
            this.labelTenNV.TabIndex = 1;
            this.labelTenNV.Text = "Họ tên";
            // 
            // labelGioitinh
            // 
            this.labelGioitinh.AutoSize = true;
            this.labelGioitinh.Location = new System.Drawing.Point(38, 110);
            this.labelGioitinh.Name = "labelGioitinh";
            this.labelGioitinh.Size = new System.Drawing.Size(47, 13);
            this.labelGioitinh.TabIndex = 2;
            this.labelGioitinh.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "số điện thoại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(98, 24);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaNV.TabIndex = 6;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(98, 71);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(100, 20);
            this.textBoxTen.TabIndex = 7;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(459, 103);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoDienThoai.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(459, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(98, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 108);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 280);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonthem
            // 
            this.buttonthem.Location = new System.Drawing.Point(603, 18);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(75, 23);
            this.buttonthem.TabIndex = 14;
            this.buttonthem.Text = "thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(603, 52);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 15;
            this.buttonxoa.Text = "xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.Location = new System.Drawing.Point(603, 106);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(75, 23);
            this.buttonsua.TabIndex = 16;
            this.buttonsua.Text = "sửa";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Location = new System.Drawing.Point(464, 51);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(94, 20);
            this.textBoxdiachi.TabIndex = 17;
            this.textBoxdiachi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBaocao
            // 
            this.buttonBaocao.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBaocao.Location = new System.Drawing.Point(703, 105);
            this.buttonBaocao.Name = "buttonBaocao";
            this.buttonBaocao.Size = new System.Drawing.Size(75, 23);
            this.buttonBaocao.TabIndex = 18;
            this.buttonBaocao.Text = "In phiếu";
            this.buttonBaocao.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBaocao);
            this.Controls.Add(this.textBoxdiachi);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSoDienThoai);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGioitinh);
            this.Controls.Add(this.labelTenNV);
            this.Controls.Add(this.labelMaNV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.Label labelGioitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.Button buttonBaocao;
    }
}

