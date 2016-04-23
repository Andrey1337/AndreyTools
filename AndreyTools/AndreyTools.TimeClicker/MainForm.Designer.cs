namespace AndreyTools.TimeClicker
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xNumeric = new System.Windows.Forms.NumericUpDown();
            this.yNumeric = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.discriptionLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.yCoordinatesLabel = new System.Windows.Forms.Label();
            this.xCoordinatesLabel = new System.Windows.Forms.Label();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.secNumeric = new System.Windows.Forms.NumericUpDown();
            this.hrsNumeric = new System.Windows.Forms.NumericUpDown();
            this.minNumeric = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Controls.Add(this.timerLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xNumeric);
            this.panel1.Controls.Add(this.yNumeric);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.discriptionLabel);
            this.panel1.Controls.Add(this.pointsLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.yCoordinatesLabel);
            this.panel1.Controls.Add(this.xCoordinatesLabel);
            this.panel1.Controls.Add(this.moveDownButton);
            this.panel1.Controls.Add(this.moveUpButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Controls.Add(this.secondsLabel);
            this.panel1.Controls.Add(this.minutesLabel);
            this.panel1.Controls.Add(this.hoursLabel);
            this.panel1.Controls.Add(this.secNumeric);
            this.panel1.Controls.Add(this.hrsNumeric);
            this.panel1.Controls.Add(this.minNumeric);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 300);
            this.panel1.TabIndex = 20;
            // 
            // xNumeric
            // 
            this.xNumeric.Location = new System.Drawing.Point(407, 154);
            this.xNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.xNumeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(72, 20);
            this.xNumeric.TabIndex = 63;
            // 
            // yNumeric
            // 
            this.yNumeric.Location = new System.Drawing.Point(407, 180);
            this.yNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yNumeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(72, 20);
            this.yNumeric.TabIndex = 62;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(407, 244);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(127, 20);
            this.descriptionTextBox.TabIndex = 61;
            // 
            // discriptionLabel
            // 
            this.discriptionLabel.AutoSize = true;
            this.discriptionLabel.BackColor = System.Drawing.Color.Azure;
            this.discriptionLabel.Location = new System.Drawing.Point(425, 228);
            this.discriptionLabel.Name = "discriptionLabel";
            this.discriptionLabel.Size = new System.Drawing.Size(56, 13);
            this.discriptionLabel.TabIndex = 60;
            this.discriptionLabel.Text = "Discription";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Azure;
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pointsLabel.Location = new System.Drawing.Point(427, 137);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(36, 13);
            this.pointsLabel.TabIndex = 59;
            this.pointsLabel.Text = "Points";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Azure;
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeLabel.Location = new System.Drawing.Point(427, 15);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(33, 13);
            this.timeLabel.TabIndex = 58;
            this.timeLabel.Text = "Time:";
            // 
            // yCoordinatesLabel
            // 
            this.yCoordinatesLabel.AutoSize = true;
            this.yCoordinatesLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.yCoordinatesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yCoordinatesLabel.Location = new System.Drawing.Point(485, 182);
            this.yCoordinatesLabel.Name = "yCoordinatesLabel";
            this.yCoordinatesLabel.Size = new System.Drawing.Size(73, 13);
            this.yCoordinatesLabel.TabIndex = 57;
            this.yCoordinatesLabel.Text = "Y Coordinates";
            // 
            // xCoordinatesLabel
            // 
            this.xCoordinatesLabel.AutoSize = true;
            this.xCoordinatesLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.xCoordinatesLabel.Location = new System.Drawing.Point(485, 156);
            this.xCoordinatesLabel.Name = "xCoordinatesLabel";
            this.xCoordinatesLabel.Size = new System.Drawing.Size(73, 13);
            this.xCoordinatesLabel.TabIndex = 56;
            this.xCoordinatesLabel.Text = "X Coordinates";
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(4, 261);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(75, 29);
            this.moveDownButton.TabIndex = 55;
            this.moveDownButton.Text = "Move Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(4, 226);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(75, 29);
            this.moveUpButton.TabIndex = 54;
            this.moveUpButton.Text = "Move Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(4, 81);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 29);
            this.updateButton.TabIndex = 53;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(4, 46);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 29);
            this.removeButton.TabIndex = 52;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(4, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 29);
            this.addButton.TabIndex = 51;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(85, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(316, 277);
            this.listBox.TabIndex = 50;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.secondsLabel.Location = new System.Drawing.Point(485, 91);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(49, 13);
            this.secondsLabel.TabIndex = 49;
            this.secondsLabel.Text = "Seconds";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minutesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minutesLabel.Location = new System.Drawing.Point(485, 65);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(44, 13);
            this.minutesLabel.TabIndex = 48;
            this.minutesLabel.Text = "Minutes";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hoursLabel.Location = new System.Drawing.Point(485, 39);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(35, 13);
            this.hoursLabel.TabIndex = 47;
            this.hoursLabel.Text = "Hours";
            // 
            // secNumeric
            // 
            this.secNumeric.Location = new System.Drawing.Point(407, 89);
            this.secNumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secNumeric.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.secNumeric.Name = "secNumeric";
            this.secNumeric.Size = new System.Drawing.Size(72, 20);
            this.secNumeric.TabIndex = 46;
            // 
            // hrsNumeric
            // 
            this.hrsNumeric.Location = new System.Drawing.Point(407, 37);
            this.hrsNumeric.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hrsNumeric.Name = "hrsNumeric";
            this.hrsNumeric.Size = new System.Drawing.Size(72, 20);
            this.hrsNumeric.TabIndex = 45;
            // 
            // minNumeric
            // 
            this.minNumeric.Location = new System.Drawing.Point(407, 63);
            this.minNumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(72, 20);
            this.minNumeric.TabIndex = 44;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(197, 349);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 48);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "Start ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(197, 316);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(181, 30);
            this.timerLabel.TabIndex = 19;
            this.timerLabel.Text = "0:00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 442);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Andrey Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label desctiptionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown minNumeric;
        private System.Windows.Forms.NumericUpDown hrsNumeric;
        private System.Windows.Forms.NumericUpDown secNumeric;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Label xCoordinatesLabel;
        private System.Windows.Forms.Label yCoordinatesLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label discriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.NumericUpDown yNumeric;
        private System.Windows.Forms.NumericUpDown xNumeric;
    }
}

