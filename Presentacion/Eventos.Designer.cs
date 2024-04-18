namespace Presentacion
{
    partial class Eventos
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
            txtInfo = new TextBox();
            label3 = new Label();
            txtprecio = new TextBox();
            txthorario = new TextBox();
            label1 = new Label();
            cbPresentador = new ComboBox();
            label2 = new Label();
            cbAnimador = new ComboBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            AgregarEvento = new Button();
            checkBox1 = new CheckBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(414, 44);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(316, 93);
            txtInfo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 14;
            label3.Text = "Valor Base:";
            // 
            // txtprecio
            // 
            txtprecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtprecio.ForeColor = SystemColors.ActiveCaptionText;
            txtprecio.Location = new Point(173, 12);
            txtprecio.Margin = new Padding(3, 2, 3, 2);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(225, 27);
            txtprecio.TabIndex = 15;
            // 
            // txthorario
            // 
            txthorario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txthorario.ForeColor = SystemColors.ActiveCaptionText;
            txthorario.Location = new Point(122, 46);
            txthorario.Margin = new Padding(3, 2, 3, 2);
            txthorario.Name = "txthorario";
            txthorario.Size = new Size(276, 27);
            txthorario.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 18;
            label1.Text = "Horario:";
            // 
            // cbPresentador
            // 
            cbPresentador.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPresentador.FormattingEnabled = true;
            cbPresentador.Location = new Point(173, 80);
            cbPresentador.Name = "cbPresentador";
            cbPresentador.Size = new Size(225, 23);
            cbPresentador.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 21;
            label2.Text = "Presentador:";
            // 
            // cbAnimador
            // 
            cbAnimador.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAnimador.FormattingEnabled = true;
            cbAnimador.Location = new Point(225, 109);
            cbAnimador.Name = "cbAnimador";
            cbAnimador.Size = new Size(173, 23);
            cbAnimador.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(414, 9);
            label5.Name = "label5";
            label5.Size = new Size(291, 30);
            label5.TabIndex = 24;
            label5.Text = "Descripcion de Evento:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(708, 205);
            dataGridView1.TabIndex = 25;
            // 
            // AgregarEvento
            // 
            AgregarEvento.BackColor = SystemColors.ButtonShadow;
            AgregarEvento.FlatStyle = FlatStyle.System;
            AgregarEvento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgregarEvento.ForeColor = SystemColors.Control;
            AgregarEvento.Location = new Point(12, 142);
            AgregarEvento.Margin = new Padding(3, 2, 3, 2);
            AgregarEvento.Name = "AgregarEvento";
            AgregarEvento.Size = new Size(708, 48);
            AgregarEvento.TabIndex = 26;
            AgregarEvento.Text = "Agregar Nuevo Evento";
            AgregarEvento.UseVisualStyleBackColor = false;
            AgregarEvento.Click += AgregarEvento_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(173, 109);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(43, 26);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "SI";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(9, 103);
            label6.Name = "label6";
            label6.Size = new Size(158, 30);
            label6.TabIndex = 28;
            label6.Text = "¿Animador?";
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(AgregarEvento);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(cbAnimador);
            Controls.Add(label2);
            Controls.Add(cbPresentador);
            Controls.Add(label1);
            Controls.Add(txthorario);
            Controls.Add(txtprecio);
            Controls.Add(label3);
            Controls.Add(txtInfo);
            Name = "Eventos";
            Text = "Eventos";
            Load += Eventos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInfo;
        private Label label3;
        private TextBox txtprecio;
        private TextBox txthorario;
        private Label label1;
        private ComboBox cbPresentador;
        private Label label2;
        private ComboBox cbAnimador;
        private Label label5;
        private DataGridView dataGridView1;
        private Button AgregarEvento;
        private CheckBox checkBox1;
        private Label label6;
    }
}