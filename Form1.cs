using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSISTEMAS_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Peso, Estatura, Calculo;

            Peso = Convert.ToDouble(textBox1.Text);
            Estatura = Convert.ToDouble(textBox2.Text);

            Calculo = (Peso/(Estatura*Estatura));
            if (Calculo <= 18.5)
            {
                MessageBox.Show("Tu indice de masa corporal es: " + Calculo + "y tienes Bajo peso");
            }
            else
            {
                if (Calculo > 18.5 && Calculo <= 24.9)
                {
                    MessageBox.Show("Tu indice de masa corporal es: " + Calculo + "y tienes peso normal");
                }
                else
                {
                    if (Calculo > 25.0 && Calculo <= 29.9)
                    {
                        MessageBox.Show("Tu indice de masa corporal es: " + Calculo + "y tienes SobrePeso");
                    }
                    else
                    {
                        MessageBox.Show("Tu indice de masa corporal es: " + Calculo + "y tiene Obesidad");
                    }
                }
            }

        }
    }
}
