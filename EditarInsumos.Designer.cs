
namespace TrabajoFinalNanzerClima
{
    partial class EditarInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarInsumos));
            this.EspecifEITxt = new System.Windows.Forms.TextBox();
            this.ProductoEITxt = new System.Windows.Forms.TextBox();
            this.CodigoEITxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EspecifEITxt
            // 
            this.EspecifEITxt.Location = new System.Drawing.Point(103, 37);
            this.EspecifEITxt.Name = "EspecifEITxt";
            this.EspecifEITxt.ReadOnly = true;
            this.EspecifEITxt.Size = new System.Drawing.Size(172, 20);
            this.EspecifEITxt.TabIndex = 2;
            // 
            // ProductoEITxt
            // 
            this.ProductoEITxt.Location = new System.Drawing.Point(103, 11);
            this.ProductoEITxt.Name = "ProductoEITxt";
            this.ProductoEITxt.ReadOnly = true;
            this.ProductoEITxt.Size = new System.Drawing.Size(172, 20);
            this.ProductoEITxt.TabIndex = 1;
            // 
            // CodigoEITxt
            // 
            this.CodigoEITxt.Location = new System.Drawing.Point(103, 86);
            this.CodigoEITxt.Name = "CodigoEITxt";
            this.CodigoEITxt.ReadOnly = true;
            this.CodigoEITxt.Size = new System.Drawing.Size(68, 20);
            this.CodigoEITxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Código:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(118, 118);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(199, 118);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 5;
            this.AgregarBtn.Text = "Aceptar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(103, 62);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(68, 20);
            this.CantidadTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Especificaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Producto:";
            // 
            // EditarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 149);
            this.Controls.Add(this.EspecifEITxt);
            this.Controls.Add(this.ProductoEITxt);
            this.Controls.Add(this.CodigoEITxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarInsumos";
            this.Text = "Editar Insumos";
            this.Load += new System.EventHandler(this.EditarInsumos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox EspecifEITxt;
        public System.Windows.Forms.TextBox ProductoEITxt;
        public System.Windows.Forms.TextBox CodigoEITxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}