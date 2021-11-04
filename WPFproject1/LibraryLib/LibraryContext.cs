﻿using LibraryLib.Domain.Interfaces;
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
        private ICatogeries _categeriesService = null;


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
        private ObservableCollection<Publisher> allpublishers = new ObservableCollection<Publisher>();
        public ObservableCollection<Publisher> AllPublishers
        {
            get
            {
                return this.allpublishers;
            }

            set
            {
                if (value != this.allpublishers)
                {
                    this.allpublishers = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private ObservableCollection<Author> allAuthors = new ObservableCollection<Author>();
        public ObservableCollection<Author> AllAuthors
        {
            get
            {
                return this.allAuthors;
            }

            set
            {
                if (value != this.allAuthors)
                {
                    this.allAuthors = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private ObservableCollection<Category> allCatogeries = new ObservableCollection<Category>();
        public ObservableCollection<Category> AllCatogeries
        {
            get
            {
                return this.allCatogeries;
            }

            set
            {
                if (value != this.allCatogeries)
                {
                    this.allCatogeries = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public LibraryContext(IAuthors authorsService, IBooks booksService, ICatogeries catogeriesService,ICutomers cutomersService, IPublishers publishersService)
        {
            _authorsService = authorsService;
            _booksService = booksService;
            _categeriesService = catogeriesService;
            _cutomersServices = cutomersService;
            _publishersService = publishersService;


            GetBooks();
            GetCustomers();
            GetPublisher();
            GetAuthors();
            GetCategories();
            
        }

        public void IssuedBook(Book book)
        {

            _booksService.IssuedBook(book);
            GetBooks();

        }

        public void AddBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            _booksService.CreateBook(bookName, publisher, authors, categories, isIssued);
            GetBooks();

        }

        public void DeleteBook(Book book)
        {
            _booksService.Deletebook(book);
            GetBooks();

        }
        public void GetPublisher()
        {
            AllPublishers = new ObservableCollection<Publisher>(_publishersService.GetAllPublisers());
        }

        public void GetAuthors(){


            AllAuthors = new ObservableCollection<Author>(_authorsService.GetAllAuthors());
        }

        public void GetCategories()
        {
            AllCatogeries = new ObservableCollection<Category>(_categeriesService.GetAllcatogiers());
        }
        

        public void GetBooks()
        {
            Allbooks = new ObservableCollection<Book>(_booksService.GetAllBooks());
            AvialableBooks = new ObservableCollection<Book>(_booksService.GetallAvailableBooks());

        }
        public bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories)
        {
            bool res= _booksService.CreateBook(bookName, publisher, authors, categories);
            GetBooks();
            return res;

            
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
