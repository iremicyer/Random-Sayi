namespace Random_Sayı
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
            this.textBoxSayilar = new System.Windows.Forms.TextBox();
            this.btnRandomOluşturma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSayilar
            // 
            this.textBoxSayilar.BackColor = System.Drawing.Color.Pink;
            this.textBoxSayilar.Location = new System.Drawing.Point(64, 87);
            this.textBoxSayilar.Multiline = true;
            this.textBoxSayilar.Name = "textBoxSayilar";
            this.textBoxSayilar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSayilar.Size = new System.Drawing.Size(126, 449);
            this.textBoxSayilar.TabIndex = 2;
            this.textBoxSayilar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSayilar_KeyPress);
            // 
            // btnRandomOluşturma
            // 
            this.btnRandomOluşturma.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRandomOluşturma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandomOluşturma.Location = new System.Drawing.Point(78, 23);
            this.btnRandomOluşturma.Name = "btnRandomOluşturma";
            this.btnRandomOluşturma.Size = new System.Drawing.Size(95, 58);
            this.btnRandomOluşturma.TabIndex = 3;
            this.btnRandomOluşturma.Text = "Randon Sayi Oluşturma";
            this.btnRandomOluşturma.UseVisualStyleBackColor = false;
            this.btnRandomOluşturma.Click += new System.EventHandler(this.btnRandomOluşturma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(263, 579);
            this.Controls.Add(this.btnRandomOluşturma);
            this.Controls.Add(this.textBoxSayilar);
            this.Name = "Form1";
            this.Text = "Random Sayi Oluşturma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSayilar;
        private System.Windows.Forms.Button btnRandomOluşturma;
    }
}

