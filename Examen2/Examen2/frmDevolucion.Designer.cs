namespace Examen2
{
    partial class frmDevolucion
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
            this.cmbSuscriptor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.dgvDevolver = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suscriptor";
            // 
            // cmbSuscriptor
            // 
            this.cmbSuscriptor.FormattingEnabled = true;
            this.cmbSuscriptor.Location = new System.Drawing.Point(42, 48);
            this.cmbSuscriptor.Name = "cmbSuscriptor";
            this.cmbSuscriptor.Size = new System.Drawing.Size(357, 24);
            this.cmbSuscriptor.TabIndex = 1;
            this.cmbSuscriptor.SelectedIndexChanged += new System.EventHandler(this.cmbSuscriptor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pelicula";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(168, 313);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(87, 39);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dgvDevolver
            // 
            this.dgvDevolver.AllowUserToAddRows = false;
            this.dgvDevolver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolver.Location = new System.Drawing.Point(42, 134);
            this.dgvDevolver.Name = "dgvDevolver";
            this.dgvDevolver.RowHeadersWidth = 51;
            this.dgvDevolver.RowTemplate.Height = 24;
            this.dgvDevolver.Size = new System.Drawing.Size(357, 150);
            this.dgvDevolver.TabIndex = 5;
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 377);
            this.Controls.Add(this.dgvDevolver);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSuscriptor);
            this.Controls.Add(this.label1);
            this.Name = "frmDevolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.frmDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSuscriptor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DataGridView dgvDevolver;
    }
}