namespace Examen2
{
    partial class Renta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRenta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbSuscriptor = new System.Windows.Forms.ComboBox();
            this.cbPelicula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suscriptor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelicula";
            // 
            // dgvRenta
            // 
            this.dgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvRenta.Location = new System.Drawing.Point(12, 170);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.RowHeadersWidth = 51;
            this.dgvRenta.RowTemplate.Height = 24;
            this.dgvRenta.Size = new System.Drawing.Size(480, 247);
            this.dgvRenta.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pelicula";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(387, 120);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(187, 445);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(137, 31);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar Renta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbSuscriptor
            // 
            this.cbSuscriptor.FormattingEnabled = true;
            this.cbSuscriptor.Location = new System.Drawing.Point(16, 43);
            this.cbSuscriptor.Name = "cbSuscriptor";
            this.cbSuscriptor.Size = new System.Drawing.Size(424, 24);
            this.cbSuscriptor.TabIndex = 5;
            // 
            // cbPelicula
            // 
            this.cbPelicula.FormattingEnabled = true;
            this.cbPelicula.Location = new System.Drawing.Point(16, 120);
            this.cbPelicula.Name = "cbPelicula";
            this.cbPelicula.Size = new System.Drawing.Size(334, 24);
            this.cbPelicula.TabIndex = 6;
            // 
            // Renta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 497);
            this.Controls.Add(this.cbPelicula);
            this.Controls.Add(this.cbSuscriptor);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvRenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Renta";
            this.Text = "Renta";
            this.Load += new System.EventHandler(this.Renta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRenta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbSuscriptor;
        private System.Windows.Forms.ComboBox cbPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}