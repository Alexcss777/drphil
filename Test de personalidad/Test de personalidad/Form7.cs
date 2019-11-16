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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (rB1.Checked == true)
                Form2.Resultado += 6;
            if (rB2.Checked == true)
                Form2.Resultado += 4;
            if (rB3.Checked == true)
                Form2.Resultado += 2;
            
            Form8 form8a = new Form8();
            form8a.Show();
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
    }
}
