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
    public partial class ChangePass : Form
    {
        int i = 0;
        public ChangePass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox4.isPassword = true;
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox5.isPassword = true;   
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                bunifuMaterialTextbox4.isPassword = false;
            }
            else
            {
                bunifuMaterialTextbox4.isPassword = true;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
