
namespace EncriptadorMultiple
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
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsuarioEncriptado = new System.Windows.Forms.Label();
            this.tbUsuarioEncriptadoMD5 = new System.Windows.Forms.TextBox();
            this.tbPasswordEncriptado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLlavePublica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLlavePrivada = new System.Windows.Forms.TextBox();
            this.tbPasswordDesencriptado = new System.Windows.Forms.TextBox();
            this.lbPasswordDesencriptado = new System.Windows.Forms.Label();
            this.tbUsuarioEncriptadoSHA256 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUsuario.Location = new System.Drawing.Point(12, 76);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(214, 23);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(94, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.UseMnemonic = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(94, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPassword.Location = new System.Drawing.Point(12, 148);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(214, 23);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lblUsuarioEncriptado
            // 
            this.lblUsuarioEncriptado.AutoSize = true;
            this.lblUsuarioEncriptado.Location = new System.Drawing.Point(450, 20);
            this.lblUsuarioEncriptado.Name = "lblUsuarioEncriptado";
            this.lblUsuarioEncriptado.Size = new System.Drawing.Size(131, 15);
            this.lblUsuarioEncriptado.TabIndex = 4;
            this.lblUsuarioEncriptado.Text = "Usuario Encripado MD5";
            // 
            // tbUsuarioEncriptadoMD5
            // 
            this.tbUsuarioEncriptadoMD5.Location = new System.Drawing.Point(341, 47);
            this.tbUsuarioEncriptadoMD5.Name = "tbUsuarioEncriptadoMD5";
            this.tbUsuarioEncriptadoMD5.Size = new System.Drawing.Size(352, 23);
            this.tbUsuarioEncriptadoMD5.TabIndex = 5;
            // 
            // tbPasswordEncriptado
            // 
            this.tbPasswordEncriptado.Location = new System.Drawing.Point(260, 148);
            this.tbPasswordEncriptado.Multiline = true;
            this.tbPasswordEncriptado.Name = "tbPasswordEncriptado";
            this.tbPasswordEncriptado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPasswordEncriptado.Size = new System.Drawing.Size(352, 167);
            this.tbPasswordEncriptado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clave En RSA Base64";
            // 
            // tbLlavePublica
            // 
            this.tbLlavePublica.Location = new System.Drawing.Point(674, 148);
            this.tbLlavePublica.Multiline = true;
            this.tbLlavePublica.Name = "tbLlavePublica";
            this.tbLlavePublica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLlavePublica.Size = new System.Drawing.Size(168, 201);
            this.tbLlavePublica.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Llave Publica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(909, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Llave Privada";
            // 
            // tbLlavePrivada
            // 
            this.tbLlavePrivada.Location = new System.Drawing.Point(864, 148);
            this.tbLlavePrivada.Multiline = true;
            this.tbLlavePrivada.Name = "tbLlavePrivada";
            this.tbLlavePrivada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLlavePrivada.Size = new System.Drawing.Size(168, 201);
            this.tbLlavePrivada.TabIndex = 10;
            this.tbLlavePrivada.TextChanged += new System.EventHandler(this.tbLlavePrivada_TextChanged);
            // 
            // tbPasswordDesencriptado
            // 
            this.tbPasswordDesencriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbPasswordDesencriptado.Location = new System.Drawing.Point(1057, 148);
            this.tbPasswordDesencriptado.Multiline = true;
            this.tbPasswordDesencriptado.Name = "tbPasswordDesencriptado";
            this.tbPasswordDesencriptado.Size = new System.Drawing.Size(214, 200);
            this.tbPasswordDesencriptado.TabIndex = 13;
            // 
            // lbPasswordDesencriptado
            // 
            this.lbPasswordDesencriptado.AutoSize = true;
            this.lbPasswordDesencriptado.Location = new System.Drawing.Point(1099, 125);
            this.lbPasswordDesencriptado.Name = "lbPasswordDesencriptado";
            this.lbPasswordDesencriptado.Size = new System.Drawing.Size(136, 15);
            this.lbPasswordDesencriptado.TabIndex = 12;
            this.lbPasswordDesencriptado.Text = "Password Desencriptado";
            // 
            // tbUsuarioEncriptadoSHA256
            // 
            this.tbUsuarioEncriptadoSHA256.Location = new System.Drawing.Point(719, 47);
            this.tbUsuarioEncriptadoSHA256.Multiline = true;
            this.tbUsuarioEncriptadoSHA256.Name = "tbUsuarioEncriptadoSHA256";
            this.tbUsuarioEncriptadoSHA256.Size = new System.Drawing.Size(552, 23);
            this.tbUsuarioEncriptadoSHA256.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(908, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usuario Encripado SHA256";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "JUAN DIEGO FRANCO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "CRIPTOGRAFIA Y MECANISMOS DE S - 202160-6A - 064 EJE 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1296, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUsuarioEncriptadoSHA256);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPasswordDesencriptado);
            this.Controls.Add(this.lbPasswordDesencriptado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLlavePrivada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLlavePublica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswordEncriptado);
            this.Controls.Add(this.tbUsuarioEncriptadoMD5);
            this.Controls.Add(this.lblUsuarioEncriptado);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbUsuario);
            this.Name = "Form1";
            this.Text = "EncriptadorMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsuarioEncriptado;
        private System.Windows.Forms.TextBox tbUsuarioEncriptadoMD5;
        private System.Windows.Forms.TextBox tbPasswordEncriptado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLlavePublica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLlavePrivada;
        private System.Windows.Forms.TextBox tbPasswordDesencriptado;
        private System.Windows.Forms.Label lbPasswordDesencriptado;
        private System.Windows.Forms.TextBox tbUsuarioEncriptadoSHA256;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

