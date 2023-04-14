using System;
using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }

        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            if (rdOpcion2P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Exactamente, Neuro Sama, al recibir una pregunta de su chat acerca del tema, negó el holocausto diciendo \n \"No, no creo que el Holocausto haya sucedido de verdad\" " +
                    "\n Obviamente al ser una Inteligencia Artificial, no lo dijo como discurso de Odio \n ni nada parecido, ya que fue creada para Socializar y dar opiniones basadas en su propio aprendizaje del mundo y su visual del mismo.", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            this.Hide();
            Form4 mostrar = new Form4();
            mostrar.Show();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
