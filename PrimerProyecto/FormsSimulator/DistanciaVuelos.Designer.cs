namespace FormsSimulator
{
    partial class DistanciaVuelos
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
            Distancia = new Label();
            SuspendLayout();
            // 
            // Distancia
            // 
            Distancia.AutoSize = true;
            Distancia.Location = new Point(273, 184);
            Distancia.Name = "Distancia";
            Distancia.Size = new Size(59, 25);
            Distancia.TabIndex = 0;
            Distancia.Text = "label1";
            // 
            // DistanciaVuelos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Distancia);
            Name = "DistanciaVuelos";
            Text = "DistanciaVuelos";
            Load += DistanciaVuelos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Distancia;
    }
}