namespace SistemaAdminHotel
{
    partial class reportes
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
            this.generar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generar
            // 
            this.generar.BackColor = System.Drawing.Color.Gray;
            this.generar.FlatAppearance.BorderSize = 0;
            this.generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generar.ForeColor = System.Drawing.Color.White;
            this.generar.Location = new System.Drawing.Point(415, 240);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(136, 43);
            this.generar.TabIndex = 3;
            this.generar.Text = "Generar";
            this.generar.UseVisualStyleBackColor = false;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 508);
            this.Controls.Add(this.generar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportes";
            this.Text = "reportes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generar;
    }
}