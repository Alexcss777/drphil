using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_de_personalidad
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void BtnSig_Click(object sender, EventArgs e)
        {
            if (rB1.Checked == true)
                Form2.Resultado += 7;
            if (rB2.Checked == true)
                Form2.Resultado += 6;
            if (rB3.Checked == true)
                Form2.Resultado += 4;
            if (rB4.Checked == true)
                Form2.Resultado += 2;
            if (rB5.Checked == true)
                Form2.Resultado += 1;
           
            Form11 form11a = new Form11();
            form11a.Show();
            this.Close();
        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            btnSig.Visible = true;
        }

        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            btnSig.Visible = true;
        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {
            btnSig.Visible = true;
        }

        private void RB4_CheckedChanged(object sender, EventArgs e)
        {
            btnSig.Visible = true;
        }

        private void RB5_CheckedChanged(object sender, EventArgs e)
        {
            btnSig.Visible = true;
        }
    }
}
