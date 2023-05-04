namespace Prueba_Lector_RFID
{
    partial class PantallaUsuario
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
            lbl_bienvenida = new Label();
            btn_comprar = new Button();
            btn_cargar_saldo = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lbl_bienvenida
            // 
            lbl_bienvenida.AutoSize = true;
            lbl_bienvenida.Font = new Font("Sitka Banner", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_bienvenida.ImageAlign = ContentAlignment.BottomLeft;
            lbl_bienvenida.Location = new Point(161, 9);
            lbl_bienvenida.Name = "lbl_bienvenida";
            lbl_bienvenida.Size = new Size(0, 58);
            lbl_bienvenida.TabIndex = 0;
            // 
            // btn_comprar
            // 
            btn_comprar.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btn_comprar.Location = new Point(111, 136);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(357, 54);
            btn_comprar.TabIndex = 1;
            btn_comprar.Text = "Comprar Productos";
            btn_comprar.UseVisualStyleBackColor = true;
            btn_comprar.Click += btn_comprar_Click;
            // 
            // btn_cargar_saldo
            // 
            btn_cargar_saldo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cargar_saldo.Location = new Point(111, 242);
            btn_cargar_saldo.Name = "btn_cargar_saldo";
            btn_cargar_saldo.Size = new Size(357, 54);
            btn_cargar_saldo.TabIndex = 2;
            btn_cargar_saldo.Text = "Cargar Saldo";
            btn_cargar_saldo.UseVisualStyleBackColor = true;
            btn_cargar_saldo.Click += btn_cargar_saldo_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(111, 348);
            button3.Name = "button3";
            button3.Size = new Size(357, 54);
            button3.TabIndex = 3;
            button3.Text = "Otra Opción";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(111, 454);
            button4.Name = "button4";
            button4.Size = new Size(357, 54);
            button4.TabIndex = 4;
            button4.Text = "Otra Opción";
            button4.UseVisualStyleBackColor = true;
            // 
            // PantallaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 643);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btn_cargar_saldo);
            Controls.Add(btn_comprar);
            Controls.Add(lbl_bienvenida);
            Name = "PantallaUsuario";
            Text = "PantallaUsuario";
            Load += PantallaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_comprar;
        private Button btn_cargar_saldo;
        private Button button3;
        private Button button4;
        public Label lbl_bienvenida;
    }
}