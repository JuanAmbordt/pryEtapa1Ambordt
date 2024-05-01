namespace pryEtapa1Ambordt
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
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnSalir = new Button();
            pctFirma = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctFirma).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(52, 45);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(52, 198);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(479, 308);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // pctFirma
            // 
            pctFirma.BackColor = SystemColors.ControlDark;
            pctFirma.Location = new Point(263, 45);
            pctFirma.Name = "pctFirma";
            pctFirma.Size = new Size(291, 176);
            pctFirma.TabIndex = 3;
            pctFirma.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 357);
            Controls.Add(pctFirma);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctFirma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnSalir;
        private PictureBox pctFirma;
    }
}
