using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LegendTimer
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new Container();
            this.buttonNachtragen = new Button();
            this.buttonAuswertung = new Button();
            this.buttonStart = new Button();
            this.labelZeitAnzeige = new Label();
            this.timer1 = new Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonNachtragen
            // 
            this.buttonNachtragen.Font = new Font("Papyrus", 12F);
            this.buttonNachtragen.Location = new Point(497, 145);
            this.buttonNachtragen.Name = "buttonNachtragen";
            this.buttonNachtragen.Size = new Size(208, 54);
            this.buttonNachtragen.TabIndex = 0;
            this.buttonNachtragen.Text = "Zeiten nachtragen";
            this.buttonNachtragen.UseVisualStyleBackColor = true;
            this.buttonNachtragen.Click += new EventHandler(this.FillInTime);
            // 
            // buttonAuswertung
            // 
            this.buttonAuswertung.Font = new Font("Papyrus", 12F);
            this.buttonAuswertung.Location = new Point(267, 146);
            this.buttonAuswertung.Name = "buttonAuswertung";
            this.buttonAuswertung.Size = new Size(208, 53);
            this.buttonAuswertung.TabIndex = 1;
            this.buttonAuswertung.Text = "Auswertung";
            this.buttonAuswertung.UseVisualStyleBackColor = true;
            this.buttonAuswertung.Click += new EventHandler(this.ShowWeeklyEvaluation);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new Point(41, 146);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new Size(208, 53);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new EventHandler(this.StartOrStopSession);
            // 
            // labelZeitAnzeige
            // 
            this.labelZeitAnzeige.AutoSize = true;
            this.labelZeitAnzeige.Font = new Font("Papyrus", 19.8F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            this.labelZeitAnzeige.Location = new Point(298, 54);
            this.labelZeitAnzeige.Name = "labelZeitAnzeige";
            this.labelZeitAnzeige.Size = new Size(159, 52);
            this.labelZeitAnzeige.TabIndex = 4;
            this.labelZeitAnzeige.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new EventHandler(this.UpdateDisplaiedTime);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 267);
            this.Controls.Add(this.labelZeitAnzeige);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAuswertung);
            this.Controls.Add(this.buttonNachtragen);
            this.Name = "MainForm";
            this.Text = "LegendTimer";
            this.FormClosing += new FormClosingEventHandler(this.SaveBeforeClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNachtragen;
        private Button buttonAuswertung;
        private Button buttonStart;
        private Label labelZeitAnzeige;
        private Timer timer1;
    }
}

