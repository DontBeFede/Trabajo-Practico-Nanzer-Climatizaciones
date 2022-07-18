
namespace TrabajoFinalNanzerClima
{
    partial class EditarArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarArticulos));
            this.CodigoETxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoETxt = new System.Windows.Forms.TextBox();
            this.EspecifETxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CodigoETxt
            // 
            this.CodigoETxt.Location = new System.Drawing.Point(102, 82);
            this.CodigoETxt.Name = "CodigoETxt";
            this.CodigoETxt.ReadOnly = true;
            this.CodigoETxt.Size = new System.Drawing.Size(68, 20);
            this.CodigoETxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Código:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(117, 114);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(198, 114);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 5;
            this.AgregarBtn.Text = "Aceptar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(102, 58);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(68, 20);
            this.CantidadTxt.TabIndex = 3;
            //this.CantidadTxt.TextChanged += new System.EventHandler(this.CantidadTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Especificaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto:";
            // 
            // ProductoETxt
            // 
            this.ProductoETxt.Location = new System.Drawing.Point(102, 6);
            this.ProductoETxt.Name = "ProductoETxt";
            this.ProductoETxt.ReadOnly = true;
            this.ProductoETxt.Size = new System.Drawing.Size(172, 20);
            this.ProductoETxt.TabIndex = 1;
            // 
            // EspecifETxt
            // 
            this.EspecifETxt.Location = new System.Drawing.Point(102, 32);
            this.EspecifETxt.Name = "EspecifETxt";
            this.EspecifETxt.ReadOnly = true;
            this.EspecifETxt.Size = new System.Drawing.Size(172, 20);
            this.EspecifETxt.TabIndex = 2;
            // 
            // EditarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 143);
            this.Controls.Add(this.EspecifETxt);
            this.Controls.Add(this.ProductoETxt);
            this.Controls.Add(this.CodigoETxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarArticulos";
            this.Text = "Editar Artículos";
            this.Load += new System.EventHandler(this.EditarArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox CodigoETxt;
        public System.Windows.Forms.TextBox ProductoETxt;
        public System.Windows.Forms.TextBox EspecifETxt;
    }
}