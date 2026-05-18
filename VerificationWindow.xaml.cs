using System.Collections.Generic;
using System.Windows;
using ContractClaimSystem.Models;

namespace ContractClaimSystem
{
    public partial class VerificationWindow : Window
    {
        private List<Claim> claims;

        public VerificationWindow(List<Claim> submittedClaims)
        {
            InitializeComponent();
            claims = submittedClaims;

            ClaimsGrid.ItemsSource = claims;
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            if (ClaimsGrid.SelectedItem is Claim selected)
            {
                selected.Status = ClaimStatus.Approved;
                ClaimsGrid.Items.Refresh();
                MessageBox.Show($"Claim #{selected.Id} approved.", "Approval", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            if (ClaimsGrid.SelectedItem is Claim selected)
            {
                selected.Status = ClaimStatus.Rejected;
                ClaimsGrid.Items.Refresh();
                MessageBox.Show($"Claim #{selected.Id} rejected.", "Rejection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
