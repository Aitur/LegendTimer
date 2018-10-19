using System.ComponentModel;
using System.Windows.Forms;

namespace LegendTimer
{
    partial class AddTimeManually
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
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Font = new System.Drawing.Font("Papyrus", 12F);
            this.textBoxSeconds.Location = new System.Drawing.Point(34, 139);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(100, 39);
            this.textBoxSeconds.TabIndex = 0;
            this.textBoxSeconds.Text = "Seconds";
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Font = new System.Drawing.Font("Papyrus", 12F);
            this.textBoxMinutes.Location = new System.Drawing.Point(163, 139);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(100, 39);
            this.textBoxMinutes.TabIndex = 1;
            this.textBoxMinutes.Text = "Minutes";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Papyrus", 12F);
            this.textBoxHours.Location = new System.Drawing.Point(296, 139);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(100, 39);
            this.textBoxHours.TabIndex = 2;
            this.textBoxHours.Text = "Hours";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Papyrus", 12F);
            this.button1.Location = new System.Drawing.Point(511, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bestätigen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Papyrus", 12F);
            this.dateTimePicker.Location = new System.Drawing.Point(34, 43);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(362, 39);
            this.dateTimePicker.TabIndex = 4;
            // 
            // ZeitNachtragenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxSeconds);
            this.Name = "ZeitNachtragenForm";
            this.Text = "Zeiten nachtragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSeconds;
        private TextBox textBoxMinutes;
        private TextBox textBoxHours;
        private Button button1;
        private DateTimePicker dateTimePicker;
    }
}