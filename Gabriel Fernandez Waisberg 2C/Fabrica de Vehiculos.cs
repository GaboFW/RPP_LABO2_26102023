using Entidades;

namespace Gabriel_Fernandez_Waisberg_2C
{
    public partial class Form1 : Form
    {
        private Fabrica fabrica;

        public Form1()
        {
            InitializeComponent();
            InicializarFabrica();
            Refrescar();
        }

        /// <summary>
        /// Cargo todas las opciones para el comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbTipoVehiculo.DataSource = new object[] { "Automovil", "Camioneta", "Moto" };
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedIndex >= 0)
            {
                Vehiculo vehiculoAEliminar = fabrica.Vehiculos[(int)lstVehiculos.SelectedIndex];
                this.fabrica -= vehiculoAEliminar;
            }
            
            Refrescar();
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo crear = CrearVehiculo();
            this.fabrica += crear;
            Refrescar();
        }

        private Vehiculo CrearVehiculo()
        {
            switch (this.cmbTipoVehiculo.SelectedIndex)
            {
                case 0:
                    return new Automovil();
                case 1:
                    return new Camioneta(EPropulsion.Hibrida, false);
                default:
                    return new Moto(EPropulsion.Combustion);
            }
        }

        private void InicializarFabrica()
        {
            this.fabrica = new Fabrica(8);
        }

        private void Refrescar()
        {
            this.lstVehiculos.DataSource = null;
            this.lstVehiculos.DataSource = fabrica.Vehiculos;
        }
    }
}