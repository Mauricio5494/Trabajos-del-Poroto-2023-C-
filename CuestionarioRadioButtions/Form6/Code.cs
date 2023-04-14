using System;
using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }

        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            if (rdOpcion1P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Excatamente, una por mi Madre\nY otra por mi Abuela", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            this.Hide();
            Form7 mostrar = new Form7();
            mostrar.Show();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
