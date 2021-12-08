namespace WindowsFormsApplication1
{
    partial class confMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfigUser = new System.Windows.Forms.Button();
            this.btnConfigEstacion = new System.Windows.Forms.Button();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfigUser);
            this.panel1.Controls.Add(this.btnConfigEstacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnConfigUser
            // 
            this.btnConfigUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfigUser.FlatAppearance.BorderSize = 0;
            this.btnConfigUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigUser.Font = new System.Drawing.Font("Futura Md BT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigUser.Location = new System.Drawing.Point(146, 32);
            this.btnConfigUser.Name = "btnConfigUser";
            this.btnConfigUser.Size = new System.Drawing.Size(147, 48);
            this.btnConfigUser.TabIndex = 1;
            this.btnConfigUser.Text = "Configuracion de Usuarios";
            this.btnConfigUser.UseVisualStyleBackColor = false;
            this.btnConfigUser.Click += new System.EventHandler(this.btnConfigUser_Click);
            // 
            // btnConfigEstacion
            // 
            this.btnConfigEstacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfigEstacion.FlatAppearance.BorderSize = 0;
            this.btnConfigEstacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigEstacion.Font = new System.Drawing.Font("Futura Md BT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigEstacion.Location = new System.Drawing.Point(0, 32);
            this.btnConfigEstacion.Name = "btnConfigEstacion";
            this.btnConfigEstacion.Size = new System.Drawing.Size(147, 48);
            this.btnConfigEstacion.TabIndex = 0;
            this.btnConfigEstacion.Text = "Configuracion de Estaciones";
            this.btnConfigEstacion.UseVisualStyleBackColor = false;
            this.btnConfigEstacion.Click += new System.EventHandler(this.btnConfigEstacion_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 80);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(530, 406);
            this.panelFormularios.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 53);
            this.panel3.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(425, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // confMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 486);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "confMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfigUser;
        private System.Windows.Forms.Button btnConfigEstacion;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
    }
}