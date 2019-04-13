namespace Prog2
{
    partial class Letter_Form
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
            this.orgAddressLabel = new System.Windows.Forms.Label();
            this.destAddressLabel = new System.Windows.Forms.Label();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.orgAddressBox = new System.Windows.Forms.ComboBox();
            this.destAddressBox = new System.Windows.Forms.ComboBox();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // orgAddressLabel
            // 
            this.orgAddressLabel.AutoSize = true;
            this.orgAddressLabel.Location = new System.Drawing.Point(36, 26);
            this.orgAddressLabel.Name = "orgAddressLabel";
            this.orgAddressLabel.Size = new System.Drawing.Size(73, 13);
            this.orgAddressLabel.TabIndex = 0;
            this.orgAddressLabel.Text = "Orgin Address";
            // 
            // destAddressLabel
            // 
            this.destAddressLabel.AutoSize = true;
            this.destAddressLabel.Location = new System.Drawing.Point(36, 61);
            this.destAddressLabel.Name = "destAddressLabel";
            this.destAddressLabel.Size = new System.Drawing.Size(101, 13);
            this.destAddressLabel.TabIndex = 1;
            this.destAddressLabel.Text = "Destination Address";
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(36, 102);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(56, 13);
            this.fixedCostLabel.TabIndex = 2;
            this.fixedCostLabel.Text = "Fixed Cost";
            // 
            // orgAddressBox
            // 
            this.orgAddressBox.FormattingEnabled = true;
            this.orgAddressBox.Location = new System.Drawing.Point(181, 26);
            this.orgAddressBox.Name = "orgAddressBox";
            this.orgAddressBox.Size = new System.Drawing.Size(159, 21);
            this.orgAddressBox.TabIndex = 3;
            this.orgAddressBox.Validating += new System.ComponentModel.CancelEventHandler(this.orgAddressBox_Validating);
            this.orgAddressBox.Validated += new System.EventHandler(this.orgAddressBox_Validated);
            // 
            // destAddressBox
            // 
            this.destAddressBox.FormattingEnabled = true;
            this.destAddressBox.Location = new System.Drawing.Point(181, 61);
            this.destAddressBox.Name = "destAddressBox";
            this.destAddressBox.Size = new System.Drawing.Size(159, 21);
            this.destAddressBox.TabIndex = 4;
            this.destAddressBox.Validating += new System.ComponentModel.CancelEventHandler(this.destAddressBox_Validating);
            this.destAddressBox.Validated += new System.EventHandler(this.destAddressBox_Validated);
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.Location = new System.Drawing.Point(181, 102);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(159, 20);
            this.fixedCostTextBox.TabIndex = 5;
            this.fixedCostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCost_Validating);
            this.fixedCostTextBox.Validated += new System.EventHandler(this.fixedCost_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(65, 157);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(211, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButtonDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Letter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 197);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.destAddressBox);
            this.Controls.Add(this.orgAddressBox);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.destAddressLabel);
            this.Controls.Add(this.orgAddressLabel);
            this.Name = "Letter_Form";
            this.Text = "Letter_Form";
            this.Load += new System.EventHandler(this.Letter_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orgAddressLabel;
        private System.Windows.Forms.Label destAddressLabel;
        private System.Windows.Forms.Label fixedCostLabel;
        private System.Windows.Forms.ComboBox orgAddressBox;
        private System.Windows.Forms.ComboBox destAddressBox;
        private System.Windows.Forms.TextBox fixedCostTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}