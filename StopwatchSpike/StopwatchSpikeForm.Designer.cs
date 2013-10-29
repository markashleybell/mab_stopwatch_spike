namespace StopwatchSpike
{
    partial class StopwatchSpikeForm
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
            this._totalElapsedTimeDisplay = new System.Windows.Forms.TextBox();
            this._currentElapsedTimeDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _totalElapsedTimeDisplay
            // 
            this._totalElapsedTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._totalElapsedTimeDisplay.Location = new System.Drawing.Point(41, 95);
            this._totalElapsedTimeDisplay.Name = "_totalElapsedTimeDisplay";
            this._totalElapsedTimeDisplay.Size = new System.Drawing.Size(349, 31);
            this._totalElapsedTimeDisplay.TabIndex = 0;
            // 
            // _currentElapsedTimeDisplay
            // 
            this._currentElapsedTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._currentElapsedTimeDisplay.Location = new System.Drawing.Point(41, 33);
            this._currentElapsedTimeDisplay.Name = "_currentElapsedTimeDisplay";
            this._currentElapsedTimeDisplay.Size = new System.Drawing.Size(349, 31);
            this._currentElapsedTimeDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Time";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(41, 162);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 78);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start/Stop";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Elapsed Time";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(41, 259);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(200, 78);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // StopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 364);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._currentElapsedTimeDisplay);
            this.Controls.Add(this._totalElapsedTimeDisplay);
            this.Name = "StopwatchForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _totalElapsedTimeDisplay;
        private System.Windows.Forms.TextBox _currentElapsedTimeDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
    }
}

