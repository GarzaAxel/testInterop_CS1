namespace testInterop_CS
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
            this.btnGuardarExcel = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnGuardarWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarExcel
            // 
            this.btnGuardarExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarExcel.Location = new System.Drawing.Point(236, 115);
            this.btnGuardarExcel.Name = "btnGuardarExcel";
            this.btnGuardarExcel.Size = new System.Drawing.Size(113, 56);
            this.btnGuardarExcel.TabIndex = 5;
            this.btnGuardarExcel.Text = "Guardar Excel";
            this.btnGuardarExcel.UseVisualStyleBackColor = true;
            this.btnGuardarExcel.Click += new System.EventHandler(this.btnGuardarExcel_Click);
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(118, 37);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(138, 27);
            this.txtDato.TabIndex = 4;
            this.txtDato.Text = "EVOLUTION";
            this.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardarWord
            // 
            this.btnGuardarWord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarWord.Location = new System.Drawing.Point(22, 115);
            this.btnGuardarWord.Name = "btnGuardarWord";
            this.btnGuardarWord.Size = new System.Drawing.Size(113, 56);
            this.btnGuardarWord.TabIndex = 3;
            this.btnGuardarWord.Text = "Guardar Word";
            this.btnGuardarWord.UseVisualStyleBackColor = true;
            this.btnGuardarWord.Click += new System.EventHandler(this.btnGuardarWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 222);
            this.Controls.Add(this.btnGuardarExcel);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnGuardarWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarExcel;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnGuardarWord;
    }
}

