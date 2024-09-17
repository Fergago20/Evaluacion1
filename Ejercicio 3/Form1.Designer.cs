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
            this.Registrar = new System.Windows.Forms.Button();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGanancia = new System.Windows.Forms.TextBox();
            this.lbTabla = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.lblVen.Size = new System.Drawing.Size(177, 20);
            this.lblVen.TabIndex = 1;
            this.lblVen.Text = "Ingrese n° de Vendedor";
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(572, 65);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(129, 67);
            this.Registrar.TabIndex = 3;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbVendedor
            // 
            this.tbVendedor.Location = new System.Drawing.Point(204, 62);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.Size = new System.Drawing.Size(263, 20);
            this.tbVendedor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese n° de producto";
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(204, 114);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(263, 20);
            this.tbProducto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese valor de producto";
            // 
            // tbGanancia
            // 
            this.tbGanancia.Location = new System.Drawing.Point(204, 160);
            this.tbGanancia.Name = "tbGanancia";
            this.tbGanancia.Size = new System.Drawing.Size(263, 20);
            this.tbGanancia.TabIndex = 8;
            // 
            // lbTabla
            // 
            this.lbTabla.FormattingEnabled = true;
            this.lbTabla.Location = new System.Drawing.Point(204, 209);
            this.lbTabla.Name = "lbTabla";
            this.lbTabla.Size = new System.Drawing.Size(263, 95);
            this.lbTabla.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Informe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbTabla);
            this.Controls.Add(this.tbGanancia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVendedor);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.lblVen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVen;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGanancia;
        private System.Windows.Forms.ListBox lbTabla;
        private System.Windows.Forms.Button button2;
    }
}

