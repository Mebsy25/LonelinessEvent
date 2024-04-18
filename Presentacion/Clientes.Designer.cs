namespace Presentacion
{
    partial class Clientes
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
            label3 = new Label();
            txtDomicilio = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            txtTelfono = new TextBox();
            AgregarClientes = new Button();
            txtrut = new TextBox();
            label1 = new Label();
            label5 = new Label();
            GridClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridClientes).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 14;
            label2.Text = "Domicilio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 13;
            label3.Text = "Nombre:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDomicilio.ForeColor = SystemColors.ActiveCaptionText;
            txtDomicilio.Location = new Point(152, 106);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(553, 27);
            txtDomicilio.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(264, 14);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(441, 27);
            txtNombre.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 16;
            label4.Text = "Telefono";
            // 
            // txtTelfono
            // 
            txtTelfono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelfono.ForeColor = SystemColors.ActiveCaptionText;
            txtTelfono.Location = new Point(352, 75);
            txtTelfono.Margin = new Padding(3, 2, 3, 2);
            txtTelfono.Name = "txtTelfono";
            txtTelfono.Size = new Size(353, 27);
            txtTelfono.TabIndex = 15;
            txtTelfono.TextChanged += txtTelfono_TextChanged;
            txtTelfono.KeyPress += txtTelfono_KeyPress;
            // 
            // AgregarClientes
            // 
            AgregarClientes.BackColor = SystemColors.ButtonShadow;
            AgregarClientes.FlatStyle = FlatStyle.System;
            AgregarClientes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgregarClientes.ForeColor = SystemColors.Control;
            AgregarClientes.Location = new Point(12, 137);
            AgregarClientes.Margin = new Padding(3, 2, 3, 2);
            AgregarClientes.Name = "AgregarClientes";
            AgregarClientes.Size = new Size(693, 48);
            AgregarClientes.TabIndex = 17;
            AgregarClientes.Text = "Agregar Nuevo Cliente";
            AgregarClientes.UseVisualStyleBackColor = false;
            AgregarClientes.Click += AgregarClientes_Click;
            // 
            // txtrut
            // 
            txtrut.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtrut.ForeColor = SystemColors.ActiveCaptionText;
            txtrut.Location = new Point(352, 45);
            txtrut.Margin = new Padding(3, 2, 3, 2);
            txtrut.Name = "txtrut";
            txtrut.Size = new Size(353, 27);
            txtrut.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 34;
            label1.Text = "RUT:";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(176, 48);
            label5.Name = "label5";
            label5.Size = new Size(170, 21);
            label5.TabIndex = 35;
            label5.Text = "Ejemplo: (27859309-6)";
            // 
            // GridClientes
            // 
            GridClientes.AllowUserToAddRows = false;
            GridClientes.AllowUserToDeleteRows = false;
            GridClientes.Anchor = AnchorStyles.None;
            GridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GridClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridClientes.Location = new Point(12, 190);
            GridClientes.Name = "GridClientes";
            GridClientes.ReadOnly = true;
            GridClientes.RowTemplate.Height = 25;
            GridClientes.Size = new Size(693, 209);
            GridClientes.TabIndex = 36;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(GridClientes);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtrut);
            Controls.Add(AgregarClientes);
            Controls.Add(label4);
            Controls.Add(txtTelfono);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtDomicilio);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            KeyPress += Clientes_KeyPress;
            ((System.ComponentModel.ISupportInitialize)GridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtDomicilio;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtTelfono;
        private Button AgregarClientes;
        private TextBox txtrut;
        private Label label1;
        private Label label5;
        private DataGridView GridClientes;
    }
}