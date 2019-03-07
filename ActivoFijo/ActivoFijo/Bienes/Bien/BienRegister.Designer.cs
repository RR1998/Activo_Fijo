namespace ActivoFijo.Bienes.Bien
{
    partial class BienRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BienRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.RichTextBox();
            this.Color = new System.Windows.Forms.TextBox();
            this.VidaUtil = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.TextBox();
            this.FechaCompra = new System.Windows.Forms.DateTimePicker();
            this.Cantidad = new System.Windows.Forms.NumericUpDown();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.AgregarMarca = new System.Windows.Forms.Button();
            this.AgregarClasificacion = new System.Windows.Forms.Button();
            this.FechaAdquisision = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.IDUserLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.MarcaCombo = new System.Windows.Forms.ComboBox();
            this.TipoCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EstadoCombobox = new System.Windows.Forms.ComboBox();
            this.IDAsignado = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VidaUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero identificador del bien";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion del bien";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clasificacion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vida Util";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(288, 79);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(311, 238);
            this.Descripcion.TabIndex = 7;
            this.Descripcion.Text = "";
            this.Descripcion.TextChanged += new System.EventHandler(this.Descripcion_TextChanged);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(164, 80);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(100, 20);
            this.Color.TabIndex = 8;
            this.Color.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VidaUtil
            // 
            this.VidaUtil.Location = new System.Drawing.Point(14, 177);
            this.VidaUtil.Name = "VidaUtil";
            this.VidaUtil.Size = new System.Drawing.Size(105, 20);
            this.VidaUtil.TabIndex = 11;
            this.VidaUtil.ValueChanged += new System.EventHandler(this.PorcentageDepreciacion_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Costo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cantidad";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha de Compra";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(14, 217);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(100, 20);
            this.Costo.TabIndex = 15;
            this.Costo.TextChanged += new System.EventHandler(this.Costo_TextChanged);
            // 
            // FechaCompra
            // 
            this.FechaCompra.Location = new System.Drawing.Point(14, 256);
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.Size = new System.Drawing.Size(250, 20);
            this.FechaCompra.TabIndex = 16;
            this.FechaCompra.Value = new System.DateTime(2019, 1, 8, 12, 53, 1, 0);
            this.FechaCompra.ValueChanged += new System.EventHandler(this.FechaCompra_ValueChanged);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(144, 216);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(120, 20);
            this.Cantidad.TabIndex = 17;
            this.Cantidad.ValueChanged += new System.EventHandler(this.Cantidad_ValueChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(14, 323);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 18;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(95, 323);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 19;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // AgregarMarca
            // 
            this.AgregarMarca.Location = new System.Drawing.Point(176, 323);
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.Size = new System.Drawing.Size(131, 23);
            this.AgregarMarca.TabIndex = 20;
            this.AgregarMarca.Text = "Agregar Nueva Marca";
            this.AgregarMarca.UseVisualStyleBackColor = true;
            this.AgregarMarca.Click += new System.EventHandler(this.AgregarMarca_Click);
            // 
            // AgregarClasificacion
            // 
            this.AgregarClasificacion.Location = new System.Drawing.Point(313, 323);
            this.AgregarClasificacion.Name = "AgregarClasificacion";
            this.AgregarClasificacion.Size = new System.Drawing.Size(168, 23);
            this.AgregarClasificacion.TabIndex = 21;
            this.AgregarClasificacion.Text = "Agregar Nueva Clasificacion";
            this.AgregarClasificacion.UseVisualStyleBackColor = true;
            this.AgregarClasificacion.Click += new System.EventHandler(this.AgregarClasificacion_Click);
            // 
            // FechaAdquisision
            // 
            this.FechaAdquisision.Location = new System.Drawing.Point(14, 297);
            this.FechaAdquisision.Name = "FechaAdquisision";
            this.FechaAdquisision.Size = new System.Drawing.Size(250, 20);
            this.FechaAdquisision.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha de Adquisision";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(13, 13);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(43, 13);
            this.UserLabel.TabIndex = 24;
            this.UserLabel.Text = "Usuario";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(13, 29);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(41, 13);
            this.UserNameLabel.TabIndex = 25;
            this.UserNameLabel.Text = "Default";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // IDUserLabel
            // 
            this.IDUserLabel.AutoSize = true;
            this.IDUserLabel.Location = new System.Drawing.Point(113, 12);
            this.IDUserLabel.Name = "IDUserLabel";
            this.IDUserLabel.Size = new System.Drawing.Size(98, 13);
            this.IDUserLabel.TabIndex = 26;
            this.IDUserLabel.Text = "Numero de Usuario";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(116, 29);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(41, 13);
            this.IDLabel.TabIndex = 27;
            this.IDLabel.Text = "Default";
            // 
            // MarcaCombo
            // 
            this.MarcaCombo.FormattingEnabled = true;
            this.MarcaCombo.Location = new System.Drawing.Point(14, 129);
            this.MarcaCombo.Name = "MarcaCombo";
            this.MarcaCombo.Size = new System.Drawing.Size(121, 21);
            this.MarcaCombo.TabIndex = 28;
            this.MarcaCombo.SelectedIndexChanged += new System.EventHandler(this.MarcaCombo_SelectedIndexChanged);
            // 
            // TipoCombo
            // 
            this.TipoCombo.FormattingEnabled = true;
            this.TipoCombo.Location = new System.Drawing.Point(144, 129);
            this.TipoCombo.Name = "TipoCombo";
            this.TipoCombo.Size = new System.Drawing.Size(121, 21);
            this.TipoCombo.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Estado";
            // 
            // EstadoCombobox
            // 
            this.EstadoCombobox.FormattingEnabled = true;
            this.EstadoCombobox.Location = new System.Drawing.Point(144, 177);
            this.EstadoCombobox.Name = "EstadoCombobox";
            this.EstadoCombobox.Size = new System.Drawing.Size(121, 21);
            this.EstadoCombobox.TabIndex = 31;
            // 
            // IDAsignado
            // 
            this.IDAsignado.AutoSize = true;
            this.IDAsignado.Location = new System.Drawing.Point(11, 80);
            this.IDAsignado.Name = "IDAsignado";
            this.IDAsignado.Size = new System.Drawing.Size(41, 13);
            this.IDAsignado.TabIndex = 33;
            this.IDAsignado.Text = "Default";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(487, 323);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(112, 23);
            this.RefreshButton.TabIndex = 34;
            this.RefreshButton.Text = "Actualizar";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // BienRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 358);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.IDAsignado);
            this.Controls.Add(this.EstadoCombobox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TipoCombo);
            this.Controls.Add(this.MarcaCombo);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDUserLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FechaAdquisision);
            this.Controls.Add(this.AgregarClasificacion);
            this.Controls.Add(this.AgregarMarca);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.FechaCompra);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VidaUtil);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BienRegister";
            this.Text = "Bien";
            ((System.ComponentModel.ISupportInitialize)(this.VidaUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox Descripcion;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.NumericUpDown VidaUtil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.DateTimePicker FechaCompra;
        private System.Windows.Forms.NumericUpDown Cantidad;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button AgregarMarca;
        private System.Windows.Forms.Button AgregarClasificacion;
        private System.Windows.Forms.DateTimePicker FechaAdquisision;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label IDUserLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.ComboBox MarcaCombo;
        private System.Windows.Forms.ComboBox TipoCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox EstadoCombobox;
        private System.Windows.Forms.Label IDAsignado;
        private System.Windows.Forms.Button RefreshButton;
    }
}