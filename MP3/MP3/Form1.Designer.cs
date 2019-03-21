namespace MP3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lista_Canciones = new System.Windows.Forms.ListBox();
            this.b = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Iniciar = new System.Windows.Forms.Button();
            this.Pausar = new System.Windows.Forms.Button();
            this.Detener = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista_Canciones
            // 
            this.Lista_Canciones.FormattingEnabled = true;
            this.Lista_Canciones.Location = new System.Drawing.Point(12, 12);
            this.Lista_Canciones.Name = "Lista_Canciones";
            this.Lista_Canciones.Size = new System.Drawing.Size(309, 199);
            this.Lista_Canciones.TabIndex = 0;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(29, 217);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 23);
            this.b.TabIndex = 1;
            this.b.Text = "AGREGAR";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(668, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(206, 183);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(668, 243);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(75, 23);
            this.Iniciar.TabIndex = 3;
            this.Iniciar.Text = "button1";
            this.Iniciar.UseVisualStyleBackColor = true;
            // 
            // Pausar
            // 
            this.Pausar.Location = new System.Drawing.Point(769, 243);
            this.Pausar.Name = "Pausar";
            this.Pausar.Size = new System.Drawing.Size(75, 23);
            this.Pausar.TabIndex = 4;
            this.Pausar.Text = "button2";
            this.Pausar.UseVisualStyleBackColor = true;
            // 
            // Detener
            // 
            this.Detener.Location = new System.Drawing.Point(721, 281);
            this.Detener.Name = "Detener";
            this.Detener.Size = new System.Drawing.Size(75, 23);
            this.Detener.TabIndex = 5;
            this.Detener.Text = "button3";
            this.Detener.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 334);
            this.Controls.Add(this.Detener);
            this.Controls.Add(this.Pausar);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.b);
            this.Controls.Add(this.Lista_Canciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_Canciones;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Pausar;
        private System.Windows.Forms.Button Detener;
    }
}

