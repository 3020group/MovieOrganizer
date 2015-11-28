namespace MovieOrganizer
{
    partial class TestForm
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
            this.TestBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TestBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(12, 12);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(194, 229);
            this.TestBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TestBox.TabIndex = 0;
            this.TestBox.TabStop = false;
            this.TestBox.Click += new System.EventHandler(this.TestBox_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.TestBox);
            this.Name = "TestForm";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.TestBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TestBox;
    }
}