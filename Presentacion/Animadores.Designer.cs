namespace Presentacion
{
    partial class Animadores
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
            label2 = new Label();
            label1 = new Label();
            cbdisfraz = new ComboBox();
            label3 = new Label();
            txtnombre = new TextBox();
            txtrut = new TextBox();
            btnoAnimador = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 42;
            label2.Text = "Rut:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 43;
            label1.Text = "Nombre Completo: ";
            // 
            // cbdisfraz
            // 
            cbdisfraz.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdisfraz.FormattingEnabled = true;
            cbdisfraz.Location = new Point(280, 79);
            cbdisfraz.Name = "cbdisfraz";
            cbdisfraz.Size = new Size(201, 23);
            cbdisfraz.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(262, 30);
            label3.TabIndex = 45;
            label3.Text = "Personaje del Disfraz:";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.ForeColor = SystemColors.ActiveCaptionText;
            txtnombre.Location = new Point(262, 12);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(360, 27);
            txtnombre.TabIndex = 46;
            // 
            // txtrut
            // 
            txtrut.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtrut.ForeColor = SystemColors.ActiveCaptionText;
            txtrut.Location = new Point(76, 43);
            txtrut.Margin = new Padding(3, 2, 3, 2);
            txtrut.Name = "txtrut";
            txtrut.Size = new Size(189, 27);
            txtrut.TabIndex = 47;
            // 
            // btnoAnimador
            // 
            btnoAnimador.BackColor = SystemColors.ButtonShadow;
            btnoAnimador.FlatStyle = FlatStyle.System;
            btnoAnimador.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnoAnimador.ForeColor = SystemColors.Control;
            btnoAnimador.Location = new Point(499, 54);
            btnoAnimador.Margin = new Padding(3, 2, 3, 2);
            btnoAnimador.Name = "btnoAnimador";
            btnoAnimador.Size = new Size(202, 48);
            btnoAnimador.TabIndex = 48;
            btnoAnimador.Text = "Agregar Animador";
            btnoAnimador.UseVisualStyleBackColor = false;
            btnoAnimador.Click += btnoAnimador_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(689, 150);
            dataGridView1.TabIndex = 49;
            // 
            // Animadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 295);
            Controls.Add(dataGridView1);
            Controls.Add(btnoAnimador);
            Controls.Add(txtrut);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Controls.Add(cbdisfraz);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Animadores";
            Text = "Animadores";
            Load += Animadores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox cbdisfraz;
        private Label label3;
        private TextBox txtnombre;
        private TextBox txtrut;
        private Button btnoAnimador;
        private DataGridView dataGridView1;
    }
}