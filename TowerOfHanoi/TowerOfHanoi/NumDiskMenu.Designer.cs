namespace TowerOfHanoi
{
    partial class NumDiskMenu
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
            this.numDisksTextBox = new System.Windows.Forms.TextBox();
            this.numDisksLabel = new System.Windows.Forms.Label();
            this.initializeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numDisksTextBox
            // 
            this.numDisksTextBox.Location = new System.Drawing.Point(292, 34);
            this.numDisksTextBox.Name = "numDisksTextBox";
            this.numDisksTextBox.Size = new System.Drawing.Size(33, 20);
            this.numDisksTextBox.TabIndex = 3;
            // 
            // numDisksLabel
            // 
            this.numDisksLabel.AutoSize = true;
            this.numDisksLabel.Location = new System.Drawing.Point(33, 37);
            this.numDisksLabel.Name = "numDisksLabel";
            this.numDisksLabel.Size = new System.Drawing.Size(253, 13);
            this.numDisksLabel.TabIndex = 2;
            this.numDisksLabel.Text = "Choose the number of disks you would like (up to 8):";
            // 
            // initializeButton
            // 
            this.initializeButton.Location = new System.Drawing.Point(146, 93);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Size = new System.Drawing.Size(72, 28);
            this.initializeButton.TabIndex = 5;
            this.initializeButton.Text = "INITIALIZE";
            this.initializeButton.UseVisualStyleBackColor = true;
            this.initializeButton.Click += new System.EventHandler(this.initializeButton_Click);
            // 
            // NumDiskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(370, 133);
            this.Controls.Add(this.initializeButton);
            this.Controls.Add(this.numDisksTextBox);
            this.Controls.Add(this.numDisksLabel);
            this.Name = "NumDiskMenu";
            this.Text = "Towers Of Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numDisksTextBox;
        private System.Windows.Forms.Label numDisksLabel;
        private System.Windows.Forms.Button initializeButton;
    }
}