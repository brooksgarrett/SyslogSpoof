namespace SyslogSpoof
{
    partial class fmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMaster));
            this.tbSRC = new System.Windows.Forms.TextBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.bnSend = new System.Windows.Forms.Button();
            this.bnReset = new System.Windows.Forms.Button();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbSRC
            // 
            this.tbSRC.Location = new System.Drawing.Point(13, 12);
            this.tbSRC.Name = "tbSRC";
            this.tbSRC.Size = new System.Drawing.Size(181, 20);
            this.tbSRC.TabIndex = 0;
            this.tbSRC.Text = "Source IP";
            // 
            // tbMsg
            // 
            this.tbMsg.AcceptsTab = true;
            this.tbMsg.Location = new System.Drawing.Point(13, 64);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(181, 154);
            this.tbMsg.TabIndex = 1;
            // 
            // bnSend
            // 
            this.bnSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnSend.Location = new System.Drawing.Point(12, 224);
            this.bnSend.Name = "bnSend";
            this.bnSend.Size = new System.Drawing.Size(75, 23);
            this.bnSend.TabIndex = 2;
            this.bnSend.Text = "Send";
            this.bnSend.UseVisualStyleBackColor = true;
            this.bnSend.Click += new System.EventHandler(this.bnSend_Click);
            // 
            // bnReset
            // 
            this.bnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnReset.Location = new System.Drawing.Point(119, 224);
            this.bnReset.Name = "bnReset";
            this.bnReset.Size = new System.Drawing.Size(75, 23);
            this.bnReset.TabIndex = 3;
            this.bnReset.Text = "Reset";
            this.bnReset.UseVisualStyleBackColor = true;
            this.bnReset.Click += new System.EventHandler(this.bnReset_Click);
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Items.AddRange(new object[] {
            "10.16.1.180",
            "10.16.1.181",
            "10.16.1.182",
            "10.16.1.183"});
            this.cbDestination.Location = new System.Drawing.Point(13, 37);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(180, 21);
            this.cbDestination.TabIndex = 4;
            // 
            // fmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnReset;
            this.ClientSize = new System.Drawing.Size(205, 354);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.bnReset);
            this.Controls.Add(this.bnSend);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.tbSRC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SyslogSpoof";
            this.Load += new System.EventHandler(this.fmMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSRC;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button bnSend;
        private System.Windows.Forms.Button bnReset;
        private System.Windows.Forms.ComboBox cbDestination;
    }
}

