using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;


namespace ContractClaimSystem
{
   
        public partial class ViewClaims : Window
        {
            public ViewClaims()
            {
                InitializeComponent();
                LoadClaims();
            }

            private void LoadClaims()
            {
                lvSubmittedClaims.Items.Clear();

                if (File.Exists("claims.txt"))
                {
                    using (StreamReader sr = new StreamReader("claims.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');

                            lvSubmittedClaims.Items.Add(new Claim
                            {
                                ContractID = parts[0],
                                HoursWorked = parts[1],
                                HourlyRate = parts[2],
                                TotalAmount = parts[3],
                                Description = parts[4],
                                Date = parts[5],
                                Status = parts[6],
                                Document = parts[7]
                            });
                        }
                    }
                }
            }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();  // Close the current window
        }


        private void BtnApprove_Click(object sender, RoutedEventArgs e)
            {
                ProcessSelectedClaim("Approved");
            }

            private void BtnReject_Click(object sender, RoutedEventArgs e)
            {
                ProcessSelectedClaim("Rejected");
            }

            private void ProcessSelectedClaim(string newStatus)
            {
                if (lvSubmittedClaims.SelectedItem is Claim selectedClaim)
                {
                    string[] claims = File.ReadAllLines("claims.txt");

                    for (int i = 0; i < claims.Length; i++)
                    {
                        string[] parts = claims[i].Split(',');

                        if (parts[0] == selectedClaim.ContractID && parts[5] == selectedClaim.Date)
                        {
                            // Update status
                            parts[6] = newStatus;
                            claims[i] = string.Join(",", parts);
                            break;
                        }
                    }

                    File.WriteAllLines("claims.txt", claims);
                    MessageBox.Show($"Claim {newStatus.ToLower()} successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadClaims();
                }
                else
                {
                    MessageBox.Show("Please select a claim to process.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

            private void BtnRefresh_Click(object sender, RoutedEventArgs e)
            {
                LoadClaims();
            }
        }

        // Define a Claim class to represent a claim
        public class Claim
        {
            public string ContractID { get; set; }
            public string HoursWorked { get; set; }
            public string HourlyRate { get; set; }
            public string TotalAmount { get; set; }
            public string Description { get; set; }
            public string Date { get; set; }
            public string Status { get; set; }
            public string Document { get; set; }
        }
    }
