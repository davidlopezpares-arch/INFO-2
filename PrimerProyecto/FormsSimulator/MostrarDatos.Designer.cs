namespace FormsSimulator
{
    partial class MostrarDatos
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
            Matriz = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Matriz).BeginInit();
            SuspendLayout();
            // 
            // Matriz
            // 
            Matriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Matriz.Location = new Point(12, 12);
            Matriz.Name = "Matriz";
            Matriz.RowHeadersWidth = 62;
            Matriz.Size = new Size(776, 426);
            Matriz.TabIndex = 0;
            Matriz.CellClick += Matriz_CellClick;
            // 
            // MostrarDatos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Matriz);
            Name = "MostrarDatos";
            Text = "MostrarDatos";
            Load += MostrarDatos_Load;
            ((System.ComponentModel.ISupportInitialize)Matriz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Matriz;
    }
}