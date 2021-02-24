
namespace FORMULARIOS
{
    partial class FRMEMPLEADOS
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
            this.GboEmpleados = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.CboTipoContrato = new System.Windows.Forms.ComboBox();
            this.CboTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.TxtNumSegSoc = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.LblTipoContrato = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblTipoEmpleado = new System.Windows.Forms.Label();
            this.LblNumSegSoc = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.DGVEMPLEADOS = new System.Windows.Forms.DataGridView();
            this.LblCedulaEmpleado = new System.Windows.Forms.Label();
            this.TxtCedulaEmpleado = new System.Windows.Forms.TextBox();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GboEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // GboEmpleados
            // 
            this.GboEmpleados.Controls.Add(this.TxtCedulaEmpleado);
            this.GboEmpleados.Controls.Add(this.LblCedulaEmpleado);
            this.GboEmpleados.Controls.Add(this.BtnGuardar);
            this.GboEmpleados.Controls.Add(this.CboSexo);
            this.GboEmpleados.Controls.Add(this.CboTipoContrato);
            this.GboEmpleados.Controls.Add(this.CboTipoEmpleado);
            this.GboEmpleados.Controls.Add(this.TxtNumSegSoc);
            this.GboEmpleados.Controls.Add(this.TxtNombres);
            this.GboEmpleados.Controls.Add(this.TxtApMaterno);
            this.GboEmpleados.Controls.Add(this.TxtApPaterno);
            this.GboEmpleados.Controls.Add(this.LblTipoContrato);
            this.GboEmpleados.Controls.Add(this.LblSexo);
            this.GboEmpleados.Controls.Add(this.LblTipoEmpleado);
            this.GboEmpleados.Controls.Add(this.LblNumSegSoc);
            this.GboEmpleados.Controls.Add(this.LblNombres);
            this.GboEmpleados.Controls.Add(this.LblApMaterno);
            this.GboEmpleados.Controls.Add(this.LblApPaterno);
            this.GboEmpleados.Location = new System.Drawing.Point(16, 15);
            this.GboEmpleados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GboEmpleados.Name = "GboEmpleados";
            this.GboEmpleados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GboEmpleados.Size = new System.Drawing.Size(1260, 250);
            this.GboEmpleados.TabIndex = 0;
            this.GboEmpleados.TabStop = false;
            this.GboEmpleados.Text = "EMPLEADOS";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(115)))));
            this.BtnGuardar.Location = new System.Drawing.Point(1054, 145);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 105);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CboSexo.Location = new System.Drawing.Point(999, 106);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(150, 33);
            this.CboSexo.TabIndex = 14;
            this.CboSexo.Text = "MASCULINO";
            // 
            // CboTipoContrato
            // 
            this.CboTipoContrato.FormattingEnabled = true;
            this.CboTipoContrato.Items.AddRange(new object[] {
            "NUEVO",
            "ANTIGUO"});
            this.CboTipoContrato.Location = new System.Drawing.Point(826, 193);
            this.CboTipoContrato.Name = "CboTipoContrato";
            this.CboTipoContrato.Size = new System.Drawing.Size(198, 33);
            this.CboTipoContrato.TabIndex = 13;
            this.CboTipoContrato.Text = "NUEVO";
            // 
            // CboTipoEmpleado
            // 
            this.CboTipoEmpleado.FormattingEnabled = true;
            this.CboTipoEmpleado.Items.AddRange(new object[] {
            "VENDEDOR",
            "GERENTE"});
            this.CboTipoEmpleado.Location = new System.Drawing.Point(567, 194);
            this.CboTipoEmpleado.Name = "CboTipoEmpleado";
            this.CboTipoEmpleado.Size = new System.Drawing.Size(195, 33);
            this.CboTipoEmpleado.TabIndex = 12;
            this.CboTipoEmpleado.Text = "VENDEDOR";
            // 
            // TxtNumSegSoc
            // 
            this.TxtNumSegSoc.Location = new System.Drawing.Point(26, 197);
            this.TxtNumSegSoc.Name = "TxtNumSegSoc";
            this.TxtNumSegSoc.Size = new System.Drawing.Size(249, 30);
            this.TxtNumSegSoc.TabIndex = 11;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(467, 109);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(430, 30);
            this.TxtNombres.TabIndex = 10;
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Location = new System.Drawing.Point(236, 109);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(192, 30);
            this.TxtApMaterno.TabIndex = 9;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(26, 109);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(175, 30);
            this.TxtApPaterno.TabIndex = 8;
            // 
            // LblTipoContrato
            // 
            this.LblTipoContrato.AutoSize = true;
            this.LblTipoContrato.Location = new System.Drawing.Point(821, 158);
            this.LblTipoContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipoContrato.Name = "LblTipoContrato";
            this.LblTipoContrato.Size = new System.Drawing.Size(158, 25);
            this.LblTipoContrato.TabIndex = 7;
            this.LblTipoContrato.Text = "Tipo de Contrato";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(994, 59);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(58, 25);
            this.LblSexo.TabIndex = 6;
            this.LblSexo.Text = "Sexo";
            // 
            // LblTipoEmpleado
            // 
            this.LblTipoEmpleado.AutoSize = true;
            this.LblTipoEmpleado.Location = new System.Drawing.Point(562, 158);
            this.LblTipoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipoEmpleado.Name = "LblTipoEmpleado";
            this.LblTipoEmpleado.Size = new System.Drawing.Size(171, 25);
            this.LblTipoEmpleado.TabIndex = 5;
            this.LblTipoEmpleado.Text = "Tipo de Empleado";
            // 
            // LblNumSegSoc
            // 
            this.LblNumSegSoc.AutoSize = true;
            this.LblNumSegSoc.Location = new System.Drawing.Point(21, 158);
            this.LblNumSegSoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumSegSoc.Name = "LblNumSegSoc";
            this.LblNumSegSoc.Size = new System.Drawing.Size(254, 25);
            this.LblNumSegSoc.TabIndex = 4;
            this.LblNumSegSoc.Text = "Número de seguridad social";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(463, 59);
            this.LblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(91, 25);
            this.LblNombres.TabIndex = 2;
            this.LblNombres.Text = "Nombres";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(232, 59);
            this.LblApMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(158, 25);
            this.LblApMaterno.TabIndex = 1;
            this.LblApMaterno.Text = "Apellido materno";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(21, 59);
            this.LblApPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(155, 25);
            this.LblApPaterno.TabIndex = 0;
            this.LblApPaterno.Text = "Apellido Paterno";
            // 
            // DGVEMPLEADOS
            // 
            this.DGVEMPLEADOS.AllowUserToAddRows = false;
            this.DGVEMPLEADOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.DGVEMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.NUMSEGSOC,
            this.CEDULA,
            this.TIPOEMPLEADO,
            this.TIPOCONTRATO,
            this.SUELDO});
            this.DGVEMPLEADOS.Location = new System.Drawing.Point(9, 271);
            this.DGVEMPLEADOS.Name = "DGVEMPLEADOS";
            this.DGVEMPLEADOS.RowHeadersWidth = 62;
            this.DGVEMPLEADOS.RowTemplate.Height = 28;
            this.DGVEMPLEADOS.Size = new System.Drawing.Size(1267, 315);
            this.DGVEMPLEADOS.TabIndex = 1;
            // 
            // LblCedulaEmpleado
            // 
            this.LblCedulaEmpleado.AutoSize = true;
            this.LblCedulaEmpleado.Location = new System.Drawing.Point(315, 158);
            this.LblCedulaEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCedulaEmpleado.Name = "LblCedulaEmpleado";
            this.LblCedulaEmpleado.Size = new System.Drawing.Size(75, 25);
            this.LblCedulaEmpleado.TabIndex = 16;
            this.LblCedulaEmpleado.Text = "Cedula";
            // 
            // TxtCedulaEmpleado
            // 
            this.TxtCedulaEmpleado.Location = new System.Drawing.Point(322, 193);
            this.TxtCedulaEmpleado.Name = "TxtCedulaEmpleado";
            this.TxtCedulaEmpleado.Size = new System.Drawing.Size(221, 30);
            this.TxtCedulaEmpleado.TabIndex = 17;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 8;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 120;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 8;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 120;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 8;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 270;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 8;
            this.SEXO.Name = "SEXO";
            // 
            // NUMSEGSOC
            // 
            this.NUMSEGSOC.HeaderText = "NÚMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOC.MinimumWidth = 8;
            this.NUMSEGSOC.Name = "NUMSEGSOC";
            this.NUMSEGSOC.Width = 150;
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.MinimumWidth = 8;
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Width = 150;
            // 
            // TIPOEMPLEADO
            // 
            this.TIPOEMPLEADO.HeaderText = "TIPO DE EMPLEADO";
            this.TIPOEMPLEADO.MinimumWidth = 8;
            this.TIPOEMPLEADO.Name = "TIPOEMPLEADO";
            this.TIPOEMPLEADO.Width = 130;
            // 
            // TIPOCONTRATO
            // 
            this.TIPOCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPOCONTRATO.MinimumWidth = 8;
            this.TIPOCONTRATO.Name = "TIPOCONTRATO";
            this.TIPOCONTRATO.Width = 130;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.MinimumWidth = 8;
            this.SUELDO.Name = "SUELDO";
            this.SUELDO.Width = 120;
            // 
            // FRMEMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1539, 875);
            this.Controls.Add(this.DGVEMPLEADOS);
            this.Controls.Add(this.GboEmpleados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMEMPLEADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMEMPLEADOS";
            this.GboEmpleados.ResumeLayout(false);
            this.GboEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboEmpleados;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblTipoEmpleado;
        private System.Windows.Forms.Label LblNumSegSoc;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.Windows.Forms.Label LblTipoContrato;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.ComboBox CboTipoContrato;
        private System.Windows.Forms.ComboBox CboTipoEmpleado;
        private System.Windows.Forms.TextBox TxtNumSegSoc;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.DataGridView DGVEMPLEADOS;
        private System.Windows.Forms.TextBox TxtCedulaEmpleado;
        private System.Windows.Forms.Label LblCedulaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
    }
}