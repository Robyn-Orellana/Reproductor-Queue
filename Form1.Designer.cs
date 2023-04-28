namespace Reproductor01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Agregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nombre = new System.Windows.Forms.Label();
            this.artista = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(38, 26);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(143, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(143, 66);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(41, 15);
            this.lblArtista.TabIndex = 2;
            this.lblArtista.Text = "Artista";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(143, 99);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(22, 15);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "Url";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(38, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 229);
            this.listBox1.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(236, 34);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(10, 15);
            this.nombre.TabIndex = 5;
            this.nombre.Text = ".";
            // 
            // artista
            // 
            this.artista.AutoSize = true;
            this.artista.Location = new System.Drawing.Point(236, 66);
            this.artista.Name = "artista";
            this.artista.Size = new System.Drawing.Size(10, 15);
            this.artista.TabIndex = 6;
            this.artista.Text = ".";
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(236, 99);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(10, 15);
            this.url.TabIndex = 7;
            this.url.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.url);
            this.Controls.Add(this.artista);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.Agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Agregar;
        private Label lblNombre;
        private Label lblArtista;
        private Label lblUrl;
        private ListBox listBox1;
        private Label nombre;
        private Label artista;
        private Label url;
    }
}