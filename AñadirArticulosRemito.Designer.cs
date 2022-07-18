
namespace TrabajoFinalNanzerClima
{
    partial class AñadirArticulosRemito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirArticulosRemito));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrecioUnitarioTxt = new System.Windows.Forms.TextBox();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.ProducntoCbo = new System.Windows.Forms.ComboBox();
            this.EspecificacionesCbo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especificaciones:";
            // 
            // PrecioUnitarioTxt
            // 
            this.PrecioUnitarioTxt.Location = new System.Drawing.Point(103, 86);
            this.PrecioUnitarioTxt.Name = "PrecioUnitarioTxt";
            this.PrecioUnitarioTxt.ReadOnly = true;
            this.PrecioUnitarioTxt.Size = new System.Drawing.Size(68, 20);
            this.PrecioUnitarioTxt.TabIndex = 4;
            this.PrecioUnitarioTxt.Text = "0";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(103, 60);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(68, 20);
            this.CantidadTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad:";
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(204, 144);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 6;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(123, 144);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 7;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ProducntoCbo
            // 
            this.ProducntoCbo.FormattingEnabled = true;
            this.ProducntoCbo.Location = new System.Drawing.Point(103, 9);
            this.ProducntoCbo.Name = "ProducntoCbo";
            this.ProducntoCbo.Size = new System.Drawing.Size(176, 21);
            this.ProducntoCbo.TabIndex = 1;
            this.ProducntoCbo.Text = "Seleccione un Producto";
            this.ProducntoCbo.SelectedIndexChanged += new System.EventHandler(this.ProducntoCbo_SelectedIndexChanged);
            // 
            // EspecificacionesCbo
            // 
            this.EspecificacionesCbo.FormattingEnabled = true;
            this.EspecificacionesCbo.Location = new System.Drawing.Point(103, 34);
            this.EspecificacionesCbo.Name = "EspecificacionesCbo";
            this.EspecificacionesCbo.Size = new System.Drawing.Size(176, 21);
            this.EspecificacionesCbo.TabIndex = 2;
            this.EspecificacionesCbo.Text = "Seleccione Especificaciones";
            this.EspecificacionesCbo.SelectedIndexChanged += new System.EventHandler(this.EspecificacionesCbo_SelectedIndexChanged);
            this.EspecificacionesCbo.TextChanged += new System.EventHandler(this.EspecificacionesCbo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(185, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Su Selección:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 5;
            // 
            // AñadirArticulosRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 179);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Name = "AñadirArticulosRemito";
            this.Text = "Agregar Artículos";
            this.Load += new System.EventHandler(this.AñadirArticulosRemito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrecioUnitarioTxt;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.ComboBox ProducntoCbo;
        private System.Windows.Forms.ComboBox EspecificacionesCbo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}