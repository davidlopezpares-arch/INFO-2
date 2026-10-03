namespace FormsSimulator
{
    partial class Simulator
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
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevoFormularioToolStripMenuItem = new ToolStripMenuItem();
            distSeguridadYTCicloToolStripMenuItem = new ToolStripMenuItem();
            espacioAéreoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoFormularioToolStripMenuItem, distSeguridadYTCicloToolStripMenuItem, espacioAéreoToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(103, 29);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nuevoFormularioToolStripMenuItem
            // 
            nuevoFormularioToolStripMenuItem.Name = "nuevoFormularioToolStripMenuItem";
            nuevoFormularioToolStripMenuItem.Size = new Size(300, 34);
            nuevoFormularioToolStripMenuItem.Text = "Nuevo Formulario";
            nuevoFormularioToolStripMenuItem.Click += nuevoFormularioToolStripMenuItem_Click;
            // 
            // distSeguridadYTCicloToolStripMenuItem
            // 
            distSeguridadYTCicloToolStripMenuItem.Name = "distSeguridadYTCicloToolStripMenuItem";
            distSeguridadYTCicloToolStripMenuItem.Size = new Size(300, 34);
            distSeguridadYTCicloToolStripMenuItem.Text = "Dist.Seguridad y T.Ciclo";
            distSeguridadYTCicloToolStripMenuItem.Click += distSeguridadYTCicloToolStripMenuItem_Click;
            // 
            // espacioAéreoToolStripMenuItem
            // 
            espacioAéreoToolStripMenuItem.Name = "espacioAéreoToolStripMenuItem";
            espacioAéreoToolStripMenuItem.Size = new Size(300, 34);
            espacioAéreoToolStripMenuItem.Text = "Espacio Aéreo";
            espacioAéreoToolStripMenuItem.Click += espacioAéreoToolStripMenuItem_Click;
            // 
            // Simulator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Simulator";
            Text = "Simulator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem nuevoFormularioToolStripMenuItem;
        private ToolStripMenuItem distSeguridadYTCicloToolStripMenuItem;
        private ToolStripMenuItem espacioAéreoToolStripMenuItem;
    }
}
