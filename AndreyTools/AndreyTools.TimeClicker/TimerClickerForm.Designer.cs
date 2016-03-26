namespace AndreyTools.TimeClicker
{
    partial class TimerClickerForm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerPanel = new System.Windows.Forms.Panel();
            this.secNumeric = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.hrsNumeric = new System.Windows.Forms.NumericUpDown();
            this.minNumeric = new System.Windows.Forms.NumericUpDown();
            this.time = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.repeaterLabel = new System.Windows.Forms.Label();
            this.timeRepeater = new System.Windows.Forms.NumericUpDown();
            this.timerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRepeater)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerPanel
            // 
            this.timerPanel.Controls.Add(this.repeaterLabel);
            this.timerPanel.Controls.Add(this.timeRepeater);
            this.timerPanel.Controls.Add(this.secondsLabel);
            this.timerPanel.Controls.Add(this.minutesLabel);
            this.timerPanel.Controls.Add(this.hoursLabel);
            this.timerPanel.Controls.Add(this.secNumeric);
            this.timerPanel.Controls.Add(this.addButton);
            this.timerPanel.Controls.Add(this.startButton);
            this.timerPanel.Controls.Add(this.hrsNumeric);
            this.timerPanel.Controls.Add(this.minNumeric);
            this.timerPanel.Controls.Add(this.time);
            this.timerPanel.Location = new System.Drawing.Point(12, 12);
            this.timerPanel.Name = "timerPanel";
            this.timerPanel.Size = new System.Drawing.Size(188, 240);
            this.timerPanel.TabIndex = 4;
            // 
            // secNumeric
            // 
            this.secNumeric.Location = new System.Drawing.Point(6, 56);
            this.secNumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secNumeric.Name = "secNumeric";
            this.secNumeric.Size = new System.Drawing.Size(120, 20);
            this.secNumeric.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 81);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 34);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 151);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 48);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // hrsNumeric
            // 
            this.hrsNumeric.Location = new System.Drawing.Point(6, 4);
            this.hrsNumeric.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hrsNumeric.Name = "hrsNumeric";
            this.hrsNumeric.Size = new System.Drawing.Size(120, 20);
            this.hrsNumeric.TabIndex = 7;
            // 
            // minNumeric
            // 
            this.minNumeric.Location = new System.Drawing.Point(6, 30);
            this.minNumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(120, 20);
            this.minNumeric.TabIndex = 6;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(6, 118);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 30);
            this.time.TabIndex = 5;
            this.time.Text = "00:00:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.secondsLabel.Location = new System.Drawing.Point(132, 58);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(49, 13);
            this.secondsLabel.TabIndex = 15;
            this.secondsLabel.Text = "Seconds";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minutesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minutesLabel.Location = new System.Drawing.Point(132, 32);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(44, 13);
            this.minutesLabel.TabIndex = 14;
            this.minutesLabel.Text = "Minutes";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hoursLabel.Location = new System.Drawing.Point(132, 6);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(35, 13);
            this.hoursLabel.TabIndex = 13;
            this.hoursLabel.Text = "Hours";
            // 
            // repeaterLabel
            // 
            this.repeaterLabel.AutoSize = true;
            this.repeaterLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.repeaterLabel.Location = new System.Drawing.Point(58, 215);
            this.repeaterLabel.Name = "repeaterLabel";
            this.repeaterLabel.Size = new System.Drawing.Size(68, 13);
            this.repeaterLabel.TabIndex = 17;
            this.repeaterLabel.Text = "Time Repeat";
            // 
            // timeRepeater
            // 
            this.timeRepeater.Location = new System.Drawing.Point(6, 213);
            this.timeRepeater.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.timeRepeater.Name = "timeRepeater";
            this.timeRepeater.Size = new System.Drawing.Size(38, 20);
            this.timeRepeater.TabIndex = 16;
            this.timeRepeater.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TimerClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 281);
            this.Controls.Add(this.timerPanel);
            this.Name = "TimerClickerForm";
            this.Text = "TimerClickerForm";
            this.timerPanel.ResumeLayout(false);
            this.timerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRepeater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel timerPanel;
        private System.Windows.Forms.NumericUpDown secNumeric;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.NumericUpDown minNumeric;
        private System.Windows.Forms.NumericUpDown hrsNumeric;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.NumericUpDown timeRepeater;
        private System.Windows.Forms.Label repeaterLabel;
    }
}

