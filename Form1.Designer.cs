namespace Quanlytaisan
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
            this.tb_key = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bt_tim = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.home = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_nsdt = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ttts = new System.Windows.Forms.TextBox();
            this.tb_nkt = new System.Windows.Forms.TextBox();
            this.tb_bpql = new System.Windows.Forms.TextBox();
            this.tb_bpsd = new System.Windows.Forms.TextBox();
            this.tb_tinhtrang = new System.Windows.Forms.TextBox();
            this.tb_nsd = new System.Windows.Forms.TextBox();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_Export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(1046, 74);
            this.tb_key.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_key.Name = "tb_key";
            this.tb_key.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_key.Size = new System.Drawing.Size(186, 20);
            this.tb_key.TabIndex = 19;
            this.tb_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1322, 366);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN \\ 정보";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(4, 17);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1305, 340);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // bt_tim
            // 
            this.bt_tim.AutoSize = true;
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Location = new System.Drawing.Point(1235, 65);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(105, 36);
            this.bt_tim.TabIndex = 20;
            this.bt_tim.Text = "Tìm kiếm\r\n조회";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.Location = new System.Drawing.Point(1235, 24);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(105, 36);
            this.btnImportExcel.TabIndex = 17;
            this.btnImportExcel.Text = "Nhập từ Excel\r\n엑셀 파일에서 입력";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home.Location = new System.Drawing.Point(19, 60);
            this.home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(70, 28);
            this.home.TabIndex = 22;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(874, 76);
            this.tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(49, 20);
            this.tb.TabIndex = 21;
            this.tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(393, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(417, 62);
            this.label13.TabIndex = 23;
            this.label13.Text = "THÔNG TIN QUẢN LÝ TÀI SẢN\r\n자산 관리 정보";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LAPTOP",
            "COMPUTER",
            "IP PHONE",
            "MONITOR",
            "RACK SCAN BARCODE"});
            this.comboBox1.Location = new System.Drawing.Point(942, 74);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tài sản\r\n자산 코드 번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Người sử dụng trước\r\n이전 사용자";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin tài sản\r\n자산 정보";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bộ phận quản lý\r\n관리 부서";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(734, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ảnh 1\r\n이미지";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên tài sản\r\n자산명";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày kiểm tra\r\n검사 일자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bộ phận sử dụng\r\n사용 부서";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 155);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tình trạng tài sản\r\n자산 상태";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Người sử dụng\r\n사용자";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(377, 193);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ghi chú\r\n비고";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(188, 27);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(164, 20);
            this.tb_ma.TabIndex = 1;
            // 
            // tb_nsdt
            // 
            this.tb_nsdt.Location = new System.Drawing.Point(500, 24);
            this.tb_nsdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_nsdt.Name = "tb_nsdt";
            this.tb_nsdt.Size = new System.Drawing.Size(187, 20);
            this.tb_nsdt.TabIndex = 1;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(188, 69);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(164, 20);
            this.tb_ten.TabIndex = 1;
            // 
            // tb_ttts
            // 
            this.tb_ttts.Location = new System.Drawing.Point(500, 67);
            this.tb_ttts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ttts.Name = "tb_ttts";
            this.tb_ttts.Size = new System.Drawing.Size(187, 20);
            this.tb_ttts.TabIndex = 1;
            // 
            // tb_nkt
            // 
            this.tb_nkt.Location = new System.Drawing.Point(500, 113);
            this.tb_nkt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_nkt.Name = "tb_nkt";
            this.tb_nkt.Size = new System.Drawing.Size(187, 20);
            this.tb_nkt.TabIndex = 1;
            // 
            // tb_bpql
            // 
            this.tb_bpql.Location = new System.Drawing.Point(188, 113);
            this.tb_bpql.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_bpql.Name = "tb_bpql";
            this.tb_bpql.Size = new System.Drawing.Size(164, 20);
            this.tb_bpql.TabIndex = 1;
            // 
            // tb_bpsd
            // 
            this.tb_bpsd.Location = new System.Drawing.Point(188, 159);
            this.tb_bpsd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_bpsd.Name = "tb_bpsd";
            this.tb_bpsd.Size = new System.Drawing.Size(164, 20);
            this.tb_bpsd.TabIndex = 1;
            // 
            // tb_tinhtrang
            // 
            this.tb_tinhtrang.Location = new System.Drawing.Point(500, 159);
            this.tb_tinhtrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_tinhtrang.Name = "tb_tinhtrang";
            this.tb_tinhtrang.Size = new System.Drawing.Size(187, 20);
            this.tb_tinhtrang.TabIndex = 1;
            // 
            // tb_nsd
            // 
            this.tb_nsd.Location = new System.Drawing.Point(188, 200);
            this.tb_nsd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_nsd.Name = "tb_nsd";
            this.tb_nsd.Size = new System.Drawing.Size(164, 20);
            this.tb_nsd.TabIndex = 1;
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Location = new System.Drawing.Point(500, 197);
            this.tb_ghichu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(187, 20);
            this.tb_ghichu.TabIndex = 1;
            // 
            // bt_them
            // 
            this.bt_them.AutoSize = true;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(11, 258);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(96, 45);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "Thêm mới\r\n 추가";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.AutoSize = true;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(130, 258);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(93, 45);
            this.bt_sua.TabIndex = 2;
            this.bt_sua.Text = "Sửa\r\n수정";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(247, 258);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(93, 45);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa\r\n삭제";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.AutoSize = true;
            this.bt_khoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_khoitao.Location = new System.Drawing.Point(363, 258);
            this.bt_khoitao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.Size = new System.Drawing.Size(104, 45);
            this.bt_khoitao.TabIndex = 2;
            this.bt_khoitao.Text = "Khởi tạo\r\n신규 데이터 작성";
            this.bt_khoitao.UseVisualStyleBackColor = true;
            this.bt_khoitao.Click += new System.EventHandler(this.bt_khoitao_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(636, 258);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 45);
            this.button5.TabIndex = 2;
            this.button5.Text = "In\r\n프린터";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(800, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(736, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bt_Export
            // 
            this.bt_Export.AutoSize = true;
            this.bt_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Export.Location = new System.Drawing.Point(488, 258);
            this.bt_Export.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Export.Name = "bt_Export";
            this.bt_Export.Size = new System.Drawing.Size(112, 45);
            this.bt_Export.TabIndex = 4;
            this.bt_Export.Text = "Xuất ra Excel\r\n엑셀 파일로 출력";
            this.bt_Export.UseVisualStyleBackColor = true;
            this.bt_Export.Click += new System.EventHandler(this.bt_Export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_Export);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.bt_khoitao);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.tb_ghichu);
            this.groupBox2.Controls.Add(this.tb_nsd);
            this.groupBox2.Controls.Add(this.tb_tinhtrang);
            this.groupBox2.Controls.Add(this.tb_bpsd);
            this.groupBox2.Controls.Add(this.tb_bpql);
            this.groupBox2.Controls.Add(this.tb_nkt);
            this.groupBox2.Controls.Add(this.tb_ttts);
            this.groupBox2.Controls.Add(this.tb_ten);
            this.groupBox2.Controls.Add(this.tb_nsdt);
            this.groupBox2.Controls.Add(this.tb_ma);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(19, 476);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1322, 327);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHI TIẾT \\ 상세";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1028, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 34);
            this.label14.TabIndex = 10;
            this.label14.Text = "Ảnh 2\r\n이미지";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1273, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1081, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(1027, 46);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(243, 258);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 816);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.home);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "QLTS";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TextBox tb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_nsdt;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_ttts;
        private System.Windows.Forms.TextBox tb_nkt;
        private System.Windows.Forms.TextBox tb_bpql;
        private System.Windows.Forms.TextBox tb_bpsd;
        private System.Windows.Forms.TextBox tb_tinhtrang;
        private System.Windows.Forms.TextBox tb_nsd;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_khoitao;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_Export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
    }
}

