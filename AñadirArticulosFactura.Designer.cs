
namespace TrabajoFinalNanzerClima
{
    partial class AñadirArticulosFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirArticulosFactura));
            this.EspecificacionesCbo = new System.Windows.Forms.ComboBox();
            this.ProducntoCbo = new System.Windows.Forms.ComboBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.PrecioUnitarioTxt = new System.Windows.Forms.TextBox();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EspecificacionesCbo
            // 
            this.EspecificacionesCbo.FormattingEnabled = true;
            this.EspecificacionesCbo.Location = new System.Drawing.Point(103, 37);
            this.EspecificacionesCbo.Name = "EspecificacionesCbo";
            this.EspecificacionesCbo.Size = new System.Drawing.Size(176, 21);
            this.EspecificacionesCbo.TabIndex = 2;
            this.EspecificacionesCbo.Text = "Seleccione Especificaciones";
            this.EspecificacionesCbo.SelectedIndexChanged += new System.EventHandler(this.EspecificacionesCbo_SelectedIndexChanged);
            // 
            // ProducntoCbo
            // 
            this.ProducntoCbo.FormattingEnabled = true;
            this.ProducntoCbo.Location = new System.Drawing.Point(103, 11);
            this.ProducntoCbo.Name = "ProducntoCbo";
            this.ProducntoCbo.Size = new System.Drawing.Size(176, 21);
            this.ProducntoCbo.TabIndex = 1;
            this.ProducntoCbo.Text = "Seleccione un Producto";
            this.ProducntoCbo.SelectedIndexChanged += new System.EventHandler(this.ProducntoCbo_SelectedIndexChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(122, 122);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(203, 122);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 5;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // PrecioUnitarioTxt
            // 
            this.PrecioUnitarioTxt.Location = new System.Drawing.Point(103, 89);
            this.PrecioUnitarioTxt.Name = "PrecioUnitarioTxt";
            this.PrecioUnitarioTxt.ReadOnly = true;
            this.PrecioUnitarioTxt.Size = new System.Drawing.Size(68, 20);
            this.PrecioUnitarioTxt.TabIndex = 4;
            this.PrecioUnitarioTxt.Text = "0";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(103, 63);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(68, 20);
            this.CantidadTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Especificaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Producto:";
            // 
            // AñadirArticulosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 150);
            this.Controls.Add(this.EspecificacionesCbo);
            this.Controls.Add(this.ProducntoCbo);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.PrecioUnitarioTxt);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AñadirArticulosFactura";
            this.Text = "Agregar Artículos";
            this.Load += new System.EventHandler(this.AñadirArticulosFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EspecificacionesCbo;
        private System.Windows.Forms.ComboBox ProducntoCbo;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.TextBox PrecioUnitarioTxt;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}