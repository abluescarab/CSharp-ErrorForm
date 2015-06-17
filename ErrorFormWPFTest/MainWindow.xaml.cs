using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ErrorFormWPF;

namespace ErrorFormWPFTest {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        ErrorForm errorForm = new ErrorForm();

        public MainWindow() {
            InitializeComponent();
            errorForm.WebsiteLink = "http://www.example.com";
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            try {
                throw new NullReferenceException();
            }
            catch(Exception ex) {
                errorForm.ShowDialog(ex);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            try {
                throw new Exception("This is a custom exception.");
            }
            catch(Exception ex) {
                errorForm.ShowDialog(ex);
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            errorForm.Close();
        }
    }
}
