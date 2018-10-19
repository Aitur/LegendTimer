using System.ComponentModel;
using System.Windows.Forms;

namespace TimeTracker
{
    partial class WeeklyOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMontag = new System.Windows.Forms.Label();
            this.lblDienstag = new System.Windows.Forms.Label();
            this.lblMittwoch = new System.Windows.Forms.Label();
            this.lblDonnerstag = new System.Windows.Forms.Label();
            this.lblFreitag = new System.Windows.Forms.Label();
            this.lblSamstag = new System.Windows.Forms.Label();
            this.lblSonntag = new System.Windows.Forms.Label();
            this.btnExportieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dienstag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mittwoch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Donnerstag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Freitag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Samstag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(12, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 42);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sonntag";
            // 
            // lblMontag
            // 
            this.lblMontag.AutoSize = true;
            this.lblMontag.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMontag.Location = new System.Drawing.Point(221, 18);
            this.lblMontag.Name = "lblMontag";
            this.lblMontag.Size = new System.Drawing.Size(128, 42);
            this.lblMontag.TabIndex = 7;
            this.lblMontag.Text = "00:00:00";
            // 
            // lblDienstag
            // 
            this.lblDienstag.AutoSize = true;
            this.lblDienstag.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDienstag.Location = new System.Drawing.Point(221, 61);
            this.lblDienstag.Name = "lblDienstag";
            this.lblDienstag.Size = new System.Drawing.Size(128, 42);
            this.lblDienstag.TabIndex = 8;
            this.lblDienstag.Text = "00:00:00";
            // 
            // lblMittwoch
            // 
            this.lblMittwoch.AutoSize = true;
            this.lblMittwoch.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMittwoch.Location = new System.Drawing.Point(221, 111);
            this.lblMittwoch.Name = "lblMittwoch";
            this.lblMittwoch.Size = new System.Drawing.Size(128, 42);
            this.lblMittwoch.TabIndex = 9;
            this.lblMittwoch.Text = "00:00:00";
            // 
            // lblDonnerstag
            // 
            this.lblDonnerstag.AutoSize = true;
            this.lblDonnerstag.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDonnerstag.Location = new System.Drawing.Point(221, 171);
            this.lblDonnerstag.Name = "lblDonnerstag";
            this.lblDonnerstag.Size = new System.Drawing.Size(128, 42);
            this.lblDonnerstag.TabIndex = 10;
            this.lblDonnerstag.Text = "00:00:00";
            // 
            // lblFreitag
            // 
            this.lblFreitag.AutoSize = true;
            this.lblFreitag.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFreitag.Location = new System.Drawing.Point(221, 227);
            this.lblFreitag.Name = "lblFreitag";
            this.lblFreitag.Size = new System.Drawing.Size(128, 42);
            this.lblFreitag.TabIndex = 11;
            this.lblFreitag.Text = "00:00:00";
            // 
            // lblSamstag
            // 
            this.lblSamstag.AutoSize = true;
            this.lblSamstag.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSamstag.Location = new System.Drawing.Point(221, 278);
            this.lblSamstag.Name = "lblSamstag";
            this.lblSamstag.Size = new System.Drawing.Size(128, 42);
            this.lblSamstag.TabIndex = 12;
            this.lblSamstag.Text = "00:00:00";
            // 
            // lblSonntag
            // 
            this.lblSonntag.AutoSize = true;
            this.lblSonntag.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSonntag.Location = new System.Drawing.Point(221, 323);
            this.lblSonntag.Name = "lblSonntag";
            this.lblSonntag.Size = new System.Drawing.Size(128, 42);
            this.lblSonntag.TabIndex = 13;
            this.lblSonntag.Text = "00:00:00";
            // 
            // btnExportieren
            // 
            this.btnExportieren.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExportieren.Location = new System.Drawing.Point(10, 369);
            this.btnExportieren.Name = "btnExportieren";
            this.btnExportieren.Size = new System.Drawing.Size(172, 52);
            this.btnExportieren.TabIndex = 14;
            this.btnExportieren.Text = "Exportieren";
            this.btnExportieren.UseVisualStyleBackColor = true;
            // 
            // Wochenansicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 432);
            this.Controls.Add(this.btnExportieren);
            this.Controls.Add(this.lblSonntag);
            this.Controls.Add(this.lblSamstag);
            this.Controls.Add(this.lblFreitag);
            this.Controls.Add(this.lblDonnerstag);
            this.Controls.Add(this.lblMittwoch);
            this.Controls.Add(this.lblDienstag);
            this.Controls.Add(this.lblMontag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Wochenansicht";
            this.Text = "Wochenansicht";
            this.Load += new System.EventHandler(this.ShowData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblMontag;
        private Label lblDienstag;
        private Label lblMittwoch;
        private Label lblDonnerstag;
        private Label lblFreitag;
        private Label lblSamstag;
        private Label lblSonntag;
        private Button btnExportieren;
    }
}