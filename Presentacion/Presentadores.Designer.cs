namespace Presentacion
{
    partial class Presentadores
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
            GridPresentadores = new DataGridView();
            label5 = new Label();
            label1 = new Label();
            txtrut = new TextBox();
            AgregarClientes = new Button();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)GridPresentadores).BeginInit();
            SuspendLayout();
            // 
            // GridPresentadores
            // 
            GridPresentadores.AllowUserToAddRows = false;
            GridPresentadores.AllowUserToDeleteRows = false;
            GridPresentadores.Anchor = AnchorStyles.None;
            GridPresentadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GridPresentadores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridPresentadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPresentadores.Location = new Point(12, 172);
            GridPresentadores.Name = "GridPresentadores";
            GridPresentadores.ReadOnly = true;
            GridPresentadores.RowTemplate.Height = 25;
            GridPresentadores.Size = new Size(693, 209);
            GridPresentadores.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(176, 48);
            label5.Name = "label5";
            label5.Size = new Size(170, 21);
            label5.TabIndex = 46;
            label5.Text = "Ejemplo: (27859309-6)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 45;
            label1.Text = "RUT:";
            label1.Click += label1_Click;
            // 
            // txtrut
            // 
            txtrut.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtrut.ForeColor = SystemColors.ActiveCaptionText;
            txtrut.Location = new Point(352, 45);
            txtrut.Margin = new Padding(3, 2, 3, 2);
            txtrut.Name = "txtrut";
            txtrut.Size = new Size(353, 27);
            txtrut.TabIndex = 44;
            // 
            // AgregarClientes
            // 
            AgregarClientes.BackColor = SystemColors.ButtonShadow;
            AgregarClientes.FlatStyle = FlatStyle.System;
            AgregarClientes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgregarClientes.ForeColor = SystemColors.Control;
            AgregarClientes.Location = new Point(12, 104);
            AgregarClientes.Margin = new Padding(3, 2, 3, 2);
            AgregarClientes.Name = "AgregarClientes";
            AgregarClientes.Size = new Size(693, 48);
            AgregarClientes.TabIndex = 43;
            AgregarClientes.Text = "Agregar Nuevo Presentador";
            AgregarClientes.UseVisualStyleBackColor = false;
            AgregarClientes.Click += AgregarClientes_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(167, 30);
            label4.TabIndex = 42;
            label4.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(246, 30);
            label3.TabIndex = 39;
            label3.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(264, 14);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(441, 27);
            txtNombre.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(354, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(351, 23);
            dateTimePicker1.TabIndex = 48;
            // 
            // Presentadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(dateTimePicker1);
            Controls.Add(GridPresentadores);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtrut);
            Controls.Add(AgregarClientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Name = "Presentadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Presentadores";
            ((System.ComponentModel.ISupportInitialize)GridPresentadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridPresentadores;
        private Label label5;
        private Label label1;
        private TextBox txtrut;
        private Button AgregarClientes;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private DateTimePicker dateTimePicker1;
    }
}