using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Bok3
{
    class Product
    {
        public int ProductId { get; set; }
    }

    class Book : Product
    {
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Title { get; }

        public Book(string isbn, string title)
        {
            Isbn = isbn;
            Title = title;
        }

        int _nrOfPages;

        public int NrOfPages
        {
            get => _nrOfPages;

            set
            {
                if (value > 0 && value < 1000)
                {
                    _nrOfPages = value;
                }
                else
                {
                    _nrOfPages = 300;
                }
            }
        }

        public double WeightInGram => _nrOfPages * 0.8;

        public string Size
        {
            get
            {
                if (_nrOfPages < 100)
                    return "Tunn";

                if (_nrOfPages < 300)
                    return "Normal";

                return "Tjock";
            }
        }

    }

    class ElectronicBook : Book
    {

        public void SendBookTo(string emailAdress)
        {
            Console.WriteLine($"   Send book to {emailAdress}");
        }

        public ElectronicBook(string isbn, string title) : base(isbn, title)
        {
        }
    }
}