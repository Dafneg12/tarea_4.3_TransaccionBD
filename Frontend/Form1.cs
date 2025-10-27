using System.Data;
using tarea_4._3_TransaccionBD.consultas;
using tarea_4._3_TransaccionBD.pojo;

namespace tarea_4._3_TransaccionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsProducts producto = new clsProducts();
            producto.Codigo = txtCodigoProduct.Text.Trim();

            try
            {
                clsBuscar cons = new clsBuscar();
                cons.buscarProducto(producto);

                int revisar = cons.buscarProducto(producto);

                if (revisar > 0)
                {
                    MessageBox.Show("Producto encontrado", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado." + revisar, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar iniciar sesión:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsBuscar seleccionar = new clsBuscar();
            DataTable datos = seleccionar.ObtenerProductos();

            dgvProducts.DataSource = datos;
        }
    }
}
