namespace pryRodriguezBDNeptuno
{
    partial class frmMain
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcFiltro = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBase = new System.Windows.Forms.Button();
            this.btnVerTablas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.mrcFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Compañia,
            this.Contacto,
            this.Cargo,
            this.Direccion,
            this.Ciudad,
            this.Region,
            this.CodigoPostal,
            this.Pais,
            this.Telefono,
            this.Fax});
            this.dgvClientes.Location = new System.Drawing.Point(15, 228);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(523, 248);
            this.dgvClientes.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Id Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 125;
            // 
            // Compañia
            // 
            this.Compañia.HeaderText = "Nombre Compañia";
            this.Compañia.MinimumWidth = 6;
            this.Compañia.Name = "Compañia";
            this.Compañia.Width = 125;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Nombre del contacto";
            this.Contacto.MinimumWidth = 6;
            this.Contacto.Name = "Contacto";
            this.Contacto.Width = 125;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo del contacto";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 125;
            // 
            // Region
            // 
            this.Region.HeaderText = "Region";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.Width = 125;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.HeaderText = "Codigo Pòstal";
            this.CodigoPostal.MinimumWidth = 6;
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Width = 125;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.MinimumWidth = 6;
            this.Pais.Name = "Pais";
            this.Pais.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Fax
            // 
            this.Fax.HeaderText = "Fax";
            this.Fax.MinimumWidth = 6;
            this.Fax.Name = "Fax";
            this.Fax.Width = 125;
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseDatos.Location = new System.Drawing.Point(239, 9);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(192, 31);
            this.lblBaseDatos.TabIndex = 1;
            this.lblBaseDatos.Text = "Base de Datos";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(15, 106);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(101, 34);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(9, 406);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(15, 57);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(101, 35);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(555, 490);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // mrcFiltro
            // 
            this.mrcFiltro.Controls.Add(this.comboBox2);
            this.mrcFiltro.Controls.Add(this.lblPais);
            this.mrcFiltro.Controls.Add(this.comboBox1);
            this.mrcFiltro.Controls.Add(this.lblCiudad);
            this.mrcFiltro.Location = new System.Drawing.Point(15, 145);
            this.mrcFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcFiltro.Name = "mrcFiltro";
            this.mrcFiltro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcFiltro.Size = new System.Drawing.Size(523, 76);
            this.mrcFiltro.TabIndex = 6;
            this.mrcFiltro.TabStop = false;
            this.mrcFiltro.Text = "Filtrar por";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(71, 34);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(4, 35);
            this.lblPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 20);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "Pais";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(323, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(243, 35);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(59, 20);
            this.lblCiudad.TabIndex = 0;
            this.lblCiudad.Text = "Ciudad";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(15, 499);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(75, 23);
            this.btnBase.TabIndex = 7;
            this.btnBase.Text = "Elegir Base";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnVerTablas
            // 
            this.btnVerTablas.Location = new System.Drawing.Point(160, 498);
            this.btnVerTablas.Name = "btnVerTablas";
            this.btnVerTablas.Size = new System.Drawing.Size(75, 23);
            this.btnVerTablas.TabIndex = 8;
            this.btnVerTablas.Text = "Ver tablas";
            this.btnVerTablas.UseVisualStyleBackColor = true;
            this.btnVerTablas.Click += new System.EventHandler(this.btnVerTablas_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 525);
            this.Controls.Add(this.btnVerTablas);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.mrcFiltro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblBaseDatos);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.mrcFiltro.ResumeLayout(false);
            this.mrcFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.GroupBox mrcFiltro;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btnVerTablas;
    }
}