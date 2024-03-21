namespace SITEMAVENTAS.VISTA.UsuarioVistas
{
    partial class UsuarioEditarVista
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
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(129, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // button3
            // 
            button3.Location = new Point(261, 323);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 21;
            button3.Text = "GUARDAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(46, 323);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 20;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 219);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 19;
            label4.Text = "Fecha Reg.";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 27);
            textBox3.TabIndex = 18;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 152);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 17;
            label3.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 27);
            textBox2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 91);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 15;
            label2.Text = "Nombre User.";
            // 
            // button1
            // 
            button1.Location = new Point(261, 30);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 14;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 27);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 12;
            label1.Text = "Id Persona";
            // 
            // UsuarioEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 376);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UsuarioEditarVista";
            Text = "UsuarioEditarVista";
            Load += UsuarioEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button2;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}