namespace _201504242
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
            this.analizar = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.Button();
            this.Crear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.correr3d = new System.Windows.Forms.Button();
            this.reportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // analizar
            // 
            this.analizar.Location = new System.Drawing.Point(382, 8);
            this.analizar.Name = "analizar";
            this.analizar.Size = new System.Drawing.Size(119, 42);
            this.analizar.TabIndex = 0;
            this.analizar.Text = "Generar3D";
            this.analizar.UseVisualStyleBackColor = true;
            this.analizar.Click += new System.EventHandler(this.analizar_Click);
            // 
            // abrir
            // 
            this.abrir.Location = new System.Drawing.Point(12, 8);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(115, 42);
            this.abrir.TabIndex = 3;
            this.abrir.Text = "Abrir";
            this.abrir.UseVisualStyleBackColor = true;
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(133, 8);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(111, 42);
            this.Crear.TabIndex = 4;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Debuger";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(613, 399);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(640, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 399);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Consola";
            // 
            // correr3d
            // 
            this.correr3d.Location = new System.Drawing.Point(507, 8);
            this.correr3d.Name = "correr3d";
            this.correr3d.Size = new System.Drawing.Size(119, 42);
            this.correr3d.TabIndex = 8;
            this.correr3d.Text = "Correr3D";
            this.correr3d.UseVisualStyleBackColor = true;
            // 
            // reportes
            // 
            this.reportes.Location = new System.Drawing.Point(632, 8);
            this.reportes.Name = "reportes";
            this.reportes.Size = new System.Drawing.Size(119, 42);
            this.reportes.TabIndex = 9;
            this.reportes.Text = "Reportes";
            this.reportes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 486);
            this.Controls.Add(this.reportes);
            this.Controls.Add(this.correr3d);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.abrir);
            this.Controls.Add(this.analizar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button analizar;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button correr3d;
        private System.Windows.Forms.Button reportes;
    }
}

