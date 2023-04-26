namespace WindowsFormsApplication1
{
    partial class PanelTwo
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
            this.inputTwoLabel = new System.Windows.Forms.Label();
            this.inputTwoField = new System.Windows.Forms.TextBox();
            this.inputOneLabel = new System.Windows.Forms.Label();
            this.inputOneField = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTwoLabel
            // 
            this.inputTwoLabel.AutoSize = true;
            this.inputTwoLabel.Location = new System.Drawing.Point(40, 206);
            this.inputTwoLabel.Name = "inputTwoLabel";
            this.inputTwoLabel.Size = new System.Drawing.Size(55, 13);
            this.inputTwoLabel.TabIndex = 8;
            this.inputTwoLabel.Text = "Input Two";
            // 
            // inputTwoField
            // 
            this.inputTwoField.Location = new System.Drawing.Point(43, 222);
            this.inputTwoField.Name = "inputTwoField";
            this.inputTwoField.Size = new System.Drawing.Size(100, 20);
            this.inputTwoField.TabIndex = 6;
            this.inputTwoField.TextChanged += new System.EventHandler(this.inputTwoField_TextChanged);
            // 
            // inputOneLabel
            // 
            this.inputOneLabel.AutoSize = true;
            this.inputOneLabel.Location = new System.Drawing.Point(40, 136);
            this.inputOneLabel.Name = "inputOneLabel";
            this.inputOneLabel.Size = new System.Drawing.Size(54, 13);
            this.inputOneLabel.TabIndex = 9;
            this.inputOneLabel.Text = "Input One";
            // 
            // inputOneField
            // 
            this.inputOneField.Location = new System.Drawing.Point(43, 152);
            this.inputOneField.Name = "inputOneField";
            this.inputOneField.Size = new System.Drawing.Size(100, 20);
            this.inputOneField.TabIndex = 7;
            this.inputOneField.TextChanged += new System.EventHandler(this.inputOneField_TextChanged);
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = true;
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(78, 68);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(129, 29);
            this.panelTitle.TabIndex = 5;
            this.panelTitle.Text = "Panel Two";
            // 
            // PanelTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.inputTwoLabel);
            this.Controls.Add(this.inputTwoField);
            this.Controls.Add(this.inputOneLabel);
            this.Controls.Add(this.inputOneField);
            this.Controls.Add(this.panelTitle);
            this.Name = "PanelTwo";
            this.Size = new System.Drawing.Size(316, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputTwoLabel;
        private System.Windows.Forms.TextBox inputTwoField;

        public System.Windows.Forms.TextBox InputTwoField
        {
            get { return inputTwoField; }
            set { inputTwoField = value; }
        }
        private System.Windows.Forms.Label inputOneLabel;
        private System.Windows.Forms.TextBox inputOneField;

        public System.Windows.Forms.TextBox InputOneField
        {
            get { return inputOneField; }
            set { inputOneField = value; }
        }
        private System.Windows.Forms.Label panelTitle;

    }
}
