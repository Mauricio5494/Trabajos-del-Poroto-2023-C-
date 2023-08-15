using System;
using System.Windows.Forms;

namespace DatraGridView_Ejercicio_Gori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int n = 0;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtResposable.Text == "" || txtDescripcion.Text == "" || dateFecha.Text.Length == 0 || chbPrioridad.Items == null)
            {
                MessageBox.Show("Alguna de loso campos de textos u opciones no se han marcado.\nProcura llenar todos los campos","Por Favor!", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                int n = dgv.Rows.Add();
                dgv.Rows[n].Cells[0].Value = txtResposable.Text;
                dgv.Rows[n].Cells[1].Value = txtDescripcion.Text;
                dgv.Rows[n].Cells[2].Value = (string)dateFecha.Text;
                dgv.Rows[n].Cells[3].Value = (string)chbPrioridad.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dgv.Rows.RemoveAt(n);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //No, ya no... No queda tiempo.
        }
    }
}
