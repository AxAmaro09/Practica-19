namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calificacion1 = double.Parse(textBox1.Text);
            double calificacion2 = double.Parse(textBox2.Text);
            double calificacion3 = double.Parse(textBox3.Text);
            double calificacion4 = double.Parse(textBox4.Text);

            // Calificación mínima requerida en cada examen
            double calificacionMinima = 6.0;

            // Calcula el promedio de las calificaciones
            double promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4) / 4.0;

            // Verifica si el promedio es mayor o igual a 6.0 y si todas las calificaciones individuales son mayores o iguales a 6.0
            if (promedio >= calificacionMinima && calificacion1 >= calificacionMinima && calificacion2 >= calificacionMinima && calificacion3 >= calificacionMinima && calificacion4 >= calificacionMinima)
            {
                MessageBox.Show("El alumno está aprobado.");
            }
            else
            {
                MessageBox.Show("El alumno está reprobado.");
            }
        }
    }
}