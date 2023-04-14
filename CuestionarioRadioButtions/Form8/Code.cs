using System;
using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }

        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            if (rdOpcion3P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Es que, a esta altura del partido ya no se me ocurren preguntas interesantes...", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            this.Hide();
            Form9 mostrar = new Form9();
            mostrar.Show();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
