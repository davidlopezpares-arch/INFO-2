namespace FormsSimulator
{
    partial class ArreglarConflicto
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
            Mensaje = new Label();
            SiButton = new Button();
            NoButton = new Button();
            SuspendLayout();
            // 
            // Mensaje
            // 
            Mensaje.AutoSize = true;
            Mensaje.Location = new Point(199, 102);
            Mensaje.Name = "Mensaje";
            Mensaje.Size = new Size(356, 25);
            Mensaje.TabIndex = 0;
            Mensaje.Text = "Los vuelos van a chocar. Quieres arreglarlo?";
            // 
            // SiButton
            // 
            SiButton.Location = new Point(153, 213);
            SiButton.Name = "SiButton";
            SiButton.Size = new Size(112, 34);
            SiButton.TabIndex = 1;
            SiButton.Text = "Si";
            SiButton.UseVisualStyleBackColor = true;
            SiButton.Click += SiButton_Click;
            // 
            // NoButton
            // 
            NoButton.Location = new Point(518, 213);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(112, 34);
            NoButton.TabIndex = 2;
            NoButton.Text = "No";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // ArreglarConflicto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NoButton);
            Controls.Add(SiButton);
            Controls.Add(Mensaje);
            Name = "ArreglarConflicto";
            Text = "ArreglarConflicto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Mensaje;
        private Button SiButton;
        private Button NoButton;
    }
}