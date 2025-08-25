namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarPresupuesto = new Button();
            btnAgregarProducto = new Button();
            btnVerPresupuesto = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            lbNombre = new Label();
            lbDireccion = new Label();
            SuspendLayout();
            // 
            // btnIniciarPresupuesto
            // 
            btnIniciarPresupuesto.Location = new Point(12, 12);
            btnIniciarPresupuesto.Name = "btnIniciarPresupuesto";
            btnIniciarPresupuesto.Size = new Size(140, 33);
            btnIniciarPresupuesto.TabIndex = 0;
            btnIniciarPresupuesto.Text = "Iniciar Presupuesto";
            btnIniciarPresupuesto.UseVisualStyleBackColor = true;
            btnIniciarPresupuesto.Click += btnIniciarPresupuesto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(12, 51);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(140, 33);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnVerPresupuesto
            // 
            btnVerPresupuesto.Location = new Point(12, 90);
            btnVerPresupuesto.Name = "btnVerPresupuesto";
            btnVerPresupuesto.Size = new Size(140, 33);
            btnVerPresupuesto.TabIndex = 2;
            btnVerPresupuesto.Text = "Ver Presupuesto";
            btnVerPresupuesto.UseVisualStyleBackColor = true;
            btnVerPresupuesto.Click += btnVerPresupuesto_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(12, 129);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 33);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 69);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 21);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(258, 21);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(12, 15);
            lbNombre.TabIndex = 6;
            lbNombre.Text = "-";
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Location = new Point(258, 69);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(12, 15);
            lbDireccion.TabIndex = 7;
            lbDireccion.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 176);
            Controls.Add(lbDireccion);
            Controls.Add(lbNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerPresupuesto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnIniciarPresupuesto);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarPresupuesto;
        private Button btnAgregarProducto;
        private Button btnVerPresupuesto;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
        private Label lbNombre;
        private Label lbDireccion;
    }
}
