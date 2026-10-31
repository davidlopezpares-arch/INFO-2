namespace FormsSimulator
{
    partial class DistanciaSeguridad
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
            DistanciaS = new TextBox();
            TiempoC = new TextBox();
            AceptarButton = new Button();
            AutorellenarDistBoton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Distancia de seguridad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Tiempo de ciclo";
            // 
            // DistanciaS
            // 
            DistanciaS.Location = new Point(123, 138);
            DistanciaS.Margin = new Padding(2, 2, 2, 2);
            DistanciaS.Name = "DistanciaS";
            DistanciaS.Size = new Size(121, 27);
            DistanciaS.TabIndex = 2;
            // 
            // TiempoC
            // 
            TiempoC.Location = new Point(410, 138);
            TiempoC.Margin = new Padding(2, 2, 2, 2);
            TiempoC.Name = "TiempoC";
            TiempoC.Size = new Size(121, 27);
            TiempoC.TabIndex = 3;
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(241, 267);
            AceptarButton.Margin = new Padding(2, 2, 2, 2);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(161, 38);
            AceptarButton.TabIndex = 4;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            AceptarButton.Click += AceptarButton_Click;
            // 
            // AutorellenarDistBoton
            // 
            AutorellenarDistBoton.Location = new Point(241, 232);
            AutorellenarDistBoton.Name = "AutorellenarDistBoton";
            AutorellenarDistBoton.Size = new Size(161, 29);
            AutorellenarDistBoton.TabIndex = 5;
            AutorellenarDistBoton.Text = "Autorellenar Datos";
            AutorellenarDistBoton.UseVisualStyleBackColor = true;
            AutorellenarDistBoton.Click += AutorellenarDistBoton_Click;
            // 
            // DistanciaSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(AutorellenarDistBoton);
            Controls.Add(AceptarButton);
            Controls.Add(TiempoC);
            Controls.Add(DistanciaS);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DistanciaSeguridad";
            Text = "DistanciaSeguridad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox DistanciaS;
        private TextBox TiempoC;
        private Button AceptarButton;
        private Button AutorellenarDistBoton;
    }
}