
namespace LoginRegister
{
    partial class Credenciales
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.usuario = new System.Windows.Forms.TextBox();
            this.regname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.bcrear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bcont = new System.Windows.Forms.Button();
            this.created = new System.Windows.Forms.Label();
            this.loguser = new System.Windows.Forms.TextBox();
            this.logpass = new System.Windows.Forms.TextBox();
            this.logname = new System.Windows.Forms.Label();
            this.blogin = new System.Windows.Forms.Button();
            this.sesion = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(12, 166);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(141, 20);
            this.usuario.TabIndex = 0;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // regname
            // 
            this.regname.AutoSize = true;
            this.regname.Location = new System.Drawing.Point(12, 97);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(127, 13);
            this.regname.TabIndex = 2;
            this.regname.Text = "REGISTRARSE GRATIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 250);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(141, 20);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // bcrear
            // 
            this.bcrear.Location = new System.Drawing.Point(12, 296);
            this.bcrear.Name = "bcrear";
            this.bcrear.Size = new System.Drawing.Size(80, 23);
            this.bcrear.TabIndex = 3;
            this.bcrear.Text = "Crear cuenta";
            this.bcrear.UseVisualStyleBackColor = true;
            this.bcrear.Click += new System.EventHandler(this.bcrear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bcont
            // 
            this.bcont.Location = new System.Drawing.Point(98, 296);
            this.bcont.Name = "bcont";
            this.bcont.Size = new System.Drawing.Size(80, 23);
            this.bcont.TabIndex = 9;
            this.bcont.Text = "Continuar";
            this.bcont.UseVisualStyleBackColor = true;
            this.bcont.Click += new System.EventHandler(this.bcont_Click);
            // 
            // created
            // 
            this.created.AutoSize = true;
            this.created.Location = new System.Drawing.Point(12, 332);
            this.created.Name = "created";
            this.created.Size = new System.Drawing.Size(151, 13);
            this.created.TabIndex = 10;
            this.created.Text = "Cuenta creada correctamente!";
            // 
            // loguser
            // 
            this.loguser.Location = new System.Drawing.Point(12, 166);
            this.loguser.Name = "loguser";
            this.loguser.Size = new System.Drawing.Size(141, 20);
            this.loguser.TabIndex = 11;
            this.loguser.TextChanged += new System.EventHandler(this.loguser_TextChanged);
            // 
            // logpass
            // 
            this.logpass.Location = new System.Drawing.Point(12, 250);
            this.logpass.Name = "logpass";
            this.logpass.Size = new System.Drawing.Size(141, 20);
            this.logpass.TabIndex = 12;
            this.logpass.TextChanged += new System.EventHandler(this.logpass_TextChanged);
            // 
            // logname
            // 
            this.logname.AutoSize = true;
            this.logname.Location = new System.Drawing.Point(12, 97);
            this.logname.Name = "logname";
            this.logname.Size = new System.Drawing.Size(89, 13);
            this.logname.TabIndex = 13;
            this.logname.Text = "INICIAR SESIÓN";
            // 
            // blogin
            // 
            this.blogin.Location = new System.Drawing.Point(12, 296);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(80, 23);
            this.blogin.TabIndex = 14;
            this.blogin.Text = "Iniciar Sesión";
            this.blogin.UseVisualStyleBackColor = true;
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // sesion
            // 
            this.sesion.AutoSize = true;
            this.sesion.Location = new System.Drawing.Point(12, 332);
            this.sesion.Name = "sesion";
            this.sesion.Size = new System.Drawing.Size(152, 13);
            this.sesion.TabIndex = 15;
            this.sesion.Text = "Sesión iniciada correctamente!";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LoginRegister.Properties.Resources.images;
            this.pictureBox5.Location = new System.Drawing.Point(184, 296);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(137, 165);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LoginRegister.Properties.Resources.free_ipad_1;
            this.pictureBox4.Location = new System.Drawing.Point(324, 296);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(237, 165);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LoginRegister.Properties.Resources.D6ReShuUcAAFvFd;
            this.pictureBox3.Location = new System.Drawing.Point(567, 296);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 165);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LoginRegister.Properties.Resources.viejo;
            this.pictureBox2.Location = new System.Drawing.Point(214, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginRegister.Properties.Resources.ff48dd5b2890b0dfd6fec9e0d302d679;
            this.pictureBox1.Location = new System.Drawing.Point(567, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Credenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sesion);
            this.Controls.Add(this.blogin);
            this.Controls.Add(this.logname);
            this.Controls.Add(this.logpass);
            this.Controls.Add(this.loguser);
            this.Controls.Add(this.created);
            this.Controls.Add(this.bcont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bcrear);
            this.Controls.Add(this.regname);
            this.Controls.Add(this.usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Credenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porno Furro";
            this.Load += new System.EventHandler(this.Credenciales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label regname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button bcrear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bcont;
        private System.Windows.Forms.Label created;
        private System.Windows.Forms.Button blogin;
        private System.Windows.Forms.Label logname;
        private System.Windows.Forms.TextBox logpass;
        private System.Windows.Forms.TextBox loguser;
        private System.Windows.Forms.Label sesion;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

