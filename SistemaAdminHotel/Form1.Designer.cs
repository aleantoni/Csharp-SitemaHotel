namespace SistemaAdminHotel
{
    partial class Clientes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabla = new System.Windows.Forms.TabPage();
            this.fechar = new System.Windows.Forms.DateTimePicker();
            this.tipoh = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.dia = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formpay = new System.Windows.Forms.TextBox();
            this.cambio = new System.Windows.Forms.TextBox();
            this.efectivo = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proceder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabla.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabla);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 502);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabla
            // 
            this.tabla.Controls.Add(this.fechar);
            this.tabla.Controls.Add(this.tipoh);
            this.tabla.Controls.Add(this.cancelar);
            this.tabla.Controls.Add(this.dia);
            this.tabla.Controls.Add(this.panel2);
            this.tabla.Controls.Add(this.panel1);
            this.tabla.Controls.Add(this.label8);
            this.tabla.Controls.Add(this.label7);
            this.tabla.Controls.Add(this.label6);
            this.tabla.Controls.Add(this.proceder);
            this.tabla.Location = new System.Drawing.Point(4, 22);
            this.tabla.Name = "tabla";
            this.tabla.Padding = new System.Windows.Forms.Padding(3);
            this.tabla.Size = new System.Drawing.Size(936, 476);
            this.tabla.TabIndex = 0;
            this.tabla.Text = "Habitacion";
            this.tabla.UseVisualStyleBackColor = true;
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(341, 274);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(200, 20);
            this.fechar.TabIndex = 23;
            // 
            // tipoh
            // 
            this.tipoh.Location = new System.Drawing.Point(489, 78);
            this.tipoh.Name = "tipoh";
            this.tipoh.Size = new System.Drawing.Size(100, 20);
            this.tipoh.TabIndex = 26;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelar.FlatAppearance.BorderSize = 0;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelar.Location = new System.Drawing.Point(480, 420);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(119, 48);
            this.cancelar.TabIndex = 25;
            this.cancelar.Text = "Confirmar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // dia
            // 
            this.dia.Location = new System.Drawing.Point(489, 198);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(28, 20);
            this.dia.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formpay);
            this.panel2.Controls.Add(this.cambio);
            this.panel2.Controls.Add(this.efectivo);
            this.panel2.Controls.Add(this.total);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(633, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 470);
            this.panel2.TabIndex = 21;
            // 
            // formpay
            // 
            this.formpay.Location = new System.Drawing.Point(137, 135);
            this.formpay.Name = "formpay";
            this.formpay.Size = new System.Drawing.Size(100, 20);
            this.formpay.TabIndex = 22;
            // 
            // cambio
            // 
            this.cambio.Location = new System.Drawing.Point(137, 419);
            this.cambio.Name = "cambio";
            this.cambio.Size = new System.Drawing.Size(100, 20);
            this.cambio.TabIndex = 21;
            // 
            // efectivo
            // 
            this.efectivo.Location = new System.Drawing.Point(137, 212);
            this.efectivo.Name = "efectivo";
            this.efectivo.Size = new System.Drawing.Size(100, 20);
            this.efectivo.TabIndex = 20;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(137, 74);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "PAGO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Forma de Pago";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cambio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 19);
            this.label13.TabIndex = 18;
            this.label13.Text = "Descuento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.apellido);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.numero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 470);
            this.panel1.TabIndex = 20;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(147, 107);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(147, 181);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 1;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(147, 274);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 2;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(147, 351);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "DATOS PERSONALES ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Personal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero Telefonico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(337, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dias de Alojamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de Habitacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "HABITACION";
            // 
            // proceder
            // 
            this.proceder.BackColor = System.Drawing.Color.DarkGray;
            this.proceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.proceder.FlatAppearance.BorderSize = 0;
            this.proceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.proceder.Location = new System.Drawing.Point(328, 420);
            this.proceder.Name = "proceder";
            this.proceder.Size = new System.Drawing.Size(119, 48);
            this.proceder.TabIndex = 5;
            this.proceder.Text = "Proceder";
            this.proceder.UseVisualStyleBackColor = false;
            this.proceder.Click += new System.EventHandler(this.proceder_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Disponibilidad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabla.ResumeLayout(false);
            this.tabla.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabla;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button proceder;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dia;
        private System.Windows.Forms.TextBox cambio;
        private System.Windows.Forms.TextBox efectivo;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox tipoh;
        private System.Windows.Forms.TextBox formpay;
        private System.Windows.Forms.DateTimePicker fechar;
    }
}

