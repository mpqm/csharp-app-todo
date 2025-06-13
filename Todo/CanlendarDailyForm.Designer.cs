namespace todo
{
    partial class CalendarDailyForm
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
            this.buttonCalendarDailyFormClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalendarDailyFormClose
            // 
            this.buttonCalendarDailyFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalendarDailyFormClose.BackColor = System.Drawing.Color.Gray;
            this.buttonCalendarDailyFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalendarDailyFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendarDailyFormClose.ForeColor = System.Drawing.Color.White;
            this.buttonCalendarDailyFormClose.Location = new System.Drawing.Point(1192, 12);
            this.buttonCalendarDailyFormClose.Name = "buttonCalendarDailyFormClose";
            this.buttonCalendarDailyFormClose.Size = new System.Drawing.Size(70, 30);
            this.buttonCalendarDailyFormClose.TabIndex = 1;
            this.buttonCalendarDailyFormClose.Text = "X";
            this.buttonCalendarDailyFormClose.UseVisualStyleBackColor = false;
            this.buttonCalendarDailyFormClose.Click += new System.EventHandler(this.buttonCalendarDailyFormClose_Click);
            // 
            // CalendarDailyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1274, 569);
            this.Controls.Add(this.buttonCalendarDailyFormClose);
            this.Name = "CalendarDailyForm";
            this.Text = "CalendarDailyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalendarDailyFormClose;
    }
}