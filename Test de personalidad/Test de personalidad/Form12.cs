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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            //Esta region es para orndenar los if
            #region if de las respuestas
            if (s2<21)
            {
                lbl6.Visible = true;
                lblTitle.Text = "Menos de 21 puntos"; // esto y lo que sigue en los otros if es para el titulo
            }

            if (s2>20 && s2<31)
            {
                lbl5.Visible = true;
                lblTitle.Text = "De 21 a 30 puntos";
            }

            if (s2 >30 && s2<41)
            {
                lbl4.Visible = true;
                lblTitle.Text = "De 31 a 40 puntos";
            }

            if (s2 >40 && s2<51)
            {
                lbl3.Visible = true;
                lblTitle.Text = "De 41 a 50 puntos";
            }

            if (s2 >50 && s2 <60)
            {
                lbl2.Visible = true;
                lblTitle.Text = "De 51 a 60 puntos";
            }

            if (s2 >= 60)
            {
                lbl1.Visible = true;
                lblTitle.Text = "Mas de 60 puntos";
            }
            lblPoints.Text ="Puntaje " + s; //esto es para hacer que el puntaje aparezca en pantalla
            #endregion 
        }

        public string s = Convert.ToString(Form2.Resultado); // convierte a cadena el puntaje obtenido en el test para poder escribirlo en pantalla
        public int s2 = Convert.ToInt32(Form2.Resultado); //casi lo mismo que el de arriba pero este es para facilitarme el uso de los if

        private void Button1_Click(object sender, EventArgs e)
        {
            //string s = Convert.ToString(Form2.Resultado);
            //lbl1.Text = s;
        }

        #region failxd
        private void Label1_Click(object sender, EventArgs e)
        {
            //error de click xd
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            //error de click xd
        }
        #endregion

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 form13a = new Form13();
            form13a.Show();
            this.Close();
        }
    }
}
