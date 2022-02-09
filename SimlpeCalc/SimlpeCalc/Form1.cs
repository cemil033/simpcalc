using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimlpeCalc
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double calc(string a,string b,string oper)
        {
            if(oper == "+")
            {
                
                return double.Parse(a)+double.Parse(b);
            }
            else if(oper == "-")
            {
                return double.Parse(a) - double.Parse(b);
            }
            else if (oper == "X")
            {
                return double.Parse(a) * double.Parse(b);
            }
            else if (oper == "/")
            {
                if (double.Parse(b) == 0)
                {
                    MessageBox.Show("Zero divison error!");
                    return 0;
                }
                return double.Parse(a) / double.Parse(b);
            }
            return 0;
        }
        static string a = "", b = "", oper = "";
        private void btn_numb_Click(object sender, EventArgs e)
        {
            
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (btn.Text == "0" || btn.Text == "1" || btn.Text == "2" || btn.Text == "3" || btn.Text == "4" || btn.Text == "5" || btn.Text == "6" || btn.Text == "7" || btn.Text == "8" || btn.Text == "9")
                {
                    if (lbl_result.Text == "0"|| lbl_result.Text == "+" || lbl_result.Text == "-" || lbl_result.Text == "X" || lbl_result.Text == "/") { lbl_result.Text = btn.Text; }
                    else
                    {
                        lbl_result.Text += btn.Text;
                    }
                }
                else if (btn.Text == "+" || btn.Text == "-" || btn.Text == "X" || btn.Text == "/") { 
                    if(lbl_result.Text == "+"||lbl_result.Text=="-" || lbl_result.Text=="X" || lbl_result.Text=="/") {
                        lbl_result.Text = btn.Text;
                        oper= btn.Text;
                    }
                    else
                    {
                        a = lbl_result.Text;
                        oper = btn.Text;
                        lbl_result.Text=btn.Text;
                    }
                }
                else if (btn.Text == "=")
                {
                    if (a != "" && oper != "")
                    {
                        b=lbl_result.Text;
                        lbl_result.Text=calc(a,b,oper).ToString();
                    }
                    else
                    {
                        lbl_result.Text = calc(a, b, oper).ToString();
                        a = "";
                        oper = "";
                    }
                }
                else if(btn.Text == "+/-")
                {
                    if(lbl_result.Text !="0"|| lbl_result.Text != "+" || lbl_result.Text != "-" || lbl_result.Text != "*" || lbl_result.Text != "/")
                    {
                        lbl_result.Text = (double.Parse(lbl_result.Text) * -1).ToString();
                    }
                }
                else if (btn.Text == ".")
                {
                    if (lbl_result.Text.Split('.').Length == 1)
                    {
                        lbl_result.Text += ",";
                    }
                }
                else if (btn.Text == "C" || btn.Text == "CE")
                {
                    lbl_result.Text = "0";
                    a = "";
                    b = "";
                    oper = "";
                }
                else if (btn.Text == "<<")
                {
                    lbl_result.Text=lbl_result.Text.Remove(lbl_result.Text.Length - 1);
                }
            }
        }

    }
}
