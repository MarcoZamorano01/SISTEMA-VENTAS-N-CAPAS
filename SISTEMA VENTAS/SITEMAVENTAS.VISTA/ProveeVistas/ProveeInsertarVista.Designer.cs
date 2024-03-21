namespace SITEMAVENTAS.VISTA.ProveeVistas
{
    partial class ProveeInsertarVista
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
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(389, 31);
            button4.Name = "button4";
            button4.Size = new Size(121, 29);
            button4.TabIndex = 49;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(389, 84);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 48;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 186);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 44;
            label4.Text = "PRECIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 135);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 42;
            label3.Text = "FECHA";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 84);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 40;
            label2.Text = "ID PROVEEDOR";
            // 
            // button2
            // 
            button2.Location = new Point(156, 253);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 39;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(288, 253);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 38;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 36;
            label1.Text = "ID PRODUCTO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(346, 27);
            textBox3.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 135);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 27);
            dateTimePicker1.TabIndex = 50;
            // 
            // ProveeInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 310);
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
            Name = "ProveeInsertarVista";
            Text = "ProveeInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
    }
}