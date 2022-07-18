
namespace TrabajoFinalNanzerClima
{
    partial class ConsultaDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDocumentos));
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTxt = new System.Windows.Forms.TextBox();
            this.TipoDocumentoCbo = new System.Windows.Forms.ComboBox();
            this.DgvDatosDoc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaTxt = new System.Windows.Forms.TextBox();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.SeleccionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumeroSeleccionTxt = new System.Windows.Forms.TextBox();
            this.GrbControles = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosDoc)).BeginInit();
            this.GrbControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(477, 297);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 4;
            this.GuardarBtn.Text = "Aceptar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Location = new System.Drawing.Point(8, 18);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(75, 23);
            this.BorrarBtn.TabIndex = 6;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tipo de Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Número:";
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.Location = new System.Drawing.Point(299, 12);
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Size = new System.Drawing.Size(91, 20);
            this.NumeroTxt.TabIndex = 2;
            this.NumeroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroTxt_KeyPress);
            // 
            // TipoDocumentoCbo
            // 
            this.TipoDocumentoCbo.AutoCompleteCustomSource.AddRange(new string[] {
            "Factura",
            "Orden de Compra",
            "Remito"});
            this.TipoDocumentoCbo.FormattingEnabled = true;
            this.TipoDocumentoCbo.Items.AddRange(new object[] {
            "Factura",
            "Orden De Compra",
            "Remito"});
            this.TipoDocumentoCbo.Location = new System.Drawing.Point(120, 12);
            this.TipoDocumentoCbo.Name = "TipoDocumentoCbo";
            this.TipoDocumentoCbo.Size = new System.Drawing.Size(110, 21);
            this.TipoDocumentoCbo.TabIndex = 1;
            this.TipoDocumentoCbo.Text = "Seleccione";
            this.TipoDocumentoCbo.SelectedIndexChanged += new System.EventHandler(this.TipoDocumentoCbo_SelectedIndexChanged);
            // 
            // DgvDatosDoc
            // 
            this.DgvDatosDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosDoc.Location = new System.Drawing.Point(13, 48);
            this.DgvDatosDoc.Name = "DgvDatosDoc";
            this.DgvDatosDoc.ReadOnly = true;
            this.DgvDatosDoc.RowHeadersWidth = 51;
            this.DgvDatosDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosDoc.Size = new System.Drawing.Size(543, 213);
            this.DgvDatosDoc.TabIndex = 53;
            this.DgvDatosDoc.SelectionChanged += new System.EventHandler(this.DgvDatosDoc_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Fecha:";
            // 
            // FechaTxt
            // 
            this.FechaTxt.Location = new System.Drawing.Point(465, 12);
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(91, 20);
            this.FechaTxt.TabIndex = 3;
            this.FechaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FechaTxt_KeyPress);
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Location = new System.Drawing.Point(89, 18);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBtn.TabIndex = 5;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // SeleccionTxt
            // 
            this.SeleccionTxt.Location = new System.Drawing.Point(96, 276);
            this.SeleccionTxt.Name = "SeleccionTxt";
            this.SeleccionTxt.ReadOnly = true;
            this.SeleccionTxt.Size = new System.Drawing.Size(91, 20);
            this.SeleccionTxt.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Seleccionando:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Número:";
            // 
            // NumeroSeleccionTxt
            // 
            this.NumeroSeleccionTxt.Location = new System.Drawing.Point(96, 300);
            this.NumeroSeleccionTxt.Name = "NumeroSeleccionTxt";
            this.NumeroSeleccionTxt.ReadOnly = true;
            this.NumeroSeleccionTxt.Size = new System.Drawing.Size(91, 20);
            this.NumeroSeleccionTxt.TabIndex = 66;
            // 
            // GrbControles
            // 
            this.GrbControles.BackColor = System.Drawing.SystemColors.Control;
            this.GrbControles.Controls.Add(this.BorrarBtn);
            this.GrbControles.Controls.Add(this.ConsultarBtn);
            this.GrbControles.Enabled = false;
            this.GrbControles.Location = new System.Drawing.Point(241, 271);
            this.GrbControles.Margin = new System.Windows.Forms.Padding(2);
            this.GrbControles.Name = "GrbControles";
            this.GrbControles.Padding = new System.Windows.Forms.Padding(2);
            this.GrbControles.Size = new System.Drawing.Size(172, 49);
            this.GrbControles.TabIndex = 68;
            this.GrbControles.TabStop = false;
            this.GrbControles.Text = "Controles";
            // 
            // ConsultaDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 325);
            this.Controls.Add(this.GrbControles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumeroSeleccionTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SeleccionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaTxt);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeroTxt);
            this.Controls.Add(this.TipoDocumentoCbo);
            this.Controls.Add(this.DgvDatosDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaDocumentos";
            this.Text = "Consultar Documentos";
            this.Load += new System.EventHandler(this.ConsultaDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosDoc)).EndInit();
            this.GrbControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button BorrarBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTxt;
        private System.Windows.Forms.ComboBox TipoDocumentoCbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FechaTxt;
        public System.Windows.Forms.DataGridView DgvDatosDoc;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.TextBox SeleccionTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumeroSeleccionTxt;
        private System.Windows.Forms.GroupBox GrbControles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}