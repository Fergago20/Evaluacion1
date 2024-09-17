namespace Ejercicio_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVen = new System.Windows.Forms.Label();
            this.dgMatriz = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.lblPro = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.lblCos = new System.Windows.Forms.Label();
            this.tbCosto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de Resultado";
            // 
            // lblVen
            // 
            this.lblVen.AutoSize = true;
            this.lblVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVen.Location = new System.Drawing.Point(13, 65);
            this.lblVen.Name = "lblVen";
            this.lblVen.Size = new System.Drawing.Size(159, 20);
            this.lblVen.TabIndex = 1;
            this.lblVen.Text = "Ingreso de Vendedor";
            // 
            // dgMatriz
            // 
            this.dgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriz.Location = new System.Drawing.Point(204, 205);
            this.dgMatriz.Name = "dgMatriz";
            this.dgMatriz.Size = new System.Drawing.Size(263, 150);
            this.dgMatriz.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbVendedor
            // 
            this.tbVendedor.Location = new System.Drawing.Point(204, 62);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.Size = new System.Drawing.Size(263, 20);
            this.tbVendedor.TabIndex = 4;
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(13, 119);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(153, 13);
            this.lblPro.TabIndex = 5;
            this.lblPro.Text = "Ingrese el nombre del producto";
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(204, 116);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(263, 20);
            this.tbProducto.TabIndex = 6;
            // 
            // lblCos
            // 
            this.lblCos.AutoSize = true;
            this.lblCos.Location = new System.Drawing.Point(13, 174);
            this.lblCos.Name = "lblCos";
            this.lblCos.Size = new System.Drawing.Size(174, 13);
            this.lblCos.TabIndex = 7;
            this.lblCos.Text = "Ingrese ventas totales por producto";
            // 
            // tbCosto
            // 
            this.tbCosto.Location = new System.Drawing.Point(204, 167);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(263, 20);
            this.tbCosto.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.lblCos);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.tbVendedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgMatriz);
            this.Controls.Add(this.lblVen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVen;
        private System.Windows.Forms.DataGridView dgMatriz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Label lblCos;
        private System.Windows.Forms.TextBox tbCosto;
    }
}

