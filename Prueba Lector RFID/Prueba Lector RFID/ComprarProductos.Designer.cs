namespace Prueba_Lector_RFID
{
    partial class ComprarProductos
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
            gridProductos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            SuspendLayout();
            // 
            // gridProductos
            // 
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(12, 44);
            gridProductos.Name = "gridProductos";
            gridProductos.RowHeadersWidth = 51;
            gridProductos.RowTemplate.Height = 29;
            gridProductos.Size = new Size(558, 188);
            gridProductos.TabIndex = 0;
            gridProductos.CellContentDoubleClick += gridProductos_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // ComprarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 450);
            Controls.Add(label1);
            Controls.Add(gridProductos);
            Name = "ComprarProductos";
            Text = "ComprarProductos";
            Load += ComprarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridProductos;
        private Label label1;
    }
}