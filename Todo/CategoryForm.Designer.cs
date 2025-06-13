namespace Todo
{
    partial class CategoryForm
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
            this.buttonCategoryFormClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCategoryFormClose
            // 
            this.buttonCategoryFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCategoryFormClose.BackColor = System.Drawing.Color.Gray;
            this.buttonCategoryFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCategoryFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategoryFormClose.ForeColor = System.Drawing.Color.White;
            this.buttonCategoryFormClose.Location = new System.Drawing.Point(1171, 12);
            this.buttonCategoryFormClose.Name = "buttonCategoryFormClose";
            this.buttonCategoryFormClose.Size = new System.Drawing.Size(91, 31);
            this.buttonCategoryFormClose.TabIndex = 0;
            this.buttonCategoryFormClose.Text = "X";
            this.buttonCategoryFormClose.UseVisualStyleBackColor = false;
            this.buttonCategoryFormClose.Click += new System.EventHandler(this.buttonCategoryFormClose_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1274, 569);
            this.Controls.Add(this.buttonCategoryFormClose);
            this.Name = "CategoryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCategoryFormClose;
    }
}