
namespace Calculadora
{
    partial class CalculadoraGUI
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
            this.panel_sup = new System.Windows.Forms.Panel();
            this.lbl_mostrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_rest = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_nueve = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn_dos = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_ocho = new System.Windows.Forms.Button();
            this.btn_AC = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_siete = new System.Windows.Forms.Button();
            this.btn_cero = new System.Windows.Forms.Button();
            this.btn_uno = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.panel_sup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sup
            // 
            this.panel_sup.Controls.Add(this.lbl_mostrar);
            this.panel_sup.Location = new System.Drawing.Point(2, 2);
            this.panel_sup.Name = "panel_sup";
            this.panel_sup.Size = new System.Drawing.Size(479, 41);
            this.panel_sup.TabIndex = 0;
            // 
            // lbl_mostrar
            // 
            this.lbl_mostrar.Font = new System.Drawing.Font("Arial", 18F);
            this.lbl_mostrar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_mostrar.Location = new System.Drawing.Point(16, 9);
            this.lbl_mostrar.Name = "lbl_mostrar";
            this.lbl_mostrar.Size = new System.Drawing.Size(450, 23);
            this.lbl_mostrar.TabIndex = 1;
            this.lbl_mostrar.Text = "1234567890";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sum);
            this.panel1.Controls.Add(this.btn_rest);
            this.panel1.Controls.Add(this.btn_mul);
            this.panel1.Controls.Add(this.btn_igual);
            this.panel1.Controls.Add(this.btn_3);
            this.panel1.Controls.Add(this.btn_seis);
            this.panel1.Controls.Add(this.btn_div);
            this.panel1.Controls.Add(this.btn_nueve);
            this.panel1.Controls.Add(this.btn_punto);
            this.panel1.Controls.Add(this.btn_dos);
            this.panel1.Controls.Add(this.btn_cinco);
            this.panel1.Controls.Add(this.btn_ocho);
            this.panel1.Controls.Add(this.btn_AC);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btn_siete);
            this.panel1.Controls.Add(this.btn_cero);
            this.panel1.Controls.Add(this.btn_uno);
            this.panel1.Controls.Add(this.btn_4);
            this.panel1.Controls.Add(this.button);
            this.panel1.Location = new System.Drawing.Point(2, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 300);
            this.panel1.TabIndex = 1;
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(358, 238);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(108, 40);
            this.btn_sum.TabIndex = 19;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_rest
            // 
            this.btn_rest.Location = new System.Drawing.Point(358, 182);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(108, 40);
            this.btn_rest.TabIndex = 18;
            this.btn_rest.Text = "-";
            this.btn_rest.UseVisualStyleBackColor = true;
            this.btn_rest.Click += new System.EventHandler(this.btn_rest_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(358, 125);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(108, 40);
            this.btn_mul.TabIndex = 17;
            this.btn_mul.Text = "X";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_igual.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_igual.Location = new System.Drawing.Point(244, 238);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(108, 40);
            this.btn_igual.TabIndex = 16;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(244, 182);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(108, 40);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_seis
            // 
            this.btn_seis.Location = new System.Drawing.Point(244, 125);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(108, 40);
            this.btn_seis.TabIndex = 14;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = true;
            this.btn_seis.Click += new System.EventHandler(this.btn_seis_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(358, 69);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(108, 40);
            this.btn_div.TabIndex = 13;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_nueve
            // 
            this.btn_nueve.Location = new System.Drawing.Point(244, 69);
            this.btn_nueve.Name = "btn_nueve";
            this.btn_nueve.Size = new System.Drawing.Size(108, 40);
            this.btn_nueve.TabIndex = 12;
            this.btn_nueve.Text = "9";
            this.btn_nueve.UseVisualStyleBackColor = true;
            this.btn_nueve.Click += new System.EventHandler(this.btn_nueve_Click);
            // 
            // btn_punto
            // 
            this.btn_punto.Location = new System.Drawing.Point(130, 238);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(108, 40);
            this.btn_punto.TabIndex = 11;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = true;
            this.btn_punto.Click += new System.EventHandler(this.btn_punto_Click);
            // 
            // btn_dos
            // 
            this.btn_dos.Location = new System.Drawing.Point(130, 182);
            this.btn_dos.Name = "btn_dos";
            this.btn_dos.Size = new System.Drawing.Size(108, 40);
            this.btn_dos.TabIndex = 10;
            this.btn_dos.Text = "2";
            this.btn_dos.UseVisualStyleBackColor = true;
            this.btn_dos.Click += new System.EventHandler(this.btn_dos_Click);
            // 
            // btn_cinco
            // 
            this.btn_cinco.Location = new System.Drawing.Point(130, 125);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(108, 40);
            this.btn_cinco.TabIndex = 9;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = true;
            this.btn_cinco.Click += new System.EventHandler(this.btn_cinco_Click);
            // 
            // btn_ocho
            // 
            this.btn_ocho.Location = new System.Drawing.Point(130, 69);
            this.btn_ocho.Name = "btn_ocho";
            this.btn_ocho.Size = new System.Drawing.Size(108, 40);
            this.btn_ocho.TabIndex = 8;
            this.btn_ocho.Text = "8";
            this.btn_ocho.UseVisualStyleBackColor = true;
            this.btn_ocho.Click += new System.EventHandler(this.btn_ocho_Click);
            // 
            // btn_AC
            // 
            this.btn_AC.Location = new System.Drawing.Point(358, 13);
            this.btn_AC.Name = "btn_AC";
            this.btn_AC.Size = new System.Drawing.Size(108, 40);
            this.btn_AC.TabIndex = 7;
            this.btn_AC.Text = "AC";
            this.btn_AC.UseVisualStyleBackColor = true;
            this.btn_AC.Click += new System.EventHandler(this.btn_AC_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(244, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 40);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 40);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_siete
            // 
            this.btn_siete.Location = new System.Drawing.Point(16, 69);
            this.btn_siete.Name = "btn_siete";
            this.btn_siete.Size = new System.Drawing.Size(108, 40);
            this.btn_siete.TabIndex = 4;
            this.btn_siete.Text = "7";
            this.btn_siete.UseVisualStyleBackColor = true;
            this.btn_siete.Click += new System.EventHandler(this.btn_siete_Click);
            // 
            // btn_cero
            // 
            this.btn_cero.Location = new System.Drawing.Point(16, 238);
            this.btn_cero.Name = "btn_cero";
            this.btn_cero.Size = new System.Drawing.Size(108, 40);
            this.btn_cero.TabIndex = 3;
            this.btn_cero.Text = "0";
            this.btn_cero.UseVisualStyleBackColor = true;
            this.btn_cero.Click += new System.EventHandler(this.btn_cero_Click);
            // 
            // btn_uno
            // 
            this.btn_uno.Location = new System.Drawing.Point(16, 182);
            this.btn_uno.Name = "btn_uno";
            this.btn_uno.Size = new System.Drawing.Size(108, 40);
            this.btn_uno.TabIndex = 2;
            this.btn_uno.Text = "1";
            this.btn_uno.UseVisualStyleBackColor = true;
            this.btn_uno.Click += new System.EventHandler(this.btn_uno_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(16, 125);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(108, 40);
            this.btn_4.TabIndex = 1;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(16, 13);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(108, 40);
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = true;
            // 
            // CalculadoraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_sup);
            this.MaximizeBox = false;
            this.Name = "CalculadoraGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.panel_sup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sup;
        private System.Windows.Forms.Label lbl_mostrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_rest;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_seis;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_nueve;
        private System.Windows.Forms.Button btn_punto;
        private System.Windows.Forms.Button btn_dos;
        private System.Windows.Forms.Button btn_cinco;
        private System.Windows.Forms.Button btn_ocho;
        private System.Windows.Forms.Button btn_AC;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_siete;
        private System.Windows.Forms.Button btn_cero;
        private System.Windows.Forms.Button btn_uno;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button button;
    }
}

