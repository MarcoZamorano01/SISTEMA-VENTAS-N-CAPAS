namespace SITEMAVENTAS.VISTA.ProveeVistas
{
    partial class ProveeEditarVista
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
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(157, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 27);
            dateTimePicker1.TabIndex = 62;
            // 
            // button4
            // 
            button4.Location = new Point(382, 29);
            button4.Name = "button4";
            button4.Size = new Size(121, 29);
            button4.TabIndex = 61;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(382, 82);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 60;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 184);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 59;
            label4.Text = "PRECIO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(346, 27);
            textBox3.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 133);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 57;
            label3.Text = "FECHA";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 82);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 55;
            label2.Text = "ID PROVEEDOR";
            // 
            // button2
            // 
            button2.Location = new Point(149, 251);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 54;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(281, 251);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 53;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 51;
            label1.Text = "ID PRODUCTO";
            // 
            // ProveeEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 289);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ProveeEditarVista";
            Text = "ProveeEditarVista";
            Load += ProveeEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button3;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}