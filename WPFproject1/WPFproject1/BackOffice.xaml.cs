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
                bool res = context.DeleteBook((Book)lsbAllBooks.SelectedItem);

                if (res==false)
                {
                    MessageBox.Show("book is isseud");

                }
               

            }
            else
            {
                MessageBox.Show("Select a book first");
            }
        }

        private void btnAddPublisher_Click(object sender, RoutedEventArgs e)
        {
            context.CreatePublisher(txtPublisherName.Text);
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            context.CreateCustomer(txtCustomerFirst.Text, txbcutomerLast.Text);
        }

        private void btnAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            context.CreateAuthor(txbAuthorFirst.Text, txbAuthorLast.Text);
        }

        private void btnAddCategory_Click(object sender, RoutedEventArgs e)
        {
            context.CreateCategory(txbCategoryName.Text);
        }

        private void btnDeletePublisher_Click(object sender, RoutedEventArgs e)
        {
            context.DeletePublisher((Publisher)lsbPublishers.SelectedItem);

        }

        private void btnDeleteCatories_Click(object sender, RoutedEventArgs e)
        {
            context.DeleteCategory((Category)lsbCategories.SelectedItem);
        }

        private void btnDeleteAuthor_Click(object sender, RoutedEventArgs e)
        {
            context.DeleteAuthor((Author)lsbAuthors.SelectedItem);
        }

        private void btbDeleleCustomers_Click(object sender, RoutedEventArgs e)
        {
            context.DeleteCutomer((Cutomer)lsbCustomers.SelectedItem);

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            context.Clear();
        }
    }
}
