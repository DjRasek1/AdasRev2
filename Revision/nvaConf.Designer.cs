namespace WindowsFormsApplication1
{
    partial class nvaConf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nvaConf));
            this.dgConfig = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btOk = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btDn = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConfig
            // 
            this.dgConfig.AllowUserToAddRows = false;
            this.dgConfig.AllowUserToDeleteRows = false;
            this.dgConfig.AllowUserToResizeColumns = false;
            this.dgConfig.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2});
            this.dgConfig.Location = new System.Drawing.Point(12, 12);
            this.dgConfig.MultiSelect = false;
            this.dgConfig.Name = "dgConfig";
            this.dgConfig.ReadOnly = true;
            this.dgConfig.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgConfig.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConfig.Size = new System.Drawing.Size(379, 334);
            this.dgConfig.TabIndex = 0;
            // 
            // Col1
            // 
            this.Col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col1.HeaderText = "Siglas";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col2.HeaderText = "Ruta";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // btOk
            // 
            this.btOk.Enabled = false;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(397, 323);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(110, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "Guardar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Lime;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(397, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(110, 51);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Agregar Estación";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Red;
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(397, 69);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(110, 51);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Eliminar Estación";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btDn
            // 
            this.btDn.Image = ((System.Drawing.Image)(resources.GetObject("btDn.Image")));
            this.btDn.Location = new System.Drawing.Point(457, 126);
            this.btDn.Name = "btDn";
            this.btDn.Size = new System.Drawing.Size(50, 49);
            this.btDn.TabIndex = 2;
            this.btDn.UseVisualStyleBackColor = true;
            this.btDn.Click += new System.EventHandler(this.btDn_Click);
            // 
            // btUp
            // 
            this.btUp.Image = ((System.Drawing.Image)(resources.GetObject("btUp.Image")));
            this.btUp.Location = new System.Drawing.Point(397, 126);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(54, 49);
            this.btUp.TabIndex = 1;
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // nvaConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 360);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btDn);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.dgConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nvaConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Estaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDn;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dgConfig;
        private System.Windows.Forms.Button btDel;
    }
}