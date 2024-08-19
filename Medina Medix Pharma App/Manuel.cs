using System;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{
    public partial class ManuelForm : Form
    {
        private string _role;

        public ManuelForm(string role)
        {
            InitializeComponent();
            _role = role; // Store the role
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
        }

        private void ManuelForm_Load(object sender, EventArgs e)
        {
            LoadPdfInBrowser(webBrowser1, @"D:\Medina Medix Pharma Project 2024\Medina Medix Pharma App\Manuel\Introduction.pdf");
        }

        private void LoadPdfInBrowser(WebBrowser browser, string filePath)
        {
            try
            {
                browser.Navigate(new Uri($"file:///{filePath}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du fichier PDF : " + ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTab = tabControl1.SelectedTab.Name;
            string pdfPath = "";

            switch (selectedTab)
            {
                case "tabPage2":
                    pdfPath = @"D:\Medina Medix Pharma Project 2024\Medina Medix Pharma App\Manuel\Introduction.pdf";
                    break;
                case "tabPage3":
                    pdfPath = @"D:\Medina Medix Pharma Project 2024\Medina Medix Pharma App\Manuel\Configuration Requise.pdf";
                    break;
                case "tabPage4":
                    pdfPath = @"D:\Medina Medix Pharma Project 2024\Medina Medix Pharma App\Manuel\Utilisation des Fonctionnalités Clés.pdf";
                    break;
            }

            if (!string.IsNullOrEmpty(pdfPath))
            {
                LoadPdfInBrowser(webBrowser1, pdfPath);
                LoadPdfInBrowser(webBrowser4, pdfPath);
                LoadPdfInBrowser(webBrowser5, pdfPath);
            }
        }

        private void bttnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboardForm = new DashboardForm(_role); // Pass the role to DashboardForm
            dashboardForm.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser1.Url = new Uri("D:\\C# Projects\\Medina Medix Pharma\\Medina-Medix-Pharma-Proj\\Introduction.pdf");
        }

        private void Manuel_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser1.Url = new Uri("D:\\C# Projects\\Medina Medix Pharma\\Medina-Medix-Pharma-Proj\\Manuel Medina Medix Pharma\\Introduction.pdf");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        //private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selectedTab = tabControl1.SelectedTab.Name;
        //    string pdfPath = "";

        //    switch (selectedTab)
        //    {
        //        case "tabPage2":
        //            pdfPath = @"file://D:/C#Projects/MedinaMedixPharma/Medina-Medix-Pharma-Proj/Manuel/Introduction.pdf";
        //            break;
        //        case "tabPage3":
        //            pdfPath = @"file://D:\C# Projects\Medina Medix Pharma\Medina-Medix-Pharma-Proj\Manuel\ConfigurationRequise.pdf";
        //            break;
        //        case "tabPage4":
        //            pdfPath = @"file://D:/C#Projects/MedinaMedixPharma/Medina-Medix-Pharma-Proj/Manuel/UtilisationdesFonctionnalitésClés.pdf";
        //            break;
        //    }

        //    if (!string.IsNullOrEmpty(pdfPath))
        //    {
        //        webBrowser1.Navigate(new Uri(pdfPath));
        //        webBrowser2.Navigate(new Uri(pdfPath));
        //        webBrowser3.Navigate(new Uri(pdfPath));
        //    }
        //}

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
