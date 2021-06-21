namespace Kreisberechnung
{
    partial class FRMkreis
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Rechnen = new System.Windows.Forms.Button();
            this.BTN_reset = new System.Windows.Forms.Button();
            this.BTN_beenden = new System.Windows.Forms.Button();
            this.TB_radius = new System.Windows.Forms.TextBox();
            this.TB_flaeche = new System.Windows.Forms.TextBox();
            this.TB_umfang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Rechnen
            // 
            this.BTN_Rechnen.Location = new System.Drawing.Point(54, 216);
            this.BTN_Rechnen.Name = "BTN_Rechnen";
            this.BTN_Rechnen.Size = new System.Drawing.Size(75, 23);
            this.BTN_Rechnen.TabIndex = 0;
            this.BTN_Rechnen.Text = "Berechne";
            this.BTN_Rechnen.UseVisualStyleBackColor = true;
            this.BTN_Rechnen.Click += new System.EventHandler(this.BTN_Rechnen_Click);
            // 
            // BTN_reset
            // 
            this.BTN_reset.Location = new System.Drawing.Point(179, 216);
            this.BTN_reset.Name = "BTN_reset";
            this.BTN_reset.Size = new System.Drawing.Size(75, 23);
            this.BTN_reset.TabIndex = 1;
            this.BTN_reset.Text = "Reset";
            this.BTN_reset.UseVisualStyleBackColor = true;
            this.BTN_reset.Click += new System.EventHandler(this.BTN_reset_Click);
            // 
            // BTN_beenden
            // 
            this.BTN_beenden.Location = new System.Drawing.Point(302, 216);
            this.BTN_beenden.Name = "BTN_beenden";
            this.BTN_beenden.Size = new System.Drawing.Size(75, 23);
            this.BTN_beenden.TabIndex = 2;
            this.BTN_beenden.Text = "Beenden";
            this.BTN_beenden.UseVisualStyleBackColor = true;
            this.BTN_beenden.Click += new System.EventHandler(this.BTN_beenden_Click);
            // 
            // TB_radius
            // 
            this.TB_radius.Location = new System.Drawing.Point(179, 54);
            this.TB_radius.Name = "TB_radius";
            this.TB_radius.Size = new System.Drawing.Size(100, 20);
            this.TB_radius.TabIndex = 3;
            // 
            // TB_flaeche
            // 
            this.TB_flaeche.Location = new System.Drawing.Point(86, 117);
            this.TB_flaeche.Name = "TB_flaeche";
            this.TB_flaeche.Size = new System.Drawing.Size(100, 20);
            this.TB_flaeche.TabIndex = 4;
            // 
            // TB_umfang
            // 
            this.TB_umfang.Location = new System.Drawing.Point(277, 117);
            this.TB_umfang.Name = "TB_umfang";
            this.TB_umfang.Size = new System.Drawing.Size(100, 20);
            this.TB_umfang.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fläche:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Umfang:";
            // 
            // FRMkreis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_umfang);
            this.Controls.Add(this.TB_flaeche);
            this.Controls.Add(this.TB_radius);
            this.Controls.Add(this.BTN_beenden);
            this.Controls.Add(this.BTN_reset);
            this.Controls.Add(this.BTN_Rechnen);
            this.Name = "FRMkreis";
            this.Text = "Kreisberechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Rechnen;
        private System.Windows.Forms.Button BTN_reset;
        private System.Windows.Forms.Button BTN_beenden;
        private System.Windows.Forms.TextBox TB_radius;
        private System.Windows.Forms.TextBox TB_flaeche;
        private System.Windows.Forms.TextBox TB_umfang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

