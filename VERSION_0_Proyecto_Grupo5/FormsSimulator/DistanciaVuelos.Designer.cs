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
            VolverAtrasBoton_DistanciaVuelos = new Button();
            SuspendLayout();
            // 
            // Distancia
            // 
            Distancia.AutoSize = true;
            Distancia.Location = new Point(218, 147);
            Distancia.Margin = new Padding(2, 0, 2, 0);
            Distancia.Name = "Distancia";
            Distancia.Size = new Size(50, 20);
            Distancia.TabIndex = 0;
            Distancia.Text = "label1";
            // 
            // VolverAtrasBoton_DistanciaVuelos
            // 
            VolverAtrasBoton_DistanciaVuelos.Location = new Point(246, 224);
            VolverAtrasBoton_DistanciaVuelos.Name = "VolverAtrasBoton_DistanciaVuelos";
            VolverAtrasBoton_DistanciaVuelos.Size = new Size(127, 29);
            VolverAtrasBoton_DistanciaVuelos.TabIndex = 1;
            VolverAtrasBoton_DistanciaVuelos.Text = "Volver atrás";
            VolverAtrasBoton_DistanciaVuelos.UseVisualStyleBackColor = true;
            VolverAtrasBoton_DistanciaVuelos.Click += VolverAtrasBoton_DistanciaVuelos_Click;
            // 
            // DistanciaVuelos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(VolverAtrasBoton_DistanciaVuelos);
            Controls.Add(Distancia);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DistanciaVuelos";
            Text = "DistanciaVuelos";
            Load += DistanciaVuelos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Distancia;
        private Button VolverAtrasBoton_DistanciaVuelos;
    }
}