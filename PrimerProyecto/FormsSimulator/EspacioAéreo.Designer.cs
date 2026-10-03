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
            panel1 = new Panel();
            button2 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Location = new Point(319, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 400);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(57, 131);
            button2.Name = "button2";
            button2.Size = new Size(175, 66);
            button2.TabIndex = 1;
            button2.Text = "Mover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EspacioAéreo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 468);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "EspacioAéreo";
            Text = "EspacioAéreo";
            Load += EspacioAéreo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
    }
}