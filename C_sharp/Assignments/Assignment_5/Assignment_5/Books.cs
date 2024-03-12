using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    /*Create a class called Books with BookName and AuthorName as members. 
    Instantiate the class through constructor and also write a method Display() to display the details. 
    Create an Indexer of Books Object to store 5 books in a class called BookShelf. Using the indexer method assign values to the books and display the same.
    Hint(use Aggregation/composition)*/
    class Books
    {
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }

        public Books(string book_name, string author_name)
        {
            Book_Name = book_name;
            Author_Name = author_name;
        }
        public Books() { }

        //public void display()
        //{
        //    console.writeline($"book name -> {book_name}");
        //    console.writeline($"author name -> {author_name}");
        //}
    }

    //using composition
    class BookShelf
    {
        private Books[] books=new Books[5];
        //List<Books> books = new List<Books>();

        //Instantiate the class through constructor
        public Books this[int index]
        {
            
            get 
            {
                return books[index];
                
                //for giving Hard-coded values

                //if (index >= 0 && index < book_count)
                //    return books[index];
                //else
                //    throw new IndexOutOfRangeException("Invalid Book Index.");
            }

            set 
            {
                books[index] = value;

                //for giving Hard-coded values

                //if (index >= 0 && index < book_count)
                //    books[index] = value;
                //else
                //    throw new IndexOutOfRangeException("Invalid Book Index.");
            }
        }
    }

    class Test_Books
    {

        int book_count = 5;
        //instance of BookSelf for setting and printing the value
       
        //Setting Books in Bookself
        public void Books_Self()
        {
            string B_Name;
            string B_Author;
            var bookShelf = new BookShelf();
           

            //adding books 
            for (int i = 0; i < book_count; i++)
            {
                Console.Write($"Enter the {i + 1} Book Name -> ");
                B_Name = Console.ReadLine();
                Console.Write($"Enter The Author Name -> ");
                B_Author = Console.ReadLine();
                //bookShelf[i] = new Books { Book_Name = B_Name, Author_Name = B_Author};
                bookShelf[i] = new Books(B_Name, B_Author);
                Console.WriteLine();
            }

            // Displaying Stored books

            Console.WriteLine("--- Available Books in BookSelf--- ");
            for (int i = 0; i < book_count; i++)
            {
                Console.WriteLine($"Book {i + 1} -> {bookShelf[i].Book_Name} written by {bookShelf[i].Book_Name}");
            }

        }

    }
}
