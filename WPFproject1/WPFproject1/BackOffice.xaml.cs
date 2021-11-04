using LibraryLib;
using LibraryLib.Domain.Models;
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
using System.Windows.Shapes;

namespace WPFproject1
{
    /// <summary>
    /// Interaction logic for BackOffice.xaml
    /// </summary>
    public partial class BackOffice : Window
    {
        LibraryContext context = null;
        public BackOffice(LibraryContext ctx)
        {
            InitializeComponent();
            context = ctx;

            DataContext = context;
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {

            bool res = context.CreateBook(txbBookName.Text, (Publisher)cmbPublisher.SelectedItem,
                new List<Author>() { (Author)cmbAuthors.SelectedItem },
                new List<Category>() { (Category)cmbCategories.SelectedItem });

            if (res==false)
            {
                MessageBox.Show("can't create book");
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lsbAllBooks.SelectedItem!=null)
            {
            context.DeleteBook((Book)lsbAllBooks.SelectedItem);

            }
            else
            {
                MessageBox.Show("Select a book first");
            }
        }
    }
}
