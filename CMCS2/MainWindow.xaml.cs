using System.Windows;
using CMCS2;

namespace ContractClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnViewClaims_Click(object sender, RoutedEventArgs e)
        {
            ViewClaims viewClaimsPage = new ViewClaims();
            viewClaimsPage.Show();
            this.Close();
        }

        

         private void BtnSubmitClaim_Click(object sender, RoutedEventArgs e)
            {
                SubmitClaim submitClaimPage = new SubmitClaim();
                submitClaimPage.Show();
                this.Close();
            }

        }
    }

