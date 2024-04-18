namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            ButtonLogin = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(152, 26);
            label3.Name = "label3";
            label3.Size = new Size(256, 39);
            label3.TabIndex = 11;
            label3.Text = "Autentificación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(52, 170);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(52, 103);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 9;
            label1.Text = "Usuario:";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = SystemColors.ActiveCaptionText;
            txtPass.Location = new Point(198, 170);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(235, 27);
            txtPass.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.ActiveCaptionText;
            txtUsuario.Location = new Point(198, 103);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(235, 27);
            txtUsuario.TabIndex = 7;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = SystemColors.ButtonShadow;
            ButtonLogin.FlatAppearance.BorderSize = 0;
            ButtonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            ButtonLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            ButtonLogin.FlatStyle = FlatStyle.System;
            ButtonLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLogin.ForeColor = SystemColors.Control;
            ButtonLogin.Location = new Point(198, 224);
            ButtonLogin.Margin = new Padding(3, 2, 3, 2);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(234, 41);
            ButtonLogin.TabIndex = 6;
            ButtonLogin.Text = "Ingresar";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(ButtonLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPass;
        private TextBox txtUsuario;
        private Button ButtonLogin;
    }
}