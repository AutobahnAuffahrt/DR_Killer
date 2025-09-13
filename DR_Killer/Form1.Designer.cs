namespace DR_Killer
{
    partial class DR_Killer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DR_Killer));
            this.inputButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.killButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(956, 25);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(36, 23);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "...";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 9);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(107, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Ausgangsverzeichnis";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(15, 25);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(935, 20);
            this.inputTextBox.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 51);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Suchen";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(15, 80);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(977, 323);
            this.outputBox.TabIndex = 5;
            // 
            // killButton
            // 
            this.killButton.Location = new System.Drawing.Point(917, 409);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(75, 23);
            this.killButton.TabIndex = 6;
            this.killButton.Text = "löschen";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // DR_Killer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 447);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DR_Killer";
            this.Text = "DR_Killer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button killButton;
    }
}

