
namespace Color
{
    partial class vnt_colores
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
            this.bton_red = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bton_red
            // 
            this.bton_red.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bton_red.Location = new System.Drawing.Point(19, 18);
            this.bton_red.Name = "bton_red";
            this.bton_red.Size = new System.Drawing.Size(57, 21);
            this.bton_red.TabIndex = 0;
            this.bton_red.Text = "Rojo";
            this.bton_red.UseVisualStyleBackColor = true;
            this.bton_red.Click += new System.EventHandler(this.bton_red_Click);
            // 
            // vnt_colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bton_red);
            this.Name = "vnt_colores";
            this.Text = "Colores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bton_red;
    }
}

