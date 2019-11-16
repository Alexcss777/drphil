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
    public partial class Form2 : Form
    {
        public static int Resultado = 0;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void BtnSig_Click(object sender, EventArgs e)
        {
             // "if" en cascada, para hacer la operacion del puntaje y mostrar los resultados, este
             // codigo se repite en las siguientes 9 forms
             // esta acompañado del codigo para abrir otro form, en este caso el form de la pregunta siguiente
            if (rB1.Checked == true)
                Resultado += 2;
                btnSig.Visible = true;
            if (rB2.Checked == true)
                Resultado += 4;
                btnSig.Visible = true;
            if (rB3.Checked == true)
                Resultado += 6;
                btnSig.Visible = true;

            Form3 form3a = new Form3();
            form3a.Show();
            this.Close();                                        
        }

        //este evento de los radio button hace visible el boton para continuar

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
