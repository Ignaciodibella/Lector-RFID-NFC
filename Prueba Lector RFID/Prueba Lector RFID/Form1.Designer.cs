namespace Prueba_Lector_RFID
{
    partial class Form1
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
            txt_udi_receiver = new TextBox();
            txt_3dni = new TextBox();
            btn_ingresar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_udi_receiver
            // 
            txt_udi_receiver.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_udi_receiver.Location = new Point(350, 16);
            txt_udi_receiver.Name = "txt_udi_receiver";
            txt_udi_receiver.Size = new Size(352, 47);
            txt_udi_receiver.TabIndex = 1;
            txt_udi_receiver.TextChanged += txt_udi_receiver_TextChanged;
            // 
            // txt_3dni
            // 
            txt_3dni.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txt_3dni.Location = new Point(350, 78);
            txt_3dni.Name = "txt_3dni";
            txt_3dni.PasswordChar = '*';
            txt_3dni.Size = new Size(352, 47);
            txt_3dni.TabIndex = 3;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ingresar.Location = new Point(556, 131);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(146, 53);
            btn_ingresar.TabIndex = 5;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 0;
            label1.Text = "RFID UID Identificado:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 81);
            label2.Name = "label2";
            label2.Size = new Size(340, 41);
            label2.TabIndex = 4;
            label2.Text = "Últimos 3 digitos DNI: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 200);
            Controls.Add(btn_ingresar);
            Controls.Add(label2);
            Controls.Add(txt_3dni);
            Controls.Add(txt_udi_receiver);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ingresar";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_udi_receiver;
        private TextBox txt_3dni;
        private Button btn_ingresar;
        private Label label1;
        private Label label2;
    }
}