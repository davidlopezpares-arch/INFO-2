namespace FormsSimulator
{
    partial class CambiarVel
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
            Vuelolbl = new Label();
            AceptarBtn = new Button();
            VelocidadBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // Vuelolbl
            // 
            Vuelolbl.AutoSize = true;
            Vuelolbl.Location = new Point(90, 78);
            Vuelolbl.Name = "Vuelolbl";
            Vuelolbl.Size = new Size(59, 25);
            Vuelolbl.TabIndex = 0;
            Vuelolbl.Text = "label1";
            // 
            // AceptarBtn
            // 
            AceptarBtn.Location = new Point(602, 78);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(112, 34);
            AceptarBtn.TabIndex = 1;
            AceptarBtn.Text = "Aceptar";
            AceptarBtn.UseVisualStyleBackColor = true;
            AceptarBtn.Click += AceptarBtn_Click;
            // 
            // VelocidadBox
            // 
            VelocidadBox.Location = new Point(310, 81);
            VelocidadBox.Name = "VelocidadBox";
            VelocidadBox.Size = new Size(150, 31);
            VelocidadBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 38);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 3;
            label2.Text = "Nueva Velocidad";
            // 
            // CambiarVel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(VelocidadBox);
            Controls.Add(AceptarBtn);
            Controls.Add(Vuelolbl);
            Name = "CambiarVel";
            Text = "CambiarVel";
            Load += CambiarVel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Vuelolbl;
        private Button AceptarBtn;
        private TextBox VelocidadBox;
        private Label label2;
    }
}