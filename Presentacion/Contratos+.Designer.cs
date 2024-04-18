namespace Presentacion
{
    partial class Contratos_
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
            label6 = new Label();
            cbClientes = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbEventos = new ComboBox();
            txtlugar = new TextBox();
            txtpreciofinal = new TextBox();
            txtmetododepago = new TextBox();
            AgregarContrato = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 31;
            label6.Text = "Cliente:";
            // 
            // cbClientes
            // 
            cbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(125, 16);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(235, 23);
            cbClientes.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 32;
            label1.Text = "Evento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 33;
            label2.Text = "Lugar del Evento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 34;
            label3.Text = "Valor Final:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(223, 30);
            label4.TabIndex = 35;
            label4.Text = "Metodo de Pago:";
            // 
            // cbEventos
            // 
            cbEventos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEventos.FormattingEnabled = true;
            cbEventos.Location = new Point(125, 46);
            cbEventos.Name = "cbEventos";
            cbEventos.Size = new Size(235, 23);
            cbEventos.TabIndex = 36;
            // 
            // txtlugar
            // 
            txtlugar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtlugar.ForeColor = SystemColors.ActiveCaptionText;
            txtlugar.Location = new Point(238, 72);
            txtlugar.Margin = new Padding(3, 2, 3, 2);
            txtlugar.Name = "txtlugar";
            txtlugar.Size = new Size(344, 27);
            txtlugar.TabIndex = 37;
            // 
            // txtpreciofinal
            // 
            txtpreciofinal.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpreciofinal.ForeColor = SystemColors.ActiveCaptionText;
            txtpreciofinal.Location = new Point(238, 104);
            txtpreciofinal.Margin = new Padding(3, 2, 3, 2);
            txtpreciofinal.Name = "txtpreciofinal";
            txtpreciofinal.Size = new Size(218, 27);
            txtpreciofinal.TabIndex = 38;
            // 
            // txtmetododepago
            // 
            txtmetododepago.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmetododepago.ForeColor = SystemColors.ActiveCaptionText;
            txtmetododepago.Location = new Point(238, 139);
            txtmetododepago.Margin = new Padding(3, 2, 3, 2);
            txtmetododepago.Name = "txtmetododepago";
            txtmetododepago.Size = new Size(218, 27);
            txtmetododepago.TabIndex = 39;
            // 
            // AgregarContrato
            // 
            AgregarContrato.BackColor = SystemColors.ButtonShadow;
            AgregarContrato.FlatStyle = FlatStyle.System;
            AgregarContrato.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgregarContrato.ForeColor = SystemColors.Control;
            AgregarContrato.Location = new Point(492, 118);
            AgregarContrato.Margin = new Padding(3, 2, 3, 2);
            AgregarContrato.Name = "AgregarContrato";
            AgregarContrato.Size = new Size(211, 48);
            AgregarContrato.TabIndex = 40;
            AgregarContrato.Text = "Agregar Nuevo Contrato";
            AgregarContrato.UseVisualStyleBackColor = false;
            AgregarContrato.Click += AgregarContrato_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(691, 177);
            dataGridView1.TabIndex = 41;
            // 
            // Contratos_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 387);
            Controls.Add(dataGridView1);
            Controls.Add(AgregarContrato);
            Controls.Add(txtmetododepago);
            Controls.Add(txtpreciofinal);
            Controls.Add(txtlugar);
            Controls.Add(cbEventos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(cbClientes);
            Name = "Contratos_";
            Text = "Contratos_";
            Load += Contratos__Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cbClientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbEventos;
        private TextBox txtlugar;
        private TextBox txtpreciofinal;
        private TextBox txtmetododepago;
        private Button AgregarContrato;
        private DataGridView dataGridView1;
    }
}