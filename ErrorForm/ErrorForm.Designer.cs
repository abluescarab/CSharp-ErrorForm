namespace ErrorForm {
    partial class ErrorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.lblError = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.linkSend = new System.Windows.Forms.LinkLabel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(162, 13);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "The following error has occurred:";
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtError.Location = new System.Drawing.Point(12, 25);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(346, 58);
            this.txtError.TabIndex = 1;
            this.txtError.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(251, 89);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 27);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // linkSend
            // 
            this.linkSend.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkSend.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkSend.Location = new System.Drawing.Point(12, 91);
            this.linkSend.Name = "linkSend";
            this.linkSend.Size = new System.Drawing.Size(120, 23);
            this.linkSend.TabIndex = 2;
            this.linkSend.TabStop = true;
            this.linkSend.Text = "Send me this error.";
            this.linkSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkSend.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkSend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSend_LinkClicked);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(138, 89);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(107, 27);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy Error";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 128);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.linkSend);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmError";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.frmError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.LinkLabel linkSend;
        private System.Windows.Forms.Button btnCopy;
    }
}