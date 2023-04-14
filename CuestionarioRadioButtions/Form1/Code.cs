using System;
using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {

            if (rdOpcion2P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Si, un termo de aluminio común y corriente lleva un litro...\n aunque últimamente estoy sospechando de que lleva 900ml", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //¿Y porqué 2 variables y no una? Es mi programa, yo decido mis variables >:(
                // (Saqué la información de la viariable universal por StackOverflow, semejante página para programadores es).
                VariableUniversal.Variables.respuestaIncorrecta++;
            }
            this.Hide();
            Form2 mostrar = new Form2();
            mostrar.Show();

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Reglas:\n\n1) Las respuestas Correctas mostrarán un mensaje con información, si respondes mal, lo sabrás.\n2) Tienes que conseguir mínimo 6 respuestas correctas para Supera la Prueba.\n\nY eso sería todo, Disfruta respondiendo preguntas.", "Reglas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
