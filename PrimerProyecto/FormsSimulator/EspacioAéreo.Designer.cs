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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Location = new Point(319, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Moverbutton
            // 
            Moverbutton.Location = new Point(57, 131);
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
            Automáticobutton.Location = new Point(57, 236);
            Automáticobutton.Name = "Automáticobutton";
            Automáticobutton.Size = new Size(175, 65);
            Automáticobutton.TabIndex = 2;
            Automáticobutton.Text = "Automático";
            Automáticobutton.UseVisualStyleBackColor = true;
            Automáticobutton.Click += Automáticobutton_Click;
            // 
            // MostarDatosButton
            // 
            MostarDatosButton.Location = new Point(57, 38);
            MostarDatosButton.Name = "MostarDatosButton";
            MostarDatosButton.Size = new Size(175, 58);
            MostarDatosButton.TabIndex = 3;
            MostarDatosButton.Text = "Mostrar Datos";
            MostarDatosButton.UseVisualStyleBackColor = true;
            MostarDatosButton.Click += MostarDatosButton_Click;
            // 
            // Conflicto
            // 
            Conflicto.Location = new Point(62, 343);
            Conflicto.Name = "Conflicto";
            Conflicto.Size = new Size(170, 60);
            Conflicto.TabIndex = 4;
            Conflicto.Text = "Comprobar Conflicto";
            Conflicto.UseVisualStyleBackColor = true;
            Conflicto.Click += Conflicto_Click;
            // 
            // EspacioAéreo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 468);
            Controls.Add(Conflicto);
            Controls.Add(MostarDatosButton);
            Controls.Add(Automáticobutton);
            Controls.Add(Moverbutton);
            Controls.Add(panel1);
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
    }
}