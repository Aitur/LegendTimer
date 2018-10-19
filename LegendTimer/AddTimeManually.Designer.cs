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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSeconds.Location = new System.Drawing.Point(51, 217);
            this.textBoxSeconds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(148, 44);
            this.textBoxSeconds.TabIndex = 0;
            this.textBoxSeconds.Text = "Seconds";
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinutes.Location = new System.Drawing.Point(244, 217);
            this.textBoxMinutes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(148, 44);
            this.textBoxMinutes.TabIndex = 1;
            this.textBoxMinutes.Text = "Minutes";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHours.Location = new System.Drawing.Point(444, 217);
            this.textBoxHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(148, 44);
            this.textBoxHours.TabIndex = 2;
            this.textBoxHours.Text = "Hours";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(766, 203);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(202, 84);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Bestätigen";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(51, 67);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(541, 44);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // AddTimeManually
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 327);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxSeconds);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTimeManually";
            this.Text = "Zeiten nachtragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSeconds;
        private TextBox textBoxMinutes;
        private TextBox textBoxHours;
        private Button btnConfirm;
        private DateTimePicker dateTimePicker;
    }
}