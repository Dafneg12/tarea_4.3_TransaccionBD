using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using tarea_4._3_TransaccionBD.consultas;
using tarea_4._3_TransaccionBD.pojo;

namespace tarea_4._3_TransaccionBD
{
    public partial class Form1 : Form
    {
        private List<clsProducts> listaProductos = new List<clsProducts>();
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
                    clsBuscar seleccionar = new clsBuscar();
                    DataTable datos = seleccionar.ObtenerProductos(producto.Codigo);
                    
                    listaProductos.Add(producto);
                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = datos;

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
            /*clsBuscar seleccionar = new clsBuscar();
            DataTable datos = seleccionar.ObtenerProductos();

            dgvProducts.DataSource = datos;*/



        }

        private void btnDescontinuar_Click(object sender, EventArgs e)
        {
            if(dgvProducts.Rows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show( "¿Está seguro que quiere descontinuar el producto?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes) {
                    try
                    {
                       clsProducts producto = new clsProducts();
                       clsBuscar desc = new clsBuscar();
                        if (desc.DescontinuarProducto(producto))
                        {
                            dgvProducts.DataSource = null;
                            MessageBox.Show("Productos descontinuados correctamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al descontinuar productos: " + ex.Message);
                    }
                }
            }
            
        }
    }
}
