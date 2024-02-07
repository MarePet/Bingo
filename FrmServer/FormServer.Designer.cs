namespace FrmServer
{
    partial class FormServer
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblCifra1 = new System.Windows.Forms.Label();
            this.lblCifra2 = new System.Windows.Forms.Label();
            this.lblCifra3 = new System.Windows.Forms.Label();
            this.lblCifra4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(54, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(413, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(54, 178);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(142, 40);
            this.btnPokreni.TabIndex = 2;
            this.btnPokreni.Text = "Pokreni igru";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(371, 178);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(142, 40);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sacuvaj igru";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblCifra1
            // 
            this.lblCifra1.AutoSize = true;
            this.lblCifra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifra1.Location = new System.Drawing.Point(49, 116);
            this.lblCifra1.Name = "lblCifra1";
            this.lblCifra1.Size = new System.Drawing.Size(0, 29);
            this.lblCifra1.TabIndex = 4;
            // 
            // lblCifra2
            // 
            this.lblCifra2.AutoSize = true;
            this.lblCifra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifra2.Location = new System.Drawing.Point(177, 116);
            this.lblCifra2.Name = "lblCifra2";
            this.lblCifra2.Size = new System.Drawing.Size(0, 29);
            this.lblCifra2.TabIndex = 5;
            // 
            // lblCifra3
            // 
            this.lblCifra3.AutoSize = true;
            this.lblCifra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifra3.Location = new System.Drawing.Point(305, 116);
            this.lblCifra3.Name = "lblCifra3";
            this.lblCifra3.Size = new System.Drawing.Size(0, 29);
            this.lblCifra3.TabIndex = 6;
            // 
            // lblCifra4
            // 
            this.lblCifra4.AutoSize = true;
            this.lblCifra4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifra4.Location = new System.Drawing.Point(433, 116);
            this.lblCifra4.Name = "lblCifra4";
            this.lblCifra4.Size = new System.Drawing.Size(0, 29);
            this.lblCifra4.TabIndex = 7;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 255);
            this.Controls.Add(this.lblCifra4);
            this.Controls.Add(this.lblCifra3);
            this.Controls.Add(this.lblCifra2);
            this.Controls.Add(this.lblCifra1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "FormServer";
            this.Text = "Moje igre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblCifra1;
        private System.Windows.Forms.Label lblCifra2;
        private System.Windows.Forms.Label lblCifra3;
        private System.Windows.Forms.Label lblCifra4;
    }
}

