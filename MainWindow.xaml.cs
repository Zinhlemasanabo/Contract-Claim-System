using System;
using System.Collections.Generic;
using System.Windows;
using ContractClaimSystem.Models;
using Microsoft.Win32;

namespace ContractClaimSystem
{
    public partial class MainWindow : Window
    {
        private List<Claim> claims = new List<Claim>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double hours = double.Parse(txtHours.Text);
                double rate = double.Parse(txtRate.Text);
                string notes = txtNotes.Text;

                Claim newClaim = new Claim
                {
                    Id = claims.Count + 1,
                    LecturerName = txtName.Text,
                    HoursWorked = hours,
                    HourlyRate = rate,
                    Notes = notes,
                    FilePath = txtFilePath.Text,
                    Status = ClaimStatus.Pending
                };

                claims.Add(newClaim);
                MessageBox.Show("Claim submitted successfully!");
                ClearForm();
                LecturerClaimsGrid.ItemsSource = null;
                LecturerClaimsGrid.ItemsSource = claims; // refresh DataGrid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnUpload_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PDF files (*.pdf)|*.pdf|Word files (*.docx)|*.docx|Excel files (*.xlsx)|*.xlsx";

            if (dlg.ShowDialog() == true)
            {
                txtFilePath.Text = dlg.FileName;
                MessageBox.Show("File uploaded successfully!");
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtHours.Text = "";
            txtRate.Text = "";
            txtNotes.Text = "";
            txtFilePath.Text = "";
        }

        private void BtnOpenVerification_Click(object sender, RoutedEventArgs e)
        {
            VerificationWindow verificationWindow = new VerificationWindow(claims);
            verificationWindow.Show();
        }

        // Placeholder text behavior for WPF
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.TextBox tb && tb.Foreground == System.Windows.Media.Brushes.Gray)
            {
                tb.Text = "";
                tb.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Foreground = System.Windows.Media.Brushes.Gray;

                switch (tb.Name)
                {
                    case "txtName":
                        tb.Text = "Enter Lecturer Name";
                        break;
                    case "txtHours":
                        tb.Text = "Enter Hours Worked";
                        break;
                    case "txtRate":
                        tb.Text = "Enter Hourly Rate";
                        break;
                    case "txtNotes":
                        tb.Text = "Enter Additional Notes";
                        break;
                }
            }
        }
    }
}
