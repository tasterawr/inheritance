using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studs = new List<Student>();
            List<Book> books = new List<Book>();
            List<Author> authors = new List<Author>();

            ReadData(studs, authors, books);

            foreach (Student st in studs)
                Console.WriteLine(st.ToString());

            foreach (Book book in books)
                Console.WriteLine(book.ToString());
        }

        static void ReadData(List<Student> studs, List<Author> authors, List<Book> books)
        {
            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/students.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] dat = sr.ReadLine().Split(',');
                    string name = dat[0];
                    int age = int.Parse(dat[1]);
                    int weight = int.Parse(dat[2]);
                    int height = int.Parse(dat[3]);
                    int year = int.Parse(dat[4]);
                    int course = int.Parse(dat[5]);
                    int gr_number = int.Parse(dat[6]);
                    if (HumanValidator.ValidateStudentData(age, weight, height, course))
                        studs.Add(new Student(name, age, weight, height, year, course, gr_number));
                    else
                    {
                        HumanValidator.DisplayError();
                    }
                }
            }

            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/authors.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] dat = sr.ReadLine().Split(',');
                    string lname = dat[0];
                    string fname = dat[1];
                    int birthdate = int.Parse(dat[2]);
                    authors.Add(new Author(fname, lname, birthdate));
                }
            }

            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/books.txt"))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    string[] dat = sr.ReadLine().Split(',');
                    string name = dat[0]; 
                    int num_of_pages = int.Parse(dat[1]);
                    string publ_house = dat[2];
                    int publ_date = int.Parse(dat[3]);
                    int completion_date = int.Parse(dat[4]);

                    if (BookValidator.ValidateBookData(num_of_pages, publ_date, completion_date))
                        books.Add(new Book(name, num_of_pages, publ_house, publ_date, completion_date, authors[i]));
                    else
                    {
                        BookValidator.DisplayError();
                    }

                    i++;
                }
            }
        }
    }
}
