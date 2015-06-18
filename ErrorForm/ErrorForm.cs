using System;
using System.Windows.Forms;

namespace ErrorForm {
    public partial class ErrorForm : Form {
        private string website;

        public string WebsiteLink {
            get { return website; }
            set { website = value; }
        }

        public string ErrorLabelText {
            get { return lblError.Text; }
            set { lblError.Text = value; }
        }

        public string SendLinkText {
            get { return linkSend.Text; }
            set { linkSend.Text = value; }
        }

        public bool SendLinkEnabled {
            get { return linkSend.Enabled; }
            set {
                linkSend.Enabled = linkSend.Visible = value;
            }
        }

        public ErrorForm() {
            InitializeComponent();
        }

        public void ShowDialog(Exception ex) {
            txtError.Text = ex.Message;
            txtError.Focus();

            if(string.IsNullOrEmpty(WebsiteLink)) {
                SendLinkEnabled = false;
            }
            else {
                SendLinkEnabled = true;
            }

            this.ShowDialog();
        }

        private void frmError_Load(object sender, EventArgs e) {
            this.BringToFront();
        }

        private void linkSend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(WebsiteLink);
        }

        private void btnCopy_Click(object sender, EventArgs e) {
            Clipboard.SetText(txtError.Text);
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Hide();
        }

        public void Reset() {
            WebsiteLink = "";
            ErrorLabelText = "The following error has occurred:";
            SendLinkText = "Send me this error.";
            SendLinkEnabled = false;
        }
    }
}
