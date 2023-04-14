using System;
using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }

        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            if (rdOpcion2P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Es que, si el profe se va, se prende fuego la UTU de verdad, es importantísimo para la infraestructura de profesores el tenerlo presente dando clases todos los días \n\n Profe, si está leyendo esto, lo queremos un montón, por favor, quédese, lo necesitamos.", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdOpcion3P1.Checked)
            {
                MessageBox.Show("A mi también me gustan las empanadas... Pero no era la respuesta correcta!!", "Si pero No", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }

            if (VariableUniversal.Variables.respuestaCorrecta >= 6 && VariableUniversal.Variables.respuestaIncorrecta < 6)
            {
                MessageBox.Show("Haz Superado el Cuestionario!\n\n" + "Respuestas correctas: " + VariableUniversal.Variables.respuestaCorrecta.ToString() + "\n" + "Respuestas Incorrectas: " + VariableUniversal.Variables.respuestaIncorrecta.ToString(), "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (VariableUniversal.Variables.respuestaCorrecta < 6 && VariableUniversal.Variables.respuestaIncorrecta >= 6)
            {
                MessageBox.Show("Fallaste! Inténtalo de nuevo.\n\n" + "Respuestas correctas: " + VariableUniversal.Variables.respuestaCorrecta.ToString() + "\n" + "Respuestas Incorrectas: " + VariableUniversal.Variables.respuestaIncorrecta.ToString(), "Muy mal!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
