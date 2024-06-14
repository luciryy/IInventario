using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1.forms.Inventario
{
    public partial class FormInventarioEditar : Form
    {
        private FormInventario _formInventario;
        private Entities.Inventario _inventario;
        public FormInventarioEditar(FormInventario formInventario, int id)
        {
            InitializeComponent();
            _formInventario = formInventario;

            LoadData();
        }
        private void LoadData()
        {
            /*
            textBoxNombreProducto.Text = _inventario.ProductName;
            textBoxCantidad.Text = _inventario.Quantity.ToString();
            textBoxPrecioCompra.Text = _inventario.PurchasePrice.ToString();
            textBoxPrecioVenta.Text =_inventario.SellingPrice.ToString();   
            */
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxCantidad.Text, out int Cantidad);
            decimal.TryParse(textBoxPrecioCompra.Text, out decimal PrecioCompra);
            decimal.TryParse(textBoxPrecioVenta.Text, out decimal PrecioVenta);

            /*
            _inventario.productName = textBoxNombreProducto.Text;
            _inventario.Quantity = Cantidad;
            _inventario.PurchasePrice = PrecioCompra;
            _inventario.SellingPrice = PrecioVenta;

            CacheData.DatosInventario.Remove(_inventario);
            CacheData.DatosInventario.Add(_inventario);
            CacheData.DatosInventario = CacheData.DatosInventario.OrderBy(x => x.productId).ToList();
            
            _formInventario.LoadData();
            this.Close();
            */
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            textBoxNombreProducto.Text = string.Empty;
            textBoxCantidad.Text = string.Empty;
            textBoxPrecioCompra.Text = string.Empty;
            textBoxPrecioVenta.Text = string.Empty;
        }

    }
}
