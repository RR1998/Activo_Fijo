namespace ActivoFijo.Login_and_Register
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUsuario = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSize = true;
            this.NombreUsuario.Location = new System.Drawing.Point(12, 67);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(41, 13);
            this.NombreUsuario.TabIndex = 1;
            this.NombreUsuario.Text = "Default";
            this.NombreUsuario.Click += new System.EventHandler(this.NombreUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NUsuario
            // 
            this.NUsuario.AutoSize = true;
            this.NUsuario.Location = new System.Drawing.Point(347, 67);
            this.NUsuario.Name = "NUsuario";
            this.NUsuario.Size = new System.Drawing.Size(41, 13);
            this.NUsuario.TabIndex = 3;
            this.NUsuario.Text = "Default";
            this.NUsuario.Click += new System.EventHandler(this.NUsuario_Click);
            // 
            // Opciones
            // 
            this.Opciones.FormattingEnabled = true;
            this.Opciones.Location = new System.Drawing.Point(12, 147);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(194, 21);
            this.Opciones.TabIndex = 4;
            this.Opciones.SelectedIndexChanged += new System.EventHandler(this.Opciones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opciones";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(212, 147);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(293, 147);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cerrar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Ayuda
            // 
            this.Ayuda.Location = new System.Drawing.Point(374, 145);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(75, 23);
            this.Ayuda.TabIndex = 8;
            this.Ayuda.Text = "Ayuda";
            this.Ayuda.UseVisualStyleBackColor = true;
            this.Ayuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 204);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.NUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NUsuario;
        private System.Windows.Forms.ComboBox Opciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Ayuda;
    }
}