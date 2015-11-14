namespace BillEasy0._1._0
{
    partial class RegistroMarca
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
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.MarcaIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::BillEasy0._1._0.Properties.Resources._1443839488_file_search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(252, 11);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(74, 42);
            this.Buscarbutton.TabIndex = 31;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.Image = global::BillEasy0._1._0.Properties.Resources._1445977752_Save;
            this.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGuardar.Location = new System.Drawing.Point(150, 141);
            this.ButtonGuardar.MaximumSize = new System.Drawing.Size(81, 44);
            this.ButtonGuardar.MinimumSize = new System.Drawing.Size(81, 44);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(81, 44);
            this.ButtonGuardar.TabIndex = 30;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGuardar.UseVisualStyleBackColor = true;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::BillEasy0._1._0.Properties.Resources._1445976510_Delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(257, 141);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(81, 44);
            this.EliminarButton.TabIndex = 29;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::BillEasy0._1._0.Properties.Resources._1445976554_Plus__Orange;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(46, 141);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(81, 44);
            this.Nuevobutton.TabIndex = 28;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(135, 59);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(191, 20);
            this.NombreTextBox.TabIndex = 23;
            // 
            // MarcaIdtextBox
            // 
            this.MarcaIdtextBox.Location = new System.Drawing.Point(135, 23);
            this.MarcaIdtextBox.Name = "MarcaIdtextBox";
            this.MarcaIdtextBox.Size = new System.Drawing.Size(111, 20);
            this.MarcaIdtextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "MarcaId:";
            // 
            // RegistroMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 193);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.MarcaIdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroMarca";
            this.Text = "RegistroMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox MarcaIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}