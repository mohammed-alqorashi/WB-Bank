namespace WB_Bank
{
    partial class Transaction
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
            this.pastPaymentEvents = new System.Windows.Forms.Label();
            this.transations = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pastPaymentEvents
            // 
            this.pastPaymentEvents.AutoSize = true;
            this.pastPaymentEvents.Location = new System.Drawing.Point(228, 9);
            this.pastPaymentEvents.Name = "pastPaymentEvents";
            this.pastPaymentEvents.Size = new System.Drawing.Size(134, 16);
            this.pastPaymentEvents.TabIndex = 0;
            this.pastPaymentEvents.Text = "Past Payment Events";
            // 
            // transations
            // 
            this.transations.Location = new System.Drawing.Point(66, 62);
            this.transations.Multiline = true;
            this.transations.Name = "transations";
            this.transations.Size = new System.Drawing.Size(466, 129);
            this.transations.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(92, 230);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(104, 31);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(245, 230);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(104, 31);
            this.Deposit.TabIndex = 3;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(394, 230);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(104, 31);
            this.Withdraw.TabIndex = 4;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 340);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.transations);
            this.Controls.Add(this.pastPaymentEvents);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pastPaymentEvents;
        private System.Windows.Forms.TextBox transations;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Withdraw;
    }
}