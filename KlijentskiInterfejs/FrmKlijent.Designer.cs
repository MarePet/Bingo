namespace KlijentskiInterfejs
{
    partial class FrmKlijent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCifra1 = new System.Windows.Forms.TextBox();
            this.txtCifra2 = new System.Windows.Forms.TextBox();
            this.txtCifra3 = new System.Windows.Forms.TextBox();
            this.txtCifra4 = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.dgvPogadjanja = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNaMestu = new System.Windows.Forms.Label();
            this.lblNISUNaMestu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPogadjanja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cifra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cifra 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cifra 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cifra 4";
            // 
            // txtCifra1
            // 
            this.txtCifra1.Location = new System.Drawing.Point(63, 10);
            this.txtCifra1.Name = "txtCifra1";
            this.txtCifra1.Size = new System.Drawing.Size(57, 22);
            this.txtCifra1.TabIndex = 4;
            // 
            // txtCifra2
            // 
            this.txtCifra2.Location = new System.Drawing.Point(63, 47);
            this.txtCifra2.Name = "txtCifra2";
            this.txtCifra2.Size = new System.Drawing.Size(57, 22);
            this.txtCifra2.TabIndex = 5;
            // 
            // txtCifra3
            // 
            this.txtCifra3.Location = new System.Drawing.Point(63, 84);
            this.txtCifra3.Name = "txtCifra3";
            this.txtCifra3.Size = new System.Drawing.Size(57, 22);
            this.txtCifra3.TabIndex = 6;
            // 
            // txtCifra4
            // 
            this.txtCifra4.Location = new System.Drawing.Point(63, 121);
            this.txtCifra4.Name = "txtCifra4";
            this.txtCifra4.Size = new System.Drawing.Size(57, 22);
            this.txtCifra4.TabIndex = 7;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(16, 158);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(104, 45);
            this.btnPosalji.TabIndex = 8;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // dgvPogadjanja
            // 
            this.dgvPogadjanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPogadjanja.Location = new System.Drawing.Point(136, 10);
            this.dgvPogadjanja.Name = "dgvPogadjanja";
            this.dgvPogadjanja.RowHeadersWidth = 51;
            this.dgvPogadjanja.RowTemplate.Height = 24;
            this.dgvPogadjanja.Size = new System.Drawing.Size(436, 193);
            this.dgvPogadjanja.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj pogodjenih na mestu: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Broj pogodjenih koje NISU na mestu: ";
            // 
            // lblNaMestu
            // 
            this.lblNaMestu.AutoSize = true;
            this.lblNaMestu.Location = new System.Drawing.Point(251, 220);
            this.lblNaMestu.Name = "lblNaMestu";
            this.lblNaMestu.Size = new System.Drawing.Size(0, 16);
            this.lblNaMestu.TabIndex = 12;
            // 
            // lblNISUNaMestu
            // 
            this.lblNISUNaMestu.AutoSize = true;
            this.lblNISUNaMestu.Location = new System.Drawing.Point(251, 258);
            this.lblNISUNaMestu.Name = "lblNISUNaMestu";
            this.lblNISUNaMestu.Size = new System.Drawing.Size(0, 16);
            this.lblNISUNaMestu.TabIndex = 13;
            // 
            // FrmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 294);
            this.Controls.Add(this.lblNISUNaMestu);
            this.Controls.Add(this.lblNaMestu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPogadjanja);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtCifra4);
            this.Controls.Add(this.txtCifra3);
            this.Controls.Add(this.txtCifra2);
            this.Controls.Add(this.txtCifra1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKlijent";
            this.Text = "Klijent";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPogadjanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCifra1;
        private System.Windows.Forms.TextBox txtCifra2;
        private System.Windows.Forms.TextBox txtCifra3;
        private System.Windows.Forms.TextBox txtCifra4;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.DataGridView dgvPogadjanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNaMestu;
        private System.Windows.Forms.Label lblNISUNaMestu;
    }
}

