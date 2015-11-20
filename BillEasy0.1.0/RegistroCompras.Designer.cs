namespace BillEasy0._1._0
{
    partial class RegistroCompras
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
            this.TotallTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DatosVentasGroupBox = new System.Windows.Forms.GroupBox();
            this.BuscarVentaButton = new System.Windows.Forms.Button();
            this.ProductoGroupBox = new System.Windows.Forms.GroupBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ITBISTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BuscarProductoButton = new System.Windows.Forms.Button();
            this.ProductoIdTextBox = new System.Windows.Forms.TextBox();
            this.CostoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescuentosTextBox = new System.Windows.Forms.TextBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.CompraDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.TipoNFCTextBox = new System.Windows.Forms.TextBox();
            this.NFCTextBox = new System.Windows.Forms.TextBox();
            this.TipoCompraTextBox = new System.Windows.Forms.TextBox();
            this.CompraIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.DatosVentasGroupBox.SuspendLayout();
            this.ProductoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TotallTextBox
            // 
            this.TotallTextBox.Location = new System.Drawing.Point(58, 433);
            this.TotallTextBox.Name = "TotallTextBox";
            this.TotallTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotallTextBox.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 36);
            this.label11.TabIndex = 22;
            this.label11.Text = "Compras";
            // 
            // DatosVentasGroupBox
            // 
            this.DatosVentasGroupBox.Controls.Add(this.BuscarVentaButton);
            this.DatosVentasGroupBox.Controls.Add(this.ProductoGroupBox);
            this.DatosVentasGroupBox.Controls.Add(this.FechaDateTimePicker);
            this.DatosVentasGroupBox.Controls.Add(this.label10);
            this.DatosVentasGroupBox.Controls.Add(this.CompraDataGridView);
            this.DatosVentasGroupBox.Controls.Add(this.ClienteComboBox);
            this.DatosVentasGroupBox.Controls.Add(this.TipoNFCTextBox);
            this.DatosVentasGroupBox.Controls.Add(this.NFCTextBox);
            this.DatosVentasGroupBox.Controls.Add(this.TipoCompraTextBox);
            this.DatosVentasGroupBox.Controls.Add(this.CompraIdTextBox);
            this.DatosVentasGroupBox.Controls.Add(this.label6);
            this.DatosVentasGroupBox.Controls.Add(this.label5);
            this.DatosVentasGroupBox.Controls.Add(this.label4);
            this.DatosVentasGroupBox.Controls.Add(this.label2);
            this.DatosVentasGroupBox.Controls.Add(this.label1);
            this.DatosVentasGroupBox.Location = new System.Drawing.Point(12, 79);
            this.DatosVentasGroupBox.Name = "DatosVentasGroupBox";
            this.DatosVentasGroupBox.Size = new System.Drawing.Size(720, 344);
            this.DatosVentasGroupBox.TabIndex = 21;
            this.DatosVentasGroupBox.TabStop = false;
            this.DatosVentasGroupBox.Text = "Datos Compras";
            // 
            // BuscarVentaButton
            // 
            this.BuscarVentaButton.Image = global::BillEasy0._1._0.Properties.Resources._1447807738_Search;
            this.BuscarVentaButton.Location = new System.Drawing.Point(171, 26);
            this.BuscarVentaButton.Name = "BuscarVentaButton";
            this.BuscarVentaButton.Size = new System.Drawing.Size(46, 31);
            this.BuscarVentaButton.TabIndex = 22;
            this.BuscarVentaButton.UseVisualStyleBackColor = true;
            this.BuscarVentaButton.Click += new System.EventHandler(this.BuscarVentaButton_Click);
            // 
            // ProductoGroupBox
            // 
            this.ProductoGroupBox.Controls.Add(this.AgregarButton);
            this.ProductoGroupBox.Controls.Add(this.NombreTextBox);
            this.ProductoGroupBox.Controls.Add(this.ITBISTextBox);
            this.ProductoGroupBox.Controls.Add(this.label14);
            this.ProductoGroupBox.Controls.Add(this.label13);
            this.ProductoGroupBox.Controls.Add(this.BuscarProductoButton);
            this.ProductoGroupBox.Controls.Add(this.ProductoIdTextBox);
            this.ProductoGroupBox.Controls.Add(this.CostoTextBox);
            this.ProductoGroupBox.Controls.Add(this.label9);
            this.ProductoGroupBox.Controls.Add(this.label7);
            this.ProductoGroupBox.Controls.Add(this.label8);
            this.ProductoGroupBox.Controls.Add(this.label3);
            this.ProductoGroupBox.Controls.Add(this.DescuentosTextBox);
            this.ProductoGroupBox.Controls.Add(this.CantidadTextBox);
            this.ProductoGroupBox.Location = new System.Drawing.Point(9, 96);
            this.ProductoGroupBox.Name = "ProductoGroupBox";
            this.ProductoGroupBox.Size = new System.Drawing.Size(705, 100);
            this.ProductoGroupBox.TabIndex = 21;
            this.ProductoGroupBox.TabStop = false;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(657, 21);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(42, 30);
            this.AgregarButton.TabIndex = 4;
            this.AgregarButton.Text = ">>";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(74, 54);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.Size = new System.Drawing.Size(143, 20);
            this.NombreTextBox.TabIndex = 19;
            // 
            // ITBISTextBox
            // 
            this.ITBISTextBox.Location = new System.Drawing.Point(508, 26);
            this.ITBISTextBox.Name = "ITBISTextBox";
            this.ITBISTextBox.ReadOnly = true;
            this.ITBISTextBox.Size = new System.Drawing.Size(143, 20);
            this.ITBISTextBox.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Nombre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "ITBIS:";
            // 
            // BuscarProductoButton
            // 
            this.BuscarProductoButton.Image = global::BillEasy0._1._0.Properties.Resources._1447807738_Search;
            this.BuscarProductoButton.Location = new System.Drawing.Point(171, 20);
            this.BuscarProductoButton.Name = "BuscarProductoButton";
            this.BuscarProductoButton.Size = new System.Drawing.Size(46, 31);
            this.BuscarProductoButton.TabIndex = 1;
            this.BuscarProductoButton.UseVisualStyleBackColor = true;
            this.BuscarProductoButton.Click += new System.EventHandler(this.BuscarProductoButton_Click);
            // 
            // ProductoIdTextBox
            // 
            this.ProductoIdTextBox.Location = new System.Drawing.Point(74, 26);
            this.ProductoIdTextBox.Name = "ProductoIdTextBox";
            this.ProductoIdTextBox.Size = new System.Drawing.Size(91, 20);
            this.ProductoIdTextBox.TabIndex = 0;
            // 
            // CostoTextBox
            // 
            this.CostoTextBox.Location = new System.Drawing.Point(281, 54);
            this.CostoTextBox.Name = "CostoTextBox";
            this.CostoTextBox.ReadOnly = true;
            this.CostoTextBox.Size = new System.Drawing.Size(143, 20);
            this.CostoTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Costo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ProductoId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento:";
            // 
            // DescuentosTextBox
            // 
            this.DescuentosTextBox.Location = new System.Drawing.Point(508, 54);
            this.DescuentosTextBox.Name = "DescuentosTextBox";
            this.DescuentosTextBox.Size = new System.Drawing.Size(143, 20);
            this.DescuentosTextBox.TabIndex = 3;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(281, 26);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(143, 20);
            this.CantidadTextBox.TabIndex = 2;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(537, 32);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.FechaDateTimePicker.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha:";
            // 
            // CompraDataGridView
            // 
            this.CompraDataGridView.AllowUserToAddRows = false;
            this.CompraDataGridView.AllowUserToDeleteRows = false;
            this.CompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.ITBIS,
            this.Descuento});
            this.CompraDataGridView.Location = new System.Drawing.Point(9, 202);
            this.CompraDataGridView.Name = "CompraDataGridView";
            this.CompraDataGridView.ReadOnly = true;
            this.CompraDataGridView.Size = new System.Drawing.Size(705, 134);
            this.CompraDataGridView.TabIndex = 18;
            // 
            // ProductoId
            // 
            this.ProductoId.HeaderText = "ProductoId";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // ITBIS
            // 
            this.ITBIS.HeaderText = "ITBIS";
            this.ITBIS.Name = "ITBIS";
            this.ITBIS.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(74, 65);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(143, 21);
            this.ClienteComboBox.TabIndex = 1;
            // 
            // TipoNFCTextBox
            // 
            this.TipoNFCTextBox.Location = new System.Drawing.Point(537, 65);
            this.TipoNFCTextBox.Name = "TipoNFCTextBox";
            this.TipoNFCTextBox.Size = new System.Drawing.Size(143, 20);
            this.TipoNFCTextBox.TabIndex = 5;
            // 
            // NFCTextBox
            // 
            this.NFCTextBox.Location = new System.Drawing.Point(312, 65);
            this.NFCTextBox.Name = "NFCTextBox";
            this.NFCTextBox.Size = new System.Drawing.Size(143, 20);
            this.NFCTextBox.TabIndex = 3;
            // 
            // TipoCompraTextBox
            // 
            this.TipoCompraTextBox.Location = new System.Drawing.Point(312, 32);
            this.TipoCompraTextBox.Name = "TipoCompraTextBox";
            this.TipoCompraTextBox.Size = new System.Drawing.Size(143, 20);
            this.TipoCompraTextBox.TabIndex = 2;
            // 
            // CompraIdTextBox
            // 
            this.CompraIdTextBox.Location = new System.Drawing.Point(74, 32);
            this.CompraIdTextBox.Name = "CompraIdTextBox";
            this.CompraIdTextBox.Size = new System.Drawing.Size(91, 20);
            this.CompraIdTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de NFC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NFC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CompraId:";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::BillEasy0._1._0.Properties.Resources._1445976510_Delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(651, 436);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(81, 46);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::BillEasy0._1._0.Properties.Resources._1445977752_Save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(552, 436);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(81, 46);
            this.GuardarButton.TabIndex = 1;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::BillEasy0._1._0.Properties.Resources._1445976554_Plus__Orange;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(447, 436);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(81, 46);
            this.NuevoButton.TabIndex = 0;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // RegistroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 493);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.TotallTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DatosVentasGroupBox);
            this.Name = "RegistroCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de compras";
            this.Load += new System.EventHandler(this.RegistroCompras_Load);
            this.DatosVentasGroupBox.ResumeLayout(false);
            this.DatosVentasGroupBox.PerformLayout();
            this.ProductoGroupBox.ResumeLayout(false);
            this.ProductoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox TotallTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox DatosVentasGroupBox;
        private System.Windows.Forms.Button BuscarVentaButton;
        private System.Windows.Forms.GroupBox ProductoGroupBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ITBISTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BuscarProductoButton;
        private System.Windows.Forms.TextBox ProductoIdTextBox;
        private System.Windows.Forms.TextBox CostoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescuentosTextBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView CompraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITBIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.TextBox TipoNFCTextBox;
        private System.Windows.Forms.TextBox NFCTextBox;
        private System.Windows.Forms.TextBox TipoCompraTextBox;
        private System.Windows.Forms.TextBox CompraIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}