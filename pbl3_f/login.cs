using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_f
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void User_TXT_OnValueChanged(object sender, EventArgs e)
        {
           

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=DESKTOP-SRQRFL4\SQLEXPRESS;Initial Catalog=coffe;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            string querry = "select * from hehe";

            SqlCommand cmd = new SqlCommand(querry,cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
                try
                {
                    foreach (DataRow i in dt.Tables[0].Rows)
                    {                      
                        string user = i[2].ToString();
                        string pass = i[3].ToString();
                        int num1 = user.IndexOf(" ");
                        user = user.Substring(0, num1);
                        int num2 = pass.IndexOf(" ");
                        pass = pass.Substring(0, num2);

                        if (User_TXT.Text == user && pass_txt.Text == pass && i[0].ToString() == "0")
                        {
                            annouce_lbl.ForeColor = Color.SteelBlue;
                            annouce_lbl.Text = "đăng nhập thành công !";
                            QL form = new QL();
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                            User_TXT.Focus();
                            pass_txt.Text = "";
                            annouce_lbl.Text = "";
                            break;
                    }
                        else if (User_TXT.Text == user && pass_txt.Text == pass && i[0].ToString() == "1")
                        {
                            annouce_lbl.ForeColor = Color.SteelBlue;
                            annouce_lbl.Text = "đăng nhập thành công !";
                            Form form = new NV();
                            this.Hide();
                            form.ShowDialog();
                            this.Show();

                            User_TXT.Focus();
                            pass_txt.Text = "";
                            annouce_lbl.Text = "";
                            break;
                    }
                        else if (User_TXT.Text != user && pass_txt.Text != pass)
                        {
                            annouce_lbl.ForeColor = Color.Red;
                            annouce_lbl.Text = "tài khoản hoặc mật khẩu không chính xác !!";                      
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex);
                }
            
            
           



        }

        private void pass_txt_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pass_txt_OnValueChanged_1(object sender, EventArgs e)
        {
            pass_txt.isPassword = true;
        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            
            i++;
            if(i%2 != 0 )
            {
                pass_txt.isPassword=false;
            }
            else
            {
                pass_txt.isPassword=true;
            }
        }

        

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                Login_btn_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
           this.KeyPress += Form1_KeyPress;

        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
