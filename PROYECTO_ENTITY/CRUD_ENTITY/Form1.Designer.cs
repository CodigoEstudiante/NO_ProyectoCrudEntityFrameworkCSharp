namespace CRUD_ENTITY
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewPersona = new System.Windows.Forms.DataGridView();
            this.BotonCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPersona
            // 
            this.DataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPersona.Location = new System.Drawing.Point(12, 51);
            this.DataGridViewPersona.Name = "DataGridViewPersona";
            this.DataGridViewPersona.Size = new System.Drawing.Size(750, 329);
            this.DataGridViewPersona.TabIndex = 0;
            this.DataGridViewPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPersona_CellContentClick);
            // 
            // BotonCrear
            // 
            this.BotonCrear.Location = new System.Drawing.Point(12, 22);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(143, 23);
            this.BotonCrear.TabIndex = 1;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = true;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 387);
            this.Controls.Add(this.BotonCrear);
            this.Controls.Add(this.DataGridViewPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPersona;
        private System.Windows.Forms.Button BotonCrear;
    }
}

