using LibraryLib;
using LibraryLib.Domain.Models;
using LibraryLib.Domain.Services;
using LibraryLib.Domain.Services.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFproject1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibraryContext context = new LibraryContext(
            new FileOAuthorService(),
            new FileOBooksService(),
            new FileOCategoryService(),
            new FileOCustomerservice(),
            new FileOPublisherservice());
       

        public MainWindow()
        {
            InitializeComponent();

            DataContext = context;
        }

        private void btnIssued_Click(object sender, RoutedEventArgs e)
        {

            context.IssuedBook((Book)cmbavailabelBooks.SelectedItem);
        }

        private void btnBackoffice_Click(object sender, RoutedEventArgs e)
        {
            BackOffice backOffice = new BackOffice(context);
            backOffice.Show();
        }
    }
}
