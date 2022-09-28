namespace CheckBox_kontrola
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
            this.CheckDorucak = new System.Windows.Forms.CheckBox();
            this.CheckRucak = new System.Windows.Forms.CheckBox();
            this.CheckVecera = new System.Windows.Forms.CheckBox();
            this.TxtNarudzba = new System.Windows.Forms.TextBox();
            this.CheckSakrij = new System.Windows.Forms.CheckBox();
            this.BtnPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckDorucak
            // 
            this.CheckDorucak.AutoSize = true;
            this.CheckDorucak.Location = new System.Drawing.Point(44, 43);
            this.CheckDorucak.Name = "CheckDorucak";
            this.CheckDorucak.Size = new System.Drawing.Size(67, 17);
            this.CheckDorucak.TabIndex = 0;
            this.CheckDorucak.Text = "Doručak";
            this.CheckDorucak.UseVisualStyleBackColor = true;
            // 
            // CheckRucak
            // 
            this.CheckRucak.AutoSize = true;
            this.CheckRucak.Location = new System.Drawing.Point(44, 93);
            this.CheckRucak.Name = "CheckRucak";
            this.CheckRucak.Size = new System.Drawing.Size(58, 17);
            this.CheckRucak.TabIndex = 1;
            this.CheckRucak.Text = "Ručak";
            this.CheckRucak.UseVisualStyleBackColor = true;
            // 
            // CheckVecera
            // 
            this.CheckVecera.AutoSize = true;
            this.CheckVecera.Location = new System.Drawing.Point(44, 147);
            this.CheckVecera.Name = "CheckVecera";
            this.CheckVecera.Size = new System.Drawing.Size(60, 17);
            this.CheckVecera.TabIndex = 2;
            this.CheckVecera.Text = "Večera";
            this.CheckVecera.UseVisualStyleBackColor = true;
            // 
            // TxtNarudzba
            // 
            this.TxtNarudzba.Location = new System.Drawing.Point(253, 43);
            this.TxtNarudzba.Multiline = true;
            this.TxtNarudzba.Name = "TxtNarudzba";
            this.TxtNarudzba.ReadOnly = true;
            this.TxtNarudzba.Size = new System.Drawing.Size(176, 121);
            this.TxtNarudzba.TabIndex = 3;
            // 
            // CheckSakrij
            // 
            this.CheckSakrij.AutoSize = true;
            this.CheckSakrij.Location = new System.Drawing.Point(253, 210);
            this.CheckSakrij.Name = "CheckSakrij";
            this.CheckSakrij.Size = new System.Drawing.Size(101, 17);
            this.CheckSakrij.TabIndex = 4;
            this.CheckSakrij.Text = "Sakrij Narudžbu";
            this.CheckSakrij.UseVisualStyleBackColor = true;
            this.CheckSakrij.CheckedChanged += new System.EventHandler(this.CheckSakrij_CheckedChanged);
            // 
            // BtnPosalji
            // 
            this.BtnPosalji.Location = new System.Drawing.Point(44, 210);
            this.BtnPosalji.Name = "BtnPosalji";
            this.BtnPosalji.Size = new System.Drawing.Size(75, 23);
            this.BtnPosalji.TabIndex = 5;
            this.BtnPosalji.Text = "Pošalji";
            this.BtnPosalji.UseVisualStyleBackColor = true;
            this.BtnPosalji.Click += new System.EventHandler(this.BtnPosalji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 306);
            this.Controls.Add(this.BtnPosalji);
            this.Controls.Add(this.CheckSakrij);
            this.Controls.Add(this.TxtNarudzba);
            this.Controls.Add(this.CheckVecera);
            this.Controls.Add(this.CheckRucak);
            this.Controls.Add(this.CheckDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckDorucak;
        private System.Windows.Forms.CheckBox CheckRucak;
        private System.Windows.Forms.CheckBox CheckVecera;
        private System.Windows.Forms.TextBox TxtNarudzba;
        private System.Windows.Forms.CheckBox CheckSakrij;
        private System.Windows.Forms.Button BtnPosalji;
    }
}

