namespace WB_Bank
{
    partial class log_sign
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
            this.sign = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(264, 140);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(98, 40);
            this.sign.TabIndex = 11;
            this.sign.Text = "SignUp";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(66, 140);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(98, 40);
            this.log.TabIndex = 10;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(141, 71);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(221, 22);
            this.pass.TabIndex = 9;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(141, 28);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(221, 22);
            this.id.TabIndex = 8;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Register If You Haven\'t";
            // 
            // log_sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.log);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "log_sign";
            this.Text = "log/sign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

