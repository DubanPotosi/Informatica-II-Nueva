
namespace forma_grafica_desprendible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textContraseña = new System.Windows.Forms.Label();
            this.boxContraseña = new System.Windows.Forms.TextBox();
            this.buttonContraseña = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textContraseña
            // 
            this.textContraseña.AutoSize = true;
            this.textContraseña.BackColor = System.Drawing.Color.White;
            this.textContraseña.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.ForeColor = System.Drawing.Color.Red;
            this.textContraseña.Location = new System.Drawing.Point(275, 43);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(251, 31);
            this.textContraseña.TabIndex = 0;
            this.textContraseña.Text = "Ingresar Contraseña";
            // 
            // boxContraseña
            // 
            this.boxContraseña.Location = new System.Drawing.Point(250, 133);
            this.boxContraseña.Name = "boxContraseña";
            this.boxContraseña.PasswordChar = '*';
            this.boxContraseña.Size = new System.Drawing.Size(301, 20);
            this.boxContraseña.TabIndex = 1;
            // 
            // buttonContraseña
            // 
            this.buttonContraseña.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonContraseña.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContraseña.ForeColor = System.Drawing.Color.White;
            this.buttonContraseña.Location = new System.Drawing.Point(334, 315);
            this.buttonContraseña.Name = "buttonContraseña";
            this.buttonContraseña.Size = new System.Drawing.Size(132, 35);
            this.buttonContraseña.TabIndex = 2;
            this.buttonContraseña.Text = "INGRESAR";
            this.buttonContraseña.UseVisualStyleBackColor = false;
            this.buttonContraseña.Click += new System.EventHandler(this.buttoncontraseña_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonContraseña);
            this.Controls.Add(this.boxContraseña);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textContraseña;
        private System.Windows.Forms.TextBox boxContraseña;
        private System.Windows.Forms.Button buttonContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

