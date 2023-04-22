namespace PE17
{
    partial class parameterForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LowNumberLabel = new System.Windows.Forms.Label();
            this.HighNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(156, 232);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // LowNumberLabel
            // 
            this.LowNumberLabel.AutoSize = true;
            this.LowNumberLabel.Location = new System.Drawing.Point(35, 108);
            this.LowNumberLabel.Name = "LowNumberLabel";
            this.LowNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.LowNumberLabel.TabIndex = 3;
            this.LowNumberLabel.Text = "Low Number:";
            // 
            // HighNumberLabel
            // 
            this.HighNumberLabel.AutoSize = true;
            this.HighNumberLabel.Location = new System.Drawing.Point(33, 162);
            this.HighNumberLabel.Name = "HighNumberLabel";
            this.HighNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.HighNumberLabel.TabIndex = 4;
            this.HighNumberLabel.Text = "High Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Range of Value to Guess";
            // 
            // parameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighNumberLabel);
            this.Controls.Add(this.LowNumberLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startButton);
            this.Name = "parameterForm";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LowNumberLabel;
        private System.Windows.Forms.Label HighNumberLabel;
        private System.Windows.Forms.Label label1;
    }
}

