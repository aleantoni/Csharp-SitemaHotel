namespace SistemaAdminHotel
{
    partial class Busqueda
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
            this.tablaDato = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDato)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDato
            // 
            this.tablaDato.AllowUserToDeleteRows = false;
            this.tablaDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDato.Location = new System.Drawing.Point(57, 131);
            this.tablaDato.Name = "tablaDato";
            this.tablaDato.Size = new System.Drawing.Size(839, 328);
            this.tablaDato.TabIndex = 0;
            this.tablaDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(95, 88);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(407, 20);
            this.searchBox.TabIndex = 2;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Location = new System.Drawing.Point(564, 80);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(118, 35);
            this.search.TabIndex = 3;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete.Location = new System.Drawing.Point(476, 474);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 35);
            this.delete.TabIndex = 4;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cargar
            // 
            this.cargar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cargar.FlatAppearance.BorderSize = 0;
            this.cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cargar.Location = new System.Drawing.Point(763, 26);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(118, 35);
            this.cargar.TabIndex = 5;
            this.cargar.Text = "Cargar Datos";
            this.cargar.UseVisualStyleBackColor = false;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ControlDark;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(291, 474);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(118, 35);
            this.update.TabIndex = 6;
            this.update.Text = "Actualizar";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 521);
            this.ControlBox = false;
            this.Controls.Add(this.update);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.tablaDato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Busqueda_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDato;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button update;
    }
}