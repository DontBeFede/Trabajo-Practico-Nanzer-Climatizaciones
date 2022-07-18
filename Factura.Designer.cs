
namespace TrabajoFinalNanzerClima
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProvinciaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DireccionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CiudadTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTxt = new System.Windows.Forms.TextBox();
            this.RazonSocialCbo = new System.Windows.Forms.ComboBox();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.CargarArticulosBtn = new System.Windows.Forms.Button();
            this.FechaDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TipoCbo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.BorrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(422, 352);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 6;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(341, 352);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 8;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Razon Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Provincia:";
            // 
            // ProvinciaTxt
            // 
            this.ProvinciaTxt.Location = new System.Drawing.Point(86, 84);
            this.ProvinciaTxt.Name = "ProvinciaTxt";
            this.ProvinciaTxt.ReadOnly = true;
            this.ProvinciaTxt.Size = new System.Drawing.Size(100, 20);
            this.ProvinciaTxt.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Dirección:";
            // 
            // DireccionTxt
            // 
            this.DireccionTxt.Location = new System.Drawing.Point(86, 58);
            this.DireccionTxt.Name = "DireccionTxt";
            this.DireccionTxt.ReadOnly = true;
            this.DireccionTxt.Size = new System.Drawing.Size(248, 20);
            this.DireccionTxt.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ciudad:";
            // 
            // CiudadTxt
            // 
            this.CiudadTxt.Location = new System.Drawing.Point(237, 84);
            this.CiudadTxt.Name = "CiudadTxt";
            this.CiudadTxt.ReadOnly = true;
            this.CiudadTxt.Size = new System.Drawing.Size(97, 20);
            this.CiudadTxt.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Número:";
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.Location = new System.Drawing.Point(57, 6);
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Size = new System.Drawing.Size(91, 20);
            this.NumeroTxt.TabIndex = 1;
            // 
            // RazonSocialCbo
            // 
            this.RazonSocialCbo.FormattingEnabled = true;
            this.RazonSocialCbo.Location = new System.Drawing.Point(86, 32);
            this.RazonSocialCbo.Name = "RazonSocialCbo";
            this.RazonSocialCbo.Size = new System.Drawing.Size(248, 21);
            this.RazonSocialCbo.TabIndex = 4;
            this.RazonSocialCbo.SelectedIndexChanged += new System.EventHandler(this.RazonSocialCbo_SelectedIndexChanged);
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(10, 110);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.RowHeadersWidth = 51;
            this.DgvDatos.Size = new System.Drawing.Size(488, 213);
            this.DgvDatos.TabIndex = 17;
            // 
            // CargarArticulosBtn
            // 
            this.CargarArticulosBtn.Location = new System.Drawing.Point(393, 83);
            this.CargarArticulosBtn.Name = "CargarArticulosBtn";
            this.CargarArticulosBtn.Size = new System.Drawing.Size(104, 23);
            this.CargarArticulosBtn.TabIndex = 5;
            this.CargarArticulosBtn.Text = "Cargar Artículos";
            this.CargarArticulosBtn.UseVisualStyleBackColor = true;
            this.CargarArticulosBtn.Click += new System.EventHandler(this.CargarArticulosBtn_Click);
            // 
            // FechaDate
            // 
            this.FechaDate.Location = new System.Drawing.Point(298, 7);
            this.FechaDate.Name = "FechaDate";
            this.FechaDate.Size = new System.Drawing.Size(200, 20);
            this.FechaDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tipo:";
            // 
            // TipoCbo
            // 
            this.TipoCbo.FormattingEnabled = true;
            this.TipoCbo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.TipoCbo.Location = new System.Drawing.Point(187, 6);
            this.TipoCbo.Name = "TipoCbo";
            this.TipoCbo.Size = new System.Drawing.Size(48, 21);
            this.TipoCbo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(372, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Total:";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TotalLbl.Location = new System.Drawing.Point(422, 326);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(24, 17);
            this.TotalLbl.TabIndex = 36;
            this.TotalLbl.Text = "$0";
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Location = new System.Drawing.Point(393, 55);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(104, 23);
            this.BorrarBtn.TabIndex = 7;
            this.BorrarBtn.Text = "Borrar Artículos";
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 387);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TipoCbo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProvinciaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DireccionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CiudadTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CargarArticulosBtn);
            this.Controls.Add(this.NumeroTxt);
            this.Controls.Add(this.RazonSocialCbo);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.FechaDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Factura";
            this.Text = "Cargar Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProvinciaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DireccionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CiudadTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTxt;
        private System.Windows.Forms.ComboBox RazonSocialCbo;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Button CargarArticulosBtn;
        private System.Windows.Forms.DateTimePicker FechaDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TipoCbo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Button BorrarBtn;
    }
}