namespace Yatzhee3
{
    partial class ScoreboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScoreboardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreboardLabel
            // 
            this.ScoreboardLabel.Location = new System.Drawing.Point(3, 0);
            this.ScoreboardLabel.Name = "ScoreboardLabel";
            this.ScoreboardLabel.Size = new System.Drawing.Size(169, 48);
            this.ScoreboardLabel.TabIndex = 0;
            this.ScoreboardLabel.Text = "Totale Worpen:";
            this.ScoreboardLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ScoreboardLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "ScoreboardView";
            this.Size = new System.Drawing.Size(175, 47);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ScoreboardLabel;
    }
}
