namespace Bank_system_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBranchBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addLoanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showLoanInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loanStatuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.dBToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.dBToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Admin";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.fileToolStripMenuItem.Text = "User";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem1,
            this.addEmployeeToolStripMenuItem1});
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.addCustomerToolStripMenuItem.Text = "SignUP";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem1
            // 
            this.addCustomerToolStripMenuItem1.Name = "addCustomerToolStripMenuItem1";
            this.addCustomerToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.addCustomerToolStripMenuItem1.Text = "Add Customer";
            this.addCustomerToolStripMenuItem1.Click += new System.EventHandler(this.addCustomerToolStripMenuItem1_Click);
            // 
            // addEmployeeToolStripMenuItem1
            // 
            this.addEmployeeToolStripMenuItem1.Name = "addEmployeeToolStripMenuItem1";
            this.addEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.addEmployeeToolStripMenuItem1.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem1_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomerToolStripMenuItem1});
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.updateCustomerToolStripMenuItem.Text = "Update ";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem1
            // 
            this.updateCustomerToolStripMenuItem1.Name = "updateCustomerToolStripMenuItem1";
            this.updateCustomerToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.updateCustomerToolStripMenuItem1.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem1.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem1_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBankToolStripMenuItem,
            this.addBranchBankToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // addBankToolStripMenuItem
            // 
            this.addBankToolStripMenuItem.Name = "addBankToolStripMenuItem";
            this.addBankToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.addBankToolStripMenuItem.Text = "Add Bank";
            this.addBankToolStripMenuItem.Click += new System.EventHandler(this.addBankToolStripMenuItem_Click_1);
            // 
            // addBranchBankToolStripMenuItem
            // 
            this.addBranchBankToolStripMenuItem.Name = "addBranchBankToolStripMenuItem";
            this.addBranchBankToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.addBranchBankToolStripMenuItem.Text = "Add Branch Bank";
            this.addBranchBankToolStripMenuItem.Click += new System.EventHandler(this.addBranchBankToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionsToolStripMenuItem1,
            this.accountingToolStripMenuItem1,
            this.allEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // transactionsToolStripMenuItem1
            // 
            this.transactionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLoanToolStripMenuItem1,
            this.showLoanInfoToolStripMenuItem1,
            this.loanStatuesToolStripMenuItem});
            this.transactionsToolStripMenuItem1.Name = "transactionsToolStripMenuItem1";
            this.transactionsToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.transactionsToolStripMenuItem1.Text = "Transactions";
            // 
            // addLoanToolStripMenuItem1
            // 
            this.addLoanToolStripMenuItem1.Name = "addLoanToolStripMenuItem1";
            this.addLoanToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.addLoanToolStripMenuItem1.Text = "Add Loan";
            this.addLoanToolStripMenuItem1.Click += new System.EventHandler(this.addLoanToolStripMenuItem1_Click);
            // 
            // showLoanInfoToolStripMenuItem1
            // 
            this.showLoanInfoToolStripMenuItem1.Name = "showLoanInfoToolStripMenuItem1";
            this.showLoanInfoToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.showLoanInfoToolStripMenuItem1.Text = "Show Loan Info";
            this.showLoanInfoToolStripMenuItem1.Click += new System.EventHandler(this.showLoanInfoToolStripMenuItem1_Click);
            // 
            // loanStatuesToolStripMenuItem
            // 
            this.loanStatuesToolStripMenuItem.Name = "loanStatuesToolStripMenuItem";
            this.loanStatuesToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.loanStatuesToolStripMenuItem.Text = "Loan Status";
            this.loanStatuesToolStripMenuItem.Click += new System.EventHandler(this.loanStatuesToolStripMenuItem_Click);
            // 
            // accountingToolStripMenuItem1
            // 
            this.accountingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.searchAccountToolStripMenuItem});
            this.accountingToolStripMenuItem1.Name = "accountingToolStripMenuItem1";
            this.accountingToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.accountingToolStripMenuItem1.Text = "Accounting";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addAccountToolStripMenuItem.Text = "Add Account ";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // searchAccountToolStripMenuItem
            // 
            this.searchAccountToolStripMenuItem.Name = "searchAccountToolStripMenuItem";
            this.searchAccountToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.searchAccountToolStripMenuItem.Text = "Search Account";
            this.searchAccountToolStripMenuItem.Click += new System.EventHandler(this.searchAccountToolStripMenuItem_Click);
            // 
            // allEmployeeToolStripMenuItem
            // 
            this.allEmployeeToolStripMenuItem.Name = "allEmployeeToolStripMenuItem";
            this.allEmployeeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.allEmployeeToolStripMenuItem.Text = "All Employee";
            this.allEmployeeToolStripMenuItem.Click += new System.EventHandler(this.allEmployeeToolStripMenuItem_Click);
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(14, 25);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // dBToolStripMenuItem1
            // 
            this.dBToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.dToolStripMenuItem,
            this.eToolStripMenuItem,
            this.fToolStripMenuItem});
            this.dBToolStripMenuItem1.Name = "dBToolStripMenuItem1";
            this.dBToolStripMenuItem1.Size = new System.Drawing.Size(44, 25);
            this.dBToolStripMenuItem1.Text = "DB";
            this.dBToolStripMenuItem1.Click += new System.EventHandler(this.dBToolStripMenuItem1_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aToolStripMenuItem.Text = "a.";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bToolStripMenuItem.Text = "b.";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cToolStripMenuItem.Text = "c.";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dToolStripMenuItem.Text = "d.";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eToolStripMenuItem.Text = "e.";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fToolStripMenuItem.Text = "f.";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_system_3.Properties.Resources.download_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(213, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(980, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBranchBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addLoanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showLoanInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loanStatuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEmployeeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
    }
}

