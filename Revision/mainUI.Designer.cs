namespace WindowsFormsApplication1
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Estacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fInic = new System.Windows.Forms.DateTimePicker();
            this.cbSelec = new System.Windows.Forms.ComboBox();
            this.estSelec = new System.Windows.Forms.RadioButton();
            this.estTodas = new System.Windows.Forms.RadioButton();
            this.lbProgreso = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.fFin = new System.Windows.Forms.DateTimePicker();
            this.btList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.PictureBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pbLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estacion,
            this.Fecha,
            this.Hora,
            this.Codigo,
            this.Contrato});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(536, 405);
            this.dataGridView1.TabIndex = 2;
            // 
            // Estacion
            // 
            this.Estacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Estacion.HeaderText = "Estacion";
            this.Estacion.Name = "Estacion";
            this.Estacion.ReadOnly = true;
            this.Estacion.Width = 104;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Contrato
            // 
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.ReadOnly = true;
            // 
            // fInic
            // 
            this.fInic.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fInic.CalendarForeColor = System.Drawing.Color.Black;
            this.fInic.CalendarMonthBackground = System.Drawing.Color.White;
            this.fInic.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.fInic.CalendarTitleForeColor = System.Drawing.Color.White;
            this.fInic.Checked = false;
            this.fInic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fInic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fInic.Location = new System.Drawing.Point(57, 97);
            this.fInic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fInic.Name = "fInic";
            this.fInic.Size = new System.Drawing.Size(96, 22);
            this.fInic.TabIndex = 1;
            // 
            // cbSelec
            // 
            this.cbSelec.BackColor = System.Drawing.Color.White;
            this.cbSelec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelec.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbSelec.FormattingEnabled = true;
            this.cbSelec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSelec.Location = new System.Drawing.Point(319, 107);
            this.cbSelec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbSelec.Name = "cbSelec";
            this.cbSelec.Size = new System.Drawing.Size(143, 24);
            this.cbSelec.TabIndex = 2;
            this.cbSelec.Visible = false;
            // 
            // estSelec
            // 
            this.estSelec.AutoSize = true;
            this.estSelec.BackColor = System.Drawing.Color.Transparent;
            this.estSelec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estSelec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(189)))), ((int)(((byte)(60)))));
            this.estSelec.Location = new System.Drawing.Point(371, 86);
            this.estSelec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.estSelec.Name = "estSelec";
            this.estSelec.Size = new System.Drawing.Size(100, 19);
            this.estSelec.TabIndex = 4;
            this.estSelec.Text = "                         ";
            this.estSelec.UseVisualStyleBackColor = false;
            this.estSelec.CheckedChanged += new System.EventHandler(this.EstSelec_CheckedChanged);
            // 
            // estTodas
            // 
            this.estTodas.AutoSize = true;
            this.estTodas.BackColor = System.Drawing.Color.Transparent;
            this.estTodas.Checked = true;
            this.estTodas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estTodas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(189)))), ((int)(((byte)(60)))));
            this.estTodas.Location = new System.Drawing.Point(308, 86);
            this.estTodas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.estTodas.Name = "estTodas";
            this.estTodas.Size = new System.Drawing.Size(61, 19);
            this.estTodas.TabIndex = 3;
            this.estTodas.TabStop = true;
            this.estTodas.Text = "            ";
            this.estTodas.UseVisualStyleBackColor = false;
            this.estTodas.CheckedChanged += new System.EventHandler(this.EstTodas_CheckedChanged);
            // 
            // lbProgreso
            // 
            this.lbProgreso.AutoSize = true;
            this.lbProgreso.BackColor = System.Drawing.Color.White;
            this.lbProgreso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.lbProgreso.Location = new System.Drawing.Point(292, 575);
            this.lbProgreso.Name = "lbProgreso";
            this.lbProgreso.Size = new System.Drawing.Size(89, 18);
            this.lbProgreso.TabIndex = 9;
            this.lbProgreso.Text = "Progreso";
            this.lbProgreso.Visible = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.White;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(598, 517);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(41, 48);
            this.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConfig.TabIndex = 13;
            this.btnConfig.TabStop = false;
            this.btnConfig.Click += new System.EventHandler(this.ConfiguracionToolStripMenuItem_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::WindowsFormsApplication1.Properties.Resources.BorradorIco;
            this.btnAbout.Location = new System.Drawing.Point(645, 517);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(43, 48);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAbout.TabIndex = 14;
            this.btnAbout.TabStop = false;
            this.btnAbout.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(658, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 38);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // fFin
            // 
            this.fFin.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fFin.CalendarForeColor = System.Drawing.Color.Black;
            this.fFin.CalendarMonthBackground = System.Drawing.Color.White;
            this.fFin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.fFin.Checked = false;
            this.fFin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fFin.Location = new System.Drawing.Point(180, 97);
            this.fFin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fFin.Name = "fFin";
            this.fFin.Size = new System.Drawing.Size(96, 22);
            this.fFin.TabIndex = 2;
            // 
            // btList
            // 
            this.btList.BackColor = System.Drawing.Color.White;
            this.btList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btList.ForeColor = System.Drawing.Color.White;
            this.btList.Image = ((System.Drawing.Image)(resources.GetObject("btList.Image")));
            this.btList.Location = new System.Drawing.Point(598, 272);
            this.btList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(90, 90);
            this.btList.TabIndex = 6;
            this.btList.UseVisualStyleBackColor = false;
            this.btList.Click += new System.EventHandler(this.BtList_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(598, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtRev_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(502, 56);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(186, 75);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 17;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitch.Image = global::WindowsFormsApplication1.Properties.Resources.btnCom;
            this.btnSwitch.Location = new System.Drawing.Point(598, 383);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(90, 90);
            this.btnSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSwitch.TabIndex = 18;
            this.btnSwitch.TabStop = false;
            this.btnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // pbLoader
            // 
            this.pbLoader.Image = global::WindowsFormsApplication1.Properties.Resources.ajax_loader_1_;
            this.pbLoader.Location = new System.Drawing.Point(53, 571);
            this.pbLoader.Name = "pbLoader";
            this.pbLoader.Size = new System.Drawing.Size(233, 22);
            this.pbLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoader.TabIndex = 19;
            this.pbLoader.TabStop = false;
            this.pbLoader.Visible = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 604);
            this.Controls.Add(this.pbLoader);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fFin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.estSelec);
            this.Controls.Add(this.estTodas);
            this.Controls.Add(this.fInic);
            this.Controls.Add(this.cbSelec);
            this.Controls.Add(this.lbProgreso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revision de Audios";
            this.TransparencyKey = System.Drawing.Color.YellowGreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fInic;
        private System.Windows.Forms.RadioButton estSelec;
        private System.Windows.Forms.RadioButton estTodas;
        private System.Windows.Forms.Label lbProgreso;
        public System.Windows.Forms.ComboBox cbSelec;
        private System.Windows.Forms.PictureBox btnAbout;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DateTimePicker fFin;
        private System.Windows.Forms.Button btList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox btnSwitch;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.PictureBox pbLoader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.PictureBox btnConfig;
    }
}

