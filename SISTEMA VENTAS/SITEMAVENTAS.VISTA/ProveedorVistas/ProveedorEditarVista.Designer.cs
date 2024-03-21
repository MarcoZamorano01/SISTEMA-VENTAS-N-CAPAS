namespace SITEMAVENTAS.VISTA.ProveedorVistas
{
    partial class ProveedorEditarVista
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
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 146);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 19;
            label3.Text = "DIRECCION";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 27);
            textBox3.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 88);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 17;
            label2.Text = "TELEFONO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(97, 209);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(215, 209);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 13;
            label1.Text = "NOMBRE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 27);
            textBox1.TabIndex = 12;
            // 
            // ProveedorEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 266);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ProveedorEditarVista";
            Text = "ProveedorEditarVista";
            Load += ProveedorEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}