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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void BtnSig_Click(object sender, EventArgs e)
        {
            // "if" en cascada, para hacer la operacion del puntaje y mostrar los resultados, este
            // codigo se repite en las siguientes 9 forms
            // esta acompañado del codigo para abrir otro form, en este caso el form de la pregunta siguiente
            if (rB1.Checked == true)
                Form2.Resultado += 6;
            if (rB2.Checked == true)
                Form2.Resultado += 4;
            if (rB3.Checked == true)
                Form2.Resultado += 7;
            if (rB4.Checked == true)
                Form2.Resultado += 2;
            if (rB5.Checked == true)
                Form2.Resultado += 1;

            Form4 form4a = new Form4();
            form4a.Show();
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
