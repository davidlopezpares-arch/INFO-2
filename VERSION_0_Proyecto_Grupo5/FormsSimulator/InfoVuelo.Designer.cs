namespace FormsSimulator
{
    partial class InfoVuelo
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
            VolverAtrasBoton_InfoVuelo = new Button();
            ((System.ComponentModel.ISupportInitialize)Matriz).BeginInit();
            SuspendLayout();
            // 
            // Matriz
            // 
            Matriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Matriz.Location = new Point(20, 10);
            Matriz.Margin = new Padding(2, 2, 2, 2);
            Matriz.Name = "Matriz";
            Matriz.RowHeadersWidth = 62;
            Matriz.Size = new Size(610, 341);
            Matriz.TabIndex = 0;
            // 
            // VolverAtrasBoton_InfoVuelo
            // 
            VolverAtrasBoton_InfoVuelo.Location = new Point(248, 357);
            VolverAtrasBoton_InfoVuelo.Name = "VolverAtrasBoton_InfoVuelo";
            VolverAtrasBoton_InfoVuelo.Size = new Size(153, 29);
            VolverAtrasBoton_InfoVuelo.TabIndex = 1;
            VolverAtrasBoton_InfoVuelo.Text = "Volver atrás";
            VolverAtrasBoton_InfoVuelo.UseVisualStyleBackColor = true;
            VolverAtrasBoton_InfoVuelo.Click += VolverAtrasBoton_InfoVuelo_Click;
            // 
            // InfoVuelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 398);
            Controls.Add(VolverAtrasBoton_InfoVuelo);
            Controls.Add(Matriz);
            Margin = new Padding(2, 2, 2, 2);
            Name = "InfoVuelo";
            Text = "InfoVuelo";
            Load += InfoVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)Matriz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Matriz;
        private Button VolverAtrasBoton_InfoVuelo;
    }
}