using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;


namespace WindowsFormsApp1.forms.Inventario
{
    public partial class FormInventarioAgregar : Form
    {
        private FormInventario _formInventario;
        private object dato;
        private readonly object textBoxNombreProducto;

        public FormInventarioAgregar(FormInventario formInventario)
        {
            InitializeComponent();
            _formInventario = formInventario;
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
            using (var db = new proyectoFESCEntities())
            {
                int.TryParse(textBoxCantidad.Text, out int Cantidad);
                decimal.TryParse(textBoxPrecioCompra.Text, out decimal PrecioCompra);
                decimal.TryParse(textBoxPrecioVenta.Text, out decimal PrecioVenta);

                Data.Inventario dato = new Data.Inventario
                {


                    productName = textBoxNombreProducto,
                    Quantity = Cantidad,
                    PurchasePrice = PrecioCompra,
                    SellingPrice = PrecioVenta,

                };

                 db.Inventario.Add(dato);
                 db.SaveChanges();

                _formInventario.LoadData();
                Limpiar();
            }
        }

            private void Limpiar()
            {
                textBoxNombreProducto1.Text = string.Empty;
                textBoxCantidad.Text = string.Empty;
                textBoxPrecioCompra.Text = string.Empty;
                textBoxPrecioVenta.Text = string.Empty;
            }
        
    }

}  

