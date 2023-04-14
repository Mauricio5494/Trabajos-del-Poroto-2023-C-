using System;
using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }

        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            if (rdOpcion2P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Bueno, si. Se dice que la temperatura para sentir bien el sabor del mate\n sin quemarte y sin que pierda \"Propiedades\" es de 40°C.");
            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            this.Hide();
            Form8 mostrar = new Form8();
            mostrar.Show();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
