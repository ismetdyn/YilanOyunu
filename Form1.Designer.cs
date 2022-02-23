
namespace Proje5._38_YilanOyunu
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
            this.components = new System.ComponentModel.Container();
            this.pnlAlan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lYutulanYemSayisi = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlAlan
            // 
            this.pnlAlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlan.Location = new System.Drawing.Point(12, 12);
            this.pnlAlan.Name = "pnlAlan";
            this.pnlAlan.Size = new System.Drawing.Size(562, 562);
            this.pnlAlan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yutulan Yem Sayısı:";
            // 
            // lYutulanYemSayisi
            // 
            this.lYutulanYemSayisi.AutoSize = true;
            this.lYutulanYemSayisi.Location = new System.Drawing.Point(144, 601);
            this.lYutulanYemSayisi.Name = "lYutulanYemSayisi";
            this.lYutulanYemSayisi.Size = new System.Drawing.Size(14, 16);
            this.lYutulanYemSayisi.TabIndex = 2;
            this.lYutulanYemSayisi.Text = "0";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(467, 593);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(107, 35);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 639);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lYutulanYemSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlAlan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lYutulanYemSayisi;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
    }
}

