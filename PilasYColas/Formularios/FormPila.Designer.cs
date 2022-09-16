namespace PilasYColas.Formularios
{
    partial class FormPila
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
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnVacia = new System.Windows.Forms.Button();
            this.txtPilas = new System.Windows.Forms.TextBox();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.lstPilas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(291, 52);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(110, 23);
            this.btnAniadir.TabIndex = 0;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // btnVacia
            // 
            this.btnVacia.Location = new System.Drawing.Point(206, 314);
            this.btnVacia.Name = "btnVacia";
            this.btnVacia.Size = new System.Drawing.Size(97, 31);
            this.btnVacia.TabIndex = 2;
            this.btnVacia.Text = "Esta Vacia?";
            this.btnVacia.UseVisualStyleBackColor = true;
            this.btnVacia.Click += new System.EventHandler(this.btnVacia_Click);
            // 
            // txtPilas
            // 
            this.txtPilas.Location = new System.Drawing.Point(17, 55);
            this.txtPilas.Name = "txtPilas";
            this.txtPilas.Size = new System.Drawing.Size(237, 20);
            this.txtPilas.TabIndex = 4;
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(383, 314);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(97, 31);
            this.btnExtraer.TabIndex = 7;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(17, 314);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(97, 31);
            this.btnPrimero.TabIndex = 8;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // lstPilas
            // 
            this.lstPilas.FormattingEnabled = true;
            this.lstPilas.Location = new System.Drawing.Point(17, 81);
            this.lstPilas.Name = "lstPilas";
            this.lstPilas.Size = new System.Drawing.Size(473, 225);
            this.lstPilas.TabIndex = 9;
            // 
            // FormPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.lstPilas);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.txtPilas);
            this.Controls.Add(this.btnVacia);
            this.Controls.Add(this.btnAniadir);
            this.Name = "FormPila";
            this.Text = "FormPila";
            this.Load += new System.EventHandler(this.FormPila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnVacia;
        private System.Windows.Forms.TextBox txtPilas;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.ListBox lstPilas;
    }
}