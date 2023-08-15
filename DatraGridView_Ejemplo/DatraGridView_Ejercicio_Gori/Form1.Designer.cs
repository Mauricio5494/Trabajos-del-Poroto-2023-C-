namespace DatraGridView_Ejercicio_Gori
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labResponsable = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtResposable = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.labFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.chbPrioridad = new System.Windows.Forms.ComboBox();
            this.c1_Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4_Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1_Responsable,
            this.c2_Descripcion,
            this.c3_Fecha,
            this.c4_Prioridad});
            this.dgv.Location = new System.Drawing.Point(29, 191);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(562, 247);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(102, 153);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labResponsable
            // 
            this.labResponsable.AutoSize = true;
            this.labResponsable.Location = new System.Drawing.Point(26, 33);
            this.labResponsable.Name = "labResponsable";
            this.labResponsable.Size = new System.Drawing.Size(69, 13);
            this.labResponsable.TabIndex = 3;
            this.labResponsable.Text = "Responsable";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Location = new System.Drawing.Point(410, 153);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(114, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar Tarea";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResposable
            // 
            this.txtResposable.Location = new System.Drawing.Point(102, 30);
            this.txtResposable.Name = "txtResposable";
            this.txtResposable.Size = new System.Drawing.Size(121, 20);
            this.txtResposable.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(102, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(239, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Location = new System.Drawing.Point(26, 63);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labDescripcion.TabIndex = 9;
            this.labDescripcion.Text = "Descripción";
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Location = new System.Drawing.Point(27, 90);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(37, 13);
            this.labFecha.TabIndex = 10;
            this.labFecha.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prioridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(101, 84);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(122, 20);
            this.dateFecha.TabIndex = 13;
            this.dateFecha.Value = new System.DateTime(2023, 8, 14, 0, 0, 0, 0);
            // 
            // chbPrioridad
            // 
            this.chbPrioridad.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbPrioridad.FormattingEnabled = true;
            this.chbPrioridad.Items.AddRange(new object[] {
            "Inexistente",
            "Baja",
            "Media",
            "Alta",
            "Máxima"});
            this.chbPrioridad.Location = new System.Drawing.Point(102, 110);
            this.chbPrioridad.Name = "chbPrioridad";
            this.chbPrioridad.Size = new System.Drawing.Size(121, 21);
            this.chbPrioridad.TabIndex = 14;
            // 
            // c1_Responsable
            // 
            this.c1_Responsable.HeaderText = "Responsable";
            this.c1_Responsable.Name = "c1_Responsable";
            this.c1_Responsable.ReadOnly = true;
            // 
            // c2_Descripcion
            // 
            this.c2_Descripcion.HeaderText = "Descricpion (Breve)";
            this.c2_Descripcion.Name = "c2_Descripcion";
            this.c2_Descripcion.ReadOnly = true;
            this.c2_Descripcion.Width = 220;
            // 
            // c3_Fecha
            // 
            this.c3_Fecha.HeaderText = "Fecha";
            this.c3_Fecha.Name = "c3_Fecha";
            this.c3_Fecha.ReadOnly = true;
            // 
            // c4_Prioridad
            // 
            this.c4_Prioridad.HeaderText = "Prioridad";
            this.c4_Prioridad.Name = "c4_Prioridad";
            this.c4_Prioridad.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.chbPrioridad);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.labDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtResposable);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.labResponsable);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labResponsable;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtResposable;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.ComboBox chbPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1_Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4_Prioridad;
    }
}

