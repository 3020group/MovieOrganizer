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
            this.components = new System.ComponentModel.Container();
            this.scatterPlot1 = new MovieOrganizer.ScatterPlot(this.components);
            this.SuspendLayout();
            // 
            // scatterPlot1
            // 
            this.scatterPlot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scatterPlot1.Location = new System.Drawing.Point(12, 12);
            this.scatterPlot1.Name = "scatterPlot1";
            this.scatterPlot1.Size = new System.Drawing.Size(723, 468);
            this.scatterPlot1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 492);
            this.Controls.Add(this.scatterPlot1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TestForm";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private ScatterPlot scatterPlot1;
    }
}