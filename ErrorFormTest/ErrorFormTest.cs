using System;
using System.Windows.Forms;

namespace ErrorFormTest {
    public partial class ErrorFormTest : Form {
        ErrorForm.ErrorForm errorForm = new ErrorForm.ErrorForm();

        public ErrorFormTest() {
            InitializeComponent();
        }

        private void ErrorFormTest_Load(object sender, EventArgs e) {
            errorForm.WebsiteLink = "http://www.example.com/";
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                throw new NullReferenceException();
            }
            catch(Exception ex) {
                errorForm.ShowDialog(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                throw new System.Exception("This is a custom exception.");
            }
            catch(Exception ex) {
                errorForm.ShowDialog(ex);
            }
        }
    }
}
