using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_tur_på_biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a list and stack
            List<Book> books = new List<Book>();
            Stack<Book> UserLoan = new Stack<Book>();
            //creating books
            Book book1 = new Book { Title = "book", Author = "A cool person", Pages = 100 };
            Book book2 = new Book { Title = "book1", Author = "A cool person", Pages = 110 };
            Book book3 = new Book { Title = "book2", Author = "A cool person", Pages = 120 };
            Book book4 = new Book { Title = "book3", Author = "A cool person", Pages = 130 };
            Book book5 = new Book { Title = "book4", Author = "A cool person", Pages = 140 };
            Book book6 = new Book { Title = "book5", Author = "A cool person", Pages = 150 };
            Book book7 = new Book { Title = "book6", Author = "A cool person", Pages = 160 };
            Book book8 = new Book { Title = "book7", Author = "A cool person", Pages = 170 };
            //adding books to the "books" list
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);
            books.Add(book6);
            books.Add(book7);
            books.Add(book8);

            while (true)
            {
                //printing the available books
                Console.WriteLine("These are the avilable books:");

                foreach (Book b in books)
                {
                    Console.WriteLine(books.IndexOf(b) + ". " + b.Title);
                }
                //Chosing which book to loan
                Console.Write("Enter the number of the book you want to loan: ");
                int loanNumber = int.Parse(Console.ReadLine());
                //adding the the book chosen to the users stack
                UserLoan.Push(books[loanNumber]);
                //removing the chosen book from the list
                books.RemoveAt(loanNumber);
                //checking if the user want more books
                //If the user writes "no" the loop will break
                Console.Write("Do you want to loan more books?");
                string temp = Console.ReadLine();
                if (temp == "No".ToLower())
                {
                    break;
                }
                //breaks the loop if there is no more books remaining
                if (books.Count == 0)
                {
                    Console.WriteLine("No more books left");
                    break;
                }
                Console.WriteLine(UserLoan.Peek());
                //clears text in console
                Console.Clear();
            }

            while (true)
            {
                //clears text in console
                Console.Clear();
                //checks if there is any books left to scan
                if (UserLoan.Count == 0)
                {
                    Console.WriteLine("All books have been scanned");
                    break;
                }
                //prints the next book in the stack
                Console.WriteLine(UserLoan.Peek().Title + " Has been scanned\n Press any key to scan next");
                //deletes the next book in the stack
                UserLoan.Pop();
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
