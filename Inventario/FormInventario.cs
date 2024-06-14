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
    public partial class FormInventario : Form
    {

        public FormInventario()
        {
            InitializeComponent();
            LoadData();
        }
       public void LoadData()
        {
            using (var db = new proyectoFESCEntities())
            {
                if (db.Inventario.Count() == 0)
                
                    dgvInventario.DataSource = null;
                    dgvInventario.DataSource = db.Inventario.ToList();

                    dgvInventario.Columns["productId"].HeaderText = "ID del Producto";

                    dgvInventario.Columns["ProductName"].HeaderText = "Nombre del Producto";

                    dgvInventario.Columns["Quantity"].HeaderText = "Cantidad";

                    dgvInventario.Columns["PurchasePrice"].HeaderText = "Precio de Compra";

                    dgvInventario.Columns["SellingPrice"].HeaderText = "Precio de Venta";
                
           }
            
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelBuscar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormInventarioAgregar formInventarioAgregar = new FormInventarioAgregar(this);
            formInventarioAgregar.Show();
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
           string idproducto = (dgvInventario.Rows[e.RowIndex].Cells[0].Value.ToString());
            int.TryParse(idproducto, out int id);

            FormInventarioEditar formInventarioEditar = new FormInventarioEditar(this, id);
            formInventarioEditar.Show();
        }
    } 
        }
    

