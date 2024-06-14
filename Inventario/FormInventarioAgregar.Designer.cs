namespace WindowsFormsApp1.forms.Inventario
{
    partial class FormInventarioAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreProducto1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.textBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreProducto1.Location = new System.Drawing.Point(250, 91);
            this.textBoxNombreProducto1.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto1.Size = new System.Drawing.Size(364, 35);
            this.textBoxNombreProducto1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 54);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio venta:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(502, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Formulario Agregar a Inventario";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(250, 144);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(364, 35);
            this.textBoxCantidad.TabIndex = 6;
            // 
            // textBoxPrecioCompra
            // 
            this.textBoxPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioCompra.Location = new System.Drawing.Point(250, 192);
            this.textBoxPrecioCompra.Name = "textBoxPrecioCompra";
            this.textBoxPrecioCompra.Size = new System.Drawing.Size(364, 35);
            this.textBoxPrecioCompra.TabIndex = 7;
            // 
            // textBoxPrecioVenta
            // 
            this.textBoxPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioVenta.Location = new System.Drawing.Point(250, 246);
            this.textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            this.textBoxPrecioVenta.Size = new System.Drawing.Size(364, 35);
            this.textBoxPrecioVenta.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(535, 310);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(130, 50);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(316, 310);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(130, 50);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(105, 310);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(130, 50);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormInventarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxPrecioVenta);
            this.Controls.Add(this.textBoxPrecioCompra);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreProducto1);
            this.Controls.Add(this.label1);
            this.Name = "FormInventarioAgregar";
            this.Text = "Formulario Agregar a Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreProducto1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxPrecioCompra;
        private System.Windows.Forms.TextBox textBoxPrecioVenta;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}