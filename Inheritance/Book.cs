using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Book
    {
        private string name;
        private int num_of_pages;
        private string publ_house;
        private int publ_date;
        private int completion_date;
        private Author author;

        public Book(string name, int num_of_pages, string publ_house,
            int publ_date, int completion_date, Author author)
        {
            this.name = name;
            this.num_of_pages = num_of_pages;
            this.publ_house = publ_house;
            this.publ_date = publ_date;
            this.completion_date = completion_date;
            this.author = author;
        }

        public override string ToString()
        {
            string result = "Название: " + Name + '\n';
            result += "Число страниц: " + PagesCount + '\n';
            result += "Издательство: " + Publisher + '\n';
            result += "Дата издания: " + ReleaseDate + '\n';
            result += "Дата написания: " + CompletionDate + '\n';
            result += "Автор: " + author.ToString() + '\n';
            return result;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int PagesCount
        {
            get => num_of_pages;
            set => num_of_pages = value;
        }

        public string Publisher
        {
            get => publ_house;
            set => publ_house = value;
        }

        public int ReleaseDate
        {
            get => publ_date;
            set => publ_date = value;
        }

        public int CompletionDate
        {
            get => completion_date;
            set => completion_date = value;
        }

        public Author Author
        {
            get => author;
            set => author = value;
        }
    }
}
