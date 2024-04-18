namespace Presentacion
{
    partial class Disfraces
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
            label1 = new Label();
            txtpersonaje = new TextBox();
            label2 = new Label();
            gridisfraz = new DataGridView();
            AgregarClientes = new Button();
            txtprecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridisfraz).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 39;
            label1.Text = "PRECIO:";
            // 
            // txtpersonaje
            // 
            txtpersonaje.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpersonaje.ForeColor = SystemColors.ActiveCaptionText;
            txtpersonaje.Location = new Point(12, 46);
            txtpersonaje.Margin = new Padding(3, 2, 3, 2);
            txtpersonaje.Name = "txtpersonaje";
            txtpersonaje.Size = new Size(379, 27);
            txtpersonaje.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(303, 30);
            label2.TabIndex = 41;
            label2.Text = "PERSONAJE DEL DISFRAZ:";
            // 
            // gridisfraz
            // 
            gridisfraz.AllowUserToAddRows = false;
            gridisfraz.AllowUserToDeleteRows = false;
            gridisfraz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridisfraz.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridisfraz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridisfraz.Location = new Point(397, 9);
            gridisfraz.Name = "gridisfraz";
            gridisfraz.ReadOnly = true;
            gridisfraz.RowTemplate.Height = 25;
            gridisfraz.Size = new Size(325, 160);
            gridisfraz.TabIndex = 42;
            // 
            // AgregarClientes
            // 
            AgregarClientes.BackColor = SystemColors.ButtonShadow;
            AgregarClientes.FlatStyle = FlatStyle.System;
            AgregarClientes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgregarClientes.ForeColor = SystemColors.Control;
            AgregarClientes.Location = new Point(12, 121);
            AgregarClientes.Margin = new Padding(3, 2, 3, 2);
            AgregarClientes.Name = "AgregarClientes";
            AgregarClientes.Size = new Size(379, 48);
            AgregarClientes.TabIndex = 43;
            AgregarClientes.Text = "Agregar Nuevo Disfraz";
            AgregarClientes.UseVisualStyleBackColor = false;
            AgregarClientes.Click += AgregarClientes_Click;
            // 
            // txtprecio
            // 
            txtprecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtprecio.ForeColor = SystemColors.ActiveCaptionText;
            txtprecio.Location = new Point(127, 80);
            txtprecio.Margin = new Padding(3, 2, 3, 2);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(264, 27);
            txtprecio.TabIndex = 44;
            // 
            // Disfraces
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 196);
            Controls.Add(txtprecio);
            Controls.Add(AgregarClientes);
            Controls.Add(gridisfraz);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpersonaje);
            Name = "Disfraces";
            Text = "Disfraces";
            ((System.ComponentModel.ISupportInitialize)gridisfraz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private TextBox txtrut;
        private TextBox txtpersonaje;
        private Label label2;
        private DataGridView gridisfraz;
        private Button AgregarClientes;
        private TextBox txtprecio;
    }
}