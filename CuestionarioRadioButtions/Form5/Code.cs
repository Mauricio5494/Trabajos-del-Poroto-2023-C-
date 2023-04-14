using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            rdOpcion1P1.Text = "Lain es una adolecente que se aventura en un mundo mágico dónde pasan ciertos acontecimientos que la llevan a enfrentarse al mismísimo Rey Demonio.";

            rdOpcion3P1.Text = "La trama de este anime se basa en un grupo de 4 estudiantes dónde Lain Iwakura como protagonista \nprincipal de la serie, esta se sumerge totalmente en la Red (Layer), \ncon el paso del tiempo se va dando cuenta que en \nrealidad toda su vida ha sido una distopía.";

            rdOpcion2P1.Text = "es un anime psicológico de ciencia ficción que sigue a una adolescente introvertida llamada Lain \nIwakura que se sumerge en el mundo de internet (Weird) y descubre verdades ocultas sobre la naturaleza de la realidad y la existencia humana.";

            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }



        private void btnEnviarRespuesta_Click(object sender, System.EventArgs e)
        {
            if (rdOpcion2P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Correcto, Lain se sumerge en el Internet (Weird) de ese mundo distópico \ny descubre verdades que, al usuario al ver tal anime no va a captar de primeras\n(Es Recomendable verlo por lo menos 2 veces para entencer bien) \n\nY no, yo no me lo vi más de una vez.", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            this.Hide();
            Form6 mostrar = new Form6();
            mostrar.Show();
        }

        private void btnReiniciar_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
