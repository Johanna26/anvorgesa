namespace salchipapa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.salida = new System.Windows.Forms.Button();
            this.usu = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Super Secreto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(30, 271);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(93, 53);
            this.inicio.TabIndex = 3;
            this.inicio.Text = "Iniciar";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.Button1_Click);
            // 
            // salida
            // 
            this.salida.Location = new System.Drawing.Point(238, 271);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(93, 53);
            this.salida.TabIndex = 4;
            this.salida.Text = "Salir";
            this.salida.UseVisualStyleBackColor = true;
            this.salida.Click += new System.EventHandler(this.Salida_Click);
            // 
            // usu
            // 
            this.usu.Location = new System.Drawing.Point(105, 93);
            this.usu.Name = "usu";
            this.usu.Size = new System.Drawing.Size(225, 20);
            this.usu.TabIndex = 5;
            this.usu.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(105, 170);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(225, 20);
            this.password.TabIndex = 6;
            this.password.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 395);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usu);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Button salida;
        private System.Windows.Forms.TextBox usu;
        private System.Windows.Forms.TextBox password;
    }
}

