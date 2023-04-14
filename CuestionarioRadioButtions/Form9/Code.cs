using System;
using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }

        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            if (rdOpcion1P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Correcto, un tomo del manga de Chainsaw-man posee 8 capíutlos.", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            this.Hide();
            Form10 mostrar = new Form10();
            mostrar.Show();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
