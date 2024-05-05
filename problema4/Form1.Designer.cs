namespace problema4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mostrar_persona = new System.Windows.Forms.Button();
            this.mostrar_cuenta = new System.Windows.Forms.Button();
            this.textBoxCi = new System.Windows.Forms.TextBox();
            this.textBoxCi_cuenta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxCi_cuenta);
            this.panel1.Controls.Add(this.textBoxCi);
            this.panel1.Controls.Add(this.mostrar_cuenta);
            this.panel1.Controls.Add(this.mostrar_persona);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // mostrar_persona
            // 
            this.mostrar_persona.Location = new System.Drawing.Point(128, 25);
            this.mostrar_persona.Name = "mostrar_persona";
            this.mostrar_persona.Size = new System.Drawing.Size(108, 23);
            this.mostrar_persona.TabIndex = 0;
            this.mostrar_persona.Text = "Mostrar persona";
            this.mostrar_persona.UseVisualStyleBackColor = true;
            this.mostrar_persona.Click += new System.EventHandler(this.mostrar_persona_Click);
            // 
            // mostrar_cuenta
            // 
            this.mostrar_cuenta.Location = new System.Drawing.Point(426, 26);
            this.mostrar_cuenta.Name = "mostrar_cuenta";
            this.mostrar_cuenta.Size = new System.Drawing.Size(105, 23);
            this.mostrar_cuenta.TabIndex = 1;
            this.mostrar_cuenta.Text = "Mostrar cuenta";
            this.mostrar_cuenta.UseVisualStyleBackColor = true;
            this.mostrar_cuenta.Click += new System.EventHandler(this.mostrar_cuenta_Click);
            // 
            // textBoxCi
            // 
            this.textBoxCi.Location = new System.Drawing.Point(22, 28);
            this.textBoxCi.Name = "textBoxCi";
            this.textBoxCi.Size = new System.Drawing.Size(100, 20);
            this.textBoxCi.TabIndex = 2;
            // 
            // textBoxCi_cuenta
            // 
            this.textBoxCi_cuenta.Location = new System.Drawing.Point(320, 28);
            this.textBoxCi_cuenta.Name = "textBoxCi_cuenta";
            this.textBoxCi_cuenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxCi_cuenta.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 331);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCi_cuenta;
        private System.Windows.Forms.TextBox textBoxCi;
        private System.Windows.Forms.Button mostrar_cuenta;
        private System.Windows.Forms.Button mostrar_persona;
    }
}

