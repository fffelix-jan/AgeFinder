
namespace AgeFinder
{
    partial class ResultForm
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
            this.ScamProgressBar = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.RandomTextLabel = new System.Windows.Forms.Label();
            this.FakeLoadTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ScamProgressBar
            // 
            this.ScamProgressBar.Location = new System.Drawing.Point(12, 172);
            this.ScamProgressBar.Name = "ScamProgressBar";
            this.ScamProgressBar.Size = new System.Drawing.Size(776, 96);
            this.ScamProgressBar.TabIndex = 0;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Courier New", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 47);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(248, 40);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Gu3ss1ng...";
            // 
            // RandomTextLabel
            // 
            this.RandomTextLabel.AutoSize = true;
            this.RandomTextLabel.Font = new System.Drawing.Font("Courier New", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomTextLabel.Location = new System.Drawing.Point(12, 296);
            this.RandomTextLabel.Name = "RandomTextLabel";
            this.RandomTextLabel.Size = new System.Drawing.Size(143, 40);
            this.RandomTextLabel.TabIndex = 2;
            this.RandomTextLabel.Text = "r@nd0m";
            // 
            // FakeLoadTimer
            // 
            this.FakeLoadTimer.Interval = 1000;
            this.FakeLoadTimer.Tick += new System.EventHandler(this.FakeLoadTimer_Tick);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomTextLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ScamProgressBar);
            this.Name = "ResultForm";
            this.Text = "Y0ur R3su1t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ScamProgressBar;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label RandomTextLabel;
        private System.Windows.Forms.Timer FakeLoadTimer;
    }
}