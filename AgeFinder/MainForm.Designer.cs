﻿
namespace AgeFinder
{
    partial class MainForm
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
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.AgeSelector = new System.Windows.Forms.NumericUpDown();
            this.GuessButton = new System.Windows.Forms.Button();
            this.ToggleModeButton = new System.Windows.Forms.Button();
            this.IDCardTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(935, 98);
            this.InstructionsLabel.TabIndex = 0;
            this.InstructionsLabel.Text = "Welcome to Age Guesser!\r\nPlease enter your age, and we will try to guess your age" +
    "...";
            // 
            // AgeSelector
            // 
            this.AgeSelector.BackColor = System.Drawing.Color.Blue;
            this.AgeSelector.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeSelector.ForeColor = System.Drawing.Color.White;
            this.AgeSelector.Location = new System.Drawing.Point(367, 127);
            this.AgeSelector.Maximum = new decimal(new int[] {
            969,
            0,
            0,
            0});
            this.AgeSelector.Name = "AgeSelector";
            this.AgeSelector.Size = new System.Drawing.Size(177, 97);
            this.AgeSelector.TabIndex = 1;
            // 
            // GuessButton
            // 
            this.GuessButton.BackColor = System.Drawing.SystemColors.Control;
            this.GuessButton.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessButton.Location = new System.Drawing.Point(283, 243);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(357, 179);
            this.GuessButton.TabIndex = 2;
            this.GuessButton.Text = "Guess!";
            this.GuessButton.UseVisualStyleBackColor = false;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // ToggleModeButton
            // 
            this.ToggleModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ToggleModeButton.Location = new System.Drawing.Point(807, 17);
            this.ToggleModeButton.Name = "ToggleModeButton";
            this.ToggleModeButton.Size = new System.Drawing.Size(132, 48);
            this.ToggleModeButton.TabIndex = 3;
            this.ToggleModeButton.Text = "使用居民身份证";
            this.ToggleModeButton.UseVisualStyleBackColor = false;
            this.ToggleModeButton.Click += new System.EventHandler(this.ToggleModeButton_Click);
            // 
            // IDCardTextBox
            // 
            this.IDCardTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.IDCardTextBox.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCardTextBox.Location = new System.Drawing.Point(21, 138);
            this.IDCardTextBox.MaxLength = 18;
            this.IDCardTextBox.Name = "IDCardTextBox";
            this.IDCardTextBox.Size = new System.Drawing.Size(918, 74);
            this.IDCardTextBox.TabIndex = 4;
            this.IDCardTextBox.Text = "请在此处输入居民身份证号...";
            this.IDCardTextBox.Enter += new System.EventHandler(this.IDCardTextBox_Enter);
            this.IDCardTextBox.Leave += new System.EventHandler(this.IDCardTextBox_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(951, 469);
            this.Controls.Add(this.AgeSelector);
            this.Controls.Add(this.IDCardTextBox);
            this.Controls.Add(this.ToggleModeButton);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.InstructionsLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Age Guesser";
            ((System.ComponentModel.ISupportInitialize)(this.AgeSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.NumericUpDown AgeSelector;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button ToggleModeButton;
        private System.Windows.Forms.TextBox IDCardTextBox;
    }
}

