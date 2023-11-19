using System.Xml.Schema;

namespace Práctica_02_U4
{
    public partial class Form1 : Form
    {
        //Declaración de variables de cantidad.
        int cantidadHam, cantHtdog, cantSánd, cantTé, cantRef, cantPap;

        double totVent, costoHam, costoHtdog, costoSánd, costoTé, costoRef, costoPap;

        //Iniciar las variables con el precio de los productos.

        double Ham = 20.5, Htdog = 19.25, Sánd = 17.5, Té = 5, Pap = 4.5, Ref = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Multiplicando la cantidad por el precio que vamos a usar y sumando el total
            costoHam = (cantidadHam * Ham);
            costoHtdog = (cantHtdog * Htdog);
            costoSánd = (cantSánd * Sánd);
            costoTé = (cantTé * Té);
            costoRef = (cantRef * Ref);
            costoPap = (cantPap * Pap);
            totVent = (costoHam + costoHtdog + costoSánd + costoTé + costoRef + costoPap);
            textBox7.Text = totVent.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete no 1 de comida.
            textBox7.Text = " ";
            if (checkBox1.Checked == true) 
            {
                cantidadHam = 1;
                cantRef = 1;
                cantPap = 1;
                cantTé = 0;
                cantSánd = 0;
                cantHtdog = 0;
                //Inicializar Valores
                textBox1.Text = cantidadHam.ToString();
                textBox5.Text = cantRef.ToString();
                textBox6.Text = cantPap.ToString();

                //Activar las cajas de texto del paquete
                textBox1.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;

                //Desactivar las otras cajas
                textBox4.Enabled = false;
                textBox3.Enabled = false;
                textBox2.Enabled = false;
                //Limpiar las cajas de texto
                textBox4.Text = " ";
                textBox3.Text = " ";
                textBox2.Text = " ";
            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete no 2 de comida.
            textBox7.Text = " ";
            if (checkBox2.Checked == true) 
            {

                cantRef = 1;
                cantPap = 1;
                cantSánd = 0;
                cantHtdog = 1;
                cantidadHam = 0;
                cantTé = 0;

                //Inicializar Valores
                textBox2.Text = cantHtdog.ToString();
                textBox5.Text = cantRef.ToString();
                textBox6.Text = cantPap.ToString();

                //Activar las cajas de texto del paquete
                textBox2.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;

                //Desactivar las otras cajas
                textBox4.Enabled = false;
                textBox3.Enabled = false;
                textBox1.Enabled = false;

                //Limpiar las cajas de texto

                textBox4.Text = " ";
                textBox3.Text = " ";
                textBox1.Text = " ";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete no 3 de comida.
            textBox7.Text = " ";
            if (checkBox3.Checked == true) 
            {

                cantRef = 1;
                cantPap = 1;
                cantSánd = 1;
                cantHtdog = 0;
                cantidadHam = 0;
                cantTé = 0;

                //Inicializar Valores
                textBox3.Text = cantSánd.ToString();
                textBox5.Text = cantRef.ToString();
                textBox6.Text = cantPap.ToString();

                //Activar las cajas de texto del paquete
                textBox3.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;

                //Desactivar las otras cajas
                textBox4.Enabled = false;
                textBox2.Enabled = false;
                textBox1.Enabled = false;

                //Limpiar las cajas de texto

                textBox4.Text = " ";
                textBox2.Text = " ";
                textBox1.Text = " ";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Opción otro pedido.
            textBox7.Text = " ";
            if (checkBox4.Checked == true)
            {

                //Habilitar todas las entradas
    
                textBox2.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox4.Enabled = true;
                textBox3.Enabled = true;
                textBox1.Enabled = true;


                double cantidadHam = int.Parse(textBox1.Text);
                double cantHtdog = int.Parse(textBox2.Text);
                double cantSánd = int.Parse(textBox3.Text);
                double cantTé = int.Parse(textBox4.Text);
                double cantRef = int.Parse(textBox5.Text);
                double cantPap = int.Parse(textBox6.Text);
                

            }
        }
    }
}