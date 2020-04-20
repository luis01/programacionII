namespace programacionII_estadistica
{
    partial class frmCategorias
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
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.grbDatosCategorias = new System.Windows.Forms.GroupBox();
            this.lblidCategoria = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatosCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnBuscar);
            this.grbEdicion.Controls.Add(this.btneliminar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnNuevo);
            this.grbEdicion.Location = new System.Drawing.Point(675, 522);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(628, 135);
            this.grbEdicion.TabIndex = 8;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion de Categroias";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(457, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 79);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(290, 37);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(165, 79);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(119, 37);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 79);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(6, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 79);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblnregistros);
            this.grbNavegacion.Controls.Add(this.btnultimo);
            this.grbNavegacion.Controls.Add(this.btnsiguiente);
            this.grbNavegacion.Controls.Add(this.btnanterior);
            this.grbNavegacion.Controls.Add(this.btnprimero);
            this.grbNavegacion.Location = new System.Drawing.Point(78, 522);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(591, 135);
            this.grbNavegacion.TabIndex = 7;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(222, 61);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 32);
            this.lblnregistros.TabIndex = 13;
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(485, 37);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(106, 79);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(381, 37);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(106, 79);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(110, 37);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(106, 79);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(6, 37);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(106, 79);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // grbDatosCategorias
            // 
            this.grbDatosCategorias.Controls.Add(this.lblidCategoria);
            this.grbDatosCategorias.Controls.Add(this.textBox6);
            this.grbDatosCategorias.Controls.Add(this.label6);
            this.grbDatosCategorias.Controls.Add(this.txtnombre);
            this.grbDatosCategorias.Controls.Add(this.lblnombre);
            this.grbDatosCategorias.Enabled = false;
            this.grbDatosCategorias.Location = new System.Drawing.Point(78, 69);
            this.grbDatosCategorias.Name = "grbDatosCategorias";
            this.grbDatosCategorias.Size = new System.Drawing.Size(1219, 396);
            this.grbDatosCategorias.TabIndex = 6;
            this.grbDatosCategorias.TabStop = false;
            this.grbDatosCategorias.Text = "Datos de Categorias";
            // 
            // lblidCategoria
            // 
            this.lblidCategoria.AutoSize = true;
            this.lblidCategoria.Location = new System.Drawing.Point(31, 104);
            this.lblidCategoria.Name = "lblidCategoria";
            this.lblidCategoria.Size = new System.Drawing.Size(50, 32);
            this.lblidCategoria.TabIndex = 12;
            this.lblidCategoria.Text = "ID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(410, 1355);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 38);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 1355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(226, 177);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(826, 146);
            this.txtnombre.TabIndex = 3;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(31, 177);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(146, 32);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 719);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatosCategorias);
            this.Name = "frmCategorias";
            this.Text = "MANTENIMIENTO CATEGORIAS";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatosCategorias.ResumeLayout(false);
            this.grbDatosCategorias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.GroupBox grbDatosCategorias;
        private System.Windows.Forms.Label lblidCategoria;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
    }
}