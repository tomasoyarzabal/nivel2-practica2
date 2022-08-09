
namespace proyrctofechanoconosola
{
    partial class Form1
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
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.Calendar1 = new System.Windows.Forms.MonthCalendar();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(262, 80);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(248, 20);
            this.date1.TabIndex = 0;
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(262, 155);
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 1;
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(574, 69);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(105, 31);
            this.boton1.TabIndex = 2;
            this.boton1.Text = "prueba1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(574, 288);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(105, 29);
            this.boton2.TabIndex = 3;
            this.boton2.Text = "prueba2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.Calendar1);
            this.Controls.Add(this.date1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.MonthCalendar Calendar1;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
    }
}

