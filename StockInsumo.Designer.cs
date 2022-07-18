
namespace TrabajoFinalNanzerClima
{
    partial class StockInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInsumo));
            this.TxtTotales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbFiltrarInsumo = new System.Windows.Forms.ComboBox();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTotales
            // 
            this.TxtTotales.Location = new System.Drawing.Point(273, 259);
            this.TxtTotales.Name = "TxtTotales";
            this.TxtTotales.ReadOnly = true;
            this.TxtTotales.Size = new System.Drawing.Size(71, 20);
            this.TxtTotales.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stock Total de Búsqueda:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(110, 262);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(13, 13);
            this.lblStock.TabIndex = 18;
            this.lblStock.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Stock Total Actual:";
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(12, 35);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.Size = new System.Drawing.Size(718, 215);
            this.dgvInsumos.TabIndex = 15;
            this.dgvInsumos.SelectionChanged += new System.EventHandler(this.dgvInsumos_SelectionChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(360, 9);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(181, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Producto:";
            // 
            // CbFiltrarInsumo
            // 
            this.CbFiltrarInsumo.FormattingEnabled = true;
            this.CbFiltrarInsumo.Items.AddRange(new object[] {
            "Seleccionar"});
            this.CbFiltrarInsumo.Location = new System.Drawing.Point(71, 9);
            this.CbFiltrarInsumo.Name = "CbFiltrarInsumo";
            this.CbFiltrarInsumo.Size = new System.Drawing.Size(222, 21);
            this.CbFiltrarInsumo.TabIndex = 0;
            this.CbFiltrarInsumo.SelectedIndexChanged += new System.EventHandler(this.CbFiltrarProducto_SelectedIndexChanged);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Location = new System.Drawing.Point(493, 262);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(75, 23);
            this.BorrarBtn.TabIndex = 4;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // EditarBtn
            // 
            this.EditarBtn.Location = new System.Drawing.Point(574, 262);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(75, 23);
            this.EditarBtn.TabIndex = 3;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            this.EditarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(404, 259);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.ReadOnly = true;
            this.CodigoTxt.Size = new System.Drawing.Size(60, 20);
            this.CodigoTxt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Código:";
            // 
            // StockInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 293);
            this.Controls.Add(this.CodigoTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.TxtTotales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbFiltrarInsumo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockInsumo";
            this.Text = "Stock de Insumos";
            this.Load += new System.EventHandler(this.StockInsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTotales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbFiltrarInsumo;
        private System.Windows.Forms.Button BorrarBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.Label label5;
    }
}