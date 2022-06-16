namespace winFormKronometre
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnTur = new System.Windows.Forms.Button();
            this.lstTur = new System.Windows.Forms.ListBox();
            this.btnBaşlat = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnTur
            // 
            this.btnTur.Location = new System.Drawing.Point(160, 209);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(75, 23);
            this.btnTur.TabIndex = 1;
            this.btnTur.Text = "Tur";
            this.btnTur.UseVisualStyleBackColor = true;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // lstTur
            // 
            this.lstTur.FormattingEnabled = true;
            this.lstTur.Location = new System.Drawing.Point(160, 241);
            this.lstTur.Name = "lstTur";
            this.lstTur.Size = new System.Drawing.Size(284, 160);
            this.lstTur.TabIndex = 2;
            // 
            // btnBaşlat
            // 
            this.btnBaşlat.Location = new System.Drawing.Point(200, 66);
            this.btnBaşlat.Name = "btnBaşlat";
            this.btnBaşlat.Size = new System.Drawing.Size(75, 23);
            this.btnBaşlat.TabIndex = 3;
            this.btnBaşlat.Text = "Başlat";
            this.btnBaşlat.UseVisualStyleBackColor = true;
            this.btnBaşlat.Click += new System.EventHandler(this.btnBaşlat_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(343, 66);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 23);
            this.btnSifirla.TabIndex = 5;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "1. Tur:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBaşlat);
            this.Controls.Add(this.lstTur);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.ListBox lstTur;
        private System.Windows.Forms.Button btnBaşlat;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

