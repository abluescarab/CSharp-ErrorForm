using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ErrorFormWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ErrorForm : Window {
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
            get { return linkSend.IsEnabled; }
            set {
                linkSend.IsEnabled = value;

                if(value) {
                    linkSend.Visibility = System.Windows.Visibility.Visible;
                }
                else {
                    linkSend.Visibility = System.Windows.Visibility.Hidden;
                }
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

        private void linkLabel_MouseDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Process.Start(WebsiteLink);
        }

        private void linkLabel_MouseEnter(object sender, MouseEventArgs e) {
            this.Cursor = Cursors.Hand;
            linkSend.Foreground = SystemColors.HighlightBrush;
        }

        private void linkLabel_MouseLeave(object sender, MouseEventArgs e) {
            this.Cursor = Cursors.Arrow;
            linkSend.Foreground = SystemColors.HotTrackBrush;
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e) {
            Clipboard.SetText(txtError.Text);
        }

        private void btnOK_Click(object sender, RoutedEventArgs e) {
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
