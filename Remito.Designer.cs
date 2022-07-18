
namespace TrabajoFinalNanzerClima
{
    partial class Remito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remito));
            this.FechaDate = new System.Windows.Forms.DateTimePicker();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.RazonSocialCbo = new System.Windows.Forms.ComboBox();
            this.NumeroTxt = new System.Windows.Forms.TextBox();
            this.ArticulosBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CiudadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DireccionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProvinciaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.BorrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDate
            // 
            this.FechaDate.Location = new System.Drawing.Point(268, 15);
            this.FechaDate.Name = "FechaDate";
            this.FechaDate.Size = new System.Drawing.Size(200, 20);
            this.FechaDate.TabIndex = 2;
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(15, 119);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.RowHeadersWidth = 51;
            this.DgvDatos.Size = new System.Drawing.Size(453, 213);
            this.DgvDatos.TabIndex = 1;
            // 
            // RazonSocialCbo
            // 
            this.RazonSocialCbo.FormattingEnabled = true;
            this.RazonSocialCbo.Location = new System.Drawing.Point(91, 41);
            this.RazonSocialCbo.Name = "RazonSocialCbo";
            this.RazonSocialCbo.Size = new System.Drawing.Size(248, 21);
            this.RazonSocialCbo.TabIndex = 3;
            this.RazonSocialCbo.SelectedIndexChanged += new System.EventHandler(this.RazonSocialCbo_SelectedIndexChanged);
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.Location = new System.Drawing.Point(91, 15);
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Size = new System.Drawing.Size(100, 20);
            this.NumeroTxt.TabIndex = 1;
            // 
            // ArticulosBtn
            // 
            this.ArticulosBtn.Location = new System.Drawing.Point(364, 91);
            this.ArticulosBtn.Name = "ArticulosBtn";
            this.ArticulosBtn.Size = new System.Drawing.Size(104, 23);
            this.ArticulosBtn.TabIndex = 4;
            this.ArticulosBtn.Text = "Cargar Artículos";
            this.ArticulosBtn.UseVisualStyleBackColor = true;
            this.ArticulosBtn.Click += new System.EventHandler(this.ArticulosBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ciudad:";
            // 
            // CiudadTxt
            // 
            this.CiudadTxt.Location = new System.Drawing.Point(242, 93);
            this.CiudadTxt.Name = "CiudadTxt";
            this.CiudadTxt.ReadOnly = true;
            this.CiudadTxt.Size = new System.Drawing.Size(97, 20);
            this.CiudadTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dirección:";
            // 
            // DireccionTxt
            // 
            this.DireccionTxt.Location = new System.Drawing.Point(91, 67);
            this.DireccionTxt.Name = "DireccionTxt";
            this.DireccionTxt.ReadOnly = true;
            this.DireccionTxt.Size = new System.Drawing.Size(248, 20);
            this.DireccionTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Provincia:";
            // 
            // ProvinciaTxt
            // 
            this.ProvinciaTxt.Location = new System.Drawing.Point(91, 93);
            this.ProvinciaTxt.Name = "ProvinciaTxt";
            this.ProvinciaTxt.ReadOnly = true;
            this.ProvinciaTxt.Size = new System.Drawing.Size(100, 20);
            this.ProvinciaTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Razon Social:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(312, 338);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(393, 338);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 5;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click_1);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Location = new System.Drawing.Point(364, 62);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(104, 23);
            this.BorrarBtn.TabIndex = 7;
            this.BorrarBtn.Text = "Borrar Artículos";
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 367);
            this.Controls.Add(this.BorrarBtn);
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
            this.Controls.Add(this.ArticulosBtn);
            this.Controls.Add(this.NumeroTxt);
            this.Controls.Add(this.RazonSocialCbo);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.FechaDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Remito";
            this.Text = "Cargar Remito";
            this.Load += new System.EventHandler(this.Remito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDate;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.ComboBox RazonSocialCbo;
        private System.Windows.Forms.TextBox NumeroTxt;
        private System.Windows.Forms.Button ArticulosBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CiudadTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DireccionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProvinciaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button BorrarBtn;
    }
}