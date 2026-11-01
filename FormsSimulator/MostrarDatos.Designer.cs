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
            VolverAtrasBoton_MostrarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)Matriz).BeginInit();
            SuspendLayout();
            // 
            // Matriz
            // 
            Matriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Matriz.Location = new Point(10, 10);
            Matriz.Margin = new Padding(2);
            Matriz.Name = "Matriz";
            Matriz.RowHeadersWidth = 62;
            Matriz.Size = new Size(621, 341);
            Matriz.TabIndex = 0;
            Matriz.CellClick += Matriz_CellClick;
            // 
            // VolverAtrasBoton_MostrarDatos
            // 
            VolverAtrasBoton_MostrarDatos.Location = new Point(250, 370);
            VolverAtrasBoton_MostrarDatos.Name = "VolverAtrasBoton_MostrarDatos";
            VolverAtrasBoton_MostrarDatos.Size = new Size(122, 28);
            VolverAtrasBoton_MostrarDatos.TabIndex = 1;
            VolverAtrasBoton_MostrarDatos.Text = "Volver atrás";
            VolverAtrasBoton_MostrarDatos.UseVisualStyleBackColor = true;
            VolverAtrasBoton_MostrarDatos.Click += VolverAtrasBoton_MostrarDatos_Click;
            // 
            // MostrarDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 426);
            Controls.Add(VolverAtrasBoton_MostrarDatos);
            Controls.Add(Matriz);
            Margin = new Padding(2);
            Name = "MostrarDatos";
            Text = "MostrarDatos";
            Load += MostrarDatos_Load;
            ((System.ComponentModel.ISupportInitialize)Matriz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Matriz;
        private Button VolverAtrasBoton_MostrarDatos;
    }
}