namespace Prog2
{
    partial class AddressForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.okButtonAdd = new System.Windows.Forms.Button();
            this.cancelButtonAdd = new System.Windows.Forms.Button();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameValidating);
            this.nameTextBox.Validated += new System.EventHandler(this.nameValidated);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(94, 54);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(170, 20);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressValidating);
            this.addressTextBox.Validated += new System.EventHandler(this.addressValidated);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(94, 122);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(170, 20);
            this.cityTextBox.TabIndex = 8;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityValidating);
            this.cityTextBox.Validated += new System.EventHandler(this.cityValidated);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(94, 212);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(170, 20);
            this.zipTextBox.TabIndex = 9;
            this.zipTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipValidating);
            this.zipTextBox.Validated += new System.EventHandler(this.zipValidated);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(94, 167);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(170, 21);
            this.stateComboBox.TabIndex = 10;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateValidating);
            this.stateComboBox.Validated += new System.EventHandler(this.stateValidated);
            // 
            // okButtonAdd
            // 
            this.okButtonAdd.Location = new System.Drawing.Point(26, 283);
            this.okButtonAdd.Name = "okButtonAdd";
            this.okButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.okButtonAdd.TabIndex = 11;
            this.okButtonAdd.Text = "OK";
            this.okButtonAdd.UseVisualStyleBackColor = true;
            this.okButtonAdd.Click += new System.EventHandler(this.okButtonAdd_Click);
            // 
            // cancelButtonAdd
            // 
            this.cancelButtonAdd.Location = new System.Drawing.Point(189, 283);
            this.cancelButtonAdd.Name = "cancelButtonAdd";
            this.cancelButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonAdd.TabIndex = 12;
            this.cancelButtonAdd.Text = "Cancel";
            this.cancelButtonAdd.UseVisualStyleBackColor = true;
          
            this.cancelButtonAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButtonAddDown);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(94, 80);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(170, 20);
            this.address2TextBox.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 334);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.cancelButtonAdd);
            this.Controls.Add(this.okButtonAdd);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button okButtonAdd;
        private System.Windows.Forms.Button cancelButtonAdd;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}