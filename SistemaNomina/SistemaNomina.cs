using System;
using System.Windows.Forms;
using SistemaNomina.Modelos;
using SistemaNomina.Servicios;

namespace SistemaNomina
{
    public partial class SistemaNomina : Form
    {
        private NominaService nominaService = new NominaService();
        private int indiceSeleccionado = -1; // -1 = ninguno seleccionado

        public SistemaNomina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoEmpleado.SelectedIndexChanged += CmbTipoEmpleado_SelectedIndexChanged;
            btnAgregar.Click += BtnAgregar_Click;
            btnActualizar.Click += BtnActualizar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnGenerarReporte.Click += BtnGenerarReporte_Click;
            dgvEmpleados.SelectionChanged += DgvEmpleados_SelectionChanged;

            cmbTipoEmpleado.SelectedIndex = 0; // Asalariado por defecto
            ConfigurarColumnasGrid();
        }

        // ---------- Mostrar/ocultar campos según el tipo ----------
        private void CmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoEmpleado.SelectedItem.ToString();

            // Ocultar todo primero
            txtPrimerNombre.Visible = true;
            lblPrimerNombre.Visible = true;
            txtSalarioSemanal.Visible = false;
            lblSalarioSemanal.Visible = false;
            txtSueldoPorHora.Visible = false;
            lblSueldoPorHora.Visible = false;
            txtHorasTrabajadas.Visible = false;
            lblHorasTrabajadas.Visible = false;
            txtVentasBrutas.Visible = false;
            lblVentasBrutas.Visible = false;
            txtTarifaComision.Visible = false;
            lblTarifaComision.Visible = false;
            lblTarifaComision.Text = "";
            txtSalarioBase.Visible = false;
            lblSalarioBase.Visible = false;
            lblSalarioBase.Text = "";

            switch (tipo)
            {
                case "Asalariado":
                    txtSalarioSemanal.Visible = true;
                    lblSalarioSemanal.Visible = true;
                    break;

                case "Por Horas":
                    txtPrimerNombre.Visible = false;
                    lblPrimerNombre.Visible = false;
                    txtSueldoPorHora.Visible = true;
                    lblSueldoPorHora.Visible = true;
                    txtHorasTrabajadas.Visible = true;
                    lblHorasTrabajadas.Visible = true;
                    break;

                case "Por Comisión":
                    txtVentasBrutas.Visible = true;
                    lblVentasBrutas.Visible = true;
                    txtTarifaComision.Visible = true;
                    lblTarifaComision.Visible = true;
                    lblTarifaComision.Text = "Tarifa Comisión:";
                    break;

                case "Asalariado por Comisión":
                    txtVentasBrutas.Visible = true;
                    lblVentasBrutas.Visible = true;
                    txtTarifaComision.Visible = true;
                    lblTarifaComision.Visible = true;
                    lblTarifaComision.Text = "Tarifa Comisión:";
                    txtSalarioBase.Visible = true;
                    lblSalarioBase.Visible = true;
                    lblSalarioBase.Text = "Salario Base:";
                    break;
            }
        }

        // ---------- Construir un Empleado a partir de los campos ----------
        private Empleado ConstruirEmpleadoDesdeFormulario()
        {
            string tipo = cmbTipoEmpleado.SelectedItem.ToString();
            string apellidoPaterno = txtApellidoPaterno.Text.Trim();
            string numeroSeguroSocial = txtNumeroSeguroSocial.Text.Trim();

            if (string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(numeroSeguroSocial))
            {
                MessageBox.Show("Apellido Paterno y Número de Seguro Social son obligatorios.",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                switch (tipo)
                {
                    case "Asalariado":
                        return new EmpleadoAsalariado(
                            txtPrimerNombre.Text.Trim(),
                            apellidoPaterno,
                            numeroSeguroSocial,
                            decimal.Parse(txtSalarioSemanal.Text));

                    case "Por Horas":
                        return new EmpleadoPorHoras(
                            apellidoPaterno,
                            numeroSeguroSocial,
                            decimal.Parse(txtSueldoPorHora.Text),
                            decimal.Parse(txtHorasTrabajadas.Text));

                    case "Por Comisión":
                        return new EmpleadoPorComision(
                            txtPrimerNombre.Text.Trim(),
                            apellidoPaterno,
                            numeroSeguroSocial,
                            decimal.Parse(txtVentasBrutas.Text),
                            decimal.Parse(txtTarifaComision.Text));

                    case "Asalariado por Comisión":
                        return new EmpleadoAsalariadoPorComision(
                            txtPrimerNombre.Text.Trim(),
                            apellidoPaterno,
                            numeroSeguroSocial,
                            decimal.Parse(txtVentasBrutas.Text),
                            decimal.Parse(txtTarifaComision.Text),
                            decimal.Parse(txtSalarioBase.Text));

                    default:
                        return null;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Revisa que los campos numéricos tengan valores válidos.",
                    "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void LimpiarFormulario()
        {
            txtPrimerNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtNumeroSeguroSocial.Text = "";
            txtSalarioSemanal.Text = "";
            txtSueldoPorHora.Text = "";
            txtHorasTrabajadas.Text = "";
            txtVentasBrutas.Text = "";
            txtTarifaComision.Text = "";
            txtSalarioBase.Text = "";
            indiceSeleccionado = -1;
        }

        // ---------- Botones ----------
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = ConstruirEmpleadoDesdeFormulario();
            if (empleado == null) return;

            nominaService.AgregarEmpleado(empleado);
            LimpiarFormulario();
            ActualizarGrid();
            MessageBox.Show("Empleado agregado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un empleado de la tabla primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado empleado = ConstruirEmpleadoDesdeFormulario();
            if (empleado == null) return;

            nominaService.ActualizarEmpleado(indiceSeleccionado, empleado);
            LimpiarFormulario();
            ActualizarGrid();
            MessageBox.Show("Empleado actualizado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un empleado de la tabla primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nominaService.EliminarEmpleado(indiceSeleccionado);
            LimpiarFormulario();
            ActualizarGrid();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        // ---------- Grid / reporte ----------
        private void ConfigurarColumnasGrid()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();
            dgvEmpleados.Columns.Add("ColTipo", "Tipo");
            dgvEmpleados.Columns.Add("ColNombre", "Nombre");
            dgvEmpleados.Columns.Add("ColApellido", "Apellido");
            dgvEmpleados.Columns.Add("ColNSS", "N.S.S.");
            dgvEmpleados.Columns.Add("ColPago", "Pago Semanal");
        }

        private void ActualizarGrid()
        {
            dgvEmpleados.Rows.Clear();
            foreach (Empleado emp in nominaService.ObtenerTodos())
            {
                dgvEmpleados.Rows.Add(
                    emp.ObtenerTipo(),
                    emp.PrimerNombre,
                    emp.ApellidoPaterno,
                    emp.NumeroSeguroSocial,
                    emp.CalcularPago().ToString("C2"));
            }
        }

        private void DgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                indiceSeleccionado = dgvEmpleados.SelectedRows[0].Index;
            }
        }
    }
}