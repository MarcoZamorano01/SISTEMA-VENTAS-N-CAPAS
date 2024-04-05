namespace SITEMAVENTAS.VISTA.PLATAFORMAVISTAS
{
    partial class DESPEDIDA
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
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(863, 138);
            label3.Name = "label3";
            label3.Size = new Size(170, 82);
            label3.TabIndex = 27;
            label3.Text = "UPDS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 138);
            label1.Name = "label1";
            label1.Size = new Size(252, 82);
            label1.TabIndex = 26;
            label1.Text = "MARKET";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(0, 484);
            button1.Name = "button1";
            button1.Size = new Size(1072, 68);
            button1.TabIndex = 25;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.upds;
            pictureBox1.Location = new Point(249, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold Condensed", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(141, -1);
            label2.Name = "label2";
            label2.Size = new Size(831, 64);
            label2.TabIndex = 23;
            label2.Text = "GRACIAS POR UTITLIZAR ESTE SISTEMA";
            // 
            // DESPEDIDA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1072, 552);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "DESPEDIDA";
            Text = "DESPEDIDA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}