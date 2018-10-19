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
            this.components = new System.ComponentModel.Container();
            this.btnSupplement = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSupplement
            // 
            this.btnSupplement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplement.Location = new System.Drawing.Point(746, 227);
            this.btnSupplement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupplement.Name = "btnSupplement";
            this.btnSupplement.Size = new System.Drawing.Size(312, 84);
            this.btnSupplement.TabIndex = 0;
            this.btnSupplement.Text = "Zeiten nachtragen";
            this.btnSupplement.UseVisualStyleBackColor = true;
            this.btnSupplement.Click += new System.EventHandler(this.FillInTime);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluate.Location = new System.Drawing.Point(400, 228);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(312, 83);
            this.btnEvaluate.TabIndex = 1;
            this.btnEvaluate.Text = "Auswertung";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.ShowWeeklyEvaluation);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(62, 228);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(312, 83);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartOrStopSession);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(447, 84);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(229, 60);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.UpdateDisplayedTime);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 417);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnSupplement);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "LegendTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveBeforeClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSupplement;
        private Button btnEvaluate;
        private Button btnStart;
        private Label labelTime;
        private Timer timer1;
    }
}

