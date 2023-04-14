namespace CuestionarioRadioButtons
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnviarRespuesta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdOpcion1P1 = new System.Windows.Forms.RadioButton();
            this.rdOpcion2P1 = new System.Windows.Forms.RadioButton();
            this.rdOpcion3P1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviarRespuesta
            // 
            this.btnEnviarRespuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEnviarRespuesta, "btnEnviarRespuesta");
            this.btnEnviarRespuesta.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnEnviarRespuesta.Name = "btnEnviarRespuesta";
            this.btnEnviarRespuesta.UseVisualStyleBackColor = true;
            this.btnEnviarRespuesta.Click += new System.EventHandler(this.btnEnviarRespuesta_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rdOpcion1P1
            // 
            resources.ApplyResources(this.rdOpcion1P1, "rdOpcion1P1");
            this.rdOpcion1P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdOpcion1P1.Name = "rdOpcion1P1";
            this.rdOpcion1P1.TabStop = true;
            this.rdOpcion1P1.UseVisualStyleBackColor = true;
            // 
            // rdOpcion2P1
            // 
            resources.ApplyResources(this.rdOpcion2P1, "rdOpcion2P1");
            this.rdOpcion2P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdOpcion2P1.Name = "rdOpcion2P1";
            this.rdOpcion2P1.TabStop = true;
            this.rdOpcion2P1.UseVisualStyleBackColor = true;
            // 
            // rdOpcion3P1
            // 
            resources.ApplyResources(this.rdOpcion3P1, "rdOpcion3P1");
            this.rdOpcion3P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdOpcion3P1.Name = "rdOpcion3P1";
            this.rdOpcion3P1.TabStop = true;
            this.rdOpcion3P1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdOpcion1P1);
            this.groupBox1.Controls.Add(this.rdOpcion3P1);
            this.groupBox1.Controls.Add(this.rdOpcion2P1);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnReiniciar, "btnReiniciar");
            this.btnReiniciar.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarRespuesta);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarRespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdOpcion1P1;
        private System.Windows.Forms.RadioButton rdOpcion2P1;
        private System.Windows.Forms.RadioButton rdOpcion3P1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

