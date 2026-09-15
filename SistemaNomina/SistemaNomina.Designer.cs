namespace SistemaNomina
{
    partial class SistemaNomina
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpDatos = new GroupBox();
            lblTipoEmpleado = new Label();
            cmbTipoEmpleado = new ComboBox();
            lblPrimerNombre = new Label();
            txtPrimerNombre = new TextBox();
            lblApellidoPaterno = new Label();
            txtApellidoPaterno = new TextBox();
            lblNumeroSeguroSocial = new Label();
            txtNumeroSeguroSocial = new TextBox();
            lblSalarioSemanal = new Label();
            txtSalarioSemanal = new TextBox();
            lblSueldoPorHora = new Label();
            txtSueldoPorHora = new TextBox();
            lblVentasBrutas = new Label();
            txtVentasBrutas = new TextBox();
            lblHorasTrabajadas = new Label();
            txtHorasTrabajadas = new TextBox();
            lblTarifaComision = new Label();
            txtTarifaComision = new TextBox();
            lblSalarioBase = new Label();
            txtSalarioBase = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnGenerarReporte = new Button();
            lblReporte = new Label();
            dgvEmpleados = new DataGridView();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 60, 114);
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Gestión de Nómina";
            //
            // grpDatos
            //
            grpDatos.Controls.Add(lblTipoEmpleado);
            grpDatos.Controls.Add(cmbTipoEmpleado);
            grpDatos.Controls.Add(lblPrimerNombre);
            grpDatos.Controls.Add(txtPrimerNombre);
            grpDatos.Controls.Add(lblApellidoPaterno);
            grpDatos.Controls.Add(txtApellidoPaterno);
            grpDatos.Controls.Add(lblNumeroSeguroSocial);
            grpDatos.Controls.Add(txtNumeroSeguroSocial);
            grpDatos.Controls.Add(lblSalarioSemanal);
            grpDatos.Controls.Add(txtSalarioSemanal);
            grpDatos.Controls.Add(lblSueldoPorHora);
            grpDatos.Controls.Add(txtSueldoPorHora);
            grpDatos.Controls.Add(lblVentasBrutas);
            grpDatos.Controls.Add(txtVentasBrutas);
            grpDatos.Controls.Add(lblHorasTrabajadas);
            grpDatos.Controls.Add(txtHorasTrabajadas);
            grpDatos.Controls.Add(lblTarifaComision);
            grpDatos.Controls.Add(txtTarifaComision);
            grpDatos.Controls.Add(lblSalarioBase);
            grpDatos.Controls.Add(txtSalarioBase);
            grpDatos.Font = new Font("Segoe UI", 9.75F);
            grpDatos.Location = new Point(24, 70);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(430, 440);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Empleado";
            //
            // lblTipoEmpleado
            //
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Location = new Point(20, 34);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(160, 25);
            lblTipoEmpleado.TabIndex = 0;
            lblTipoEmpleado.Text = "Tipo de Empleado:";
            //
            // cmbTipoEmpleado
            //
            cmbTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEmpleado.FormattingEnabled = true;
            cmbTipoEmpleado.Items.AddRange(new object[] { "Asalariado", "Por Horas", "Por Comisión", "Asalariado por Comisión" });
            cmbTipoEmpleado.Location = new Point(200, 31);
            cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            cmbTipoEmpleado.Size = new Size(200, 31);
            cmbTipoEmpleado.TabIndex = 1;
            //
            // lblPrimerNombre
            //
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Location = new Point(20, 82);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(140, 25);
            lblPrimerNombre.TabIndex = 2;
            lblPrimerNombre.Text = "Primer Nombre:";
            //
            // txtPrimerNombre
            //
            txtPrimerNombre.Location = new Point(200, 79);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(200, 31);
            txtPrimerNombre.TabIndex = 3;
            //
            // lblApellidoPaterno
            //
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Location = new Point(20, 130);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(150, 25);
            lblApellidoPaterno.TabIndex = 4;
            lblApellidoPaterno.Text = "Apellido Paterno:";
            //
            // txtApellidoPaterno
            //
            txtApellidoPaterno.Location = new Point(200, 127);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(200, 31);
            txtApellidoPaterno.TabIndex = 5;
            //
            // lblNumeroSeguroSocial
            //
            lblNumeroSeguroSocial.AutoSize = true;
            lblNumeroSeguroSocial.Location = new Point(20, 178);
            lblNumeroSeguroSocial.Name = "lblNumeroSeguroSocial";
            lblNumeroSeguroSocial.Size = new Size(170, 25);
            lblNumeroSeguroSocial.TabIndex = 6;
            lblNumeroSeguroSocial.Text = "No. Seguro Social:";
            //
            // txtNumeroSeguroSocial
            //
            txtNumeroSeguroSocial.Location = new Point(200, 175);
            txtNumeroSeguroSocial.Name = "txtNumeroSeguroSocial";
            txtNumeroSeguroSocial.Size = new Size(200, 31);
            txtNumeroSeguroSocial.TabIndex = 7;
            //
            // lblSalarioSemanal
            //
            lblSalarioSemanal.AutoSize = true;
            lblSalarioSemanal.Location = new Point(20, 226);
            lblSalarioSemanal.Name = "lblSalarioSemanal";
            lblSalarioSemanal.Size = new Size(150, 25);
            lblSalarioSemanal.TabIndex = 8;
            lblSalarioSemanal.Text = "Salario Semanal:";
            //
            // txtSalarioSemanal
            //
            txtSalarioSemanal.Location = new Point(200, 223);
            txtSalarioSemanal.Name = "txtSalarioSemanal";
            txtSalarioSemanal.Size = new Size(200, 31);
            txtSalarioSemanal.TabIndex = 9;
            //
            // lblSueldoPorHora
            //
            lblSueldoPorHora.AutoSize = true;
            lblSueldoPorHora.Location = new Point(20, 226);
            lblSueldoPorHora.Name = "lblSueldoPorHora";
            lblSueldoPorHora.Size = new Size(150, 25);
            lblSueldoPorHora.TabIndex = 10;
            lblSueldoPorHora.Text = "Sueldo por Hora:";
            //
            // txtSueldoPorHora
            //
            txtSueldoPorHora.Location = new Point(200, 223);
            txtSueldoPorHora.Name = "txtSueldoPorHora";
            txtSueldoPorHora.Size = new Size(200, 31);
            txtSueldoPorHora.TabIndex = 11;
            //
            // lblVentasBrutas
            //
            lblVentasBrutas.AutoSize = true;
            lblVentasBrutas.Location = new Point(20, 226);
            lblVentasBrutas.Name = "lblVentasBrutas";
            lblVentasBrutas.Size = new Size(140, 25);
            lblVentasBrutas.TabIndex = 12;
            lblVentasBrutas.Text = "Ventas Brutas:";
            //
            // txtVentasBrutas
            //
            txtVentasBrutas.Location = new Point(200, 223);
            txtVentasBrutas.Name = "txtVentasBrutas";
            txtVentasBrutas.Size = new Size(200, 31);
            txtVentasBrutas.TabIndex = 13;
            //
            // lblHorasTrabajadas
            //
            lblHorasTrabajadas.AutoSize = true;
            lblHorasTrabajadas.Location = new Point(20, 274);
            lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            lblHorasTrabajadas.Size = new Size(160, 25);
            lblHorasTrabajadas.TabIndex = 14;
            lblHorasTrabajadas.Text = "Horas Trabajadas:";
            //
            // txtHorasTrabajadas
            //
            txtHorasTrabajadas.Location = new Point(200, 271);
            txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            txtHorasTrabajadas.Size = new Size(200, 31);
            txtHorasTrabajadas.TabIndex = 15;
            //
            // lblTarifaComision
            //
            lblTarifaComision.AutoSize = true;
            lblTarifaComision.Location = new Point(20, 274);
            lblTarifaComision.Name = "lblTarifaComision";
            lblTarifaComision.Size = new Size(160, 25);
            lblTarifaComision.TabIndex = 16;
            lblTarifaComision.Text = "Tarifa Comisión:";
            //
            // txtTarifaComision
            //
            txtTarifaComision.Location = new Point(200, 271);
            txtTarifaComision.Name = "txtTarifaComision";
            txtTarifaComision.Size = new Size(200, 31);
            txtTarifaComision.TabIndex = 17;
            //
            // lblSalarioBase
            //
            lblSalarioBase.AutoSize = true;
            lblSalarioBase.Location = new Point(20, 322);
            lblSalarioBase.Name = "lblSalarioBase";
            lblSalarioBase.Size = new Size(140, 25);
            lblSalarioBase.TabIndex = 18;
            lblSalarioBase.Text = "Salario Base:";
            //
            // txtSalarioBase
            //
            txtSalarioBase.Location = new Point(200, 319);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(200, 31);
            txtSalarioBase.TabIndex = 19;
            //
            // btnAgregar
            //
            btnAgregar.BackColor = Color.FromArgb(46, 125, 50);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(474, 90);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(220, 40);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar Empleado";
            btnAgregar.UseVisualStyleBackColor = false;
            //
            // btnActualizar
            //
            btnActualizar.BackColor = Color.FromArgb(30, 60, 114);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(474, 140);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 40);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            //
            // btnEliminar
            //
            btnEliminar.BackColor = Color.FromArgb(198, 40, 40);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(589, 140);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 40);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            //
            // btnGenerarReporte
            //
            btnGenerarReporte.BackColor = Color.FromArgb(255, 143, 0);
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGenerarReporte.ForeColor = Color.White;
            btnGenerarReporte.Location = new Point(474, 190);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(220, 40);
            btnGenerarReporte.TabIndex = 23;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            //
            // lblReporte
            //
            lblReporte.AutoSize = true;
            lblReporte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReporte.Location = new Point(474, 244);
            lblReporte.Name = "lblReporte";
            lblReporte.Size = new Size(220, 25);
            lblReporte.TabIndex = 24;
            lblReporte.Text = "Empleados registrados:";
            //
            // dgvEmpleados
            //
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(474, 270);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(430, 240);
            dgvEmpleados.TabIndex = 25;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(930, 540);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatos);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGenerarReporte);
            Controls.Add(lblReporte);
            Controls.Add(dgvEmpleados);
            MinimumSize = new Size(946, 579);
            Name = "Form1";
            Text = "Sistema de Nómina - SRS";
            Load += Form1_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpDatos;
        private Label lblTipoEmpleado;
        private ComboBox cmbTipoEmpleado;
        private Label lblPrimerNombre;
        private TextBox txtPrimerNombre;
        private Label lblApellidoPaterno;
        private TextBox txtApellidoPaterno;
        private Label lblNumeroSeguroSocial;
        private TextBox txtNumeroSeguroSocial;
        private Label lblSalarioSemanal;
        private TextBox txtSalarioSemanal;
        private Label lblSueldoPorHora;
        private TextBox txtSueldoPorHora;
        private Label lblVentasBrutas;
        private TextBox txtVentasBrutas;
        private Label lblHorasTrabajadas;
        private TextBox txtHorasTrabajadas;
        private Label lblTarifaComision;
        private TextBox txtTarifaComision;
        private Label lblSalarioBase;
        private TextBox txtSalarioBase;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnGenerarReporte;
        private Label lblReporte;
        private DataGridView dgvEmpleados;
    }
}