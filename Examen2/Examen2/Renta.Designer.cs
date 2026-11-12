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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbSuscriptor = new System.Windows.Forms.ComboBox();
            this.cbPelicula = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suscriptor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelicula";
            // 
            // dgvRenta
            // 
            this.dgvRenta.AllowUserToAddRows = false;
            this.dgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenta.Location = new System.Drawing.Point(12, 170);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.RowHeadersWidth = 51;
            this.dgvRenta.RowTemplate.Height = 24;
            this.dgvRenta.Size = new System.Drawing.Size(480, 247);
            this.dgvRenta.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(178, 423);
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
            this.cbSuscriptor.Size = new System.Drawing.Size(476, 24);
            this.cbSuscriptor.TabIndex = 5;
            // 
            // cbPelicula
            // 
            this.cbPelicula.FormattingEnabled = true;
            this.cbPelicula.Location = new System.Drawing.Point(16, 120);
            this.cbPelicula.Name = "cbPelicula";
            this.cbPelicula.Size = new System.Drawing.Size(334, 24);
            this.cbPelicula.TabIndex = 6;
            this.cbPelicula.SelectedIndexChanged += new System.EventHandler(this.cbPelicula_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(394, 120);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Renta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 508);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbPelicula);
            this.Controls.Add(this.cbSuscriptor);
            this.Controls.Add(this.btnRegistrar);
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
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbSuscriptor;
        private System.Windows.Forms.ComboBox cbPelicula;
        private System.Windows.Forms.Button btnAgregar;
    }
}