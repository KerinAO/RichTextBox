namespace RichTextBox
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
            this.buttonCitaj = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.buttonMapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCitaj
            // 
            this.buttonCitaj.Location = new System.Drawing.Point(13, 12);
            this.buttonCitaj.Name = "buttonCitaj";
            this.buttonCitaj.Size = new System.Drawing.Size(103, 33);
            this.buttonCitaj.TabIndex = 0;
            this.buttonCitaj.Text = "&Citaj";
            this.buttonCitaj.UseVisualStyleBackColor = true;
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(693, 12);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(95, 33);
            this.buttonBrisi.TabIndex = 1;
            this.buttonBrisi.Text = "&Brisi";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(12, 401);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(104, 37);
            this.buttonSpremi.TabIndex = 2;
            this.buttonSpremi.Text = "&Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(13, 51);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(775, 327);
            this.rtbIspis.TabIndex = 3;
            this.rtbIspis.Text = "";
            // 
            // buttonMapa
            // 
            this.buttonMapa.Location = new System.Drawing.Point(693, 401);
            this.buttonMapa.Name = "buttonMapa";
            this.buttonMapa.Size = new System.Drawing.Size(95, 37);
            this.buttonMapa.TabIndex = 4;
            this.buttonMapa.Text = "&Mapa";
            this.buttonMapa.UseVisualStyleBackColor = true;
            this.buttonMapa.Click += new System.EventHandler(this.buttonMapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMapa);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonCitaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCitaj;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button buttonMapa;
    }
}

