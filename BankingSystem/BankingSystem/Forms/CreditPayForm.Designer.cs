namespace BankingSystem.Forms
{
    partial class CreditPayForm
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
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDebt = new System.Windows.Forms.Label();
            this.labelRecommmendedSum = new System.Windows.Forms.Label();
            this.labelFullyReplaySum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPay
            // 
            this.buttonPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPay.Location = new System.Drawing.Point(192, 261);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(75, 23);
            this.buttonPay.TabIndex = 8;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(167, 155);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 22);
            this.textBoxSum.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Write-off account:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sum:";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(167, 214);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(208, 24);
            this.comboBoxFrom.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Debt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Recommended sum of payment:";
            // 
            // labelDebt
            // 
            this.labelDebt.AutoSize = true;
            this.labelDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDebt.Location = new System.Drawing.Point(74, 9);
            this.labelDebt.Name = "labelDebt";
            this.labelDebt.Size = new System.Drawing.Size(41, 16);
            this.labelDebt.TabIndex = 15;
            this.labelDebt.Text = "Debt";
            // 
            // labelRecommmendedSum
            // 
            this.labelRecommmendedSum.AutoSize = true;
            this.labelRecommmendedSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecommmendedSum.Location = new System.Drawing.Point(265, 51);
            this.labelRecommmendedSum.Name = "labelRecommmendedSum";
            this.labelRecommmendedSum.Size = new System.Drawing.Size(36, 16);
            this.labelRecommmendedSum.TabIndex = 16;
            this.labelRecommmendedSum.Text = "sum";
            // 
            // labelFullyReplaySum
            // 
            this.labelFullyReplaySum.AutoSize = true;
            this.labelFullyReplaySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullyReplaySum.Location = new System.Drawing.Point(175, 92);
            this.labelFullyReplaySum.Name = "labelFullyReplaySum";
            this.labelFullyReplaySum.Size = new System.Drawing.Size(36, 16);
            this.labelFullyReplaySum.TabIndex = 18;
            this.labelFullyReplaySum.Text = "sum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sum of fully replay:";
            // 
            // CreditPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 298);
            this.Controls.Add(this.labelFullyReplaySum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelRecommmendedSum);
            this.Controls.Add(this.labelDebt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.buttonPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreditPayForm";
            this.Text = "Credit pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPay;
        internal System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label labelDebt;
        internal System.Windows.Forms.Label labelRecommmendedSum;
        internal System.Windows.Forms.Label labelFullyReplaySum;
        private System.Windows.Forms.Label label5;
    }
}