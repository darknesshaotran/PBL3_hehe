using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_f
{
    public partial class NV : Form
    {
        public NV()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            color_home.Normalcolor = Color.OrangeRed;
            color_order.Normalcolor = Color.Black;
            color_infor.Normalcolor = Color.Black;
            Home_btn.Textcolor = Color.OrangeRed;
            bunifuFlatButton2.Textcolor = Color.White;
            bunifuFlatButton3.Textcolor = Color.White;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            color_home.Normalcolor = Color.Black;
            color_order.Normalcolor = Color.OrangeRed;
            color_infor.Normalcolor = Color.Black;
            bunifuFlatButton2.Textcolor = Color.OrangeRed;
            Home_btn.Textcolor = Color.White;
            bunifuFlatButton2.Textcolor = Color.OrangeRed;
            bunifuFlatButton3.Textcolor = Color.White;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            color_home.Normalcolor = Color.Black;
            color_order.Normalcolor = Color.Black;
            color_infor.Normalcolor = Color.OrangeRed;
            Home_btn.Textcolor = Color.White;
            bunifuFlatButton2.Textcolor = Color.White;
            bunifuFlatButton3.Textcolor = Color.OrangeRed;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form f = new Profile();
            f.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form f = new ChangePass();
            f.ShowDialog();
        }
    }
}
