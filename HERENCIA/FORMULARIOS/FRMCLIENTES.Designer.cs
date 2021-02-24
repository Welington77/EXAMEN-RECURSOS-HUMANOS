
namespace FORMULARIOS
{
    partial class FRMCLIENTES
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
            this.GPBCliente = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.TxtCodigoPedido = new System.Windows.Forms.TextBox();
            this.TxtNumSegSoc = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.LblCodigoPedido = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNumSegSoc = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.TxtCedulaCliente = new System.Windows.Forms.TextBox();
            this.LblCedulaCliente = new System.Windows.Forms.Label();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULACLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPBCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCliente
            // 
            this.GPBCliente.Controls.Add(this.LblCedulaCliente);
            this.GPBCliente.Controls.Add(this.TxtCedulaCliente);
            this.GPBCliente.Controls.Add(this.BtnGuardar);
            this.GPBCliente.Controls.Add(this.CmbCategoria);
            this.GPBCliente.Controls.Add(this.CmbSexo);
            this.GPBCliente.Controls.Add(this.TxtCodigoPedido);
            this.GPBCliente.Controls.Add(this.TxtNumSegSoc);
            this.GPBCliente.Controls.Add(this.TxtNombres);
            this.GPBCliente.Controls.Add(this.TxtApMaterno);
            this.GPBCliente.Controls.Add(this.TxtApPaterno);
            this.GPBCliente.Controls.Add(this.LblCodigoPedido);
            this.GPBCliente.Controls.Add(this.LblCategoria);
            this.GPBCliente.Controls.Add(this.LblNumSegSoc);
            this.GPBCliente.Controls.Add(this.LblSexo);
            this.GPBCliente.Controls.Add(this.LblNombres);
            this.GPBCliente.Controls.Add(this.LblApMaterno);
            this.GPBCliente.Controls.Add(this.LblApPaterno);
            this.GPBCliente.Location = new System.Drawing.Point(4, 9);
            this.GPBCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPBCliente.Name = "GPBCliente";
            this.GPBCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPBCliente.Size = new System.Drawing.Size(1260, 219);
            this.GPBCliente.TabIndex = 0;
            this.GPBCliente.TabStop = false;
            this.GPBCliente.Text = "Cliente";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGuardar.Location = new System.Drawing.Point(951, 136);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(139, 68);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Items.AddRange(new object[] {
            "NUEVO",
            "ANTIGUO"});
            this.CmbCategoria.Location = new System.Drawing.Point(273, 179);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(149, 34);
            this.CmbCategoria.TabIndex = 14;
            this.CmbCategoria.Text = "NUEVO";
            // 
            // CmbSexo
            // 
            this.CmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(869, 80);
            this.CmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(184, 38);
            this.CmbSexo.TabIndex = 13;
            this.CmbSexo.Text = "MASCULINO";
            // 
            // TxtCodigoPedido
            // 
            this.TxtCodigoPedido.Location = new System.Drawing.Point(686, 181);
            this.TxtCodigoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodigoPedido.Name = "TxtCodigoPedido";
            this.TxtCodigoPedido.Size = new System.Drawing.Size(201, 32);
            this.TxtCodigoPedido.TabIndex = 12;
            // 
            // TxtNumSegSoc
            // 
            this.TxtNumSegSoc.Location = new System.Drawing.Point(10, 172);
            this.TxtNumSegSoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNumSegSoc.Name = "TxtNumSegSoc";
            this.TxtNumSegSoc.Size = new System.Drawing.Size(209, 32);
            this.TxtNumSegSoc.TabIndex = 11;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(393, 80);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(461, 32);
            this.TxtNombres.TabIndex = 10;
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Location = new System.Drawing.Point(202, 80);
            this.TxtApMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(174, 32);
            this.TxtApMaterno.TabIndex = 9;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(10, 80);
            this.TxtApPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(163, 32);
            this.TxtApPaterno.TabIndex = 8;
            // 
            // LblCodigoPedido
            // 
            this.LblCodigoPedido.AutoSize = true;
            this.LblCodigoPedido.Location = new System.Drawing.Point(682, 136);
            this.LblCodigoPedido.Name = "LblCodigoPedido";
            this.LblCodigoPedido.Size = new System.Drawing.Size(187, 26);
            this.LblCodigoPedido.TabIndex = 7;
            this.LblCodigoPedido.Text = "Código del pedido";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(282, 136);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(106, 26);
            this.LblCategoria.TabIndex = 6;
            this.LblCategoria.Text = "Categoría";
            // 
            // LblNumSegSoc
            // 
            this.LblNumSegSoc.AutoSize = true;
            this.LblNumSegSoc.Location = new System.Drawing.Point(7, 136);
            this.LblNumSegSoc.Name = "LblNumSegSoc";
            this.LblNumSegSoc.Size = new System.Drawing.Size(265, 26);
            this.LblNumSegSoc.TabIndex = 5;
            this.LblNumSegSoc.Text = "Número del seguro social ";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(922, 36);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(62, 26);
            this.LblSexo.TabIndex = 4;
            this.LblSexo.Text = "Sexo";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(397, 36);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(101, 26);
            this.LblNombres.TabIndex = 3;
            this.LblNombres.Text = "Nombres";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(198, 36);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(176, 26);
            this.LblApMaterno.TabIndex = 1;
            this.LblApMaterno.Text = "Apellido materno";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(7, 36);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(169, 26);
            this.LblApPaterno.TabIndex = 0;
            this.LblApPaterno.Text = "Apellido paterno";
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.NUMSEGSOC,
            this.CATEGORIA,
            this.CEDULACLIENTE,
            this.CODIGOPEDIDO});
            this.DGVClientes.Location = new System.Drawing.Point(4, 235);
            this.DGVClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.RowHeadersWidth = 62;
            this.DGVClientes.RowTemplate.Height = 28;
            this.DGVClientes.Size = new System.Drawing.Size(1260, 302);
            this.DGVClientes.TabIndex = 1;
            // 
            // TxtCedulaCliente
            // 
            this.TxtCedulaCliente.Location = new System.Drawing.Point(426, 180);
            this.TxtCedulaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCedulaCliente.Name = "TxtCedulaCliente";
            this.TxtCedulaCliente.Size = new System.Drawing.Size(239, 32);
            this.TxtCedulaCliente.TabIndex = 16;
            // 
            // LblCedulaCliente
            // 
            this.LblCedulaCliente.AutoSize = true;
            this.LblCedulaCliente.Location = new System.Drawing.Point(442, 136);
            this.LblCedulaCliente.Name = "LblCedulaCliente";
            this.LblCedulaCliente.Size = new System.Drawing.Size(81, 26);
            this.LblCedulaCliente.TabIndex = 17;
            this.LblCedulaCliente.Text = "Cedula";
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 8;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 150;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 8;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 150;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 8;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 310;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 8;
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 120;
            // 
            // NUMSEGSOC
            // 
            this.NUMSEGSOC.HeaderText = "NÚMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOC.MinimumWidth = 8;
            this.NUMSEGSOC.Name = "NUMSEGSOC";
            this.NUMSEGSOC.Width = 180;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORÍA";
            this.CATEGORIA.MinimumWidth = 8;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.Width = 160;
            // 
            // CEDULACLIENTE
            // 
            this.CEDULACLIENTE.HeaderText = "CEDULA";
            this.CEDULACLIENTE.MinimumWidth = 8;
            this.CEDULACLIENTE.Name = "CEDULACLIENTE";
            this.CEDULACLIENTE.Width = 150;
            // 
            // CODIGOPEDIDO
            // 
            this.CODIGOPEDIDO.HeaderText = "CODIGO DEL PEDIDO";
            this.CODIGOPEDIDO.MinimumWidth = 8;
            this.CODIGOPEDIDO.Name = "CODIGOPEDIDO";
            this.CODIGOPEDIDO.Width = 200;
            // 
            // FRMCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(235)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1667, 910);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.GPBCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMCLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GPBCliente.ResumeLayout(false);
            this.GPBCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.Windows.Forms.Label LblCodigoPedido;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNumSegSoc;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtCodigoPedido;
        private System.Windows.Forms.TextBox TxtNumSegSoc;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblCedulaCliente;
        private System.Windows.Forms.TextBox TxtCedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULACLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPEDIDO;
    }
}