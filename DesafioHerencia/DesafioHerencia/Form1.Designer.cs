
namespace DesafioHerencia
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
            this.btnPiso = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtNumeroVentanas = new System.Windows.Forms.TextBox();
            this.txtPisoNro = new System.Windows.Forms.TextBox();
            this.lblNumeroVentanas = new System.Windows.Forms.Label();
            this.lblPisoNumero = new System.Windows.Forms.Label();
            this.btnLocal = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblm2 = new System.Windows.Forms.Label();
            this.lblAños = new System.Windows.Forms.Label();
            this.btnPrecioFinal = new System.Windows.Forms.Button();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPiso
            // 
            this.btnPiso.AutoSize = true;
            this.btnPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnPiso.Location = new System.Drawing.Point(31, 47);
            this.btnPiso.Name = "btnPiso";
            this.btnPiso.Size = new System.Drawing.Size(73, 30);
            this.btnPiso.TabIndex = 0;
            this.btnPiso.TabStop = true;
            this.btnPiso.Text = "Piso";
            this.btnPiso.UseVisualStyleBackColor = true;
            this.btnPiso.CheckedChanged += new System.EventHandler(this.btnPiso_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtNumeroVentanas);
            this.groupBox.Controls.Add(this.txtPisoNro);
            this.groupBox.Controls.Add(this.lblNumeroVentanas);
            this.groupBox.Controls.Add(this.lblPisoNumero);
            this.groupBox.Controls.Add(this.btnLocal);
            this.groupBox.Controls.Add(this.btnPiso);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(347, 173);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tipo de Inmueble";
            // 
            // txtNumeroVentanas
            // 
            this.txtNumeroVentanas.Location = new System.Drawing.Point(215, 127);
            this.txtNumeroVentanas.Name = "txtNumeroVentanas";
            this.txtNumeroVentanas.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroVentanas.TabIndex = 4;
            // 
            // txtPisoNro
            // 
            this.txtPisoNro.Location = new System.Drawing.Point(31, 127);
            this.txtPisoNro.Name = "txtPisoNro";
            this.txtPisoNro.Size = new System.Drawing.Size(73, 20);
            this.txtPisoNro.TabIndex = 3;
            // 
            // lblNumeroVentanas
            // 
            this.lblNumeroVentanas.AutoSize = true;
            this.lblNumeroVentanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVentanas.Location = new System.Drawing.Point(211, 104);
            this.lblNumeroVentanas.Name = "lblNumeroVentanas";
            this.lblNumeroVentanas.Size = new System.Drawing.Size(125, 20);
            this.lblNumeroVentanas.TabIndex = 3;
            this.lblNumeroVentanas.Text = "Nro de ventanas";
            // 
            // lblPisoNumero
            // 
            this.lblPisoNumero.AutoSize = true;
            this.lblPisoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPisoNumero.Location = new System.Drawing.Point(36, 104);
            this.lblPisoNumero.Name = "lblPisoNumero";
            this.lblPisoNumero.Size = new System.Drawing.Size(68, 20);
            this.lblPisoNumero.TabIndex = 2;
            this.lblPisoNumero.Text = "Piso Nro";
            // 
            // btnLocal
            // 
            this.btnLocal.AutoSize = true;
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnLocal.Location = new System.Drawing.Point(225, 47);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(82, 30);
            this.btnLocal.TabIndex = 1;
            this.btnLocal.TabStop = true;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.CheckedChanged += new System.EventHandler(this.btnLocal_CheckedChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(16, 254);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(343, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 231);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperficie.Location = new System.Drawing.Point(12, 318);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(80, 20);
            this.lblSuperficie.TabIndex = 6;
            this.lblSuperficie.Text = "Superficie";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedad.Location = new System.Drawing.Point(138, 318);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(91, 20);
            this.lblAntiguedad.TabIndex = 7;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBase.Location = new System.Drawing.Point(267, 318);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(92, 20);
            this.lblPrecioBase.TabIndex = 8;
            this.lblPrecioBase.Text = "Precio base";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(16, 341);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(61, 20);
            this.txtSuperficie.TabIndex = 5;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(142, 341);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(50, 20);
            this.txtAntiguedad.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(271, 341);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(88, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // lblm2
            // 
            this.lblm2.AutoSize = true;
            this.lblm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm2.Location = new System.Drawing.Point(79, 344);
            this.lblm2.Name = "lblm2";
            this.lblm2.Size = new System.Drawing.Size(34, 16);
            this.lblm2.TabIndex = 11;
            this.lblm2.Text = "(m2)";
            // 
            // lblAños
            // 
            this.lblAños.AutoSize = true;
            this.lblAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAños.Location = new System.Drawing.Point(198, 344);
            this.lblAños.Name = "lblAños";
            this.lblAños.Size = new System.Drawing.Size(46, 16);
            this.lblAños.TabIndex = 12;
            this.lblAños.Text = "(años)";
            // 
            // btnPrecioFinal
            // 
            this.btnPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioFinal.Location = new System.Drawing.Point(16, 383);
            this.btnPrecioFinal.Name = "btnPrecioFinal";
            this.btnPrecioFinal.Size = new System.Drawing.Size(252, 66);
            this.btnPrecioFinal.TabIndex = 13;
            this.btnPrecioFinal.Text = "Calcular Precio Final";
            this.btnPrecioFinal.UseVisualStyleBackColor = true;
            this.btnPrecioFinal.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.Location = new System.Drawing.Point(12, 471);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(0, 20);
            this.lblPrecioFinal.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(275, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 66);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 518);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.btnPrecioFinal);
            this.Controls.Add(this.lblAños);
            this.Controls.Add(this.lblm2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnPiso;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtNumeroVentanas;
        private System.Windows.Forms.TextBox txtPisoNro;
        private System.Windows.Forms.Label lblNumeroVentanas;
        private System.Windows.Forms.Label lblPisoNumero;
        private System.Windows.Forms.RadioButton btnLocal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblm2;
        private System.Windows.Forms.Label lblAños;
        private System.Windows.Forms.Button btnPrecioFinal;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

