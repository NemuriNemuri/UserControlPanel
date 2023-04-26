namespace WindowsFormsApplication1
{
    partial class UCPActivityForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTwoButton = new System.Windows.Forms.Button();
            this.panelOneButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputTwoLabel = new System.Windows.Forms.Label();
            this.inputTwoField = new System.Windows.Forms.TextBox();
            this.inputOneLabel = new System.Windows.Forms.Label();
            this.inputOneField = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.panelTwo = new WindowsFormsApplication1.PanelTwo();
            this.panelOne = new WindowsFormsApplication1.PanelOne();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTwoButton);
            this.panel1.Controls.Add(this.panelOneButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 362);
            this.panel1.TabIndex = 0;
            // 
            // panelTwoButton
            // 
            this.panelTwoButton.Location = new System.Drawing.Point(61, 206);
            this.panelTwoButton.Name = "panelTwoButton";
            this.panelTwoButton.Size = new System.Drawing.Size(85, 36);
            this.panelTwoButton.TabIndex = 2;
            this.panelTwoButton.Text = "Panel Two";
            this.panelTwoButton.UseVisualStyleBackColor = true;
            this.panelTwoButton.Click += new System.EventHandler(this.panelTwoButton_Click);
            // 
            // panelOneButton
            // 
            this.panelOneButton.Location = new System.Drawing.Point(61, 147);
            this.panelOneButton.Name = "panelOneButton";
            this.panelOneButton.Size = new System.Drawing.Size(85, 36);
            this.panelOneButton.TabIndex = 2;
            this.panelOneButton.Text = "Panel One";
            this.panelOneButton.UseVisualStyleBackColor = true;
            this.panelOneButton.Click += new System.EventHandler(this.panelOneButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(61, 86);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(85, 36);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inputTwoLabel);
            this.panel2.Controls.Add(this.inputTwoField);
            this.panel2.Controls.Add(this.inputOneLabel);
            this.panel2.Controls.Add(this.inputOneField);
            this.panel2.Location = new System.Drawing.Point(649, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 362);
            this.panel2.TabIndex = 1;
            // 
            // inputTwoLabel
            // 
            this.inputTwoLabel.AutoSize = true;
            this.inputTwoLabel.Location = new System.Drawing.Point(33, 159);
            this.inputTwoLabel.Name = "inputTwoLabel";
            this.inputTwoLabel.Size = new System.Drawing.Size(55, 13);
            this.inputTwoLabel.TabIndex = 1;
            this.inputTwoLabel.Text = "Input Two";
            // 
            // inputTwoField
            // 
            this.inputTwoField.BackColor = System.Drawing.SystemColors.Window;
            this.inputTwoField.Location = new System.Drawing.Point(36, 175);
            this.inputTwoField.Name = "inputTwoField";
            this.inputTwoField.ReadOnly = true;
            this.inputTwoField.Size = new System.Drawing.Size(100, 20);
            this.inputTwoField.TabIndex = 0;
            // 
            // inputOneLabel
            // 
            this.inputOneLabel.AutoSize = true;
            this.inputOneLabel.Location = new System.Drawing.Point(33, 98);
            this.inputOneLabel.Name = "inputOneLabel";
            this.inputOneLabel.Size = new System.Drawing.Size(54, 13);
            this.inputOneLabel.TabIndex = 1;
            this.inputOneLabel.Text = "Input One";
            // 
            // inputOneField
            // 
            this.inputOneField.BackColor = System.Drawing.SystemColors.Window;
            this.inputOneField.Location = new System.Drawing.Point(36, 114);
            this.inputOneField.Name = "inputOneField";
            this.inputOneField.ReadOnly = true;
            this.inputOneField.Size = new System.Drawing.Size(100, 20);
            this.inputOneField.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Salmon;
            this.title.Location = new System.Drawing.Point(263, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(371, 29);
            this.title.TabIndex = 2;
            this.title.Text = "User Control Panel Application";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(302, 112);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(294, 72);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Welcome to the Application!\r\nPlease Select a panel to continue...\r\nYour inputs wi" +
    "ll be shown on the right panel.\r\nThank you!";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelTwo
            // 
            this.panelTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTwo.Location = new System.Drawing.Point(281, 64);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(338, 310);
            this.panelTwo.TabIndex = 4;
            // 
            // panelOne
            // 
            this.panelOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelOne.Location = new System.Drawing.Point(281, 64);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(338, 310);
            this.panelOne.TabIndex = 3;
            // 
            // UCPActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.HatsuneMikuBg;
            this.ClientSize = new System.Drawing.Size(895, 386);
            this.Controls.Add(this.panelTwo);
            this.Controls.Add(this.panelOne);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPActivityForm";
            this.Text = "User Control Panel Activity Form";
            this.Load += new System.EventHandler(this.UCPActivityForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button panelTwoButton;
        private System.Windows.Forms.Button panelOneButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label inputTwoLabel;
        private System.Windows.Forms.TextBox inputTwoField;
        private System.Windows.Forms.Label inputOneLabel;
        private System.Windows.Forms.TextBox inputOneField;
        private System.Windows.Forms.Label title;
        private PanelOne panelOne;
        private PanelTwo panelTwo;
        private System.Windows.Forms.Label textLabel;
    }
}

