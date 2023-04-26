namespace WindowsFormsApplication1
{
    partial class PanelOne
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Label();
            this.inputOneLabel = new System.Windows.Forms.Label();
            this.inputOneField = new System.Windows.Forms.TextBox();
            this.inputTwoField = new System.Windows.Forms.TextBox();
            this.inputTwoLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = true;
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(77, 46);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(127, 29);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Text = "Panel One";
            // 
            // inputOneLabel
            // 
            this.inputOneLabel.AutoSize = true;
            this.inputOneLabel.Location = new System.Drawing.Point(39, 114);
            this.inputOneLabel.Name = "inputOneLabel";
            this.inputOneLabel.Size = new System.Drawing.Size(54, 13);
            this.inputOneLabel.TabIndex = 3;
            this.inputOneLabel.Text = "Input One";
            // 
            // inputOneField
            // 
            this.inputOneField.Location = new System.Drawing.Point(42, 130);
            this.inputOneField.Name = "inputOneField";
            this.inputOneField.Size = new System.Drawing.Size(100, 20);
            this.inputOneField.TabIndex = 2;
            // 
            // inputTwoField
            // 
            this.inputTwoField.Location = new System.Drawing.Point(42, 200);
            this.inputTwoField.Name = "inputTwoField";
            this.inputTwoField.Size = new System.Drawing.Size(100, 20);
            this.inputTwoField.TabIndex = 2;
            // 
            // inputTwoLabel
            // 
            this.inputTwoLabel.AutoSize = true;
            this.inputTwoLabel.Location = new System.Drawing.Point(39, 184);
            this.inputTwoLabel.Name = "inputTwoLabel";
            this.inputTwoLabel.Size = new System.Drawing.Size(55, 13);
            this.inputTwoLabel.TabIndex = 3;
            this.inputTwoLabel.Text = "Input Two";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(53, 261);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // PanelOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.inputTwoLabel);
            this.Controls.Add(this.inputTwoField);
            this.Controls.Add(this.inputOneLabel);
            this.Controls.Add(this.inputOneField);
            this.Controls.Add(this.panelTitle);
            this.Name = "PanelOne";
            this.Size = new System.Drawing.Size(338, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label panelTitle;
        private System.Windows.Forms.Label inputOneLabel;
        private System.Windows.Forms.TextBox inputOneField;

        public System.Windows.Forms.TextBox InputOneField
        {
            get { return inputOneField; }
            set { inputOneField = value; }
        }
        private System.Windows.Forms.TextBox inputTwoField;

        public System.Windows.Forms.TextBox InputTwoField
        {
            get { return inputTwoField; }
            set { inputTwoField = value; }
        }
        private System.Windows.Forms.Label inputTwoLabel;
        private System.Windows.Forms.Button submitButton;
    }
}
