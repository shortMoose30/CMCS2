using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;


namespace ContractClaimSystem
{
        public partial class SubmitClaim : Window
        {
            private string documentPath = string.Empty;

            public SubmitClaim()
            {
                InitializeComponent();
            }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();  // Close the current window
        }

        private void BtnUploadDocument_Click(object sender, RoutedEventArgs e)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "PDF Files|*.pdf|Word Documents|*.docx|Excel Files|*.xlsx";

                bool? result = dlg.ShowDialog();

                if (result == true)
                {
                    documentPath = dlg.FileName;
                    lblDocumentPath.Text = System.IO.Path.GetFileName(documentPath);

                    // Copy the file to the "uploads" folder
                    string uploadsFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "uploads");
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    string destFile = System.IO.Path.Combine(uploadsFolder, System.IO.Path.GetFileName(documentPath));
                    File.Copy(documentPath, destFile, true);
                }
            }

            private void BtnSubmit_Click(object sender, RoutedEventArgs e)
            {
                string contractID = txtContractID.Text.Trim();
                string hoursWorkedText = txtHoursWorked.Text.Trim();
                string hourlyRateText = txtHourlyRate.Text.Trim();
                string claimDescription = txtClaimDescription.Text.Trim();
                string claimDate = dpClaimDate.SelectedDate.HasValue ? dpClaimDate.SelectedDate.Value.ToString("yyyy-MM-dd") : "";

                // Validate inputs
                if (string.IsNullOrEmpty(contractID) || string.IsNullOrEmpty(hoursWorkedText) || string.IsNullOrEmpty(hourlyRateText) || string.IsNullOrEmpty(claimDate))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!double.TryParse(hoursWorkedText, out double hoursWorked))
                {
                    MessageBox.Show("Please enter a valid number for hours worked.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!double.TryParse(hourlyRateText, out double hourlyRate))
                {
                    MessageBox.Show("Please enter a valid number for hourly rate.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            


            // Calculate total claim amount
            double totalAmount = hoursWorked * hourlyRate;

                // Save claim data to a file (claims.txt)
                string claimRecord = $"{contractID},{hoursWorked},{hourlyRate},{totalAmount},{claimDescription},{claimDate},Pending,{lblDocumentPath.Text}";
                string claimsFile = "claims.txt";

                try
                {
                    using (StreamWriter sw = new StreamWriter(claimsFile, true))
                    {
                        sw.WriteLine(claimRecord);
                    }

                    MessageBox.Show("Claim submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Clear fields after submission
                    txtContractID.Clear();
                    txtHoursWorked.Clear();
                    txtHourlyRate.Clear();
                    txtClaimDescription.Clear();
                    dpClaimDate.SelectedDate = null;
                    lblDocumentPath.Text = "No file selected";
                    documentPath = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while submitting the claim: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
