
namespace BlocNota
{
    partial class VentanaBloc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.btn_tamaño = new System.Windows.Forms.Button();
            this.btn_comilas = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_historial = new System.Windows.Forms.Label();
            this.combotamaño = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combotamaño);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_abrir);
            this.panel1.Controls.Add(this.btn_tamaño);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 31);
            this.panel1.TabIndex = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(430, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 22);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(347, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 22);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_abrir
            // 
            this.btn_abrir.Location = new System.Drawing.Point(260, 4);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(75, 22);
            this.btn_abrir.TabIndex = 4;
            this.btn_abrir.Text = "Abrir";
            this.btn_abrir.UseVisualStyleBackColor = true;
            // 
            // btn_tamaño
            // 
            this.btn_tamaño.Location = new System.Drawing.Point(175, 4);
            this.btn_tamaño.Name = "btn_tamaño";
            this.btn_tamaño.Size = new System.Drawing.Size(75, 22);
            this.btn_tamaño.TabIndex = 3;
            this.btn_tamaño.Text = "Tamaño";
            this.btn_tamaño.UseVisualStyleBackColor = true;
            this.btn_tamaño.Click += new System.EventHandler(this.btn_tamaño_Click);
            // 
            // btn_comilas
            // 
            this.btn_comilas.Location = new System.Drawing.Point(175, -5);
            this.btn_comilas.Name = "btn_comilas";
            this.btn_comilas.Size = new System.Drawing.Size(75, 22);
            this.btn_comilas.TabIndex = 2;
            this.btn_comilas.Text = "Comillas";
            this.btn_comilas.UseVisualStyleBackColor = true;
            this.btn_comilas.Click += new System.EventHandler(this.btn_comilas_Click);
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(8, 5);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(75, 21);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_out);
            this.panel2.Controls.Add(this.btn_comilas);
            this.panel2.Location = new System.Drawing.Point(4, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 511);
            this.panel2.TabIndex = 1;
            // 
            // txt_out
            // 
            this.txt_out.Location = new System.Drawing.Point(0, 4);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.Size = new System.Drawing.Size(509, 504);
            this.txt_out.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_historial);
            this.panel3.Location = new System.Drawing.Point(3, 558);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 24);
            this.panel3.TabIndex = 2;
            // 
            // lbl_historial
            // 
            this.lbl_historial.AutoSize = true;
            this.lbl_historial.Location = new System.Drawing.Point(232, 9);
            this.lbl_historial.Name = "lbl_historial";
            this.lbl_historial.Size = new System.Drawing.Size(0, 13);
            this.lbl_historial.TabIndex = 0;
            // 
            // combotamaño
            // 
            this.combotamaño.FormattingEnabled = true;
            this.combotamaño.Location = new System.Drawing.Point(94, 5);
            this.combotamaño.Name = "combotamaño";
            this.combotamaño.Size = new System.Drawing.Size(75, 21);
            this.combotamaño.TabIndex = 1;
            this.combotamaño.Text = "-Tamaño-";
            this.combotamaño.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // VentanaBloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaBloc";
            this.Text = "Bloc Nota";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.Button btn_tamaño;
        private System.Windows.Forms.Button btn_comilas;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_historial;
        private System.Windows.Forms.ComboBox combotamaño;
    }
}

