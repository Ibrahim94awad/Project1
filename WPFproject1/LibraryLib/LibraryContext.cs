using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib
{
  public  class LibraryContext: INotifyPropertyChanged
    {
        private IAuthors _authorsService = null;
        private IBooks _booksService = null;
        private ICutomers _cutomersServices = null;
        private IPublishers _publishersService = null;
        private ICatogeries _categeries = null;


        private ObservableCollection<Book>allbooks =new ObservableCollection<Book>();

        public ObservableCollection<Book> Allbooks
        {
            get
            {
                return this.allbooks;
            }

            set
            {
                if (value != this.allbooks)
                {
                    this.allbooks = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private ObservableCollection<Book> avialableBooks = new ObservableCollection<Book>();
        public ObservableCollection<Book> AvialableBooks
        {
            get
            {
                return this.avialableBooks;
            }

            set
            {
                if (value != this.avialableBooks)
                {
                    this.avialableBooks = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private ObservableCollection<Cutomer> cutomers = new ObservableCollection<Cutomer>();
        public ObservableCollection<Cutomer> Cutomers
        {
            get
            {
                return this.cutomers;
            }

            set
            {
                if (value != this.cutomers)
                {
                    this.cutomers = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public LibraryContext(IAuthors authorsService, IBooks booksService, ICatogeries catogeriesService,ICutomers cutomersService, IPublishers publishersService)
        {
            _authorsService = authorsService;
            _booksService = booksService;
            _categeries = catogeriesService;
            _cutomersServices = cutomersService;
            _publishersService = publishersService;


            GetBooks();
            GetCustomers();
        }

        public void GetBooks()
        {
            Allbooks = new ObservableCollection<Book>(_booksService.GetAllBooks());
            AvialableBooks = new ObservableCollection<Book>(_booksService.GetallAvailableBooks());

        }
        public void GetCustomers()
        {
            Cutomers = new ObservableCollection<Cutomer>(_cutomersServices.GetAllcustomers());
        }
        // Interface implementation
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

     

    }
}
