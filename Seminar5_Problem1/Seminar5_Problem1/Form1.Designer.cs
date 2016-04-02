namespace Seminar5_Problem1
{
    partial class Form1
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
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.grossLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.netLabel = new System.Windows.Forms.Label();
            this.basicLabel = new System.Windows.Forms.Label();
            this.otLabel = new System.Windows.Forms.Label();
            this.hoursListBox = new System.Windows.Forms.ListBox();
            this.payListBox = new System.Windows.Forms.ListBox();
            this.netTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.grossTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.basicTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(9, 7);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(115, 13);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Weekly Hours Worked";
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Location = new System.Drawing.Point(136, 7);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(96, 13);
            this.hourlyRateLabel.TabIndex = 1;
            this.hourlyRateLabel.Text = "Hourly Rate of Pay";
            // 
            // grossLabel
            // 
            this.grossLabel.AutoSize = true;
            this.grossLabel.Location = new System.Drawing.Point(75, 185);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(57, 13);
            this.grossLabel.TabIndex = 2;
            this.grossLabel.Text = "Gross pay:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(54, 211);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(78, 13);
            this.taxLabel.TabIndex = 3;
            this.taxLabel.Text = "Tax Decucted:";
            // 
            // netLabel
            // 
            this.netLabel.AutoSize = true;
            this.netLabel.Location = new System.Drawing.Point(85, 237);
            this.netLabel.Name = "netLabel";
            this.netLabel.Size = new System.Drawing.Size(47, 13);
            this.netLabel.TabIndex = 4;
            this.netLabel.Text = "Net pay:";
            // 
            // basicLabel
            // 
            this.basicLabel.AutoSize = true;
            this.basicLabel.Location = new System.Drawing.Point(77, 133);
            this.basicLabel.Name = "basicLabel";
            this.basicLabel.Size = new System.Drawing.Size(56, 13);
            this.basicLabel.TabIndex = 5;
            this.basicLabel.Text = "Basic pay:";
            // 
            // otLabel
            // 
            this.otLabel.AutoSize = true;
            this.otLabel.Location = new System.Drawing.Point(60, 159);
            this.otLabel.Name = "otLabel";
            this.otLabel.Size = new System.Drawing.Size(72, 13);
            this.otLabel.TabIndex = 6;
            this.otLabel.Text = "Overtime pay:";
            // 
            // hoursListBox
            // 
            this.hoursListBox.FormattingEnabled = true;
            this.hoursListBox.Location = new System.Drawing.Point(12, 25);
            this.hoursListBox.Name = "hoursListBox";
            this.hoursListBox.Size = new System.Drawing.Size(120, 95);
            this.hoursListBox.TabIndex = 7;
            // 
            // payListBox
            // 
            this.payListBox.FormattingEnabled = true;
            this.payListBox.Location = new System.Drawing.Point(139, 25);
            this.payListBox.Name = "payListBox";
            this.payListBox.Size = new System.Drawing.Size(120, 95);
            this.payListBox.TabIndex = 8;
            // 
            // netTextBox
            // 
            this.netTextBox.Location = new System.Drawing.Point(139, 234);
            this.netTextBox.Name = "netTextBox";
            this.netTextBox.Size = new System.Drawing.Size(100, 20);
            this.netTextBox.TabIndex = 9;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(139, 208);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxTextBox.TabIndex = 10;
            // 
            // grossTextBox
            // 
            this.grossTextBox.Location = new System.Drawing.Point(139, 182);
            this.grossTextBox.Name = "grossTextBox";
            this.grossTextBox.Size = new System.Drawing.Size(100, 20);
            this.grossTextBox.TabIndex = 11;
            // 
            // otTextBox
            // 
            this.otTextBox.Location = new System.Drawing.Point(139, 156);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(100, 20);
            this.otTextBox.TabIndex = 12;
            // 
            // basicTextBox
            // 
            this.basicTextBox.Location = new System.Drawing.Point(139, 130);
            this.basicTextBox.Name = "basicTextBox";
            this.basicTextBox.Size = new System.Drawing.Size(100, 20);
            this.basicTextBox.TabIndex = 13;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(15, 286);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 41);
            this.calcButton.TabIndex = 14;
            this.calcButton.Text = "Calculate Pay";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(109, 286);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 41);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(204, 286);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 41);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 350);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.basicTextBox);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(this.grossTextBox);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(this.netTextBox);
            this.Controls.Add(this.payListBox);
            this.Controls.Add(this.hoursListBox);
            this.Controls.Add(this.otLabel);
            this.Controls.Add(this.basicLabel);
            this.Controls.Add(this.netLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.grossLabel);
            this.Controls.Add(this.hourlyRateLabel);
            this.Controls.Add(this.hoursLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label netLabel;
        private System.Windows.Forms.Label basicLabel;
        private System.Windows.Forms.Label otLabel;
        private System.Windows.Forms.ListBox hoursListBox;
        private System.Windows.Forms.ListBox payListBox;
        private System.Windows.Forms.TextBox netTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox grossTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.TextBox basicTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

