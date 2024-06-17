using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_đăngkimonhoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i <= 2025; i++)
            {
                cbxNienkhoa.Items.Add(i.ToString());
            }
            cbxNienkhoa.SelectedIndex = 5;
            cbxLop.Items.Add("Ứng dụng phần mềm 1");
            cbxLop.Items.Add("Ứng dụng phần mềm 2");
            cbxLop.Items.Add("Ứng dụng phần mềm 3");
            cbxLop.Items.Add("Thiết kế đồ họa 1");
            cbxLop.Items.Add("Thiết kế đồ họa 2");
            cbxLop.Items.Add("Quản trị mạng 1");
            cbxLop.Items.Add("Quản trị mạng 2");

            cbxLop.SelectedIndex = 0;

            rad1.Checked = true;
        }

        private void btndangki_Click(object sender, EventArgs e)
        {

            string thongtin;
            thongtin = "Mã số sinh viên: " + txtMssv.Text;
            thongtin = "\nHọ và tên: " + txtHovaten.Text;
            thongtin += "\nNiên khóa: " + cbxNienkhoa.SelectedItem;
            thongtin += "\nLớp: " + cbxLop.SelectedItem;

            string hocky = "";
            if (rad1.Checked)
            {
                hocky = rad1.Text;
            }
            else if (rad2.Checked)
            {
                hocky = rad2.Text;
            }
            else if (rad3.Checked)
            {
                hocky = rad3.Text;
            }
            else if (rad4.Checked)
            {
                hocky = rad4.Text;
            }
            thongtin += "\nĐã đăng ký học Học Kỳ " + hocky + " các môn học sau:";

            int stt = 1;
            foreach (var Item in cblmonhoc.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + Item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }

        private void cblmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            rad1.Checked = true;
            cblmonhoc.Items.Add( CheckState.Checked);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

      

