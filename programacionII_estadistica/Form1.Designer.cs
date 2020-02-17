namespace programacionII_estadistica
{
    partial class Form1
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
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btnCalcularEstandar = new System.Windows.Forms.Button();
            this.btnCalcularTpica = new System.Windows.Forms.Button();
            this.grdEstadistica = new System.Windows.Forms.DataGridView();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2ixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(32, 72);
            this.lblserie.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(107, 32);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "SERIE:";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(160, 64);
            this.txtserie.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(484, 38);
            this.txtserie.TabIndex = 1;
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(59, 260);
            this.btnMediaAritmetica.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(211, 76);
            this.btnMediaAritmetica.TabIndex = 2;
            this.btnMediaAritmetica.Text = "Calcular X";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(51, 179);
            this.lblrespuesta.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(34, 32);
            this.lblrespuesta.TabIndex = 3;
            this.lblrespuesta.Text = "X";
            // 
            // btnCalcularEstandar
            // 
            this.btnCalcularEstandar.Location = new System.Drawing.Point(285, 260);
            this.btnCalcularEstandar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCalcularEstandar.Name = "btnCalcularEstandar";
            this.btnCalcularEstandar.Size = new System.Drawing.Size(280, 76);
            this.btnCalcularEstandar.TabIndex = 4;
            this.btnCalcularEstandar.Text = "Calcular Estandar";
            this.btnCalcularEstandar.UseVisualStyleBackColor = true;
            this.btnCalcularEstandar.Click += new System.EventHandler(this.btnCalcularEstandar_Click);
            // 
            // btnCalcularTpica
            // 
            this.btnCalcularTpica.Location = new System.Drawing.Point(581, 260);
            this.btnCalcularTpica.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCalcularTpica.Name = "btnCalcularTpica";
            this.btnCalcularTpica.Size = new System.Drawing.Size(229, 76);
            this.btnCalcularTpica.TabIndex = 5;
            this.btnCalcularTpica.Text = "Calcular Tipica";
            this.btnCalcularTpica.UseVisualStyleBackColor = true;
            this.btnCalcularTpica.Click += new System.EventHandler(this.btnCalcularTpica_Click);
            // 
            // grdEstadistica
            // 
            this.grdEstadistica.AllowUserToDeleteRows = false;
            this.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstadistica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1,
            this.f1,
            this.fi,
            this.xixfi,
            this.x2ixfi});
            this.grdEstadistica.Location = new System.Drawing.Point(57, 430);
            this.grdEstadistica.Name = "grdEstadistica";
            this.grdEstadistica.RowHeadersWidth = 102;
            this.grdEstadistica.RowTemplate.Height = 40;
            this.grdEstadistica.Size = new System.Drawing.Size(1316, 664);
            this.grdEstadistica.TabIndex = 6;
            this.grdEstadistica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdEstadistica_KeyUp);
            // 
            // x1
            // 
            this.x1.HeaderText = "X1";
            this.x1.MinimumWidth = 12;
            this.x1.Name = "x1";
            this.x1.Width = 250;
            // 
            // f1
            // 
            this.f1.HeaderText = "F1";
            this.f1.MinimumWidth = 12;
            this.f1.Name = "f1";
            this.f1.Width = 250;
            // 
            // fi
            // 
            this.fi.HeaderText = "Fi";
            this.fi.MinimumWidth = 12;
            this.fi.Name = "fi";
            this.fi.Width = 250;
            // 
            // xixfi
            // 
            this.xixfi.HeaderText = "Xi * Fi";
            this.xixfi.MinimumWidth = 12;
            this.xixfi.Name = "xixfi";
            this.xixfi.Width = 150;
            // 
            // x2ixfi
            // 
            this.x2ixfi.HeaderText = "X2i * Fi";
            this.x2ixfi.MinimumWidth = 12;
            this.x2ixfi.Name = "x2ixfi";
            this.x2ixfi.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 1273);
            this.Controls.Add(this.grdEstadistica);
            this.Controls.Add(this.btnCalcularTpica);
            this.Controls.Add(this.btnCalcularEstandar);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Calculos basicos Estadistica";
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnMediaAritmetica;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btnCalcularEstandar;
        private System.Windows.Forms.Button btnCalcularTpica;
        private System.Windows.Forms.DataGridView grdEstadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xixfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2ixfi;
    }
}

