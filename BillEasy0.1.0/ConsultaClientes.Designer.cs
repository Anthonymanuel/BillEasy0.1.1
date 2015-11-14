namespace BillEasy0._1._0
{
    partial class ConsultaClientes
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
            this.BuscarClientescomboBox = new System.Windows.Forms.ComboBox();
            this.ClientestextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ClientesdataGridView = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de clientes";
            // 
            // BuscarClientescomboBox
            // 
            this.BuscarClientescomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarClientescomboBox.FormattingEnabled = true;
            this.BuscarClientescomboBox.Items.AddRange(new object[] {
            "ClienteId",
            "Nombres",
            "Apellidos",
            "Telefono",
            "Celular",
            "Cedula"});
            this.BuscarClientescomboBox.Location = new System.Drawing.Point(12, 57);
            this.BuscarClientescomboBox.Name = "BuscarClientescomboBox";
            this.BuscarClientescomboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarClientescomboBox.TabIndex = 1;
            // 
            // ClientestextBox
            // 
            this.ClientestextBox.Location = new System.Drawing.Point(139, 58);
            this.ClientestextBox.Name = "ClientestextBox";
            this.ClientestextBox.Size = new System.Drawing.Size(626, 20);
            this.ClientestextBox.TabIndex = 2;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::BillEasy0._1._0.Properties.Resources._1443839488_file_search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(771, 46);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 40);
            this.Buscarbutton.TabIndex = 3;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ClientesdataGridView
            // 
            this.ClientesdataGridView.AllowUserToAddRows = false;
            this.ClientesdataGridView.AllowUserToDeleteRows = false;
            this.ClientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesdataGridView.Location = new System.Drawing.Point(12, 92);
            this.ClientesdataGridView.Name = "ClientesdataGridView";
            this.ClientesdataGridView.ReadOnly = true;
            this.ClientesdataGridView.Size = new System.Drawing.Size(834, 202);
            this.ClientesdataGridView.TabIndex = 4;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Image = global::BillEasy0._1._0.Properties.Resources._1446228633_kde_folder_print;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimirbutton.Location = new System.Drawing.Point(764, 300);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(82, 36);
            this.Imprimirbutton.TabIndex = 6;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 341);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ClientesdataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ClientestextBox);
            this.Controls.Add(this.BuscarClientescomboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BuscarClientescomboBox;
        private System.Windows.Forms.TextBox ClientestextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView ClientesdataGridView;
        private System.Windows.Forms.Button Imprimirbutton;
    }
}