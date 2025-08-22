namespace Ejercicio1
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
            tbMuestra = new TextBox();
            btnPrueba = new Button();
            SuspendLayout();
            // 
            // tbMuestra
            // 
            tbMuestra.Location = new Point(12, 12);
            tbMuestra.Multiline = true;
            tbMuestra.Name = "tbMuestra";
            tbMuestra.Size = new Size(679, 227);
            tbMuestra.TabIndex = 0;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(713, 106);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(75, 50);
            btnPrueba.TabIndex = 1;
            btnPrueba.Text = "Prueba";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 255);
            Controls.Add(btnPrueba);
            Controls.Add(tbMuestra);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMuestra;
        private Button btnPrueba;
    }
}
