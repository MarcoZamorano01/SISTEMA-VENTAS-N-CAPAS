﻿namespace SITEMAVENTAS.VISTA.VentaVistas
{
    partial class VentaInsertarVista
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
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(372, 35);
            button4.Name = "button4";
            button4.Size = new Size(121, 29);
            button4.TabIndex = 49;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(372, 88);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 48;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(147, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(346, 27);
            textBox4.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 190);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 44;
            label4.Text = "TOTAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 139);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 42;
            label3.Text = "FECHA ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 88);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 40;
            label2.Text = "ID VENDEDOR";
            // 
            // button2
            // 
            button2.Location = new Point(148, 269);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 39;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(280, 269);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 38;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 36;
            label1.Text = "ID CLIENTE";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 27);
            dateTimePicker1.TabIndex = 50;
            // 
            // VentaInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 325);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "VentaInsertarVista";
            Text = "VentaInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}