namespace SITEMAVENTAS.VISTA.LISTASVISTAS
{
    partial class ClientesListarVista
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
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 84);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans Ultra Bold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(180, 55);
            label5.TabIndex = 22;
            label5.Text = "CLIENTES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gill Sans Ultra Bold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(796, 9);
            label6.Name = "label6";
            label6.Size = new Size(249, 55);
            label6.TabIndex = 21;
            label6.Text = "Market UPDS";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.market_upds1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1084, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.DialogResult = DialogResult.OK;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(915, 478);
            button3.Name = "button3";
            button3.Size = new Size(130, 54);
            button3.TabIndex = 36;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(175, 478);
            button2.Name = "button2";
            button2.Size = new Size(130, 54);
            button2.TabIndex = 35;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(25, 478);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 34;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1084, 388);
            dataGridView1.TabIndex = 33;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Blue;
            button4.Location = new Point(762, 478);
            button4.Name = "button4";
            button4.Size = new Size(130, 54);
            button4.TabIndex = 37;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ClientesListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1084, 552);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ClientesListarVista";
            Text = "ClientesListarVista";
            Load += ClientesListarVista_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button4;
    }
}