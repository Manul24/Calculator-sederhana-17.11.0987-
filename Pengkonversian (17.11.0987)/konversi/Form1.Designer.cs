namespace konversi
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputnominal = new System.Windows.Forms.TextBox();
            this.btn_konversi = new System.Windows.Forms.Button();
            this.terbilang = new System.Windows.Forms.Label();
            this.konversi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMINAL ANGKA";
            // 
            // inputnominal
            // 
            this.inputnominal.Location = new System.Drawing.Point(34, 51);
            this.inputnominal.Name = "inputnominal";
            this.inputnominal.Size = new System.Drawing.Size(266, 22);
            this.inputnominal.TabIndex = 2;
            // 
            // btn_konversi
            // 
            this.btn_konversi.Location = new System.Drawing.Point(343, 50);
            this.btn_konversi.Name = "btn_konversi";
            this.btn_konversi.Size = new System.Drawing.Size(75, 23);
            this.btn_konversi.TabIndex = 3;
            this.btn_konversi.Text = "CEK";
            this.btn_konversi.UseVisualStyleBackColor = true;
            this.btn_konversi.Click += new System.EventHandler(this.btn_konfersi_click);
            // 
            // terbilang
            // 
            this.terbilang.AutoSize = true;
            this.terbilang.Location = new System.Drawing.Point(31, 92);
            this.terbilang.Name = "terbilang";
            this.terbilang.Size = new System.Drawing.Size(68, 17);
            this.terbilang.TabIndex = 4;
            this.terbilang.Text = "Terbilang";
            // 
            // konversi
            // 
            this.konversi.FormattingEnabled = true;
            this.konversi.ItemHeight = 16;
            this.konversi.Location = new System.Drawing.Point(34, 124);
            this.konversi.Name = "konversi";
            this.konversi.Size = new System.Drawing.Size(416, 84);
            this.konversi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 253);
            this.Controls.Add(this.konversi);
            this.Controls.Add(this.terbilang);
            this.Controls.Add(this.btn_konversi);
            this.Controls.Add(this.inputnominal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputnominal;
        private System.Windows.Forms.Button btn_konversi;
        private System.Windows.Forms.Label terbilang;
        private System.Windows.Forms.ListBox konversi;
    }
}

