namespace Assignment5 {
    partial class ApplicationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelCustomerNumber = new System.Windows.Forms.Label();
            this.textBoxCustomerNumber = new System.Windows.Forms.TextBox();
            this.checkBoxOnMailingList = new System.Windows.Forms.CheckBox();
            this.buttonAddUpdate = new System.Windows.Forms.Button();
            this.labelPurchases = new System.Windows.Forms.Label();
            this.textBoxPurchases = new System.Windows.Forms.TextBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Customer Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(166, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 53);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(13, 70);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(169, 20);
            this.textBoxAddress.TabIndex = 3;
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(10, 98);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(98, 13);
            this.labelTelephone.TabIndex = 4;
            this.labelTelephone.Text = "Telephone Number";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(13, 114);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(169, 20);
            this.textBoxTelephone.TabIndex = 5;
            // 
            // labelCustomerNumber
            // 
            this.labelCustomerNumber.AutoSize = true;
            this.labelCustomerNumber.Location = new System.Drawing.Point(10, 142);
            this.labelCustomerNumber.Name = "labelCustomerNumber";
            this.labelCustomerNumber.Size = new System.Drawing.Size(91, 13);
            this.labelCustomerNumber.TabIndex = 6;
            this.labelCustomerNumber.Text = "Customer Number";
            // 
            // textBoxCustomerNumber
            // 
            this.textBoxCustomerNumber.Location = new System.Drawing.Point(13, 158);
            this.textBoxCustomerNumber.Name = "textBoxCustomerNumber";
            this.textBoxCustomerNumber.Size = new System.Drawing.Size(169, 20);
            this.textBoxCustomerNumber.TabIndex = 7;
            // 
            // checkBoxOnMailingList
            // 
            this.checkBoxOnMailingList.AutoSize = true;
            this.checkBoxOnMailingList.Location = new System.Drawing.Point(12, 231);
            this.checkBoxOnMailingList.Name = "checkBoxOnMailingList";
            this.checkBoxOnMailingList.Size = new System.Drawing.Size(118, 17);
            this.checkBoxOnMailingList.TabIndex = 9;
            this.checkBoxOnMailingList.Text = "Add to Mailing List?";
            this.checkBoxOnMailingList.UseVisualStyleBackColor = true;
            // 
            // buttonAddUpdate
            // 
            this.buttonAddUpdate.Location = new System.Drawing.Point(13, 254);
            this.buttonAddUpdate.Name = "buttonAddUpdate";
            this.buttonAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUpdate.TabIndex = 10;
            this.buttonAddUpdate.Text = "Add/Update";
            this.buttonAddUpdate.UseVisualStyleBackColor = true;
            this.buttonAddUpdate.Click += new System.EventHandler(this.buttonAddUpdate_Click);
            // 
            // labelPurchases
            // 
            this.labelPurchases.AutoSize = true;
            this.labelPurchases.Location = new System.Drawing.Point(13, 185);
            this.labelPurchases.Name = "labelPurchases";
            this.labelPurchases.Size = new System.Drawing.Size(84, 13);
            this.labelPurchases.TabIndex = 11;
            this.labelPurchases.Text = "Total Purchases";
            // 
            // textBoxPurchases
            // 
            this.textBoxPurchases.Location = new System.Drawing.Point(13, 202);
            this.textBoxPurchases.Name = "textBoxPurchases";
            this.textBoxPurchases.Size = new System.Drawing.Size(169, 20);
            this.textBoxPurchases.TabIndex = 12;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(208, 30);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(256, 199);
            this.listBoxOutput.TabIndex = 13;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.textBoxPurchases);
            this.Controls.Add(this.labelPurchases);
            this.Controls.Add(this.buttonAddUpdate);
            this.Controls.Add(this.checkBoxOnMailingList);
            this.Controls.Add(this.textBoxCustomerNumber);
            this.Controls.Add(this.labelCustomerNumber);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "ApplicationForm";
            this.Text = "Customer Application Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label labelCustomerNumber;
        private System.Windows.Forms.TextBox textBoxCustomerNumber;
        private System.Windows.Forms.CheckBox checkBoxOnMailingList;
        private System.Windows.Forms.Button buttonAddUpdate;
        private System.Windows.Forms.Label labelPurchases;
        private System.Windows.Forms.TextBox textBoxPurchases;
        private System.Windows.Forms.ListBox listBoxOutput;
    }
}

