namespace WindowsFormsApplication1
{
    partial class NvaEst
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NvaEst));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSiglas = new System.Windows.Forms.TextBox();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.btFbdial = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fbDial1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siglas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta:";
            // 
            // tbSiglas
            // 
            this.tbSiglas.Location = new System.Drawing.Point(81, 34);
            this.tbSiglas.Name = "tbSiglas";
            this.tbSiglas.Size = new System.Drawing.Size(100, 20);
            this.tbSiglas.TabIndex = 2;
            // 
            // tbRuta
            // 
            this.tbRuta.Location = new System.Drawing.Point(81, 71);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.ReadOnly = true;
            this.tbRuta.Size = new System.Drawing.Size(147, 20);
            this.tbRuta.TabIndex = 3;
            this.tbRuta.TabStop = false;
            // 
            // btFbdial
            // 
            this.btFbdial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFbdial.Location = new System.Drawing.Point(246, 69);
            this.btFbdial.Name = "btFbdial";
            this.btFbdial.Size = new System.Drawing.Size(34, 23);
            this.btFbdial.TabIndex = 4;
            this.btFbdial.Text = "...";
            this.btFbdial.UseVisualStyleBackColor = true;
            this.btFbdial.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(106, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fbDial1
            // 
            this.fbDial1.ShowNewFolderButton = false;
            // 
            // NvaEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 143);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btFbdial);
            this.Controls.Add(this.tbRuta);
            this.Controls.Add(this.tbSiglas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NvaEst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nueva Estacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFbdial;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox tbSiglas;
        public System.Windows.Forms.TextBox tbRuta;
        private System.Windows.Forms.FolderBrowserDialog fbDial1;
    }
}