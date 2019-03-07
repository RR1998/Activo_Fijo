namespace ActivoFijo.Login_and_Register.AlterarUsuario
{
    partial class AlterarUsuario
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
            this.DatabaseDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDUsuario = new System.Windows.Forms.ComboBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DUI = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.RichTextBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.RealizarBtn = new System.Windows.Forms.Button();
            this.Acciones = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseDisplay
            // 
            this.DatabaseDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseDisplay.Location = new System.Drawing.Point(13, 13);
            this.DatabaseDisplay.Name = "DatabaseDisplay";
            this.DatabaseDisplay.Size = new System.Drawing.Size(512, 199);
            this.DatabaseDisplay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero De Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // IDUsuario
            // 
            this.IDUsuario.FormattingEnabled = true;
            this.IDUsuario.Location = new System.Drawing.Point(13, 231);
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.Size = new System.Drawing.Size(121, 21);
            this.IDUsuario.TabIndex = 5;
            this.IDUsuario.SelectedIndexChanged += new System.EventHandler(this.IDUsuario_SelectedIndexChanged);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(161, 232);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(100, 20);
            this.User.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(302, 231);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DUI";
            // 
            // DUI
            // 
            this.DUI.Location = new System.Drawing.Point(418, 231);
            this.DUI.Name = "DUI";
            this.DUI.Size = new System.Drawing.Size(100, 20);
            this.DUI.TabIndex = 10;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(13, 272);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(248, 33);
            this.Nombre.TabIndex = 11;
            this.Nombre.Text = "";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(13, 312);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 12;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.Location = new System.Drawing.Point(94, 311);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbtn.TabIndex = 13;
            this.Cancelarbtn.Text = "Cancelar";
            this.Cancelarbtn.UseVisualStyleBackColor = true;
            this.Cancelarbtn.Click += new System.EventHandler(this.Cancelarbtn_Click);
            // 
            // RealizarBtn
            // 
            this.RealizarBtn.Location = new System.Drawing.Point(443, 272);
            this.RealizarBtn.Name = "RealizarBtn";
            this.RealizarBtn.Size = new System.Drawing.Size(75, 33);
            this.RealizarBtn.TabIndex = 14;
            this.RealizarBtn.Text = "Realizar";
            this.RealizarBtn.UseVisualStyleBackColor = true;
            this.RealizarBtn.Click += new System.EventHandler(this.RealizarBtn_Click);
            // 
            // Acciones
            // 
            this.Acciones.FormattingEnabled = true;
            this.Acciones.Location = new System.Drawing.Point(302, 271);
            this.Acciones.Name = "Acciones";
            this.Acciones.Size = new System.Drawing.Size(121, 21);
            this.Acciones.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Accion a realizar";
            // 
            // AlterarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 357);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Acciones);
            this.Controls.Add(this.RealizarBtn);
            this.Controls.Add(this.Cancelarbtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DUI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.IDUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabaseDisplay);
            this.Name = "AlterarUsuario";
            this.Text = "AlterarUsuario";
            this.Load += new System.EventHandler(this.AlterarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatabaseDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IDUsuario;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DUI;
        private System.Windows.Forms.RichTextBox Nombre;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.Button RealizarBtn;
        private System.Windows.Forms.ComboBox Acciones;
        private System.Windows.Forms.Label label6;
    }
}