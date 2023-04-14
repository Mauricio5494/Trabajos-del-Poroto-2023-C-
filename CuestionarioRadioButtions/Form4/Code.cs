using System;
using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }

        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            if (rdOpcion3P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Si, aunque no solo lleva eso, pero en su mayoría si \nAlcohol isopropílico, se emplea normalmente porque seca rápido y no deja estragos en los componentes electrónicos", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            this.Hide();
            Form5 show = new Form5();
            show.Show();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
