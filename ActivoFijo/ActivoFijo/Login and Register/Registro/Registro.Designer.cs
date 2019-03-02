namespace ActivoFijo.Login_and_Register
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.Nombre = new System.Windows.Forms.TextBox();
            this.DUI = new System.Windows.Forms.TextBox();
            this.Nombrelbl = new System.Windows.Forms.Label();
            this.DUIlbl = new System.Windows.Forms.Label();
            this.Usuariolbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(141, 12);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(243, 20);
            this.Nombre.TabIndex = 2;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // DUI
            // 
            this.DUI.Location = new System.Drawing.Point(141, 38);
            this.DUI.Name = "DUI";
            this.DUI.Size = new System.Drawing.Size(243, 20);
            this.DUI.TabIndex = 5;
            this.DUI.TextChanged += new System.EventHandler(this.DUI_TextChanged);
            // 
            // Nombrelbl
            // 
            this.Nombrelbl.AutoSize = true;
            this.Nombrelbl.Location = new System.Drawing.Point(34, 12);
            this.Nombrelbl.Name = "Nombrelbl";
            this.Nombrelbl.Size = new System.Drawing.Size(44, 13);
            this.Nombrelbl.TabIndex = 8;
            this.Nombrelbl.Text = "Nombre";
            this.Nombrelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // DUIlbl
            // 
            this.DUIlbl.AutoSize = true;
            this.DUIlbl.Location = new System.Drawing.Point(34, 38);
            this.DUIlbl.Name = "DUIlbl";
            this.DUIlbl.Size = new System.Drawing.Size(26, 13);
            this.DUIlbl.TabIndex = 11;
            this.DUIlbl.Text = "DUI";
            // 
            // Usuariolbl
            // 
            this.Usuariolbl.AutoSize = true;
            this.Usuariolbl.Location = new System.Drawing.Point(34, 64);
            this.Usuariolbl.Name = "Usuariolbl";
            this.Usuariolbl.Size = new System.Drawing.Size(43, 13);
            this.Usuariolbl.TabIndex = 14;
            this.Usuariolbl.Text = "Usuario";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(34, 90);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(61, 13);
            this.Passwordlbl.TabIndex = 15;
            this.Passwordlbl.Text = "Contraseña";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(141, 64);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(243, 20);
            this.User.TabIndex = 20;
            this.User.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(141, 90);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(243, 20);
            this.Password.TabIndex = 21;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(141, 116);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 22;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click_1);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(222, 116);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 23;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click_1);
            // 
            // Ayuda
            // 
            this.Ayuda.Location = new System.Drawing.Point(303, 116);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(75, 23);
            this.Ayuda.TabIndex = 24;
            this.Ayuda.Text = "Ayuda";
            this.Ayuda.UseVisualStyleBackColor = true;
            this.Ayuda.Click += new System.EventHandler(this.Ayuda_Click_1);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 183);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usuariolbl);
            this.Controls.Add(this.DUIlbl);
            this.Controls.Add(this.Nombrelbl);
            this.Controls.Add(this.DUI);
            this.Controls.Add(this.Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox DUI;
        private System.Windows.Forms.Label Nombrelbl;
        private System.Windows.Forms.Label DUIlbl;
        private System.Windows.Forms.Label Usuariolbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Ayuda;
    }
}