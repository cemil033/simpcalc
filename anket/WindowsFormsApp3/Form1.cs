using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public class file
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string fname { get; set; }
            public string country { get; set; }
            public string city { get; set; }
            public string phone { get; set; }
            public DateTime DayoB { get; set; }
            public bool gender { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            file file = new file();
            var jsonStr = File.ReadAllText(tb_filename.Text +".json");
            file = JsonConvert.DeserializeObject<file>(jsonStr);
            tb_name.Text=file.name;
            tb_sname.Text = file.surname;
            tb_fname.Text=file.fname;
            tb_cout.Text = file.country;
            tb_city.Text=file.city;
            tb_phn.Text=file.phone;
            dtp_dob.Value = file.DayoB;
            if (file.gender == true)
            {
                rb_m.Checked = false;
                rb_f.Checked = true;
            }
            else
            {
                rb_m.Checked = true;
                rb_f.Checked=false;
            } 
                

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            file file = new file();
            file.name   =tb_name.Text;
            file.surname=tb_sname.Text;
            file.fname  =tb_fname.Text;
            file.country=tb_cout.Text;
            file.city   =tb_city.Text;
            file.phone  =tb_phn.Text;
            file.DayoB  =dtp_dob.Value;
            if (rb_f.Checked)
            {
                file.gender = true;
            }
            else
            {
                file.gender=false;
            }
            var str = JsonConvert.SerializeObject(file, Newtonsoft.Json.Formatting.Indented);           
            File.WriteAllText(tb_name.Text+".json", str);
        }
    }
}
