namespace BankingSystem.Forms
{
    partial class UserForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePersonalData = new System.Windows.Forms.TabPage();
            this.labelPassNum = new System.Windows.Forms.Label();
            this.labelPassSer = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDepositsAndAccounts = new System.Windows.Forms.TabPage();
            this.buttonViewDepositInfo = new System.Windows.Forms.Button();
            this.buttonCloseDeposit = new System.Windows.Forms.Button();
            this.buttonOpenDeposit = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonCloseAccount = new System.Windows.Forms.Button();
            this.buttonOpenAccount = new System.Windows.Forms.Button();
            this.dataGridViewDeposits = new System.Windows.Forms.DataGridView();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageMoneyTransfer = new System.Windows.Forms.TabPage();
            this.dataGridViewAccountsWithoutDeposits = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTransferToAnotherUser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPagePersonalData.SuspendLayout();
            this.tabPageDepositsAndAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.tabPageMoneyTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountsWithoutDeposits)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePersonalData);
            this.tabControl.Controls.Add(this.tabPageDepositsAndAccounts);
            this.tabControl.Controls.Add(this.tabPageMoneyTransfer);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(965, 498);
            this.tabControl.TabIndex = 1;
            // 
            // tabPagePersonalData
            // 
            this.tabPagePersonalData.Controls.Add(this.labelPassNum);
            this.tabPagePersonalData.Controls.Add(this.labelPassSer);
            this.tabPagePersonalData.Controls.Add(this.labelPatronymic);
            this.tabPagePersonalData.Controls.Add(this.labelName);
            this.tabPagePersonalData.Controls.Add(this.labelSurname);
            this.tabPagePersonalData.Controls.Add(this.label5);
            this.tabPagePersonalData.Controls.Add(this.label4);
            this.tabPagePersonalData.Controls.Add(this.label3);
            this.tabPagePersonalData.Controls.Add(this.label2);
            this.tabPagePersonalData.Controls.Add(this.label1);
            this.tabPagePersonalData.Location = new System.Drawing.Point(4, 25);
            this.tabPagePersonalData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePersonalData.Name = "tabPagePersonalData";
            this.tabPagePersonalData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePersonalData.Size = new System.Drawing.Size(957, 469);
            this.tabPagePersonalData.TabIndex = 0;
            this.tabPagePersonalData.Text = "Personal data";
            this.tabPagePersonalData.UseVisualStyleBackColor = true;
            // 
            // labelPassNum
            // 
            this.labelPassNum.AutoSize = true;
            this.labelPassNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassNum.Location = new System.Drawing.Point(305, 246);
            this.labelPassNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassNum.Name = "labelPassNum";
            this.labelPassNum.Size = new System.Drawing.Size(29, 20);
            this.labelPassNum.TabIndex = 9;
            this.labelPassNum.Text = "no";
            // 
            // labelPassSer
            // 
            this.labelPassSer.AutoSize = true;
            this.labelPassSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassSer.Location = new System.Drawing.Point(305, 196);
            this.labelPassSer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassSer.Name = "labelPassSer";
            this.labelPassSer.Size = new System.Drawing.Size(29, 20);
            this.labelPassSer.TabIndex = 8;
            this.labelPassSer.Text = "no";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(305, 142);
            this.labelPatronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(29, 20);
            this.labelPatronymic.TabIndex = 7;
            this.labelPatronymic.Text = "no";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(305, 87);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "no";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(305, 32);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(29, 20);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Passport number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passport series:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patronymic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname:";
            // 
            // tabPageDepositsAndAccounts
            // 
            this.tabPageDepositsAndAccounts.Controls.Add(this.buttonViewDepositInfo);
            this.tabPageDepositsAndAccounts.Controls.Add(this.buttonCloseDeposit);
            this.tabPageDepositsAndAccounts.Controls.Add(this.buttonOpenDeposit);
            this.tabPageDepositsAndAccounts.Controls.Add(this.buttonTransfer);
            this.tabPageDepositsAndAccounts.Controls.Add(this.buttonCloseAccount);
            this.tabPageDepositsAndAccounts.Controls.Add(this.buttonOpenAccount);
            this.tabPageDepositsAndAccounts.Controls.Add(this.dataGridViewDeposits);
            this.tabPageDepositsAndAccounts.Controls.Add(this.dataGridViewAccounts);
            this.tabPageDepositsAndAccounts.Controls.Add(this.label7);
            this.tabPageDepositsAndAccounts.Controls.Add(this.label6);
            this.tabPageDepositsAndAccounts.Location = new System.Drawing.Point(4, 25);
            this.tabPageDepositsAndAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDepositsAndAccounts.Name = "tabPageDepositsAndAccounts";
            this.tabPageDepositsAndAccounts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDepositsAndAccounts.Size = new System.Drawing.Size(957, 469);
            this.tabPageDepositsAndAccounts.TabIndex = 1;
            this.tabPageDepositsAndAccounts.Text = "Deposits & accounts";
            this.tabPageDepositsAndAccounts.UseVisualStyleBackColor = true;
            // 
            // buttonViewDepositInfo
            // 
            this.buttonViewDepositInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewDepositInfo.Location = new System.Drawing.Point(708, 279);
            this.buttonViewDepositInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonViewDepositInfo.Name = "buttonViewDepositInfo";
            this.buttonViewDepositInfo.Size = new System.Drawing.Size(236, 28);
            this.buttonViewDepositInfo.TabIndex = 10;
            this.buttonViewDepositInfo.Text = "View info about the deposit";
            this.buttonViewDepositInfo.UseVisualStyleBackColor = true;
            this.buttonViewDepositInfo.Click += new System.EventHandler(this.buttonViewDepositInfo_Click);
            // 
            // buttonCloseDeposit
            // 
            this.buttonCloseDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseDeposit.Location = new System.Drawing.Point(759, 425);
            this.buttonCloseDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCloseDeposit.Name = "buttonCloseDeposit";
            this.buttonCloseDeposit.Size = new System.Drawing.Size(148, 28);
            this.buttonCloseDeposit.TabIndex = 9;
            this.buttonCloseDeposit.Text = "Close deposit";
            this.buttonCloseDeposit.UseVisualStyleBackColor = true;
            this.buttonCloseDeposit.Click += new System.EventHandler(this.buttonCloseDeposit_Click);
            // 
            // buttonOpenDeposit
            // 
            this.buttonOpenDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDeposit.Location = new System.Drawing.Point(759, 354);
            this.buttonOpenDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenDeposit.Name = "buttonOpenDeposit";
            this.buttonOpenDeposit.Size = new System.Drawing.Size(148, 28);
            this.buttonOpenDeposit.TabIndex = 8;
            this.buttonOpenDeposit.Text = "Open deposit";
            this.buttonOpenDeposit.UseVisualStyleBackColor = true;
            this.buttonOpenDeposit.Click += new System.EventHandler(this.buttonOpenDeposit_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTransfer.Location = new System.Drawing.Point(708, 202);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(236, 28);
            this.buttonTransfer.TabIndex = 7;
            this.buttonTransfer.Text = "Transfer between accounts";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonCloseAccount
            // 
            this.buttonCloseAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseAccount.Location = new System.Drawing.Point(759, 132);
            this.buttonCloseAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCloseAccount.Name = "buttonCloseAccount";
            this.buttonCloseAccount.Size = new System.Drawing.Size(148, 28);
            this.buttonCloseAccount.TabIndex = 6;
            this.buttonCloseAccount.Text = "Close account";
            this.buttonCloseAccount.UseVisualStyleBackColor = true;
            this.buttonCloseAccount.Click += new System.EventHandler(this.buttonCloseAccount_Click);
            // 
            // buttonOpenAccount
            // 
            this.buttonOpenAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAccount.Location = new System.Drawing.Point(759, 57);
            this.buttonOpenAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenAccount.Name = "buttonOpenAccount";
            this.buttonOpenAccount.Size = new System.Drawing.Size(148, 28);
            this.buttonOpenAccount.TabIndex = 5;
            this.buttonOpenAccount.Text = "Open account";
            this.buttonOpenAccount.UseVisualStyleBackColor = true;
            this.buttonOpenAccount.Click += new System.EventHandler(this.buttonOpenAccount_Click);
            // 
            // dataGridViewDeposits
            // 
            this.dataGridViewDeposits.AllowUserToAddRows = false;
            this.dataGridViewDeposits.AllowUserToDeleteRows = false;
            this.dataGridViewDeposits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeposits.Location = new System.Drawing.Point(11, 279);
            this.dataGridViewDeposits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDeposits.MultiSelect = false;
            this.dataGridViewDeposits.Name = "dataGridViewDeposits";
            this.dataGridViewDeposits.ReadOnly = true;
            this.dataGridViewDeposits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeposits.Size = new System.Drawing.Size(676, 174);
            this.dataGridViewDeposits.TabIndex = 4;
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AllowUserToAddRows = false;
            this.dataGridViewAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(8, 57);
            this.dataGridViewAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAccounts.MultiSelect = false;
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.ReadOnly = true;
            this.dataGridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(676, 174);
            this.dataGridViewAccounts.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(59, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Deposits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(59, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Accounts:";
            // 
            // tabPageMoneyTransfer
            // 
            this.tabPageMoneyTransfer.Controls.Add(this.dataGridViewAccountsWithoutDeposits);
            this.tabPageMoneyTransfer.Controls.Add(this.label8);
            this.tabPageMoneyTransfer.Controls.Add(this.buttonTransferToAnotherUser);
            this.tabPageMoneyTransfer.Location = new System.Drawing.Point(4, 25);
            this.tabPageMoneyTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMoneyTransfer.Name = "tabPageMoneyTransfer";
            this.tabPageMoneyTransfer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMoneyTransfer.Size = new System.Drawing.Size(957, 469);
            this.tabPageMoneyTransfer.TabIndex = 2;
            this.tabPageMoneyTransfer.Text = "Money transfer";
            this.tabPageMoneyTransfer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAccountsWithoutDeposits
            // 
            this.dataGridViewAccountsWithoutDeposits.AllowUserToAddRows = false;
            this.dataGridViewAccountsWithoutDeposits.AllowUserToDeleteRows = false;
            this.dataGridViewAccountsWithoutDeposits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccountsWithoutDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccountsWithoutDeposits.Location = new System.Drawing.Point(8, 57);
            this.dataGridViewAccountsWithoutDeposits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAccountsWithoutDeposits.MultiSelect = false;
            this.dataGridViewAccountsWithoutDeposits.Name = "dataGridViewAccountsWithoutDeposits";
            this.dataGridViewAccountsWithoutDeposits.ReadOnly = true;
            this.dataGridViewAccountsWithoutDeposits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccountsWithoutDeposits.Size = new System.Drawing.Size(676, 174);
            this.dataGridViewAccountsWithoutDeposits.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(44, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Accounts:";
            // 
            // buttonTransferToAnotherUser
            // 
            this.buttonTransferToAnotherUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTransferToAnotherUser.Location = new System.Drawing.Point(341, 278);
            this.buttonTransferToAnotherUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTransferToAnotherUser.Name = "buttonTransferToAnotherUser";
            this.buttonTransferToAnotherUser.Size = new System.Drawing.Size(299, 28);
            this.buttonTransferToAnotherUser.TabIndex = 8;
            this.buttonTransferToAnotherUser.Text = "Transfer to another user\'s account";
            this.buttonTransferToAnotherUser.UseVisualStyleBackColor = true;
            this.buttonTransferToAnotherUser.Click += new System.EventHandler(this.buttonTransferToAnotherUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(957, 469);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 498);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPagePersonalData.ResumeLayout(false);
            this.tabPagePersonalData.PerformLayout();
            this.tabPageDepositsAndAccounts.ResumeLayout(false);
            this.tabPageDepositsAndAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.tabPageMoneyTransfer.ResumeLayout(false);
            this.tabPageMoneyTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountsWithoutDeposits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePersonalData;
        private System.Windows.Forms.Label labelPassNum;
        private System.Windows.Forms.Label labelPassSer;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageDepositsAndAccounts;
        private System.Windows.Forms.DataGridView dataGridViewDeposits;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonViewDepositInfo;
        private System.Windows.Forms.Button buttonCloseDeposit;
        private System.Windows.Forms.Button buttonOpenDeposit;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonCloseAccount;
        private System.Windows.Forms.Button buttonOpenAccount;
        private System.Windows.Forms.TabPage tabPageMoneyTransfer;
        private System.Windows.Forms.DataGridView dataGridViewAccountsWithoutDeposits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTransferToAnotherUser;
        private System.Windows.Forms.TabPage tabPage2;
    }
}