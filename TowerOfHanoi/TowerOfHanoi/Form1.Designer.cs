namespace TowerOfHanoi
{
    partial class mainWindow
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
            this.suspendButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(294, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(72, 28);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // suspendButton
            // 
            this.suspendButton.Enabled = false;
            this.suspendButton.Location = new System.Drawing.Point(450, 12);
            this.suspendButton.Name = "suspendButton";
            this.suspendButton.Size = new System.Drawing.Size(72, 28);
            this.suspendButton.TabIndex = 3;
            this.suspendButton.Text = "SUSPEND";
            this.suspendButton.UseVisualStyleBackColor = true;
            this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Enabled = false;
            this.resumeButton.Location = new System.Drawing.Point(372, 12);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(72, 28);
            this.resumeButton.TabIndex = 4;
            this.resumeButton.Text = "RESUME";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.Enabled = false;
            this.abortButton.Location = new System.Drawing.Point(528, 12);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(72, 28);
            this.abortButton.TabIndex = 5;
            this.abortButton.Text = "ABORT";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.suspendButton);
            this.Controls.Add(this.startButton);
            this.Name = "mainWindow";
            this.Text = "Towers of Hanoi";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button suspendButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button abortButton;
    }
}

