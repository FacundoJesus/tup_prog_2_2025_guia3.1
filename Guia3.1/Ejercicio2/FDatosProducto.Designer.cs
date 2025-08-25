namespace Ejercicio2
{
    partial class FDatosProducto
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
            label1 = new Label();
            lbLargo = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            tbLargo = new TextBox();
            tbDescripcion = new TextBox();
            tbPrecio = new TextBox();
            cmbTipoProducto = new ComboBox();
            cmbTipoMaterial = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Producto";
            // 
            // lbLargo
            // 
            lbLargo.AutoSize = true;
            lbLargo.Location = new Point(12, 49);
            lbLargo.Name = "lbLargo";
            lbLargo.Size = new Size(37, 15);
            lbLargo.TabIndex = 1;
            lbLargo.Text = "Largo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 209);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Material";
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(12, 251);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(129, 33);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(240, 251);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 33);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(142, 46);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(172, 23);
            tbLargo.TabIndex = 7;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(142, 95);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(172, 23);
            tbDescripcion.TabIndex = 8;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(142, 151);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(172, 23);
            tbPrecio.TabIndex = 9;
            // 
            // cmbTipoProducto
            // 
            cmbTipoProducto.FormattingEnabled = true;
            cmbTipoProducto.Items.AddRange(new object[] { "Mesa", "Silla" });
            cmbTipoProducto.Location = new Point(142, 6);
            cmbTipoProducto.Name = "cmbTipoProducto";
            cmbTipoProducto.Size = new Size(172, 23);
            cmbTipoProducto.TabIndex = 10;
            cmbTipoProducto.SelectedIndexChanged += cmbTipoProducto_SelectedIndexChanged;
            // 
            // cmbTipoMaterial
            // 
            cmbTipoMaterial.FormattingEnabled = true;
            cmbTipoMaterial.Items.AddRange(new object[] { "Pino", "Algarrobo", "Caoba" });
            cmbTipoMaterial.Location = new Point(142, 201);
            cmbTipoMaterial.Name = "cmbTipoMaterial";
            cmbTipoMaterial.Size = new Size(172, 23);
            cmbTipoMaterial.TabIndex = 11;
            // 
            // FDatosProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 293);
            Controls.Add(cmbTipoMaterial);
            Controls.Add(cmbTipoProducto);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Controls.Add(tbLargo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbLargo);
            Controls.Add(label1);
            Name = "FDatosProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbLargo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAceptar;
        private Button btnCancelar;
        public TextBox tbLargo;
        public TextBox tbDescripcion;
        public TextBox tbPrecio;
        public ComboBox cmbTipoProducto;
        public ComboBox cmbTipoMaterial;
    }
}