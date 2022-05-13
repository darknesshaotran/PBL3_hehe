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
    public partial class QL : Form
    {
        public QL()
        {
            InitializeComponent();
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           

        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
          
        }
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
        }

        private void bunifuGradientPanel1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void bunifuGradientPanel1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QL_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tab_Home;
            Home_btn.Textcolor = Color.OrangeRed;
            waiter_btn.Textcolor = Color.White;
            Item_btn.Textcolor = Color.White;
            doanhthu_btn.Textcolor= Color.White;
            

            
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabMenu;
            Home_btn.Textcolor = Color.White;
            waiter_btn.Textcolor = Color.White;
            Item_btn.Textcolor = Color.OrangeRed;
            doanhthu_btn.Textcolor = Color.White;

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabWaiter;
            Home_btn.Textcolor = Color.White;
            waiter_btn.Textcolor = Color.OrangeRed;
            Item_btn.Textcolor = Color.White;
            doanhthu_btn.Textcolor = Color.White;

        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRevenue;
            Home_btn.Textcolor = Color.White;
            waiter_btn.Textcolor = Color.White;
            Item_btn.Textcolor = Color.White;
            doanhthu_btn.Textcolor = Color.OrangeRed;
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form f = new ChangePass();
            f.ShowDialog();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            Form form = new Category();
            form.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form f = new Profile();
            f.ShowDialog();
        }
    }
}
