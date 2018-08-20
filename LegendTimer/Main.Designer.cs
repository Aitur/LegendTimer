namespace LegendTimer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.buttonNachtragen = new System.Windows.Forms.Button();
            this.buttonAuswertung = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelZeitAnzeige = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonNachtragen
            // 
            this.buttonNachtragen.Font = new System.Drawing.Font("Papyrus", 12F);
            this.buttonNachtragen.Location = new System.Drawing.Point(497, 145);
            this.buttonNachtragen.Name = "buttonNachtragen";
            this.buttonNachtragen.Size = new System.Drawing.Size(208, 54);
            this.buttonNachtragen.TabIndex = 0;
            this.buttonNachtragen.Text = "Zeiten nachtragen";
            this.buttonNachtragen.UseVisualStyleBackColor = true;
            this.buttonNachtragen.Click += new System.EventHandler(this.fillInTime);
            // 
            // buttonAuswertung
            // 
            this.buttonAuswertung.Font = new System.Drawing.Font("Papyrus", 12F);
            this.buttonAuswertung.Location = new System.Drawing.Point(267, 146);
            this.buttonAuswertung.Name = "buttonAuswertung";
            this.buttonAuswertung.Size = new System.Drawing.Size(208, 53);
            this.buttonAuswertung.TabIndex = 1;
            this.buttonAuswertung.Text = "Auswertung";
            this.buttonAuswertung.UseVisualStyleBackColor = true;
            this.buttonAuswertung.Click += new System.EventHandler(this.showWeeklyEvaluation);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(41, 146);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(208, 53);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startOrStopSession);
            // 
            // labelZeitAnzeige
            // 
            this.labelZeitAnzeige.AutoSize = true;
            this.labelZeitAnzeige.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeitAnzeige.Location = new System.Drawing.Point(298, 54);
            this.labelZeitAnzeige.Name = "labelZeitAnzeige";
            this.labelZeitAnzeige.Size = new System.Drawing.Size(159, 52);
            this.labelZeitAnzeige.TabIndex = 4;
            this.labelZeitAnzeige.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.updateDisplaiedTime);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.labelZeitAnzeige);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAuswertung);
            this.Controls.Add(this.buttonNachtragen);
            this.Name = "MainForm";
            this.Text = "LegendTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveBeforeClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNachtragen;
        private System.Windows.Forms.Button buttonAuswertung;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelZeitAnzeige;
        private System.Windows.Forms.Timer timer1;
    }
}

