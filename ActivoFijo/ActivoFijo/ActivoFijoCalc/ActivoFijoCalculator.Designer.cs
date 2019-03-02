namespace ActivoFijo.ActivoFijoCalc
{
    partial class ActivoFijoCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivoFijoCalculator));
            this.DatabaseDisplay = new System.Windows.Forms.DataGridView();
            this.FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Anual = new System.Windows.Forms.RadioButton();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseDisplay
            // 
            this.DatabaseDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseDisplay.Location = new System.Drawing.Point(12, 60);
            this.DatabaseDisplay.Name = "DatabaseDisplay";
            this.DatabaseDisplay.Size = new System.Drawing.Size(1008, 434);
            this.DatabaseDisplay.TabIndex = 0;
            // 
            // FechaFinal
            // 
            this.FechaFinal.Location = new System.Drawing.Point(12, 34);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(200, 20);
            this.FechaFinal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // Anual
            // 
            this.Anual.AutoSize = true;
            this.Anual.Location = new System.Drawing.Point(220, 33);
            this.Anual.Name = "Anual";
            this.Anual.Size = new System.Drawing.Size(52, 17);
            this.Anual.TabIndex = 6;
            this.Anual.TabStop = true;
            this.Anual.Text = "Anual";
            this.Anual.UseVisualStyleBackColor = true;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(278, 34);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 7;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(359, 34);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(440, 34);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // ActivoFijoCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 506);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Anual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.DatabaseDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivoFijoCalculator";
            this.Text = "ActivoFijo";
            this.Load += new System.EventHandler(this.ActivoFijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatabaseDisplay;
        private System.Windows.Forms.DateTimePicker FechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Anual;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
    }
}