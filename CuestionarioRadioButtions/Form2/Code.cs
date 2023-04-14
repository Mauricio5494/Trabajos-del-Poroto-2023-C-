using System.Windows.Forms;

namespace CuestionarioRadioButtons
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labRespuestaCorrectaContador.Text = VariableUniversal.Variables.respuestaCorrecta.ToString();
        }

        private void btnEnviarRespuesta_Click(object sender, System.EventArgs e)
        {
            if (rdOpcion3P1.Checked)
            {
                VariableUniversal.Variables.respuestaCorrecta++;
                MessageBox.Show("Exactamente, la guitrra clásica solo posee 6 cuerdas, 3 de metal y 3 de tanza con esta configuración predeterminada:\nE, A, D, G, B, E.", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                VariableUniversal.Variables.respuestaIncorrecta++;
            }

            this.Hide();
            Form3 mostrear = new Form3();
            mostrear.ShowDialog();
        }

        private void btnReiniciar_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
