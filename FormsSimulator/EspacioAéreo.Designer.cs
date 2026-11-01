namespace FormsSimulator
{
    partial class EspacioAéreo
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Moverbutton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Automáticobutton = new Button();
            MostarDatosButton = new Button();
            Conflicto = new Button();
            VolverAtrasBoton_EspacioAereo = new Button();
            CambiarVelocidad = new Button();
            Restart = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Location = new Point(319, 28);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Moverbutton
            // 
            Moverbutton.Location = new Point(58, 131);
            Moverbutton.Margin = new Padding(2);
            Moverbutton.Name = "Moverbutton";
            Moverbutton.Size = new Size(175, 66);
            Moverbutton.TabIndex = 1;
            Moverbutton.Text = "Mover";
            Moverbutton.UseVisualStyleBackColor = true;
            Moverbutton.Click += Moverbutton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Automáticobutton
            // 
            Automáticobutton.Location = new Point(58, 236);
            Automáticobutton.Margin = new Padding(2);
            Automáticobutton.Name = "Automáticobutton";
            Automáticobutton.Size = new Size(175, 65);
            Automáticobutton.TabIndex = 2;
            Automáticobutton.Text = "Automático";
            Automáticobutton.UseVisualStyleBackColor = true;
            Automáticobutton.Click += Automáticobutton_Click;
            // 
            // MostarDatosButton
            // 
            MostarDatosButton.Location = new Point(58, 38);
            MostarDatosButton.Margin = new Padding(2);
            MostarDatosButton.Name = "MostarDatosButton";
            MostarDatosButton.Size = new Size(175, 58);
            MostarDatosButton.TabIndex = 3;
            MostarDatosButton.Text = "Mostrar Datos";
            MostarDatosButton.UseVisualStyleBackColor = true;
            MostarDatosButton.Click += MostarDatosButton_Click;
            // 
            // Conflicto
            // 
            Conflicto.Location = new Point(62, 342);
            Conflicto.Margin = new Padding(2);
            Conflicto.Name = "Conflicto";
            Conflicto.Size = new Size(170, 60);
            Conflicto.TabIndex = 4;
            Conflicto.Text = "Comprobar Conflicto";
            Conflicto.UseVisualStyleBackColor = true;
            Conflicto.Click += Conflicto_Click;
            // 
            // VolverAtrasBoton_EspacioAereo
            // 
            VolverAtrasBoton_EspacioAereo.Location = new Point(288, 452);
            VolverAtrasBoton_EspacioAereo.Margin = new Padding(4);
            VolverAtrasBoton_EspacioAereo.Name = "VolverAtrasBoton_EspacioAereo";
            VolverAtrasBoton_EspacioAereo.Size = new Size(259, 36);
            VolverAtrasBoton_EspacioAereo.TabIndex = 5;
            VolverAtrasBoton_EspacioAereo.Text = "Volver atrás";
            VolverAtrasBoton_EspacioAereo.UseVisualStyleBackColor = true;
            VolverAtrasBoton_EspacioAereo.Click += VolverAtrasBoton_EspacioAereo_Click;
            // 
            // CambiarVelocidad
            // 
            CambiarVelocidad.Location = new Point(62, 429);
            CambiarVelocidad.Name = "CambiarVelocidad";
            CambiarVelocidad.Size = new Size(171, 59);
            CambiarVelocidad.TabIndex = 6;
            CambiarVelocidad.Text = "Cambiar velocidad";
            CambiarVelocidad.UseVisualStyleBackColor = true;
            CambiarVelocidad.Click += CambiarVelocidad_Click;
            // 
            // Restart
            // 
            Restart.Location = new Point(707, 433);
            Restart.Name = "Restart";
            Restart.Size = new Size(112, 74);
            Restart.TabIndex = 7;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // EspacioAéreo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 519);
            Controls.Add(Restart);
            Controls.Add(CambiarVelocidad);
            Controls.Add(VolverAtrasBoton_EspacioAereo);
            Controls.Add(Conflicto);
            Controls.Add(MostarDatosButton);
            Controls.Add(Automáticobutton);
            Controls.Add(Moverbutton);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "EspacioAéreo";
            Text = "EspacioAéreo";
            Load += EspacioAéreo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Moverbutton;
        private System.Windows.Forms.Timer timer1;
        private Button Automáticobutton;
        private Button MostarDatosButton;
        private Button Conflicto;
        private Button VolverAtrasBoton_EspacioAereo;
        private Button CambiarVelocidad;
        private Button Restart;
    }
}