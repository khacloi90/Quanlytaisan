using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Data.OleDb;
using ExcelDataReader;
using System.Runtime.InteropServices;

namespace Quanlytaisan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=192.168.5.1;Initial Catalog=IT_Test;Persist Security Info=True;User ID=sa;Password=Sun!hso2012");
        SqlCommand command;

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Quanlytaisan";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

            textBox1.Visible = false;

               dgv.Columns["Anh"].Visible = false;
                dgv.Columns["Anh1"].Visible = false;
            tb.Text = table.Rows.Count.ToString();

            for (int j = 0; j < dgv.Rows.Count; j++) { dgv.Rows[j].Cells[2].Value = j + 1; }
            
            

            GetHeaderText();
            GetSizeColumn();

           
        }
        void loaddata1()
        {
            if (tb_key.Text == "")
            {
                if(comboBox1.Text == "")
                {
                    loaddata();
                }
                else { 
                
               command = connection.CreateCommand();
           
            command.CommandText = "select * from Quanlytaisan where tentaisan = '" + comboBox1.SelectedItem.ToString() + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
            tb.Text = table.Rows.Count.ToString();
            textBox1.Visible = false;


                    for (int j = 0; j < dgv.Rows.Count; j++) { dgv.Rows[j].Cells[2].Value = j + 1; }

            GetHeaderText();
            GetSizeColumn();
                }
            }
            else
            {
                if(comboBox1.Text == "")
                {
                    command = connection.CreateCommand();
                    command.CommandText = "select * from Quanlytaisan where mataisan like '%" + tb_key.Text + "%' OR bophansudung like '%" + tb_key.Text + "%'  ";
                   
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                    tb.Text = table.Rows.Count.ToString();
                    textBox1.Visible = false;
                    for (int j = 0; j < dgv.Rows.Count; j++) { dgv.Rows[j].Cells[2].Value = j + 1; }

                    GetHeaderText();
                    GetSizeColumn();
                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = "select * from Quanlytaisan where mataisan like '%" + tb_key.Text + "%' OR bophansudung like '%" + tb_key.Text + "%' and tentaisan ='" + comboBox1.SelectedItem.ToString() + "' ";
                    
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                    tb.Text = table.Rows.Count.ToString();
                    textBox1.Visible = false;
                    for (int j = 0; j < dgv.Rows.Count; j++) { dgv.Rows[j].Cells[2].Value = j + 1; }

                    GetHeaderText();
                    GetSizeColumn();
                }
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            connection.Open();

            DataGridViewCheckBoxColumn ch = new DataGridViewCheckBoxColumn();
            ch.Name = "Chon";
            ch.HeaderText = "Select";
            ch.Width =45;
            dgv.Columns.Insert(0, ch);

            loaddata();
          
           // this.Bounds = Screen.PrimaryScreen.Bounds;


            for (int j = 0; j < dgv.Rows.Count; j++) { dgv.Rows[j].Cells[2].Value = j + 1; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName ;
            }
           
            
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                if (textBox1.Text != "")
                {


                    byte[] b = PathToByteArray(this.Text);

                    command = connection.CreateCommand();
                    command.CommandText = "insert into Quanlytaisan (anh,  mataisan , tentaisan, bophanquanly, bophansudung, nguoisudung, nguoisudungtruoc, thongtintaisan, ngaykiemtra, tinhtrangtaisan, ghichu, anh1 ) values(@hinh ,  N'" + tb_ma.Text + "', N'" + tb_ten.Text + "', N'" + tb_bpql.Text + "' , N'" + tb_bpsd.Text + "', N'" + tb_nsd.Text + "' ,N'" + tb_nsdt.Text + "' ,N'" + tb_ttts.Text + "' ,N'" + tb_nkt.Text + "' ,N'" + tb_tinhtrang.Text + "' ,N'" + tb_ghichu.Text + "', @anh1 )";
                    command.Parameters.Add("@hinh", b);

                    FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    byte[] image1 = new byte[fs1.Length];
                    fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                    fs1.Close();

                    SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                    command.Parameters.Add(prm);
                    command.ExecuteNonQuery();
                    loaddata();


                }
                else
                {
                    byte[] b = PathToByteArray(this.Text);

                    command = connection.CreateCommand();
                    command.CommandText = "insert into Quanlytaisan (anh,  mataisan , tentaisan, bophanquanly, bophansudung, nguoisudung, nguoisudungtruoc, thongtintaisan, ngaykiemtra, tinhtrangtaisan, ghichu) values(@hinh ,  N'" + tb_ma.Text + "', N'" + tb_ten.Text + "', N'" + tb_bpql.Text + "' , N'" + tb_bpsd.Text + "', N'" + tb_nsd.Text + "' ,N'" + tb_nsdt.Text + "' ,N'" + tb_ttts.Text + "' ,N'" + tb_nkt.Text + "' ,N'" + tb_tinhtrang.Text + "' ,N'" + tb_ghichu.Text + "' )";
                    command.Parameters.Add("@hinh", b);
                    command.ExecuteNonQuery();
                    loaddata();

                }
            }
            else
            {
                if (textBox1.Text != "")
                {

                   

                    command = connection.CreateCommand();
                    command.CommandText = "insert into Quanlytaisan (  mataisan , tentaisan, bophanquanly, bophansudung, nguoisudung, nguoisudungtruoc, thongtintaisan, ngaykiemtra, tinhtrangtaisan, ghichu, anh1 ) values(  N'" + tb_ma.Text + "', N'" + tb_ten.Text + "', N'" + tb_bpql.Text + "' , N'" + tb_bpsd.Text + "', N'" + tb_nsd.Text + "' ,N'" + tb_nsdt.Text + "' ,N'" + tb_ttts.Text + "' ,N'" + tb_nkt.Text + "' ,N'" + tb_tinhtrang.Text + "' ,N'" + tb_ghichu.Text + "', @anh1 )";
                   

                    FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    byte[] image1 = new byte[fs1.Length];
                    fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                    fs1.Close();

                    SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                    command.Parameters.Add(prm);
                    command.ExecuteNonQuery();
                    loaddata();




                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = "insert into Quanlytaisan (  mataisan , tentaisan, bophanquanly, bophansudung, nguoisudung, nguoisudungtruoc, thongtintaisan, ngaykiemtra, tinhtrangtaisan, ghichu ) values(  N'" + tb_ma.Text + "', N'" + tb_ten.Text + "', N'" + tb_bpql.Text + "' , N'" + tb_bpsd.Text + "', N'" + tb_nsd.Text + "' ,N'" + tb_nsdt.Text + "' ,N'" + tb_ttts.Text + "' ,N'" + tb_nkt.Text + "' ,N'" + tb_tinhtrang.Text + "' ,N'" + tb_ghichu.Text + "' )";

                    command.ExecuteNonQuery();
                    loaddata();


                }
            }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Image != null) {

                if (pictureBox1.Image != null)
                {
                    if(pictureBox4.Image != null)
                    {
                        if(textBox1.Text != "")
                        {
                            byte[] b = PathToByteArray(this.Text);

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set anh = @hinh , tentaisan = N'"+tb_ten.Text+"', bophanquanly =N'"+tb_bpql.Text+"', bophansudung =N'"+tb_bpsd.Text+"', nguoisudung = N'"+tb_nsd.Text+"', nguoisudungtruoc = N'"+tb_nsdt.Text+"', thongtintaisan ='"+tb_ttts.Text+"', ngaykiemtra= N'"+tb_nkt.Text+"', tinhtrangtaisan =N'"+tb_tinhtrang.Text+"', ghichu= N'"+tb_ghichu.Text+"', anh1 = @anh1 where mataisan =N'"+tb_ma.Text+"' ";
                            command.Parameters.Add("@hinh", b);

                            FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image1 = new byte[fs1.Length];
                            fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();

                            SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                            command.Parameters.Add(prm);
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                        else
                        {
                            byte[] b = PathToByteArray(this.Text);

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set anh = @hinh , tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "' where mataisan =N'" + tb_ma.Text + "' ";
                            command.Parameters.Add("@hinh", b);

                           
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                    }
                    else
                    {
                        if (textBox1.Text != "")
                        {
                            byte[] b = PathToByteArray(this.Text);

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set anh = @hinh , tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "', anh1 = @anh1 where mataisan =N'" + tb_ma.Text + "' ";
                            command.Parameters.Add("@hinh", b);

                            FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image1 = new byte[fs1.Length];
                            fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();

                            SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                            command.Parameters.Add(prm);
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                        else
                        {
                            byte[] b = PathToByteArray(this.Text);

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set anh = @hinh , tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "' where mataisan =N'" + tb_ma.Text + "' ";
                            command.Parameters.Add("@hinh", b);


                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                    }
                }
                else
                {
                    if (pictureBox4.Image != null)
                    {
                        if (textBox1.Text != "")
                        {
                            

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set  tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "', anh1 = @anh1 where mataisan =N'" + tb_ma.Text + "' ";
                            

                            FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image1 = new byte[fs1.Length];
                            fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();

                            SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                            command.Parameters.Add(prm);
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                        else
                        {                          
                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set  tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "' where mataisan =N'" + tb_ma.Text + "' ";                           
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                    }
                    else
                    {
                        if (textBox1.Text != "")
                        {
                           

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set  tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "', anh1 = @anh1 where mataisan =N'" + tb_ma.Text + "' ";
                            

                            FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image1 = new byte[fs1.Length];
                            fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();

                            SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                            command.Parameters.Add(prm);
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                        else
                        {
                            
                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set  tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "' where mataisan =N'" + tb_ma.Text + "' ";
                             command.ExecuteNonQuery();
                            loaddata1();
                        }
                    }
                }
            }
            else
            {
                if (pictureBox1.Image != null)
                {
                    if (pictureBox4.Image != null)
                    {
                        if (textBox1.Text != "")
                        {
                            byte[] b = PathToByteArray(this.Text);

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set anh = @hinh , tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "', anh1 = @anh1 where mataisan =N'" + tb_ma.Text + "' ";
                            command.Parameters.Add("@hinh", b);

                            FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image1 = new byte[fs1.Length];
                            fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();

                            SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                            command.Parameters.Add(prm);
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                        else
                        {
                            byte[] b = PathToByteArray(this.Text);

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set anh = @hinh , tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "' where mataisan =N'" + tb_ma.Text + "' ";
                            command.Parameters.Add("@hinh", b);


                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                    }
                    else
                    {
                        if (textBox1.Text != "")
                        {
                            byte[] b = PathToByteArray(this.Text);

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set anh = @hinh , tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "', anh1 = @anh1 where mataisan =N'" + tb_ma.Text + "' ";
                            command.Parameters.Add("@hinh", b);

                            FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image1 = new byte[fs1.Length];
                            fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();

                            SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                            command.Parameters.Add(prm);
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                        else
                        {
                            byte[] b = PathToByteArray(this.Text);

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set anh = @hinh , tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "' where mataisan =N'" + tb_ma.Text + "' ";
                            command.Parameters.Add("@hinh", b);


                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                    }
                }
                else
                {
                    if (pictureBox4.Image != null)
                    {
                        if (textBox1.Text != "")
                        {


                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set  tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "', anh1 = @anh1 where mataisan =N'" + tb_ma.Text + "' ";


                            FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image1 = new byte[fs1.Length];
                            fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();

                            SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                            command.Parameters.Add(prm);
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                        else
                        {
                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set  tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "' where mataisan =N'" + tb_ma.Text + "' ";
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                    }
                    else
                    {
                        if (textBox1.Text != "")
                        {


                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set  tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "', anh1 = @anh1 where mataisan =N'" + tb_ma.Text + "' ";


                            FileStream fs1 = new FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image1 = new byte[fs1.Length];
                            fs1.Read(image1, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();

                            SqlParameter prm = new SqlParameter("@anh1", SqlDbType.VarBinary, image1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image1);
                            command.Parameters.Add(prm);
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                        else
                        {

                            command = connection.CreateCommand();
                            command.CommandText = "update Quanlytaisan set  tentaisan = N'" + tb_ten.Text + "', bophanquanly =N'" + tb_bpql.Text + "', bophansudung =N'" + tb_bpsd.Text + "', nguoisudung = N'" + tb_nsd.Text + "', nguoisudungtruoc = N'" + tb_nsdt.Text + "', thongtintaisan ='" + tb_ttts.Text + "', ngaykiemtra= N'" + tb_nkt.Text + "', tinhtrangtaisan =N'" + tb_tinhtrang.Text + "', ghichu= N'" + tb_ghichu.Text + "' where mataisan =N'" + tb_ma.Text + "' ";
                            command.ExecuteNonQuery();
                            loaddata1();
                        }
                    }
                }

            }
        }

        public void GetcellClick()
        {
            
            int i;
            i = dgv.CurrentRow.Index;            
            tb_ma.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_ten.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_bpql.Text = dgv.Rows[i].Cells[5].Value.ToString();
            tb_bpsd.Text = dgv.Rows[i].Cells[6].Value.ToString();
            tb_nsd.Text = dgv.Rows[i].Cells[7].Value.ToString();
            tb_nsdt.Text = dgv.Rows[i].Cells[8].Value.ToString();
            tb_ttts.Text = dgv.Rows[i].Cells[9].Value.ToString();
            tb_nkt.Text = dgv.Rows[i].Cells[10].Value.ToString();
            tb_tinhtrang.Text = dgv.Rows[i].Cells[11].Value.ToString();
            tb_ghichu.Text = dgv.Rows[i].Cells[12].Value.ToString();
           
            if ((!Convert.IsDBNull(dgv.CurrentRow.Cells[1].Value)))
            {


                if ((!Convert.IsDBNull(dgv.CurrentRow.Cells[13].Value)))
                {
                    byte[] bytes = (byte[])dgv.CurrentRow.Cells[1].Value;
                    Image image = byteArrayToImage(bytes);

                    pictureBox2.Image = image;


                    byte[] bytes1 = (byte[])dgv.CurrentRow.Cells[13].Value;
                    Image image1 = byteArrayToImage(bytes1);

                    pictureBox4.Image = image1;
                }
                else
                {
                    byte[] bytes = (byte[])dgv.CurrentRow.Cells[1].Value;
                    Image image = byteArrayToImage(bytes);

                    pictureBox2.Image = image;
                    pictureBox4.Image = null;
                }


            }
            else
            {
                if ((!Convert.IsDBNull(dgv.CurrentRow.Cells[13].Value)))
                {
                    

                    pictureBox2.Image = null;


                    byte[] bytes1 = (byte[])dgv.CurrentRow.Cells[13].Value;
                    Image image1 = byteArrayToImage(bytes1);

                    pictureBox4.Image = image1;
                }
                else
                {
                   

                    pictureBox2.Image = null;
                    pictureBox4.Image = null;
                }
            }
          

        }
        public void GetHeaderText()
        {
            dgv.Columns[1].HeaderText = "Anh";
            dgv.Columns[2].HeaderText = "STT\r순번";
            dgv.Columns[3].HeaderText = "Mã tài sản\r자산 코드 번호";
            dgv.Columns[4].HeaderText = "Tên tài sản\r자산명";
            dgv.Columns[5].HeaderText = "Bộ phận Quản lý\r관리 부서";
            dgv.Columns[6].HeaderText = "Bộ phận Sử dụng\r사용 부서";
            dgv.Columns[7].HeaderText = "Người sử dụng\r사용자";
            dgv.Columns[8].HeaderText = "Người sử dụng trước\r이전 사용자";
            dgv.Columns[9].HeaderText = "Thông tin tài sản\r자산 정보";
            dgv.Columns[10].HeaderText = "Ngày kiểm tra\r검사 일자";
            dgv.Columns[11].HeaderText = "Tình trạng\r자산 상태";
            dgv.Columns[12].HeaderText = "Ghi chú\r비고";
            
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        public void GetSizeColumn()
        {
            dgv.Columns[1].Width = 40;
            dgv.Columns[2].Width = 40;
            dgv.Columns[3].Width = 110;
            dgv.Columns[4].Width = 130;
            dgv.Columns[5].Width = 130;
            dgv.Columns[6].Width = 130;
            dgv.Columns[7].Width = 110;
            dgv.Columns[8].Width = 140;
            dgv.Columns[9].Width = 120;
            dgv.Columns[10].Width = 110;
            dgv.Columns[11].Width = 90;
            dgv.Columns[12].Width = 80;
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetcellClick();
            GetHeaderText();
            GetSizeColumn();
            
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }      
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        byte[] PathToByteArray(string path)
        {           
                return File.ReadAllBytes(path);            
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }


        void delete(string str)
        {


            command = connection.CreateCommand();
            command.CommandText = "delete from Quanlytaisan where mataisan = '" + str + "'";
            command.ExecuteNonQuery();
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
                if (dgv.Rows[i].Cells[0].Value != null)
                {

                    delete(dgv.Rows[i].Cells[3].Value.ToString());


                }
            loaddata1();
        }

        private void bt_khoitao_Click(object sender, EventArgs e)
        {
            tb_key.Text = "";
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_bpql.Text = "";
            tb_bpsd.Text = "";
            tb_nsd.Text = "";
            tb_nsdt.Text = "";
            tb_ttts.Text = "";
            tb_nkt.Text = "";
            pictureBox1.Image = null;
            tb_tinhtrang.Text = "";
            tb_ghichu.Text = "";
            tb_key.Text = "";
            pictureBox2.Image = null;
            comboBox1.Text = "";
            pictureBox4.Image = null;
            textBox1.Text = "";
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            loaddata1();
        }
        public void Export(DataTable dt, string sheetName, string title)
        {

            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "M1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("A3", "A3");

            cl10.Value2 = "Ảnh";
            cl10.ColumnWidth = 10.0;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("B3", "B3");

            cl1.Value2 = "STT";

            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("C3", "C3");

            cl2.Value2 = "Mã tài sản";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("D3", "D3");

            cl3.Value2 = "Tên tài sản";

            cl3.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("E3", "E3");

            cl4.Value2 = "Bộ phận quản lý";

            cl4.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("F3", "F3");

            cl5.Value2 = "Bộ phận sử dụng";

            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("G3", "G3");

            cl6.Value2 = "Người sử dụng";

            cl6.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl70 = oSheet.get_Range("H3", "H3");

            cl70.Value2 = "Người sử dụng trước";

            cl70.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("I3", "I3");

            cl8.Value2 = "Thông tin tài sản";

            cl8.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl90 = oSheet.get_Range("J3", "J3");

            cl90.Value2 = "Ngày kiểm tra";

            cl90.ColumnWidth = 25.0;
           

            
            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

            cl11.Value2 = "Tình trạng tài sản";

            cl11.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");

            cl12.Value2 = "Ghi chú";

            cl12.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("M3", "M3");

            cl13.Value2 = "Ảnh 1";

            cl13.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "M3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void bt_Export_Click(object sender, EventArgs e)
        {
            Form1 excel = new Form1();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 
            DataTable dt = (DataTable)dgv.DataSource;
            excel.Export(dt, "Sheet1", "DANH SACH TAI SAN");
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ope = new OpenFileDialog();
            ope.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (ope.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream stream = new FileStream(ope.FileName, FileMode.Open);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelReader.AsDataSet();
            DataClasses1DataContext conn = new DataClasses1DataContext();
            foreach (DataTable table in result.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    Quanlytaisan addtable = new Quanlytaisan()
                    {
                        stt = Convert.ToString(dr[1]),
                        mataisan = Convert.ToString(dr[2]),
                        tentaisan = Convert.ToString(dr[3]),
                        bophanquanly = Convert.ToString(dr[4]),
                        bophansudung = Convert.ToString(dr[5]),
                        nguoisudung = Convert.ToString(dr[6]),
                        nguoisudungtruoc = Convert.ToString(dr[7]),
                        thongtintaisan = Convert.ToString(dr[8]),
                        ngaykiemtra = Convert.ToString(dr[9]),

                        tinhtrangtaisan = Convert.ToString(dr[10]),
                        ghichu = Convert.ToString(dr[11])
                    };
                    conn.Quanlytaisans.InsertOnSubmit(addtable);
                }
            }
            conn.SubmitChanges();
            excelReader.Close();
            stream.Close();
            MessageBox.Show("Import thành công");
        }

        private void home_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            tb_key.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            
            loaddata();
          
        }


        class RawPrinterHelper
        {

            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)] public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)] public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)] public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            // SendBytesToPrinter()
            // When the function is given a printer name and an unmanaged array
            // of bytes, the function sends those bytes to the print queue.
            // Returns true on success, false on failure.
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Assume failure unless you specifically succeed.

                di.pDocName = "My C#.NET RAW Document";
                di.pDataType = "RAW";

                // Open the printer.
                if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    // Start a document.
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        // Start a page.
                        if (StartPagePrinter(hPrinter))
                        {
                            // Write your bytes.
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }
                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendFileToPrinter(string szPrinterName, string szFileName)
            {
                // Open the file.
                FileStream fs = new FileStream(szFileName, FileMode.Open);
                // Create a BinaryReader on the file.
                BinaryReader br = new BinaryReader(fs);
                // Dim an array of bytes big enough to hold the file's contents.
                Byte[] bytes = new Byte[fs.Length];
                bool bSuccess = false;
                // Your unmanaged pointer.
                IntPtr pUnmanagedBytes = new IntPtr(0);
                int nLength;

                nLength = Convert.ToInt32(fs.Length);
                // Read the contents of the file into the array.
                bytes = br.ReadBytes(nLength);
                // Allocate some unmanaged memory for those bytes.
                pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
                // Copy the managed byte array into the unmanaged array.
                Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
                // Send the unmanaged bytes to the printer.
                bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
                // Free the unmanaged memory that you allocated earlier.
                Marshal.FreeCoTaskMem(pUnmanagedBytes);
                return bSuccess;
            }
            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                Int32 dwCount;
                // How many characters are in the string?
                dwCount = szString.Length;
                // Assume that the printer is expecting ANSI text, and then convert
                // the string to ANSI text.
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                // Send the converted ANSI string to the printer.
                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }

            public static bool SendTextFileToPrinter(string szFileName, string printerName)
            {
                var sb = new StringBuilder();

                using (var sr = new StreamReader(szFileName, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        sb.AppendLine(sr.ReadLine());
                    }
                }

                return RawPrinterHelper.SendStringToPrinter(printerName, sb.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        for (int i = 0; i < dgv.Rows.Count; i++)
        if (dgv.Rows[i].Cells[0].Value != null)
        {


                    string v =


"^XA" +

"^CI0" +
"^PW480" +
"^FO22,68^GB441,197,2^FS" +
"^FO223,70^GB0,195,2^FS" +
"^FT25,115^A0N,28,16^FB97,1,0,C^FH\\^FDAsset Name^FS" +
"^FT43,181^A0N,28,16^FB66,1,0,C^FH\\^FDManage^FS" +
"^FT54,243^A0N,28,16^FB44,1,0,C^FH\\^FDSpec^FS" +
"^FT240,115^A0N,28,16^FB74,1,0,C^FH\\^FDAsset No^FS" +
"^FT232,181^A0N,28,16^FB90,1,0,C^FH\\^FDParts Used^FS" +
"^FT228,245^A0N,28,16^FB94,1,0,C^FH\\^FDCheck Date^FS" +
"^FT144,304^A0N,34,33^FB194,1,0,C^FH\\^FDHaesungVina*^FS" +
"^FO24,135^GB440,0,2^FS" +
"^FO24,200^GB440,0,2^FS" +
"^FO322,68^GB0,197,2^FS" +
"^FT144,115^A0N,28,16^FB80,1,0,C^FH\\^FD" + dgv.Rows[i].Cells[4].Value.ToString() + "^FS" +
"^FT144,181^A0N,28,16^FB76,1,0,C^FH\\^FD" + dgv.Rows[i].Cells[6].Value.ToString() + "^FS" +
"^FT122,243^A0N,28,16^FB107,1,0,C^FH\\^FD" + dgv.Rows[i].Cells[9].Value.ToString() + "^FS" +
"^FT330,115^A0N,25,14^FB124,1,0,C^FH\\^FD" + dgv.Rows[i].Cells[3].Value.ToString() + "^FS" +
"^FT345,180^A0N,28,16^FB95,1,0,C^FH\\^FD" + dgv.Rows[i].Cells[7].Value.ToString() + "^FS" +
"^FT353,245^A0N,28,16^FB79,1,0,C^FH\\^FD" + dgv.Rows[i].Cells[10].Value.ToString() + "^FS" +
"^FO118,68^GB0,197,2^FS" +
"^BY2,3,41^FT48,56^BCN,,N,N" +
"^FD" + dgv.Rows[i].Cells[3].Value.ToString() + "^FS" +
"^XZ";



                    PrintDialog pd = new PrintDialog();
                    pd.PrinterSettings = new PrinterSettings();
                   
                        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, v);
                    

                }




            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
