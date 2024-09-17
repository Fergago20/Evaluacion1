namespace Ejercicio_3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.lblCos = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.lblPro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgMatriz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos y ganancias";
            // 
            // tbCosto
            // 
            this.tbCosto.Location = new System.Drawing.Point(263, 118);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(263, 20);
            this.tbCosto.TabIndex = 12;
            // 
            // lblCos
            // 
            this.lblCos.AutoSize = true;
            this.lblCos.Location = new System.Drawing.Point(72, 125);
            this.lblCos.Name = "lblCos";
            this.lblCos.Size = new System.Drawing.Size(174, 13);
            this.lblCos.TabIndex = 11;
            this.lblCos.Text = "Ingrese ventas totales por producto";
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(263, 67);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(263, 20);
            this.tbProducto.TabIndex = 10;
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(72, 70);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(153, 13);
            this.lblPro.TabIndex = 9;
            this.lblPro.Text = "Ingrese el nombre del producto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 71);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgMatriz
            // 
            this.dgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriz.Location = new System.Drawing.Point(250, 188);
            this.dgMatriz.Name = "dgMatriz";
            this.dgMatriz.Size = new System.Drawing.Size(263, 150);
            this.dgMatriz.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgMatriz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.lblCos);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.Label lblCos;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgMatriz;
    }
}