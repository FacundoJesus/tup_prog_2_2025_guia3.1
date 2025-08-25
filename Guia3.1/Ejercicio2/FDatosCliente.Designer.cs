namespace Ejercicio2
{
    partial class FDatosCliente
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
            label2 = new Label();
            tbNombre = new TextBox();
            tbDireccion = new TextBox();
            btnAceptar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Dirección";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(96, 6);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(147, 23);
            tbNombre.TabIndex = 2;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(96, 44);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(147, 23);
            tbDireccion.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(12, 96);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(168, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FDatosCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 129);
            Controls.Add(button1);
            Controls.Add(btnAceptar);
            Controls.Add(tbDireccion);
            Controls.Add(tbNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FDatosCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox tbNombre;
        public TextBox tbDireccion;
        private Button btnAceptar;
        private Button button1;
    }
}