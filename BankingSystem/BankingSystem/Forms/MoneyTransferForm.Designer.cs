namespace BankingSystem.Forms
{
    partial class MoneyTransferForm
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
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.textBoxToAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(219, 94);
            this.comboBoxFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(276, 28);
            this.comboBoxFrom.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write-off account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "To account:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(219, 21);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(132, 26);
            this.textBoxSum.TabIndex = 5;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(219, 165);
            this.comboBoxTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(276, 28);
            this.comboBoxTo.TabIndex = 6;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTransfer.Location = new System.Drawing.Point(252, 226);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(100, 28);
            this.buttonTransfer.TabIndex = 7;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // textBoxToAccount
            // 
            this.textBoxToAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToAccount.Location = new System.Drawing.Point(219, 165);
            this.textBoxToAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxToAccount.Name = "textBoxToAccount";
            this.textBoxToAccount.Size = new System.Drawing.Size(276, 26);
            this.textBoxToAccount.TabIndex = 8;
            this.textBoxToAccount.Visible = false;
            // 
            // MoneyTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 281);
            this.Controls.Add(this.textBoxToAccount);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MoneyTransferForm";
            this.Text = "MoneyTransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTransfer;
        internal System.Windows.Forms.ComboBox comboBoxFrom;
        internal System.Windows.Forms.TextBox textBoxSum;
        internal System.Windows.Forms.TextBox textBoxToAccount;
        internal System.Windows.Forms.ComboBox comboBoxTo;
    }
}