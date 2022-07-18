
namespace TrabajoFinalNanzerClima
{
    partial class StockArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockArticulos));
            this.CbFiltrarProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.TotalesLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotales = new System.Windows.Forms.TextBox();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // CbFiltrarProducto
            // 
            this.CbFiltrarProducto.FormattingEnabled = true;
            this.CbFiltrarProducto.Items.AddRange(new object[] {
            "Seleccionar"});
            this.CbFiltrarProducto.Location = new System.Drawing.Point(71, 16);
            this.CbFiltrarProducto.Name = "CbFiltrarProducto";
            this.CbFiltrarProducto.Size = new System.Drawing.Size(222, 21);
            this.CbFiltrarProducto.TabIndex = 0;
            this.CbFiltrarProducto.SelectedIndexChanged += new System.EventHandler(this.CbFiltrarProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(362, 16);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(181, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 42);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(712, 215);
            this.dgvArticulos.TabIndex = 4;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock Total Actual:";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(649, 264);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // TotalesLbl
            // 
            this.TotalesLbl.AutoSize = true;
            this.TotalesLbl.Location = new System.Drawing.Point(110, 269);
            this.TotalesLbl.Name = "TotalesLbl";
            this.TotalesLbl.Size = new System.Drawing.Size(13, 13);
            this.TotalesLbl.TabIndex = 8;
            this.TotalesLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock Total de Búsqueda:";
            // 
            // TxtTotales
            // 
            this.TxtTotales.Location = new System.Drawing.Point(271, 266);
            this.TxtTotales.Name = "TxtTotales";
            this.TxtTotales.ReadOnly = true;
            this.TxtTotales.Size = new System.Drawing.Size(60, 20);
            this.TxtTotales.TabIndex = 10;
            // 
            // EditarBtn
            // 
            this.EditarBtn.Location = new System.Drawing.Point(568, 264);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(75, 23);
            this.EditarBtn.TabIndex = 3;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            this.EditarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Location = new System.Drawing.Point(487, 264);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(75, 23);
            this.BorrarBtn.TabIndex = 4;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(391, 266);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.ReadOnly = true;
            this.CodigoTxt.Size = new System.Drawing.Size(60, 20);
            this.CodigoTxt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Código:";
            // 
            // StockArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 299);
            this.Controls.Add(this.CodigoTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.TxtTotales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalesLbl);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbFiltrarProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockArticulos";
            this.Text = "Stock de Artículos";
            this.Load += new System.EventHandler(this.StockArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbFiltrarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label TotalesLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotales;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button BorrarBtn;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.Label label5;
    }
}